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
using SupermarketManagement.PL;

namespace SupermarketManagement
{

    public partial class MainScreen : Form
    {

        //inti form
        PL.HomeScreen home_screen = new PL.HomeScreen();
        PL.Category category = new PL.Category();
        PL.Suppliers suppliers = new PL.Suppliers();
        PL.Purchease purchease = new PL.Purchease();
        PL.Customers customers = new PL.Customers();
        PL.Selling selling = new PL.Selling();
        PL.Report report = new PL.Report();
        PL.Users users = new PL.Users();
        PL.Settings settings = new PL.Settings();
        SMP_DBEntities3 db = new SMP_DBEntities3();
        USER_TB user_tb = new USER_TB();

        BL.Permissions permissions = new BL.Permissions();

        //update data
        private void update_data()
        {
            db = new SMP_DBEntities3();
            category.gridControl1.DataSource = db.CAT_TB.ToList();
            suppliers.gridControl1.DataSource = db.SUPP_TB.ToList();
            purchease.gridControl1.DataSource = db.PUR_TB.ToList();
            customers.gridControl1.DataSource = db.CUST_TB.ToList();
            selling.gridControl1.DataSource = db.SELL_TB.ToList();
            users.gridControl1.DataSource = db.USER_TB.ToList();
        }

        // Admin Permission
        public void admin()
        {
            main_btn.Enabled = true;
            cat_btn.Enabled = true;
            sup_btn.Enabled = true;
            cust_btn.Enabled = true;
            pur_btn.Enabled = true;
            sales_btn.Enabled = true;
            report_btn.Enabled = true;
            user_btn.Enabled = true;
            settings_btn.Enabled = true;
            home_screen.addsup_btn.Enabled = true;
            home_screen.addcust_btn.Enabled = true;
            home_screen.addcat_btn.Enabled = true;
            home_screen.pur_btn.Enabled = true;
            home_screen.sale_btn.Enabled = true;
            selling.delete_btn.Enabled = true;
        }

        // User Permission
        public void user()
        {
            main_btn.Enabled = true;
            cat_btn.Enabled = false;
            sup_btn.Enabled = false;
            cust_btn.Enabled = false;
            pur_btn.Enabled = false;
            sales_btn.Enabled = true;
            report_btn.Enabled = false;
            user_btn.Enabled = false;
            settings_btn.Enabled = false;
            home_screen.addsup_btn.Enabled = false;
            home_screen.addcust_btn.Enabled = false;
            home_screen.addcat_btn.Enabled = false;
            home_screen.pur_btn.Enabled = true;
            home_screen.sale_btn.Enabled = true;
            selling.delete_btn.Enabled = false;
        }

        public MainScreen()
        {
            InitializeComponent();
        }

        //close app
        private void close_btn_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are You Sure To Close App", "Exit", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
            else { }
        }

        //max app
        private void max_btn_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        //min app
        private void min_btn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //menu view
        private void menu_btn_Click(object sender, EventArgs e)
        {
            if (leftnavbar_pan.Width == 178)
            {
                leftnavbar_pan.Width = 45;
                titlenavbar_pan.Visible = false;
                info_pan.Height = 144;
                titlenavbar_pan.Hide();
                flow_pan.Hide();
            }
            else
            {
                leftnavbar_pan.Width = 178;
                titlenavbar_pan.Visible = true;
                info_pan.Height = 144;
                titlenavbar_pan.Show();
                flow_pan.Show();
            }
        }

        //load home page
        private void main_btn_Click(object sender, EventArgs e)
        {
            container_pan.Controls.Clear();
            title_lbl.Text = "Main Screen";
            container_pan.Controls.Add(home_screen.container_pan);
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            container_pan.Controls.Clear();
            container_pan.Controls.Add(home_screen.container_pan);
            if (role_lbl.Text == "Admin")
            {
                admin();
                /*main_btn.Enabled = true;
                cat_btn.Enabled = true;
                sup_btn.Enabled = true;
                cust_btn.Enabled = true;
                pur_btn.Enabled = true;
                sales_btn.Enabled = true;
                report_btn.Enabled = true;
                user_btn.Enabled = true;
                settings_btn.Enabled = true;
                home_screen.addsup_btn.Enabled = true;
                home_screen.addcust_btn.Enabled = true;
                home_screen.addcat_btn.Enabled = true;
                home_screen.pur_btn.Enabled = true;
                home_screen.sale_btn.Enabled = true;
                selling.delete_btn.Enabled = true;*/
            }
            else
            {
                user();
                /*main_btn.Enabled = true;
                cat_btn.Enabled = false;
                sup_btn.Enabled = false;
                cust_btn.Enabled = false;
                pur_btn.Enabled = false;
                sales_btn.Enabled = true;
                report_btn.Enabled = false;
                user_btn.Enabled = false;
                settings_btn.Enabled = false;
                home_screen.addsup_btn.Enabled = false;
                home_screen.addcust_btn.Enabled = false;
                home_screen.addcat_btn.Enabled = false;
                home_screen.pur_btn.Enabled = true;
                home_screen.sale_btn.Enabled = true;
                selling.delete_btn.Enabled = false;*/
            }
            
        }

        //load category
        private void cat_btn_Click(object sender, EventArgs e)
        {
            container_pan.Controls.Clear();
            container_pan.Controls.Add(category.container_pan);
            title_lbl.Text = "Categories";
            update_data();
        }

        //load suppliers
        private void sup_btn_Click(object sender, EventArgs e)
        {
            container_pan.Controls.Clear();
            container_pan.Controls.Add(suppliers.container_pan);
            title_lbl.Text = "Suppliers";
            update_data();
        }

        //load purchases
        private void pur_btn_Click(object sender, EventArgs e)
        {
            container_pan.Controls.Clear();
            container_pan.Controls.Add(purchease.container_pan);
            title_lbl.Text = "Purchaeses";
            update_data();
        }

        //load customers
        private void cust_btn_Click(object sender, EventArgs e)
        {
            container_pan.Controls.Clear();
            container_pan.Controls.Add(customers.container_pan);
            title_lbl.Text = "Customers";
            update_data();
        }

        //load sales
        private void sales_btn_Click(object sender, EventArgs e)
        {
            container_pan.Controls.Clear();
            container_pan.Controls.Add(selling.container_pan);
            title_lbl.Text = "Selling";
            update_data();
        }

        //load reports
        private void report_btn_Click(object sender, EventArgs e)
        {
            container_pan.Controls.Clear();
            container_pan.Controls.Add(report.container_pan);
            title_lbl.Text = "Reports";
            update_data();
        }

        //load users
        private void user_btn_Click(object sender, EventArgs e)
        {
            container_pan.Controls.Clear();
            container_pan.Controls.Add(users.container_pan);
            title_lbl.Text = "Users";
            update_data();
        }

        //load settings
        private void settings_btn_Click(object sender, EventArgs e)
        {
            settings.Show();
            update_data();
        }

        //load log out
        private void logout_btn_Click(object sender, EventArgs e)
        {
            PL.Login login = new PL.Login();
            user_tb = db.USER_TB.Where(x => x.User_State == "True").FirstOrDefault();
            if(user_tb != null)
            {
                user_tb.User_State = "False";
                db.Entry(user_tb).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                this.Enabled = false;
                login.Show();
                this.Hide();
            }
            else
            {
                this.Enabled = false;
                login.Show();
                this.Hide();
            }
            
        }

        private void MainScreen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.A)
            {
                Category_Add category_Add = new Category_Add();
                category_Add.id = 0;
                category_Add.add_btn.Text = "Add";
                category_Add.Show();
            }
            else if (e.KeyData == Keys.S)
            {
                Suppliers_Add suppliers_Add = new Suppliers_Add();
                suppliers_Add.id = 0;
                suppliers_Add.add_btn.Text = "Add";
                suppliers_Add.Show();
            }
            else if (e.KeyData == Keys.P)
            {
                Purchease_Add purchease_Add = new Purchease_Add();
                purchease_Add.id = 0;
                purchease_Add.add_btn.Text = "Add";
                purchease_Add.Show();
            }
            else if (e.KeyData == Keys.C)
            {
                Customers_Add customers_Add = new Customers_Add();
                customers_Add.id = 0;
                customers_Add.add_btn.Text = "Add";
                customers_Add.Show();
            }
            else if (e.KeyData == Keys.D)
            {
                Selling_Add selling_Add = new Selling_Add();
                selling_Add.id = 0;
                selling_Add.add_btn.Text = "Add";
                selling_Add.Show();
            }
            else if (e.KeyData == Keys.R)
            {
                update_data();
            }
        }
    }
}
