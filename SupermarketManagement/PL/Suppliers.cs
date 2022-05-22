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
    public partial class Suppliers: Form
    {
        // Init
        SMP_DBEntities3 db = new SMP_DBEntities3();
        SUPP_TB supp_tb = new SUPP_TB();
        BL.Methods methods = new BL.Methods();
        HomeScreen homeScreen = new HomeScreen();
        int id;

        // Update Data
        private void update_data() 
        {
            db = new SMP_DBEntities3();
            gridControl1.DataSource = db.SUPP_TB.ToList();
        }

        // Search
        private void search()
        {
            var _search = item_search_txt.Text;
            gridControl1.DataSource = db.SUPP_TB.Where(x => x.SUPP_Name.Contains(_search) ||
                                                            x.SUPP_Phone.Contains(_search) ||
                                                            x.SUPP_Email.Contains(_search)).ToList();
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
                    supp_tb = db.SUPP_TB.Where(x => x.ID == id).FirstOrDefault();
                    db.Entry(supp_tb).State = System.Data.Entity.EntityState.Deleted;
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

        //edit
        private void edit()
        {
            PL.Suppliers_Add suppliers_add = new Suppliers_Add();
            Dialog dialog = new Dialog();

            try
            {
                id = Convert.ToInt32(tileView1.GetFocusedRowCellValue("ID"));
                supp_tb = db.SUPP_TB.Where(x => x.ID == id).FirstOrDefault();
                suppliers_add.supp_name_txt.Text = supp_tb.SUPP_Name.ToString();
                suppliers_add.supp_phone_txt.Text = supp_tb.SUPP_Phone.ToString();
                suppliers_add.supp_email_txt.Text = supp_tb.SUPP_Email.ToString();
                methods.by = supp_tb.SUPP_Image;
                suppliers_add.pic_cover.Image = Image.FromStream(methods.convert_image());

                suppliers_add.id = id;
                suppliers_add.add_btn.Text = "Edit";
                suppliers_add.Show();
            }
            catch
            {
                dialog.dialog_txt.Text = "No Item Selected To Edit.";
                dialog.Width = this.Width;
                dialog.Show();
            }
        }

        public Suppliers()
        {
            InitializeComponent();

            
            SupermarketManagement.SMP_DBEntities3 dbContext = new SupermarketManagement.SMP_DBEntities3();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.SUPP_TB.LoadAsync().ContinueWith(loadTask =>
            {
            // Bind data to control when loading complete
            gridControl1.DataSource = dbContext.SUPP_TB.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        //add item
        private void add_btn_Click(object sender, EventArgs e)
        {
            homeScreen.add_sup();
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
