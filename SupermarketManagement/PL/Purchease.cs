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
    public partial class Purchease: Form
    {
        // Init
        SMP_DBEntities3 db = new SMP_DBEntities3();
        PUR_TB pur_tb = new PUR_TB();
        BL.Methods methods = new BL.Methods();
        int id;

        // Update
        private void update_data() 
        {
            db = new SMP_DBEntities3();
            gridControl1.DataSource = db.PUR_TB.ToList();
        }

        //add
        private void add()
        {
            PL.Purchease_Add purchease_add = new Purchease_Add();
            purchease_add.id = 0;
            purchease_add.add_btn.Text = "Add";
            purchease_add.Show();
        }

        // Search
        private void search()
        {
            var _search = item_search_txt.Text;
            gridControl1.DataSource = db.PUR_TB.Where(x => x.Pur_Name.Contains(_search) ||
                                                            x.Pur_Name.Contains(_search) ||
                                                            x.Pur_Cat.Contains(_search) ||
                                                            x.Pur_Type.Contains(_search) ||
                                                            x.Pur_Supp.Contains(_search)).ToList();
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
                    pur_tb = db.PUR_TB.Where(x => x.ID == id).FirstOrDefault();
                    db.Entry(pur_tb).State = System.Data.Entity.EntityState.Deleted;
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
            PL.Purchease_Add purchease_add = new Purchease_Add();
            Dialog dialog = new Dialog();

            try
            {
                id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
                pur_tb = db.PUR_TB.Where(x => x.ID == id).FirstOrDefault();
                purchease_add.item_name_txt.Text = pur_tb.Pur_Name.ToString();
                purchease_add.type_txt.Text = pur_tb.Pur_Type.ToString();
                purchease_add.cat_comb.Text = pur_tb.Pur_Cat.ToString();
                purchease_add.supp_comb.Text = pur_tb.Pur_Supp.ToString();
                purchease_add.details_txt.Text = pur_tb.Pur_Det.ToString();
                purchease_add.pur_price_txt.Text = pur_tb.Pur_Buy.ToString();
                purchease_add.sale_price_txt.Text = pur_tb.Pur_Sell.ToString();
                purchease_add.spinEdit1.Text = pur_tb.Pur_Qt.ToString();
                //methods.by = supp_tb.SUPP_Image;
                //suppliers_add.pic_cover.Image = Image.FromStream(methods.convert_image());

                purchease_add.id = id;
                purchease_add.add_btn.Text = "Edit";
                purchease_add.Show();
            }
            catch
            {
                dialog.dialog_txt.Text = "No Item Selected To Edit.";
                dialog.Width = this.Width;
                dialog.Show();
            }
        }

        public Purchease()
        {
            InitializeComponent();

            
            SupermarketManagement.SMP_DBEntities3 dbContext = new SupermarketManagement.SMP_DBEntities3();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.PUR_TB.LoadAsync().ContinueWith(loadTask =>
            {
            // Bind data to control when loading complete
            gridControl1.DataSource = dbContext.PUR_TB.Local.ToBindingList();
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
