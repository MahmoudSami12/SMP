using SMP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermarketManagement.PL
{
    public partial class HomeScreen : Form
    {
        SMP_DBEntities3 db = new SMP_DBEntities3();

        //add cat
        public void add_cat()
        {
            PL.Category_Add category_add = new Category_Add();
            category_add.id = 0;
            category_add.add_btn.Text = "Add";
            category_add.Show();
        }

        //add sup
        public void add_sup()
        {
            PL.Suppliers_Add suppliers_add = new Suppliers_Add();
            suppliers_add.id = 0;
            suppliers_add.add_btn.Text = "Add";
            suppliers_add.Show();
        }

        //add pur
        public void add_pur()
        {
            PL.Purchease_Add purchease_add = new Purchease_Add();
            purchease_add.id = 0;
            purchease_add.add_btn.Text = "Add";
            purchease_add.Show();
        }

        //add cust
        public void add_cust()
        {
            PL.Customers_Add customers_add = new Customers_Add();
            customers_add.id = 0;
            customers_add.add_btn.Text = "Add";
            customers_add.Show();
        }

        //add sale
        public void add_sale()
        {
            PL.Selling_Add selling_add = new Selling_Add();
            selling_add.id = 0;
            selling_add.add_btn.Text = "Add";
            selling_add.Show();
        }

        public HomeScreen()
        {
            InitializeComponent();
            List<CAT_TB> list_cat = db.CAT_TB.ToList();
            item_value.Text = list_cat.Count().ToString();

            List<SUPP_TB> list_supp = db.SUPP_TB.ToList();
            sup_value.Text = list_supp.Count().ToString();

            List<CUST_TB> list_cust = db.CUST_TB.ToList();
            cust_value.Text = list_cust.Count().ToString();

            List<SELL_TB> list_sell = db.SELL_TB.ToList();
            sales_value.Text = list_sell.Count().ToString();

            List<PUR_TB> list_pur = db.PUR_TB.ToList();
            pur_value.Text = list_pur.Count().ToString();
        }

        private void additem_btn_Click(object sender, EventArgs e)
        {
            add_cat();
        }

        private void addsup_btn_Click(object sender, EventArgs e)
        {
            add_sup();
        }

        private void pur_btn_Click(object sender, EventArgs e)
        {
            add_pur();
        }

        private void addcust_btn_Click(object sender, EventArgs e)
        {
            add_cust();
        }

        private void sale_btn_Click(object sender, EventArgs e)
        {
            add_sale();
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {
            MainScreen mainScreen = new MainScreen();
            if(mainScreen.role_lbl.Text == "Admin")
            {
                addcat_btn.Enabled = true;
                addcust_btn.Enabled = true;
                addsup_btn.Enabled = true;
                pur_btn.Enabled = true;
                sale_btn.Enabled = true;
            }
            else
            {
                addcat_btn.Enabled = false;
                addcust_btn.Enabled = false;
                addsup_btn.Enabled = false;
                pur_btn.Enabled = true;
                sale_btn.Enabled = true;
            }
        }

        private void container_pn_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HomeScreen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.C)
            {
                addcat_btn.PerformClick();
            }
        }
    }
}
