namespace SupermarketManagement.PL
{
    partial class Selling_Add
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Selling_Add));
            this.container_pan = new System.Windows.Forms.Panel();
            this.add_btn = new DevExpress.XtraEditors.SimpleButton();
            this.rs_pan = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.qt_rs_lbl = new System.Windows.Forms.Label();
            this.sale_rs_lbl = new System.Windows.Forms.Label();
            this.profit_lbl = new System.Windows.Forms.Label();
            this.sale_lbl = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.title2_lbl = new System.Windows.Forms.Label();
            this.by_sl_pan = new System.Windows.Forms.Panel();
            this.spinEdit1 = new DevExpress.XtraEditors.SpinEdit();
            this.sell_price_txt = new System.Windows.Forms.TextBox();
            this.quan_lbl = new System.Windows.Forms.Label();
            this.pur__price_lbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.title1_lbl = new System.Windows.Forms.Label();
            this.info_pan = new System.Windows.Forms.Panel();
            this.item_name_comb = new System.Windows.Forms.ComboBox();
            this.add_cust_link = new System.Windows.Forms.LinkLabel();
            this.cust_comb = new System.Windows.Forms.ComboBox();
            this.item_name_lbl = new System.Windows.Forms.Label();
            this.supp_lbl = new System.Windows.Forms.Label();
            this.msg_lbl = new System.Windows.Forms.Label();
            this.container_pan.SuspendLayout();
            this.rs_pan.SuspendLayout();
            this.panel4.SuspendLayout();
            this.by_sl_pan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            this.info_pan.SuspendLayout();
            this.SuspendLayout();
            // 
            // container_pan
            // 
            this.container_pan.BackColor = System.Drawing.SystemColors.Control;
            this.container_pan.Controls.Add(this.add_btn);
            this.container_pan.Controls.Add(this.rs_pan);
            this.container_pan.Controls.Add(this.panel4);
            this.container_pan.Controls.Add(this.by_sl_pan);
            this.container_pan.Controls.Add(this.panel2);
            this.container_pan.Controls.Add(this.info_pan);
            this.container_pan.Controls.Add(this.msg_lbl);
            this.container_pan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container_pan.Location = new System.Drawing.Point(0, 0);
            this.container_pan.Name = "container_pan";
            this.container_pan.Size = new System.Drawing.Size(1275, 648);
            this.container_pan.TabIndex = 0;
            // 
            // add_btn
            // 
            this.add_btn.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.Appearance.Options.UseFont = true;
            this.add_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_btn.ImageOptions.Image = global::SupermarketManagement.Properties.Resources.plus;
            this.add_btn.Location = new System.Drawing.Point(1072, 571);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(182, 52);
            this.add_btn.TabIndex = 12;
            this.add_btn.Text = "Add";
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            this.add_btn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.add_btn_KeyPress);
            // 
            // rs_pan
            // 
            this.rs_pan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rs_pan.Controls.Add(this.label1);
            this.rs_pan.Controls.Add(this.qt_rs_lbl);
            this.rs_pan.Controls.Add(this.sale_rs_lbl);
            this.rs_pan.Controls.Add(this.profit_lbl);
            this.rs_pan.Controls.Add(this.sale_lbl);
            this.rs_pan.Location = new System.Drawing.Point(24, 28);
            this.rs_pan.Name = "rs_pan";
            this.rs_pan.Size = new System.Drawing.Size(469, 510);
            this.rs_pan.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Navy;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(467, 66);
            this.label1.TabIndex = 8;
            this.label1.Text = "Item Information";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // qt_rs_lbl
            // 
            this.qt_rs_lbl.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qt_rs_lbl.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.qt_rs_lbl.Location = new System.Drawing.Point(172, 369);
            this.qt_rs_lbl.Name = "qt_rs_lbl";
            this.qt_rs_lbl.Size = new System.Drawing.Size(110, 45);
            this.qt_rs_lbl.TabIndex = 7;
            this.qt_rs_lbl.Text = "0";
            this.qt_rs_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sale_rs_lbl
            // 
            this.sale_rs_lbl.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sale_rs_lbl.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.sale_rs_lbl.Location = new System.Drawing.Point(149, 233);
            this.sale_rs_lbl.Name = "sale_rs_lbl";
            this.sale_rs_lbl.Size = new System.Drawing.Size(153, 45);
            this.sale_rs_lbl.TabIndex = 6;
            this.sale_rs_lbl.Text = "0";
            this.sale_rs_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // profit_lbl
            // 
            this.profit_lbl.AutoSize = true;
            this.profit_lbl.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profit_lbl.ForeColor = System.Drawing.Color.SlateBlue;
            this.profit_lbl.Location = new System.Drawing.Point(166, 306);
            this.profit_lbl.Name = "profit_lbl";
            this.profit_lbl.Size = new System.Drawing.Size(116, 35);
            this.profit_lbl.TabIndex = 4;
            this.profit_lbl.Text = "Quantity";
            // 
            // sale_lbl
            // 
            this.sale_lbl.AutoSize = true;
            this.sale_lbl.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sale_lbl.ForeColor = System.Drawing.Color.SlateBlue;
            this.sale_lbl.Location = new System.Drawing.Point(143, 169);
            this.sale_lbl.Name = "sale_lbl";
            this.sale_lbl.Size = new System.Drawing.Size(159, 35);
            this.sale_lbl.TabIndex = 3;
            this.sale_lbl.Text = "Selling Price";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.title2_lbl);
            this.panel4.Location = new System.Drawing.Point(609, 300);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(92, 35);
            this.panel4.TabIndex = 8;
            // 
            // title2_lbl
            // 
            this.title2_lbl.AutoSize = true;
            this.title2_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.title2_lbl.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title2_lbl.Location = new System.Drawing.Point(0, 0);
            this.title2_lbl.Name = "title2_lbl";
            this.title2_lbl.Size = new System.Drawing.Size(92, 35);
            this.title2_lbl.TabIndex = 0;
            this.title2_lbl.Text = "Selling";
            this.title2_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // by_sl_pan
            // 
            this.by_sl_pan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.by_sl_pan.Controls.Add(this.spinEdit1);
            this.by_sl_pan.Controls.Add(this.sell_price_txt);
            this.by_sl_pan.Controls.Add(this.quan_lbl);
            this.by_sl_pan.Controls.Add(this.pur__price_lbl);
            this.by_sl_pan.Location = new System.Drawing.Point(563, 318);
            this.by_sl_pan.Name = "by_sl_pan";
            this.by_sl_pan.Size = new System.Drawing.Size(691, 220);
            this.by_sl_pan.TabIndex = 7;
            // 
            // spinEdit1
            // 
            this.spinEdit1.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinEdit1.Location = new System.Drawing.Point(322, 127);
            this.spinEdit1.Name = "spinEdit1";
            this.spinEdit1.Properties.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold);
            this.spinEdit1.Properties.Appearance.Options.UseFont = true;
            this.spinEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEdit1.Size = new System.Drawing.Size(345, 38);
            this.spinEdit1.TabIndex = 17;
            this.spinEdit1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.spinEdit1_KeyPress);
            // 
            // sell_price_txt
            // 
            this.sell_price_txt.Enabled = false;
            this.sell_price_txt.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sell_price_txt.Location = new System.Drawing.Point(322, 53);
            this.sell_price_txt.Name = "sell_price_txt";
            this.sell_price_txt.Size = new System.Drawing.Size(345, 40);
            this.sell_price_txt.TabIndex = 13;
            this.sell_price_txt.Text = "0";
            this.sell_price_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sell_price_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sell_price_txt_KeyPress);
            // 
            // quan_lbl
            // 
            this.quan_lbl.AutoSize = true;
            this.quan_lbl.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quan_lbl.ForeColor = System.Drawing.SystemColors.GrayText;
            this.quan_lbl.Location = new System.Drawing.Point(16, 130);
            this.quan_lbl.Name = "quan_lbl";
            this.quan_lbl.Size = new System.Drawing.Size(116, 35);
            this.quan_lbl.TabIndex = 15;
            this.quan_lbl.Text = "Quantity";
            // 
            // pur__price_lbl
            // 
            this.pur__price_lbl.AutoSize = true;
            this.pur__price_lbl.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pur__price_lbl.ForeColor = System.Drawing.SystemColors.GrayText;
            this.pur__price_lbl.Location = new System.Drawing.Point(16, 58);
            this.pur__price_lbl.Name = "pur__price_lbl";
            this.pur__price_lbl.Size = new System.Drawing.Size(159, 35);
            this.pur__price_lbl.TabIndex = 13;
            this.pur__price_lbl.Text = "Selling Price";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.title1_lbl);
            this.panel2.Location = new System.Drawing.Point(615, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 35);
            this.panel2.TabIndex = 6;
            // 
            // title1_lbl
            // 
            this.title1_lbl.AutoSize = true;
            this.title1_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.title1_lbl.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title1_lbl.Location = new System.Drawing.Point(0, 0);
            this.title1_lbl.Name = "title1_lbl";
            this.title1_lbl.Size = new System.Drawing.Size(218, 35);
            this.title1_lbl.TabIndex = 0;
            this.title1_lbl.Text = "Main Information";
            this.title1_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // info_pan
            // 
            this.info_pan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.info_pan.Controls.Add(this.item_name_comb);
            this.info_pan.Controls.Add(this.add_cust_link);
            this.info_pan.Controls.Add(this.cust_comb);
            this.info_pan.Controls.Add(this.item_name_lbl);
            this.info_pan.Controls.Add(this.supp_lbl);
            this.info_pan.Location = new System.Drawing.Point(563, 28);
            this.info_pan.Name = "info_pan";
            this.info_pan.Size = new System.Drawing.Size(691, 246);
            this.info_pan.TabIndex = 0;
            // 
            // item_name_comb
            // 
            this.item_name_comb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.item_name_comb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.item_name_comb.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_name_comb.FormattingEnabled = true;
            this.item_name_comb.Location = new System.Drawing.Point(322, 33);
            this.item_name_comb.Name = "item_name_comb";
            this.item_name_comb.Size = new System.Drawing.Size(345, 40);
            this.item_name_comb.TabIndex = 13;
            this.item_name_comb.SelectedIndexChanged += new System.EventHandler(this.item_name_comb_SelectedIndexChanged);
            this.item_name_comb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.item_name_comb_KeyPress);
            // 
            // add_cust_link
            // 
            this.add_cust_link.AutoSize = true;
            this.add_cust_link.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_cust_link.Location = new System.Drawing.Point(255, 105);
            this.add_cust_link.Name = "add_cust_link";
            this.add_cust_link.Size = new System.Drawing.Size(61, 35);
            this.add_cust_link.TabIndex = 12;
            this.add_cust_link.TabStop = true;
            this.add_cust_link.Text = "Add";
            this.add_cust_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.add_supp_link_LinkClicked);
            // 
            // cust_comb
            // 
            this.cust_comb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cust_comb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cust_comb.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_comb.FormattingEnabled = true;
            this.cust_comb.Location = new System.Drawing.Point(322, 100);
            this.cust_comb.Name = "cust_comb";
            this.cust_comb.Size = new System.Drawing.Size(345, 40);
            this.cust_comb.TabIndex = 9;
            this.cust_comb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cust_comb_KeyPress);
            // 
            // item_name_lbl
            // 
            this.item_name_lbl.AutoSize = true;
            this.item_name_lbl.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_name_lbl.ForeColor = System.Drawing.SystemColors.GrayText;
            this.item_name_lbl.Location = new System.Drawing.Point(23, 36);
            this.item_name_lbl.Name = "item_name_lbl";
            this.item_name_lbl.Size = new System.Drawing.Size(146, 35);
            this.item_name_lbl.TabIndex = 1;
            this.item_name_lbl.Text = "Item Name";
            // 
            // supp_lbl
            // 
            this.supp_lbl.AutoSize = true;
            this.supp_lbl.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supp_lbl.ForeColor = System.Drawing.SystemColors.GrayText;
            this.supp_lbl.Location = new System.Drawing.Point(16, 105);
            this.supp_lbl.Name = "supp_lbl";
            this.supp_lbl.Size = new System.Drawing.Size(122, 35);
            this.supp_lbl.TabIndex = 4;
            this.supp_lbl.Text = "Customer";
            // 
            // msg_lbl
            // 
            this.msg_lbl.AutoSize = true;
            this.msg_lbl.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msg_lbl.ForeColor = System.Drawing.Color.Red;
            this.msg_lbl.Location = new System.Drawing.Point(427, 582);
            this.msg_lbl.Name = "msg_lbl";
            this.msg_lbl.Size = new System.Drawing.Size(312, 41);
            this.msg_lbl.TabIndex = 2;
            this.msg_lbl.Text = "No Enough Quantity";
            this.msg_lbl.Visible = false;
            // 
            // Selling_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1275, 648);
            this.Controls.Add(this.container_pan);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Selling_Add";
            this.Opacity = 0.98D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.Purchease_Add_Activated);
            this.container_pan.ResumeLayout(false);
            this.container_pan.PerformLayout();
            this.rs_pan.ResumeLayout(false);
            this.rs_pan.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.by_sl_pan.ResumeLayout(false);
            this.by_sl_pan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.info_pan.ResumeLayout(false);
            this.info_pan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel container_pan;
        private System.Windows.Forms.Panel info_pan;
        private System.Windows.Forms.Label supp_lbl;
        private System.Windows.Forms.Label item_name_lbl;
        private System.Windows.Forms.Label title1_lbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label title2_lbl;
        private System.Windows.Forms.Panel by_sl_pan;
        private System.Windows.Forms.Label quan_lbl;
        private System.Windows.Forms.Label pur__price_lbl;
        private System.Windows.Forms.LinkLabel add_cust_link;
        private System.Windows.Forms.Panel rs_pan;
        private System.Windows.Forms.Label qt_rs_lbl;
        private System.Windows.Forms.Label sale_rs_lbl;
        private System.Windows.Forms.Label profit_lbl;
        private System.Windows.Forms.Label sale_lbl;
        public DevExpress.XtraEditors.SimpleButton add_btn;
        public DevExpress.XtraEditors.SpinEdit spinEdit1;
        public System.Windows.Forms.TextBox sell_price_txt;
        public System.Windows.Forms.ComboBox cust_comb;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox item_name_comb;
        private System.Windows.Forms.Label msg_lbl;
    }
}