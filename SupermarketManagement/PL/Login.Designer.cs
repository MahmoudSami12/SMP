namespace SupermarketManagement.PL
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.container_pan = new Bunifu.UI.WinForms.BunifuPanel();
            this.login_btn = new DevExpress.XtraEditors.SimpleButton();
            this.pass_txt = new System.Windows.Forms.TextBox();
            this.username_txt = new System.Windows.Forms.TextBox();
            this.username_lbl = new System.Windows.Forms.Label();
            this.pass_lbl = new System.Windows.Forms.Label();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.close_btn = new System.Windows.Forms.Button();
            this.pic_cover = new DevExpress.XtraEditors.PictureEdit();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.image_lbl = new System.Windows.Forms.Label();
            this.container_pan.SuspendLayout();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cover.Properties)).BeginInit();
            this.bunifuPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // container_pan
            // 
            this.container_pan.BackgroundColor = System.Drawing.SystemColors.Control;
            this.container_pan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("container_pan.BackgroundImage")));
            this.container_pan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.container_pan.BorderColor = System.Drawing.SystemColors.Control;
            this.container_pan.BorderRadius = 3;
            this.container_pan.BorderThickness = 1;
            this.container_pan.Controls.Add(this.login_btn);
            this.container_pan.Controls.Add(this.pass_txt);
            this.container_pan.Controls.Add(this.username_txt);
            this.container_pan.Controls.Add(this.username_lbl);
            this.container_pan.Controls.Add(this.pass_lbl);
            this.container_pan.Controls.Add(this.bunifuPanel1);
            this.container_pan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container_pan.Location = new System.Drawing.Point(0, 0);
            this.container_pan.Name = "container_pan";
            this.container_pan.ShowBorders = true;
            this.container_pan.Size = new System.Drawing.Size(777, 639);
            this.container_pan.TabIndex = 0;
            // 
            // login_btn
            // 
            this.login_btn.Appearance.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.Appearance.Options.UseFont = true;
            this.login_btn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.login_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("login_btn.ImageOptions.Image")));
            this.login_btn.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.login_btn.Location = new System.Drawing.Point(296, 558);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(261, 51);
            this.login_btn.TabIndex = 40;
            this.login_btn.Text = "Login";
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            this.login_btn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.login_btn_KeyPress);
            // 
            // pass_txt
            // 
            this.pass_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_txt.ForeColor = System.Drawing.Color.Black;
            this.pass_txt.Location = new System.Drawing.Point(296, 459);
            this.pass_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pass_txt.Name = "pass_txt";
            this.pass_txt.Size = new System.Drawing.Size(405, 38);
            this.pass_txt.TabIndex = 39;
            this.pass_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pass_txt.UseSystemPasswordChar = true;
            this.pass_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pass_txt_KeyPress);
            // 
            // username_txt
            // 
            this.username_txt.BackColor = System.Drawing.SystemColors.Window;
            this.username_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_txt.ForeColor = System.Drawing.Color.Black;
            this.username_txt.Location = new System.Drawing.Point(296, 388);
            this.username_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.username_txt.Name = "username_txt";
            this.username_txt.Size = new System.Drawing.Size(405, 38);
            this.username_txt.TabIndex = 37;
            this.username_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.username_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.username_txt_KeyPress);
            // 
            // username_lbl
            // 
            this.username_lbl.AutoSize = true;
            this.username_lbl.BackColor = System.Drawing.SystemColors.Control;
            this.username_lbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.username_lbl.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_lbl.ForeColor = System.Drawing.Color.DimGray;
            this.username_lbl.Location = new System.Drawing.Point(75, 385);
            this.username_lbl.Name = "username_lbl";
            this.username_lbl.Size = new System.Drawing.Size(180, 41);
            this.username_lbl.TabIndex = 36;
            this.username_lbl.Text = "User Name";
            // 
            // pass_lbl
            // 
            this.pass_lbl.AutoSize = true;
            this.pass_lbl.BackColor = System.Drawing.SystemColors.Control;
            this.pass_lbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pass_lbl.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_lbl.ForeColor = System.Drawing.Color.DimGray;
            this.pass_lbl.Location = new System.Drawing.Point(75, 456);
            this.pass_lbl.Name = "pass_lbl";
            this.pass_lbl.Size = new System.Drawing.Size(150, 41);
            this.pass_lbl.TabIndex = 38;
            this.pass_lbl.Text = "Password";
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.close_btn);
            this.bunifuPanel1.Controls.Add(this.pic_cover);
            this.bunifuPanel1.Controls.Add(this.bunifuPanel2);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(777, 334);
            this.bunifuPanel1.TabIndex = 0;
            // 
            // close_btn
            // 
            this.close_btn.BackColor = System.Drawing.SystemColors.Control;
            this.close_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_btn.ForeColor = System.Drawing.Color.White;
            this.close_btn.Image = ((System.Drawing.Image)(resources.GetObject("close_btn.Image")));
            this.close_btn.Location = new System.Drawing.Point(718, 0);
            this.close_btn.Margin = new System.Windows.Forms.Padding(4);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(59, 54);
            this.close_btn.TabIndex = 33;
            this.close_btn.UseVisualStyleBackColor = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // pic_cover
            // 
            this.pic_cover.Cursor = System.Windows.Forms.Cursors.Default;
            this.pic_cover.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_cover.EditValue = ((object)(resources.GetObject("pic_cover.EditValue")));
            this.pic_cover.Location = new System.Drawing.Point(480, 0);
            this.pic_cover.Name = "pic_cover";
            this.pic_cover.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.pic_cover.Properties.Appearance.Options.UseBackColor = true;
            this.pic_cover.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pic_cover.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pic_cover.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pic_cover.Size = new System.Drawing.Size(297, 334);
            this.pic_cover.TabIndex = 32;
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.bunifuPanel2.BorderRadius = 3;
            this.bunifuPanel2.BorderThickness = 1;
            this.bunifuPanel2.Controls.Add(this.image_lbl);
            this.bunifuPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuPanel2.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(480, 334);
            this.bunifuPanel2.TabIndex = 31;
            // 
            // image_lbl
            // 
            this.image_lbl.AutoSize = true;
            this.image_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.image_lbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.image_lbl.Font = new System.Drawing.Font("Constantia", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.image_lbl.ForeColor = System.Drawing.Color.Snow;
            this.image_lbl.Location = new System.Drawing.Point(131, 129);
            this.image_lbl.Name = "image_lbl";
            this.image_lbl.Size = new System.Drawing.Size(195, 73);
            this.image_lbl.TabIndex = 24;
            this.image_lbl.Text = "Login";
            this.image_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 639);
            this.Controls.Add(this.container_pan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.container_pan.ResumeLayout(false);
            this.container_pan.PerformLayout();
            this.bunifuPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_cover.Properties)).EndInit();
            this.bunifuPanel2.ResumeLayout(false);
            this.bunifuPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel container_pan;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private System.Windows.Forms.Label image_lbl;
        public DevExpress.XtraEditors.PictureEdit pic_cover;
        public System.Windows.Forms.TextBox pass_txt;
        public System.Windows.Forms.TextBox username_txt;
        private System.Windows.Forms.Label username_lbl;
        private System.Windows.Forms.Label pass_lbl;
        private System.Windows.Forms.Button close_btn;
        public DevExpress.XtraEditors.SimpleButton login_btn;
    }
}