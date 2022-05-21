namespace SupermarketManagement.PL
{
    partial class Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            this.panel1 = new System.Windows.Forms.Panel();
            this.container_pan = new System.Windows.Forms.FlowLayoutPanel();
            this.sale_btn = new DevExpress.XtraEditors.SimpleButton();
            this.pur_btn = new DevExpress.XtraEditors.SimpleButton();
            this.supp_btn = new DevExpress.XtraEditors.SimpleButton();
            this.cust_btn = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            this.container_pan.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.container_pan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1153, 629);
            this.panel1.TabIndex = 0;
            // 
            // container_pan
            // 
            this.container_pan.Controls.Add(this.sale_btn);
            this.container_pan.Controls.Add(this.pur_btn);
            this.container_pan.Controls.Add(this.supp_btn);
            this.container_pan.Controls.Add(this.cust_btn);
            this.container_pan.Controls.Add(this.simpleButton1);
            this.container_pan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container_pan.Location = new System.Drawing.Point(0, 0);
            this.container_pan.Name = "container_pan";
            this.container_pan.Size = new System.Drawing.Size(1153, 629);
            this.container_pan.TabIndex = 0;
            this.container_pan.Paint += new System.Windows.Forms.PaintEventHandler(this.container_pan_Paint);
            // 
            // sale_btn
            // 
            this.sale_btn.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sale_btn.Appearance.Options.UseFont = true;
            this.sale_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sale_btn.Location = new System.Drawing.Point(20, 20);
            this.sale_btn.Margin = new System.Windows.Forms.Padding(20);
            this.sale_btn.Name = "sale_btn";
            this.sale_btn.Size = new System.Drawing.Size(370, 229);
            this.sale_btn.TabIndex = 19;
            this.sale_btn.Text = "Sales Report";
            this.sale_btn.Click += new System.EventHandler(this.sale_btn_Click);
            // 
            // pur_btn
            // 
            this.pur_btn.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pur_btn.Appearance.Options.UseFont = true;
            this.pur_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pur_btn.Location = new System.Drawing.Point(430, 20);
            this.pur_btn.Margin = new System.Windows.Forms.Padding(20);
            this.pur_btn.Name = "pur_btn";
            this.pur_btn.Size = new System.Drawing.Size(370, 229);
            this.pur_btn.TabIndex = 20;
            this.pur_btn.Text = "Purchases Report";
            this.pur_btn.Click += new System.EventHandler(this.pur_btn_Click);
            // 
            // supp_btn
            // 
            this.supp_btn.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supp_btn.Appearance.Options.UseFont = true;
            this.supp_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.supp_btn.Location = new System.Drawing.Point(20, 289);
            this.supp_btn.Margin = new System.Windows.Forms.Padding(20);
            this.supp_btn.Name = "supp_btn";
            this.supp_btn.Size = new System.Drawing.Size(370, 229);
            this.supp_btn.TabIndex = 21;
            this.supp_btn.Text = "Suppliers Report";
            this.supp_btn.Click += new System.EventHandler(this.supp_btn_Click);
            // 
            // cust_btn
            // 
            this.cust_btn.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_btn.Appearance.Options.UseFont = true;
            this.cust_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cust_btn.Location = new System.Drawing.Point(430, 289);
            this.cust_btn.Margin = new System.Windows.Forms.Padding(20);
            this.cust_btn.Name = "cust_btn";
            this.cust_btn.Size = new System.Drawing.Size(370, 229);
            this.cust_btn.TabIndex = 22;
            this.cust_btn.Text = "Customers Report";
            this.cust_btn.Click += new System.EventHandler(this.cust_btn_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.simpleButton1.Location = new System.Drawing.Point(20, 558);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(20);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(370, 229);
            this.simpleButton1.TabIndex = 23;
            this.simpleButton1.Text = "Categories Report";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 629);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Report";
            this.Text = "Report";
            this.panel1.ResumeLayout(false);
            this.container_pan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public DevExpress.XtraEditors.SimpleButton sale_btn;
        public DevExpress.XtraEditors.SimpleButton pur_btn;
        public DevExpress.XtraEditors.SimpleButton supp_btn;
        public DevExpress.XtraEditors.SimpleButton cust_btn;
        public System.Windows.Forms.FlowLayoutPanel container_pan;
        public DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}