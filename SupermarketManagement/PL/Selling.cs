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
    public partial class Selling: Form
    {
        // Init
        SMP_DBEntities3 db = new SMP_DBEntities3();
        SELL_TB sell_tb = new SELL_TB();
        HomeScreen homeScreen = new HomeScreen();
        int id;

        // Update Data
        private void update_data() 
        {
            db = new SMP_DBEntities3();
            gridControl1.DataSource = db.SELL_TB.ToList();
        }

        // Search
        private void search()
        {
            var _search = item_search_txt.Text;
            gridControl1.DataSource = db.SELL_TB.Where(x => x.Sell_Name.Contains(_search) ||
                                                            x.Sell_Cust.Contains(_search)).ToList();
        }

        //delete
        private void delete()
        {
            Toast toast = new Toast();
            Dialog dialog = new Dialog();
            try
            {
                id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
                var rs = MessageBox.Show("Are you sure, You want to delete this item?", "Delete", MessageBoxButtons.YesNo);
                if (rs == DialogResult.Yes)
                {
                    sell_tb = db.SELL_TB.Where(x => x.ID == id).FirstOrDefault();
                    db.Entry(sell_tb).State = System.Data.Entity.EntityState.Deleted;
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
            PL.Selling_Add selling_add = new Selling_Add();
            Dialog dialog = new Dialog();

            try
            {
                id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
                sell_tb = db.SELL_TB.Where(x => x.ID == id).FirstOrDefault();
                selling_add.item_name_comb.Text = sell_tb.Sell_Name.ToString();
                selling_add.cust_comb.Text = sell_tb.Sell_Cust.ToString();
                selling_add.sell_price_txt.Text = sell_tb.Sell_Price.ToString();
                selling_add.spinEdit1.Text = sell_tb.Sell_Qt.ToString(); ;
                //methods.by = supp_tb.SUPP_Image;
                //suppliers_add.pic_cover.Image = Image.FromStream(methods.convert_image());

                selling_add.id = id;
                selling_add.add_btn.Text = "Edit";
                selling_add.Show();
            }
            catch
            {
                dialog.dialog_txt.Text = "No Item Selected To Edit.";
                dialog.Width = this.Width;
                dialog.Show();
            }
        }

        public Selling()
        {
            InitializeComponent();

            
            SupermarketManagement.SMP_DBEntities3 dbContext = new SupermarketManagement.SMP_DBEntities3();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.SELL_TB.LoadAsync().ContinueWith(loadTask =>
            {
    // Bind data to control when loading complete
    gridControl1.DataSource = dbContext.SELL_TB.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        //add item
        private void add_btn_Click(object sender, EventArgs e)
        {
            homeScreen.add_sale();
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

        private void gridControl1_Click(object sender, EventArgs e)
        {
            
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
