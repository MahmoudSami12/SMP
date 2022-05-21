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
    public partial class Category : Form
    {
        // Init
        SMP_DBEntities3 db = new SMP_DBEntities3();
        CAT_TB cat_tb = new CAT_TB();
        BL.Methods methods = new BL.Methods();
        HomeScreen homeScreen = new HomeScreen();
        int id;

        // Update Data
        public void update_data() 
        {
            db = new SMP_DBEntities3();
            gridControl1.DataSource = db.CAT_TB.ToList();
        }

        // Search
        public void search()
        {
            var _search = item_search_txt.Text;
            gridControl1.DataSource = db.CAT_TB.Where(x => x.CAT_Name.Contains(_search)).ToList();
        }

        //delete
        public void delete()
        {
            Toast toast = new Toast();
            Dialog dialog = new Dialog();
            try
            {
                id = Convert.ToInt32(tileView1.GetFocusedRowCellValue("ID"));
                var rs = MessageBox.Show("Are you sure, You want to delete this item?", "Delete", MessageBoxButtons.YesNo);
                if (rs == DialogResult.Yes)
                {
                    cat_tb = db.CAT_TB.Where(x => x.ID == id).FirstOrDefault();
                    db.Entry(cat_tb).State = EntityState.Deleted;
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
            PL.Category_Add category_add = new Category_Add();
            Dialog dialog = new Dialog();

            try
            {
                id = Convert.ToInt32(tileView1.GetFocusedRowCellValue("ID"));
                cat_tb = db.CAT_TB.Where(x => x.ID == id).FirstOrDefault();
                category_add.item_name_txt.Text = cat_tb.CAT_Name.ToString();
                methods.by = cat_tb.CAT_Cover;
                category_add.pic_cover.Image = Image.FromStream(methods.convert_image());

                category_add.id = id;
                category_add.add_btn.Text = "Edit";
                category_add.Show();
            }
            catch
            {
                dialog.dialog_txt.Text = "No Item Selected To Edit.";
                dialog.Width = this.Width;
                dialog.Show();
            }
        }

        public Category()
        {
            InitializeComponent();

            
            SupermarketManagement.SMP_DBEntities3 dbContext = new SupermarketManagement.SMP_DBEntities3();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.CAT_TB.LoadAsync().ContinueWith(loadTask =>
            {
    // Bind data to control when loading complete
    gridControl1.DataSource = dbContext.CAT_TB.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        //add item
        private void add_btn_Click(object sender, EventArgs e)
        {
            homeScreen.add_cat();
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
