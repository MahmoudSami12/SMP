using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMP;
using SupermarketManagement.EPL;

namespace SupermarketManagement.PL
{
    public partial class Category_Add : Form
    {

        // inti
        SMP_DBEntities3 db = new SMP_DBEntities3();
        CAT_TB cat_tb = new CAT_TB();
        BL.Methods methods = new BL.Methods();
        PL.Category category = new Category();

        public int id; 

        public Category_Add()
        {
            InitializeComponent();
        }

        // Add Or Edit
        private void add()
        {
            Toast toast = new Toast();
            Dialog dialog = new Dialog();
            //check empty or not
            if (item_name_txt.Text == "")
            {
                dialog.Width = this.Width;
                dialog.dialog_txt.Text = "This feild is required.";
                dialog.Show();
            }
            else
            {
                //check add or edit
                if (id == 0)
                {
                    //add
                    pic_cover.Image.Save(methods.ms, System.Drawing.Imaging.ImageFormat.Png);
                    cat_tb.CAT_Name = item_name_txt.Text;
                    cat_tb.CAT_Cover = methods.convert_byte();
                    db.CAT_TB.Add(cat_tb);
                    db.SaveChanges();
                    toast.toast_txt.Text = "New Item Added Successfuly.";
                    toast.Show();
                    db = new SMP_DBEntities3();
                    category.gridControl1.DataSource = db.CAT_TB.ToList();
                    this.Close();
                }
                else
                {
                    //edit
                    pic_cover.Image.Save(methods.ms, System.Drawing.Imaging.ImageFormat.Png);
                    cat_tb.CAT_Name = item_name_txt.Text;
                    cat_tb.ID = id;
                    cat_tb.CAT_Cover = methods.convert_byte();
                    db.CAT_TB.Add(cat_tb);
                    db.Entry(cat_tb).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    toast.toast_txt.Text = "Edited Successfuly.";
                    toast.Show();
                    db = new SMP_DBEntities3();
                    category.gridControl1.DataSource = db.CAT_TB.ToList();
                    this.Close();
                }

            }
        }

        // Add Or Edit
        private void add_btn_Click(object sender, EventArgs e)
        {
            add();
        }

        //close window
        private void close_btn_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are You Sure To Close It", "Exit", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                this.Close();
            }
            else { }
        }

        private void item_name_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Convert.ToInt32(e.KeyChar) == 13)
            {
                add();
            }
        }

        private void pic_cover_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                add();
            }
        }

        private void add_btn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                add();
            }
        }

        private void Category_Add_Load(object sender, EventArgs e)
        {
            item_name_txt.Focus();
        }
    }
}
