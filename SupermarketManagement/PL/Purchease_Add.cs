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
    public partial class Purchease_Add: Form
    {
        //inti
        SMP_DBEntities3 db = new SMP_DBEntities3();
        PUR_TB pur_tb = new PUR_TB();
        BL.Methods methods = new BL.Methods();
        PL.Suppliers suppliers = new Suppliers();
        Toast toast = new Toast();

        public int id;
        public double buy, sell, qt, tbuy, tsell, trev;

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

            //check empty or not
            if (item_name_txt.Text == "" ||
                type_txt.Text == "" ||
                cat_comb.SelectedItem == null ||
                supp_comb.SelectedItem == null ||
                pur_price_txt.Text == "" ||
                sale_price_txt.Text == "" ||
                spinEdit1.Text == "")
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
                    pur_tb.Pur_Name = item_name_txt.Text;
                    pur_tb.Pur_Type = type_txt.Text;
                    pur_tb.Pur_Cat = cat_comb.Text;
                    pur_tb.Pur_Supp = supp_comb.Text;
                    pur_tb.Pur_Det = details_txt.Text;
                    pur_tb.Pur_Buy = Convert.ToDouble(pur_price_txt.Text);
                    pur_tb.Pur_Sell = Convert.ToDouble(sale_price_txt.Text);
                    pur_tb.Pur_Qt = Convert.ToDouble(spinEdit1.Text);
                    pur_tb.Pur_Tbuy = Convert.ToDouble(pur_rs_lbl.Text);
                    pur_tb.Pur_Tsell = Convert.ToDouble(sale_rs_lbl.Text);
                    pur_tb.Pur_TRev = Convert.ToDouble(profit_rs_lbl.Text);
                    db.PUR_TB.Add(pur_tb);
                    db.SaveChanges();
                    toast.toast_txt.Text = "Successfully Buy.";
                    toast.Show();
                    update_data();
                    this.Close();
                }
                else
                {
                    //edit
                    pur_tb.ID = id;
                    pur_tb.Pur_Name = item_name_txt.Text;
                    pur_tb.Pur_Type = type_txt.Text;
                    pur_tb.Pur_Cat = cat_comb.Text;
                    pur_tb.Pur_Supp = supp_comb.Text;
                    pur_tb.Pur_Det = details_txt.Text;
                    pur_tb.Pur_Buy = Convert.ToDouble(pur_price_txt.Text);
                    pur_tb.Pur_Sell = Convert.ToDouble(sale_price_txt.Text);
                    pur_tb.Pur_Qt = Convert.ToDouble(spinEdit1.Text);
                    pur_tb.Pur_Tbuy = Convert.ToDouble(pur_rs_lbl.Text);
                    pur_tb.Pur_Tsell = Convert.ToDouble(sale_rs_lbl.Text);
                    pur_tb.Pur_TRev = Convert.ToDouble(profit_rs_lbl.Text);

                    //pur_tb.SUPP_Image = methods.convert_byte();
                    db.Entry(pur_tb).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    toast.toast_txt.Text = "Edited Successfully.";
                    toast.Show();
                    update_data();
                    this.Close();
                }

            }
        }

        //calc
        private void pro_calc()
        {
            try {
                if (pur_price_txt.Text == "" || sale_price_txt.Text == "")
                {
                    if (pur_price_txt.Text == "")
                    {
                        pur_price_txt.Text = "0";
                        buy = Convert.ToDouble(pur_price_txt.Text);
                        sell = Convert.ToDouble(sale_price_txt.Text);
                        qt = Convert.ToDouble(spinEdit1.Value);
                        tbuy = buy * qt;
                        tsell = sell * qt;
                        trev = sell - buy;
                        pur_rs_lbl.Text = tbuy.ToString();
                        sale_rs_lbl.Text = tsell.ToString();
                        profit_rs_lbl.Text = trev.ToString();
                    }
                    else if (sale_price_txt.Text == "")
                    {
                        sale_price_txt.Text = "0";
                        buy = Convert.ToDouble(pur_price_txt.Text);
                        sell = Convert.ToDouble(sale_price_txt.Text);
                        qt = Convert.ToDouble(spinEdit1.Value);
                        tbuy = buy * qt;
                        tsell = sell * qt;
                        trev = sell - buy;
                        pur_rs_lbl.Text = tbuy.ToString();
                        sale_rs_lbl.Text = tsell.ToString();
                        profit_rs_lbl.Text = trev.ToString();
                    }
                    else if (pur_price_txt.Text == "" && sale_price_txt.Text == "")
                    {
                        pur_price_txt.Text = "0";
                        sale_price_txt.Text = "0";
                        buy = Convert.ToDouble(pur_price_txt.Text);
                        sell = Convert.ToDouble(sale_price_txt.Text);
                        qt = Convert.ToDouble(spinEdit1.Value);
                        tbuy = buy * qt;
                        tsell = sell * qt;
                        trev = sell - buy;
                        pur_rs_lbl.Text = tbuy.ToString();
                        sale_rs_lbl.Text = tsell.ToString();
                        profit_rs_lbl.Text = trev.ToString();
                    }
                }
                else
                {
                    buy = Convert.ToDouble(pur_price_txt.Text);
                    sell = Convert.ToDouble(sale_price_txt.Text);
                    qt = Convert.ToDouble(spinEdit1.Value);
                    tbuy = buy * qt;
                    tsell = sell * qt;
                    trev = sell - buy;
                    pur_rs_lbl.Text = tbuy.ToString();
                    sale_rs_lbl.Text = tsell.ToString();
                    profit_rs_lbl.Text = trev.ToString();
                }
            }
            catch
            {
                toast.toast_txt.Text = "You Can Enter Numbers Only.";
                toast.Show();
            }  
        }

        //purchase change
        private void pur_price_txt_TextChanged(object sender, EventArgs e)
        {
            pro_calc();
        }

        //sale change
        private void sale_price_txt_TextChanged(object sender, EventArgs e)
        {
            pro_calc();
        }

        //quantity change
        private void spinEdit1_EditValueChanged(object sender, EventArgs e)
        {
            pro_calc();
        }

        public Purchease_Add()
        {
            InitializeComponent();
        }

        private void item_name_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                add();
            }
        }

        private void type_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                add();
            }
        }

        private void details_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                add();
            }
        }

        private void pur_price_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                add();
            }
        }

        private void sale_price_txt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cat_comb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                add();
            }
        }

        private void supp_comb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                add();
            }
        }

        private void spinEdit1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                add();
            }
        }

        //add and edit
        private void add_btn_Click(object sender, EventArgs e)
        {
            add();
        }

        //form activate
        private void Purchease_Add_Activated(object sender, EventArgs e)
        {
            cat_comb.DataSource = db.CAT_TB.Select(x => x.CAT_Name).ToList();
            supp_comb.DataSource = db.SUPP_TB.Select(x => x.SUPP_Name).ToList();
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
            PL.Suppliers_Add suppliers_add = new Suppliers_Add();
            suppliers_add.id = 0;
            suppliers_add.add_btn.Text = "Add";
            suppliers_add.Show();
        }
    }
}
