using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SupermarketManagement.PL;

namespace SupermarketManagement.BL
{
    class Permissions
    {
        public void admin_per()
        {
            MainScreen mainscreen = new MainScreen();
            mainscreen.main_btn.Enabled = true;
            mainscreen.cat_btn.Enabled = true;
            mainscreen.sup_btn.Enabled = true;
            mainscreen.cust_btn.Enabled = true;
            mainscreen.pur_btn.Enabled = true;
            mainscreen.sales_btn.Enabled = true;
            mainscreen.report_btn.Enabled = true;
            mainscreen.user_btn.Enabled = true;
            mainscreen.settings_btn.Enabled = true;
        }
        public void user_per()
        {
            MainScreen mainscreen = new MainScreen();
            mainscreen.main_btn.Enabled = false;
            mainscreen.cat_btn.Enabled = false;
            mainscreen.sup_btn.Enabled = false;
            mainscreen.cust_btn.Enabled = false;
            mainscreen.pur_btn.Enabled = false;
            mainscreen.sales_btn.Enabled = true;
            mainscreen.report_btn.Enabled = false;
            mainscreen.user_btn.Enabled = false;
            mainscreen.settings_btn.Enabled = false;
        }
    }
}
