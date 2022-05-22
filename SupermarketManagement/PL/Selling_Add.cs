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
    public partial class Selling_Add: Form
    {
        //inti
        SMP_DBEntities3 db = new SMP_DBEntities3();
        SELL_TB sell_tb = new SELL_TB();
        PUR_TB pur_tb = new PUR_TB();
        PL.Suppliers suppliers = new Suppliers();
        Toast toast = new Toast();

        public int id;
        public double pqt, nqt, rqt, ts, sp, se;

        //update data
        private void update_data()
        {
            db = new SMP_DBEntities3();
            suppliers.gridControl1.DataSource = db.PUR_TB.ToList();
        }

        // Add
        private void add()
        {
            Toast toast = new Toast();
            Dialog dialog = new Dialog();
            pqt = Convert.ToDouble(qt_rs_lbl.Text);
            nqt = Convert.ToDouble(spinEdit1.Text);
            rqt = pqt - nqt;
            sp = Convert.ToDouble(sell_price_txt.Text);
            se = Convert.ToDouble(spinEdit1.Text);
            ts = sp * se;


            //check empty or not
            if (item_name_comb.Text == "" ||
                cust_comb.SelectedItem == null ||
                sell_price_txt.Text == "" ||
                spinEdit1.Text == "")
            {
                dialog.Width = this.Width;
                dialog.dialog_txt.Text = "Item Name Required";
                dialog.Show();
            }
            else
            {
                //add
                if (id == 0)
                {
                    if (rqt >= 0)
                    {
                        //add
                        sell_tb.Sell_Name = item_name_comb.Text;
                        sell_tb.Sell_Cust = cust_comb.Text; ;
                        sell_tb.Sell_Price = Convert.ToDouble(sell_price_txt.Text);
                        sell_tb.Sell_Qt = Convert.ToDouble(spinEdit1.Text);
                        sell_tb.Sell_Tprice = Convert.ToDouble(ts);
                        sell_tb.Sell_Date = DateTime.Now;
                        db.SELL_TB.Add(sell_tb);
                        pur_tb.Pur_Qt = rqt;

                        db.Entry(pur_tb).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        toast.toast_txt.Text = "Successfully Buy.";
                        toast.Show();
                        update_data();
                        this.Close();
                    }
                    else
                    {
                        msg_lbl.Visible = true;
                    }
                }

            }
        }

        private void item_name_comb_SelectedIndexChanged(object sender, EventArgs e)
        {
            pur_tb = db.PUR_TB.Where(x => x.Pur_Name == item_name_comb.Text).FirstOrDefault();

            sale_rs_lbl.Text = pur_tb.Pur_Sell.ToString();
            qt_rs_lbl.Text = pur_tb.Pur_Qt.ToString();

        }

        // Enter Key Press
        private void item_name_comb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Convert.ToInt32(e.KeyChar) == 13)
            {
                add();
            }
        }

        // Enter Key Press
        private void cust_comb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                add();
            }
        }

        // Enter Key Press
        private void sell_price_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                add();
            }
        }

        // Enter Key Press
        private void spinEdit1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                add();
            }
        }

        // Enter Key Press
        private void add_btn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                add();
            }
        }

        public Selling_Add()
        {
            InitializeComponent();
        }

        //add and edit
        private void add_btn_Click(object sender, EventArgs e)
        {
            add();
        }

        //form activate
        private void Purchease_Add_Activated(object sender, EventArgs e)
        {
            var rs1 = db.CUST_TB.Select(x => x.CUST_Name).ToList();
            var rs2 = db.PUR_TB.Select(x => x.Pur_Name).ToList();
            item_name_comb.DataSource = rs2;
            cust_comb.DataSource = rs1;

            AutoCompleteStringCollection ac1 = new AutoCompleteStringCollection();
            AutoCompleteStringCollection ac2 = new AutoCompleteStringCollection();

            ac1.AddRange(rs1.ToArray());
            ac2.AddRange(rs2.ToArray());

            item_name_comb.AutoCompleteCustomSource = ac1;
            cust_comb.AutoCompleteCustomSource = ac2;
        }


        //cat_link add
        private void add_cat_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PL.Category_Add category_add = new Category_Add();
            category_add.id = 0;
            category_add.add_btn.Text = "Add";
            category_add.Show();
        }

        //supp_link add
        private void add_supp_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PL.Customers_Add customers_add = new Customers_Add();
            customers_add.id = 0;
            customers_add.add_btn.Text = "Add";
            customers_add.Show();
        }
    }
}
