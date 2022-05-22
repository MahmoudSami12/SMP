using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermarketManagement.PL
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        // Add
        private void add()
        {
            const string qu = "\"";
            var sv = sv_txt.Text;
            var constr = "metadata=res://*/SMP_DBEntity.csdl|res://*/SMP_DBEntity.ssdl|res://*/SMP_DBEntity.msl;provider=System.Data.SqlClient;provider connection string=" + qu + "; data source=" + sv + ";initial catalog=SMP_DB;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework" + qu + "; ";

            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.ConnectionStrings.ConnectionStrings["SMP_DBEntities"].ConnectionString = constr;
            config.Save();
            ConfigurationManager.RefreshSection("connectionString");
            var strl = config.ConnectionStrings.ConnectionStrings["SMP_DBEntities"].ConnectionString;
            MessageBox.Show(strl);
            Application.Restart();
        }

        // Add
        private void add_btn_Click(object sender, EventArgs e)
        {
            add();
        }

        // Close
        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sv_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                add();
            }
        }
    }
}
