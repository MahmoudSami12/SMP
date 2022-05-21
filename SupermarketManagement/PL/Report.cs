using DevExpress.XtraReports.UI;
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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void pur_btn_Click(object sender, EventArgs e)
        {
            PL.XtraReport1 report1 = new PL.XtraReport1();
            report1.ShowPreview();
        }

        private void cust_btn_Click(object sender, EventArgs e)
        {
            PL.XtraReport3 report3 = new PL.XtraReport3();
            report3.ShowPreview();
        }

        private void supp_btn_Click(object sender, EventArgs e)
        {
            PL.XtraReport2 report2 = new PL.XtraReport2();
            report2.ShowPreview();
        }

        private void sale_btn_Click(object sender, EventArgs e)
        {
            PL.XtraReport6 report6 = new PL.XtraReport6();
            report6.ShowPreview();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            PL.XtraReport4 report4 = new PL.XtraReport4();
            report4.ShowPreview();
        }

        private void container_pan_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
