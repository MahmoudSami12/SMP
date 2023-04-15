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
    public partial class Users: Form
    {
        // Init
        SMP_DBEntities3 db = new SMP_DBEntities3();
        USER_TB user_tb = new USER_TB();
        BL.Methods methods = new BL.Methods();
        int id;

        // Update Data
        private void update_data() 
        {
            db = new SMP_DBEntities3();
            gridControl1.DataSource = db.USER_TB.ToList();
        }

        // Search
        private void search()
        {
            var _search = item_search_txt.Text;
            gridControl1.DataSource = db.USER_TB.Where(x => x.User_Name.Contains(_search) ||
                                                            x.User_Role.Contains(_search)).ToList();
        }

        //add
        private void add()
        {
            PL.Users_Add users_add = new Users_Add();
            users_add.id = 0;
            users_add.add_btn.Text = "Add";
            users_add.Show();
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
                    user_tb = db.USER_TB.Where(x => x.ID == id).FirstOrDefault();
                    db.Entry(user_tb).State = System.Data.Entity.EntityState.Deleted;
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

            PL.Users_Add users_add = new Users_Add();
            Dialog dialog = new Dialog();

            try
            {
                id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
                user_tb = db.USER_TB.Where(x => x.ID == id).FirstOrDefault();
                users_add.username_txt.Text = user_tb.User_Name.ToString();
                users_add.pass_txt.Text = user_tb.User_Pass.ToString();
                users_add.role_combo.Text = user_tb.User_Role.ToString();
                db.SaveChanges();
                users_add.id = id;
                users_add.add_btn.Text = "Edit";
                users_add.Show();
            }
            catch
            {
                dialog.dialog_txt.Text = "No Item Selected To Edit.";
                dialog.Width = this.Width;
                dialog.Show();
            }
        }

        public Users()
        {
            InitializeComponent();

            
            SupermarketManagement.SMP_DBEntities3 dbContext = new SupermarketManagement.SMP_DBEntities3();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.USER_TB.LoadAsync().ContinueWith(loadTask =>
            {
    // Bind data to control when loading complete
    gridControl1.DataSource = dbContext.USER_TB.Local.ToBindingList();
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

        //search
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            search();
        }

        //edit item
        private void edit_btn_Click(object sender, EventArgs e)
        {
            edit();
        }

        private void item_search_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                search();
            }
        }
    }
}
