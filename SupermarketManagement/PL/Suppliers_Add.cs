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
    public partial class Suppliers_Add : Form
    {
        //inti
        SMP_DBEntities3 db = new SMP_DBEntities3();
        SUPP_TB supp_tb = new SUPP_TB();
        BL.Methods methods = new BL.Methods();
        PL.Suppliers suppliers = new Suppliers();

        public int id;

        //update data
        private void update_data()
        {
            db = new SMP_DBEntities3();
            suppliers.gridControl1.DataSource = db.SUPP_TB.ToList();
        }

        // Add
        private void add()
        {
            Toast toast = new Toast();
            Dialog dialog = new Dialog();

            //check empty or not
            if (supp_name_txt.Text == "")
            {
                dialog.Width = this.Width;
                dialog.dialog_txt.Text = "These feilds are required.";
                dialog.Show();
            }
            else
            {
                //check add or edit
                if (id == 0)
                {
                    //add
                    pic_cover.Image.Save(methods.ms, System.Drawing.Imaging.ImageFormat.Png);
                    supp_tb.SUPP_Name = supp_name_txt.Text;
                    supp_tb.SUPP_Phone = supp_phone_txt.Text;
                    supp_tb.SUPP_Email = supp_email_txt.Text;
                    supp_tb.SUPP_Image = methods.convert_byte();
                    db.SUPP_TB.Add(supp_tb);
                    db.SaveChanges();
                    toast.toast_txt.Text = "New Supplier Added Successfuly.";
                    toast.Show();
                    update_data();
                    this.Close();
                }
                else
                {
                    //edit
                    pic_cover.Image.Save(methods.ms, System.Drawing.Imaging.ImageFormat.Png);
                    supp_tb.SUPP_Name = supp_name_txt.Text;
                    supp_tb.SUPP_Phone = supp_phone_txt.Text;
                    supp_tb.SUPP_Email = supp_email_txt.Text;
                    supp_tb.ID = id;
                    supp_tb.SUPP_Image = methods.convert_byte();
                    db.SUPP_TB.Add(supp_tb);
                    db.Entry(supp_tb).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    toast.toast_txt.Text = "Edited Successfuly.";
                    toast.Show();
                    update_data();
                    this.Close();
                }

            }
        }

        public Suppliers_Add()
        {
            InitializeComponent();
        }

        //add and edit
        private void add_btn_Click(object sender, EventArgs e)
        {
            add();
        }

        //close window
        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void supp_name_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Convert.ToInt32(e.KeyChar) == 13)
            {
                add();
            }
        }

        private void supp_phone_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                add();
            }
        }

        private void supp_email_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
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
    }
}
