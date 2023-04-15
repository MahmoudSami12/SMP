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
    public partial class Users_Add: Form
    {
        //inti
        SMP_DBEntities3 db = new SMP_DBEntities3();
        USER_TB user_tb = new USER_TB();
        BL.Methods methods = new BL.Methods();
        PL.Users users = new Users();

        public int id;

        //update data
        private void update_data()
        {
            db = new SMP_DBEntities3();
            users.gridControl1.DataSource = db.USER_TB.ToList();
        }

        // Add Or Edit
        private void add()
        {
            Toast toast = new Toast();
            Dialog dialog = new Dialog();

            //check empty or not
            if (username_txt.Text == "" || pass_txt.Text == "" || role_combo.SelectedItem == null)
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
                    user_tb.User_Name = username_txt.Text;
                    user_tb.User_Pass = pass_txt.Text;
                    user_tb.User_Role = role_combo.Text;
                    user_tb.User_State = "False";
                    db.USER_TB.Add(user_tb);
                    db.SaveChanges();
                    toast.toast_txt.Text = "New User Added Successfuly.";
                    toast.Show();
                    update_data();
                    this.Close();
                }
                else
                {
                    //edit
                    pic_cover.Image.Save(methods.ms, System.Drawing.Imaging.ImageFormat.Png);
                    user_tb.User_Name = username_txt.Text;
                    user_tb.User_Pass = pass_txt.Text;
                    user_tb.User_Role = role_combo.Text;
                    user_tb.User_State = "False";
                    user_tb.ID = id;
                    db.Entry(user_tb).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    toast.toast_txt.Text = "Edited Successfully.";
                    toast.Show();
                    update_data();
                    this.Close();
                }

            }
        }



        public Users_Add()
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
            DialogResult res = MessageBox.Show("Are You Sure To Close App", "Exit", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                this.Close();
            }
            else { }
        }

        private void username_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Convert.ToInt32(e.KeyChar) == 13)
            {
                add();
            }
        }

        private void pass_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                add();
            }
        }

        private void role_combo_KeyPress(object sender, KeyPressEventArgs e)
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
