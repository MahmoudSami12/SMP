namespace SupermarketManagement
{
    partial class MainScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.topnavbar_pan = new System.Windows.Forms.Panel();
            this.logout_btn = new System.Windows.Forms.Button();
            this.min_btn = new System.Windows.Forms.Button();
            this.max_btn = new System.Windows.Forms.Button();
            this.close_btn = new System.Windows.Forms.Button();
            this.title_lbl = new System.Windows.Forms.Label();
            this.leftnavbar_pan = new System.Windows.Forms.Panel();
            this.flow_pan = new System.Windows.Forms.FlowLayoutPanel();
            this.main_btn = new DevExpress.XtraEditors.SimpleButton();
            this.cat_btn = new DevExpress.XtraEditors.SimpleButton();
            this.cust_btn = new DevExpress.XtraEditors.SimpleButton();
            this.pur_btn = new DevExpress.XtraEditors.SimpleButton();
            this.sup_btn = new DevExpress.XtraEditors.SimpleButton();
            this.sales_btn = new DevExpress.XtraEditors.SimpleButton();
            this.report_btn = new DevExpress.XtraEditors.SimpleButton();
            this.user_btn = new DevExpress.XtraEditors.SimpleButton();
            this.settings_btn = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.info_pan = new System.Windows.Forms.Panel();
            this.titlenavbar_pan = new System.Windows.Forms.Panel();
            this.user_img = new System.Windows.Forms.PictureBox();
            this.name_lbl = new System.Windows.Forms.Label();
            this.role_lbl = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.menu_btn = new DevExpress.XtraEditors.SimpleButton();
            this.container_pan = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.topnavbar_pan.SuspendLayout();
            this.leftnavbar_pan.SuspendLayout();
            this.flow_pan.SuspendLayout();
            this.info_pan.SuspendLayout();
            this.titlenavbar_pan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_img)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // topnavbar_pan
            // 
            this.topnavbar_pan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.topnavbar_pan.Controls.Add(this.logout_btn);
            this.topnavbar_pan.Controls.Add(this.min_btn);
            this.topnavbar_pan.Controls.Add(this.max_btn);
            this.topnavbar_pan.Controls.Add(this.close_btn);
            this.topnavbar_pan.Controls.Add(this.title_lbl);
            this.topnavbar_pan.Dock = System.Windows.Forms.DockStyle.Top;
            this.topnavbar_pan.Location = new System.Drawing.Point(237, 0);
            this.topnavbar_pan.Margin = new System.Windows.Forms.Padding(4);
            this.topnavbar_pan.Name = "topnavbar_pan";
            this.topnavbar_pan.Size = new System.Drawing.Size(1153, 54);
            this.topnavbar_pan.TabIndex = 6;
            // 
            // logout_btn
            // 
            this.logout_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.logout_btn.Image = ((System.Drawing.Image)(resources.GetObject("logout_btn.Image")));
            this.logout_btn.Location = new System.Drawing.Point(917, 0);
            this.logout_btn.Margin = new System.Windows.Forms.Padding(4);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(59, 54);
            this.logout_btn.TabIndex = 17;
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // min_btn
            // 
            this.min_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.min_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.min_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.min_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.min_btn.Image = ((System.Drawing.Image)(resources.GetObject("min_btn.Image")));
            this.min_btn.Location = new System.Drawing.Point(976, 0);
            this.min_btn.Margin = new System.Windows.Forms.Padding(4);
            this.min_btn.Name = "min_btn";
            this.min_btn.Size = new System.Drawing.Size(59, 54);
            this.min_btn.TabIndex = 16;
            this.min_btn.UseVisualStyleBackColor = true;
            this.min_btn.Click += new System.EventHandler(this.min_btn_Click);
            // 
            // max_btn
            // 
            this.max_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.max_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.max_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.max_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.max_btn.Image = ((System.Drawing.Image)(resources.GetObject("max_btn.Image")));
            this.max_btn.Location = new System.Drawing.Point(1035, 0);
            this.max_btn.Margin = new System.Windows.Forms.Padding(4);
            this.max_btn.Name = "max_btn";
            this.max_btn.Size = new System.Drawing.Size(59, 54);
            this.max_btn.TabIndex = 15;
            this.max_btn.UseVisualStyleBackColor = true;
            this.max_btn.Click += new System.EventHandler(this.max_btn_Click);
            // 
            // close_btn
            // 
            this.close_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.close_btn.Image = ((System.Drawing.Image)(resources.GetObject("close_btn.Image")));
            this.close_btn.Location = new System.Drawing.Point(1094, 0);
            this.close_btn.Margin = new System.Windows.Forms.Padding(4);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(59, 54);
            this.close_btn.TabIndex = 14;
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // title_lbl
            // 
            this.title_lbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.title_lbl.AutoSize = true;
            this.title_lbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.title_lbl.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lbl.ForeColor = System.Drawing.Color.White;
            this.title_lbl.Location = new System.Drawing.Point(427, 9);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(198, 41);
            this.title_lbl.TabIndex = 13;
            this.title_lbl.Text = "Main Screen";
            // 
            // leftnavbar_pan
            // 
            this.leftnavbar_pan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.leftnavbar_pan.Controls.Add(this.flow_pan);
            this.leftnavbar_pan.Controls.Add(this.info_pan);
            this.leftnavbar_pan.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftnavbar_pan.Location = new System.Drawing.Point(0, 0);
            this.leftnavbar_pan.Margin = new System.Windows.Forms.Padding(4);
            this.leftnavbar_pan.Name = "leftnavbar_pan";
            this.leftnavbar_pan.Size = new System.Drawing.Size(237, 683);
            this.leftnavbar_pan.TabIndex = 5;
            // 
            // flow_pan
            // 
            this.flow_pan.Controls.Add(this.main_btn);
            this.flow_pan.Controls.Add(this.cat_btn);
            this.flow_pan.Controls.Add(this.cust_btn);
            this.flow_pan.Controls.Add(this.pur_btn);
            this.flow_pan.Controls.Add(this.sup_btn);
            this.flow_pan.Controls.Add(this.sales_btn);
            this.flow_pan.Controls.Add(this.report_btn);
            this.flow_pan.Controls.Add(this.user_btn);
            this.flow_pan.Controls.Add(this.settings_btn);
            this.flow_pan.Controls.Add(this.label1);
            this.flow_pan.Location = new System.Drawing.Point(0, 177);
            this.flow_pan.Margin = new System.Windows.Forms.Padding(4);
            this.flow_pan.Name = "flow_pan";
            this.flow_pan.Size = new System.Drawing.Size(237, 506);
            this.flow_pan.TabIndex = 1;
            // 
            // main_btn
            // 
            this.main_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.main_btn.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.main_btn.Appearance.Options.UseForeColor = true;
            this.main_btn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.main_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.main_btn.ImageOptions.Image = global::SupermarketManagement.Properties.Resources.home;
            this.main_btn.Location = new System.Drawing.Point(3, 3);
            this.main_btn.Name = "main_btn";
            this.main_btn.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.main_btn.Size = new System.Drawing.Size(234, 32);
            this.main_btn.TabIndex = 0;
            this.main_btn.Text = "Main Screen";
            this.main_btn.Click += new System.EventHandler(this.main_btn_Click);
            // 
            // cat_btn
            // 
            this.cat_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cat_btn.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.cat_btn.Appearance.Options.UseForeColor = true;
            this.cat_btn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.cat_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cat_btn.ImageOptions.Image = global::SupermarketManagement.Properties.Resources.item;
            this.cat_btn.Location = new System.Drawing.Point(3, 41);
            this.cat_btn.Name = "cat_btn";
            this.cat_btn.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.cat_btn.Size = new System.Drawing.Size(234, 32);
            this.cat_btn.TabIndex = 1;
            this.cat_btn.Text = "Categories";
            this.cat_btn.Click += new System.EventHandler(this.cat_btn_Click);
            // 
            // cust_btn
            // 
            this.cust_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cust_btn.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.cust_btn.Appearance.Options.UseForeColor = true;
            this.cust_btn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.cust_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cust_btn.ImageOptions.Image = global::SupermarketManagement.Properties.Resources.customer;
            this.cust_btn.Location = new System.Drawing.Point(3, 79);
            this.cust_btn.Name = "cust_btn";
            this.cust_btn.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.cust_btn.Size = new System.Drawing.Size(234, 32);
            this.cust_btn.TabIndex = 4;
            this.cust_btn.Text = "Customers";
            this.cust_btn.Click += new System.EventHandler(this.cust_btn_Click);
            // 
            // pur_btn
            // 
            this.pur_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pur_btn.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.pur_btn.Appearance.Options.UseForeColor = true;
            this.pur_btn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.pur_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pur_btn.ImageOptions.Image = global::SupermarketManagement.Properties.Resources.shopping_cart;
            this.pur_btn.Location = new System.Drawing.Point(3, 117);
            this.pur_btn.Name = "pur_btn";
            this.pur_btn.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.pur_btn.Size = new System.Drawing.Size(234, 32);
            this.pur_btn.TabIndex = 3;
            this.pur_btn.Text = "Purcheases";
            this.pur_btn.Click += new System.EventHandler(this.pur_btn_Click);
            // 
            // sup_btn
            // 
            this.sup_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sup_btn.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.sup_btn.Appearance.Options.UseForeColor = true;
            this.sup_btn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.sup_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sup_btn.ImageOptions.Image = global::SupermarketManagement.Properties.Resources.supplier;
            this.sup_btn.Location = new System.Drawing.Point(3, 155);
            this.sup_btn.Name = "sup_btn";
            this.sup_btn.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.sup_btn.Size = new System.Drawing.Size(234, 32);
            this.sup_btn.TabIndex = 2;
            this.sup_btn.Text = "Suppliers";
            this.sup_btn.Click += new System.EventHandler(this.sup_btn_Click);
            // 
            // sales_btn
            // 
            this.sales_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sales_btn.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.sales_btn.Appearance.Options.UseForeColor = true;
            this.sales_btn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.sales_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sales_btn.ImageOptions.Image = global::SupermarketManagement.Properties.Resources.sales;
            this.sales_btn.Location = new System.Drawing.Point(3, 193);
            this.sales_btn.Name = "sales_btn";
            this.sales_btn.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.sales_btn.Size = new System.Drawing.Size(234, 32);
            this.sales_btn.TabIndex = 5;
            this.sales_btn.Text = "Sales";
            this.sales_btn.Click += new System.EventHandler(this.sales_btn_Click);
            // 
            // report_btn
            // 
            this.report_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.report_btn.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.report_btn.Appearance.Options.UseForeColor = true;
            this.report_btn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.report_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.report_btn.ImageOptions.Image = global::SupermarketManagement.Properties.Resources.report;
            this.report_btn.Location = new System.Drawing.Point(3, 231);
            this.report_btn.Name = "report_btn";
            this.report_btn.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.report_btn.Size = new System.Drawing.Size(234, 32);
            this.report_btn.TabIndex = 6;
            this.report_btn.Text = "Reports";
            this.report_btn.Click += new System.EventHandler(this.report_btn_Click);
            // 
            // user_btn
            // 
            this.user_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.user_btn.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.user_btn.Appearance.Options.UseForeColor = true;
            this.user_btn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.user_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.user_btn.ImageOptions.Image = global::SupermarketManagement.Properties.Resources.users;
            this.user_btn.Location = new System.Drawing.Point(3, 269);
            this.user_btn.Name = "user_btn";
            this.user_btn.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.user_btn.Size = new System.Drawing.Size(234, 32);
            this.user_btn.TabIndex = 7;
            this.user_btn.Text = "Users";
            this.user_btn.Click += new System.EventHandler(this.user_btn_Click);
            // 
            // settings_btn
            // 
            this.settings_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.settings_btn.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.settings_btn.Appearance.Options.UseForeColor = true;
            this.settings_btn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.settings_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settings_btn.ImageOptions.Image = global::SupermarketManagement.Properties.Resources.settings;
            this.settings_btn.Location = new System.Drawing.Point(3, 307);
            this.settings_btn.Name = "settings_btn";
            this.settings_btn.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.settings_btn.Size = new System.Drawing.Size(234, 32);
            this.settings_btn.TabIndex = 8;
            this.settings_btn.Text = "Settings";
            this.settings_btn.Click += new System.EventHandler(this.settings_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(3, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 140);
            this.label1.TabIndex = 9;
            this.label1.Text = "Quick Access :\r\n   Add Cat: A         \r\n   Add Supp: S\r\n   Purchease: P    \r\n   A" +
    "dd Cust: C\r\n   Sale: D            \r\n   Update: R";
            // 
            // info_pan
            // 
            this.info_pan.Controls.Add(this.titlenavbar_pan);
            this.info_pan.Controls.Add(this.flowLayoutPanel1);
            this.info_pan.Dock = System.Windows.Forms.DockStyle.Top;
            this.info_pan.Location = new System.Drawing.Point(0, 0);
            this.info_pan.Margin = new System.Windows.Forms.Padding(4);
            this.info_pan.Name = "info_pan";
            this.info_pan.Size = new System.Drawing.Size(237, 177);
            this.info_pan.TabIndex = 0;
            // 
            // titlenavbar_pan
            // 
            this.titlenavbar_pan.Controls.Add(this.user_img);
            this.titlenavbar_pan.Controls.Add(this.name_lbl);
            this.titlenavbar_pan.Controls.Add(this.role_lbl);
            this.titlenavbar_pan.Dock = System.Windows.Forms.DockStyle.Left;
            this.titlenavbar_pan.Location = new System.Drawing.Point(63, 0);
            this.titlenavbar_pan.Margin = new System.Windows.Forms.Padding(4);
            this.titlenavbar_pan.Name = "titlenavbar_pan";
            this.titlenavbar_pan.Size = new System.Drawing.Size(157, 177);
            this.titlenavbar_pan.TabIndex = 0;
            // 
            // user_img
            // 
            this.user_img.Image = ((System.Drawing.Image)(resources.GetObject("user_img.Image")));
            this.user_img.Location = new System.Drawing.Point(16, 4);
            this.user_img.Margin = new System.Windows.Forms.Padding(4);
            this.user_img.Name = "user_img";
            this.user_img.Size = new System.Drawing.Size(121, 98);
            this.user_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.user_img.TabIndex = 0;
            this.user_img.TabStop = false;
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.name_lbl.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_lbl.ForeColor = System.Drawing.Color.White;
            this.name_lbl.Location = new System.Drawing.Point(-4, 112);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(137, 19);
            this.name_lbl.TabIndex = 13;
            this.name_lbl.Text = "Mahmoud Sami";
            // 
            // role_lbl
            // 
            this.role_lbl.AutoSize = true;
            this.role_lbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.role_lbl.Font = new System.Drawing.Font("Imprint MT Shadow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.role_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.role_lbl.Location = new System.Drawing.Point(-4, 137);
            this.role_lbl.Name = "role_lbl";
            this.role_lbl.Size = new System.Drawing.Size(55, 16);
            this.role_lbl.TabIndex = 13;
            this.role_lbl.Text = "Admin";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.menu_btn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(63, 177);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // menu_btn
            // 
            this.menu_btn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.menu_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menu_btn.ImageOptions.Image = global::SupermarketManagement.Properties.Resources.menu;
            this.menu_btn.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.menu_btn.Location = new System.Drawing.Point(3, 3);
            this.menu_btn.Name = "menu_btn";
            this.menu_btn.Size = new System.Drawing.Size(60, 51);
            this.menu_btn.TabIndex = 0;
            this.menu_btn.Click += new System.EventHandler(this.menu_btn_Click);
            // 
            // container_pan
            // 
            this.container_pan.BackColor = System.Drawing.Color.White;
            this.container_pan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container_pan.Location = new System.Drawing.Point(237, 54);
            this.container_pan.Name = "container_pan";
            this.container_pan.Size = new System.Drawing.Size(1153, 629);
            this.container_pan.TabIndex = 7;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.topnavbar_pan;
            this.bunifuDragControl1.Vertical = true;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1390, 683);
            this.Controls.Add(this.container_pan);
            this.Controls.Add(this.topnavbar_pan);
            this.Controls.Add(this.leftnavbar_pan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainScreen";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMP";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainScreen_KeyDown);
            this.topnavbar_pan.ResumeLayout(false);
            this.topnavbar_pan.PerformLayout();
            this.leftnavbar_pan.ResumeLayout(false);
            this.flow_pan.ResumeLayout(false);
            this.flow_pan.PerformLayout();
            this.info_pan.ResumeLayout(false);
            this.titlenavbar_pan.ResumeLayout(false);
            this.titlenavbar_pan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_img)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topnavbar_pan;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Button min_btn;
        private System.Windows.Forms.Button max_btn;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.Panel leftnavbar_pan;
        private System.Windows.Forms.Panel info_pan;
        private System.Windows.Forms.Panel titlenavbar_pan;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel container_pan;
        private DevExpress.XtraEditors.SimpleButton menu_btn;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        public System.Windows.Forms.PictureBox user_img;
        public System.Windows.Forms.Label name_lbl;
        public System.Windows.Forms.Label role_lbl;
        public DevExpress.XtraEditors.SimpleButton main_btn;
        public DevExpress.XtraEditors.SimpleButton cat_btn;
        public DevExpress.XtraEditors.SimpleButton sup_btn;
        public DevExpress.XtraEditors.SimpleButton pur_btn;
        public DevExpress.XtraEditors.SimpleButton cust_btn;
        public DevExpress.XtraEditors.SimpleButton sales_btn;
        public DevExpress.XtraEditors.SimpleButton report_btn;
        public DevExpress.XtraEditors.SimpleButton user_btn;
        public DevExpress.XtraEditors.SimpleButton settings_btn;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.FlowLayoutPanel flow_pan;
    }
}

