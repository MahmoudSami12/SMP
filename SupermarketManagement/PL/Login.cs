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
    public partial class Login : Form
    {
        //init
        SMP_DBEntities3 db = new SMP_DBEntities3();
        USER_TB user_tb = new USER_TB();
        MainScreen mainScreen = new MainScreen();

        int id;
        public Login()
        {
            InitializeComponent();
        }

        // Login To Home
        private void loginintohome()
        {
            Toast toast = new Toast();
            Dialog dialog = new Dialog();


            //check empty or not
            if (username_txt.Text == "")
            {
                dialog.Width = this.Width;
                dialog.dialog_txt.Text = "These feilds are required.";
                dialog.Show();
            }
            else
            {
                //Login
                if (id == 0)
                {
                    //Login
                    user_tb = db.USER_TB.Where(x => x.User_Name == username_txt.Text && x.User_Pass == pass_txt.Text).FirstOrDefault();
                    if (user_tb != null)
                    {
                        user_tb.User_State = "True";
                        db.Entry(user_tb).State = System.Data.Entity.EntityState.Modified;
                        mainScreen.name_lbl.Text = user_tb.User_Name;
                        mainScreen.role_lbl.Text = user_tb.User_Role;
                        mainScreen.Enabled = true;
                        toast.toast_txt.Text = "Login Successfully.";
                        toast.Show();
                        db.SaveChanges();
                        mainScreen.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Login Failed");
                        username_txt.Text = "";
                        pass_txt.Text = "";
                        username_txt.Focus();
                    }
                }
            }
        }

        // Login
        private void login_btn_Click(object sender, EventArgs e)
        {
            loginintohome(); 
        }
       
        // Close
        private void close_btn_Click(object sender, EventArgs e)
        {
            DialogResult res=  MessageBox.Show("Are You Sure To Close App", "Exit", MessageBoxButtons.YesNo);
            if (res==DialogResult.Yes)
            {
                Application.Exit();
            }
            else { }
        }


        private void login_btn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Convert.ToInt32(e.KeyChar) == 13)
            {
                loginintohome();
            }
        }

        private void pass_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                loginintohome();
            }
        }

        private void username_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                loginintohome();
            }
        }
    }
}
