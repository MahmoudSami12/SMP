using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
using SMP;

namespace SupermarketManagement.PL
{
    public partial class Start : SplashScreen
    {
        //inti
        SMP_DBEntities3 db = new SMP_DBEntities3();
        USER_TB user_tb = new USER_TB();
        Login login = new Login();
        MainScreen mainScreen = new MainScreen();
        public Start()
        {
            InitializeComponent();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                user_tb = db.USER_TB.Where(x => x.User_State == "true").FirstOrDefault();
                if (user_tb != null)
                {
                    mainScreen.name_lbl.Text = user_tb.User_Name;
                    mainScreen.role_lbl.Text = user_tb.User_Role;
                    mainScreen.Show();
                }
                else
                {
                    login.Show();
                }
                this.Hide();
                timer1.Enabled = false;
            }
            catch {
                MessageBox.Show("Something Wrong");
            }
            
        }
    }
}