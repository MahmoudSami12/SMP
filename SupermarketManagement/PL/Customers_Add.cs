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
    public partial class Customers_Add: Form
    {
        //inti
        SMP_DBEntities3 db = new SMP_DBEntities3();
        CUST_TB cust_tb = new CUST_TB();
        BL.Methods methods = new BL.Methods();
        PL.Customers customers = new Customers();

        public int id;

        //update data
        private void update_data()
        {
            db = new SMP_DBEntities3();
            customers.gridControl1.DataSource = db.CUST_TB.ToList();
        }

        // Add
        private void add()
        {
            Toast toast = new Toast();
            Dialog dialog = new Dialog();

            //check empty or not
            if (cust_name_txt.Text == "")
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
                    cust_tb.CUST_Name = cust_name_txt.Text;
                    cust_tb.CUST_Phone = cust_phone_txt.Text;
                    cust_tb.CUST_Email = cust_email_txt.Text;
                    cust_tb.CUST_Image = methods.convert_byte();
                    db.CUST_TB.Add(cust_tb);
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
                    cust_tb.CUST_Name = cust_name_txt.Text;
                    cust_tb.CUST_Phone = cust_phone_txt.Text;
                    cust_tb.CUST_Email = cust_email_txt.Text;
                    cust_tb.ID = id;
                    cust_tb.CUST_Image = methods.convert_byte();
                    db.CUST_TB.Add(cust_tb);
                    db.Entry(cust_tb).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    toast.toast_txt.Text = "Edited Successfuly.";
                    toast.Show();
                    update_data();
                    this.Close();
                }

            }
        }

        public Customers_Add()
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

        private void cust_name_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Convert.ToInt32(e.KeyChar) == 13)
            {
                add();
            }
        }

        private void cust_phone_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                add();
            }
        }

        private void cust_email_txt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void add_btn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                add();
            }
        }
    }
}
