using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using SupermarketManagement.EPL;
using SMP;

namespace SupermarketManagement.PL
{
    public partial class Customers: Form
    {
        // Init
        SMP_DBEntities3 db = new SMP_DBEntities3();
        CUST_TB cust_tb = new CUST_TB();
        BL.Methods methods = new BL.Methods();
        Category category = new Category();
        int id;

        // Update Data
        private void update_data() 
        {
            db = new SMP_DBEntities3();
            gridControl1.DataSource = db.CUST_TB.ToList();
        }

        // Search
        private void search()
        {
            var _search = item_search_txt.Text;
            gridControl1.DataSource = db.CUST_TB.Where(x => x.CUST_Name.Contains(_search) ||
                                                            x.CUST_Phone.Contains(_search) ||
                                                            x.CUST_Email.Contains(_search)).ToList();
        }

        //add
        private void add()
        {
            PL.Customers_Add customers_add = new Customers_Add();
            customers_add.id = 0;
            customers_add.add_btn.Text = "Add";
            customers_add.Show();
        }

        //delete
        private void delete()
        {
            Toast toast = new Toast();
            Dialog dialog = new Dialog();
            try
            {
                id = Convert.ToInt32(tileView1.GetFocusedRowCellValue("ID"));
                var rs = MessageBox.Show("Are you sure, You want to delete this item?", "Delete", MessageBoxButtons.YesNo);
                if (rs == DialogResult.Yes)
                {
                    cust_tb = db.CUST_TB.Where(x => x.ID == id).FirstOrDefault();
                    db.Entry(cust_tb).State = System.Data.Entity.EntityState.Deleted;
                    db.SaveChanges();
                    toast.toast_txt.Text = "Item Deleted Successfully.";
                    toast.Show();
                    update_data();
                }
            }
            catch
            {
                dialog.dialog_txt.Text = "No Item Selected To Delete.";
                dialog.Width = this.Width;
                dialog.Show();
            }
        }

        //edie
        private void edit()
        {
            PL.Customers_Add customers_add = new Customers_Add();
            Dialog dialog = new Dialog();

            try
            {
                id = Convert.ToInt32(tileView1.GetFocusedRowCellValue("ID"));
                cust_tb = db.CUST_TB.Where(x => x.ID == id).FirstOrDefault();
                customers_add.cust_name_txt.Text = cust_tb.CUST_Name.ToString();
                customers_add.cust_phone_txt.Text = cust_tb.CUST_Phone.ToString();
                customers_add.cust_email_txt.Text = cust_tb.CUST_Email.ToString();
                methods.by = cust_tb.CUST_Image;
                customers_add.pic_cover.Image = Image.FromStream(methods.convert_image());

                customers_add.id = id;
                customers_add.add_btn.Text = "Edit";
                customers_add.Show();
            }
            catch
            {
                dialog.dialog_txt.Text = "No Item Selected To Edit.";
                dialog.Width = this.Width;
                dialog.Show();
            }
        }

        public Customers()
        {
            InitializeComponent();

            
            SupermarketManagement.SMP_DBEntities3 dbContext = new SupermarketManagement.SMP_DBEntities3();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.CUST_TB.LoadAsync().ContinueWith(loadTask =>
            {
            // Bind data to control when loading complete
            gridControl1.DataSource = dbContext.CUST_TB.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        //add item
        private void add_btn_Click(object sender, EventArgs e)
        {
            add();
        }

        //update window
        private void update_btn_Click(object sender, EventArgs e)
        {
            item_search_txt.Text = "";
            update_data();  
        }

        //delete item
        private void delete_btn_Click(object sender, EventArgs e)
        {

            delete();
        }

        //edit item
        private void edit_btn_Click(object sender, EventArgs e)
        {
            edit();
        }

        //search
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            search();
        }

        private void item_search_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Convert.ToInt32(e.KeyChar) == 13)
            {
                search();
            }
        }
    }
}
