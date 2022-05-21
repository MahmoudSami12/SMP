namespace SupermarketManagement.PL
{
    partial class Customers_Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customers_Add));
            this.supp_name_lbl = new System.Windows.Forms.Label();
            this.cust_name_txt = new System.Windows.Forms.TextBox();
            this.pic_cover = new DevExpress.XtraEditors.PictureEdit();
            this.close_btn = new System.Windows.Forms.Button();
            this.add_btn = new DevExpress.XtraEditors.SimpleButton();
            this.cust_phone_txt = new System.Windows.Forms.TextBox();
            this.phone_lbl = new System.Windows.Forms.Label();
            this.cust_email_txt = new System.Windows.Forms.TextBox();
            this.email_lbl = new System.Windows.Forms.Label();
            this.image_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cover.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // supp_name_lbl
            // 
            this.supp_name_lbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.supp_name_lbl.AutoSize = true;
            this.supp_name_lbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.supp_name_lbl.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supp_name_lbl.ForeColor = System.Drawing.Color.Gray;
            this.supp_name_lbl.Location = new System.Drawing.Point(19, 71);
            this.supp_name_lbl.Name = "supp_name_lbl";
            this.supp_name_lbl.Size = new System.Drawing.Size(246, 41);
            this.supp_name_lbl.TabIndex = 16;
            this.supp_name_lbl.Text = "Customer Name";
            // 
            // cust_name_txt
            // 
            this.cust_name_txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cust_name_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_name_txt.ForeColor = System.Drawing.Color.Black;
            this.cust_name_txt.Location = new System.Drawing.Point(314, 74);
            this.cust_name_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cust_name_txt.Name = "cust_name_txt";
            this.cust_name_txt.Size = new System.Drawing.Size(319, 38);
            this.cust_name_txt.TabIndex = 17;
            this.cust_name_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cust_name_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cust_name_txt_KeyPress);
            // 
            // pic_cover
            // 
            this.pic_cover.Cursor = System.Windows.Forms.Cursors.Default;
            this.pic_cover.EditValue = global::SupermarketManagement.Properties.Resources.man;
            this.pic_cover.Location = new System.Drawing.Point(382, 308);
            this.pic_cover.Name = "pic_cover";
            this.pic_cover.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pic_cover.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pic_cover.Size = new System.Drawing.Size(251, 235);
            this.pic_cover.TabIndex = 18;
            this.pic_cover.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pic_cover_KeyPress);
            // 
            // close_btn
            // 
            this.close_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_btn.ForeColor = System.Drawing.Color.White;
            this.close_btn.Image = ((System.Drawing.Image)(resources.GetObject("close_btn.Image")));
            this.close_btn.Location = new System.Drawing.Point(607, 1);
            this.close_btn.Margin = new System.Windows.Forms.Padding(4);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(59, 54);
            this.close_btn.TabIndex = 15;
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.Appearance.Font = new System.Drawing.Font("Papyrus", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.Appearance.Options.UseFont = true;
            this.add_btn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.add_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_btn.ImageOptions.Image = global::SupermarketManagement.Properties.Resources.plus;
            this.add_btn.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.add_btn.Location = new System.Drawing.Point(26, 499);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(126, 51);
            this.add_btn.TabIndex = 19;
            this.add_btn.Text = "Add";
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            this.add_btn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.add_btn_KeyPress);
            // 
            // cust_phone_txt
            // 
            this.cust_phone_txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cust_phone_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_phone_txt.ForeColor = System.Drawing.Color.Black;
            this.cust_phone_txt.Location = new System.Drawing.Point(314, 141);
            this.cust_phone_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cust_phone_txt.Name = "cust_phone_txt";
            this.cust_phone_txt.Size = new System.Drawing.Size(319, 38);
            this.cust_phone_txt.TabIndex = 21;
            this.cust_phone_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cust_phone_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cust_phone_txt_KeyPress);
            // 
            // phone_lbl
            // 
            this.phone_lbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.phone_lbl.AutoSize = true;
            this.phone_lbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.phone_lbl.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_lbl.ForeColor = System.Drawing.Color.Gray;
            this.phone_lbl.Location = new System.Drawing.Point(19, 138);
            this.phone_lbl.Name = "phone_lbl";
            this.phone_lbl.Size = new System.Drawing.Size(225, 41);
            this.phone_lbl.TabIndex = 20;
            this.phone_lbl.Text = "Phone Number";
            // 
            // cust_email_txt
            // 
            this.cust_email_txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cust_email_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_email_txt.ForeColor = System.Drawing.Color.Black;
            this.cust_email_txt.Location = new System.Drawing.Point(314, 208);
            this.cust_email_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cust_email_txt.Name = "cust_email_txt";
            this.cust_email_txt.Size = new System.Drawing.Size(319, 38);
            this.cust_email_txt.TabIndex = 23;
            this.cust_email_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cust_email_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cust_email_txt_KeyPress);
            // 
            // email_lbl
            // 
            this.email_lbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.email_lbl.AutoSize = true;
            this.email_lbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.email_lbl.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_lbl.ForeColor = System.Drawing.Color.Gray;
            this.email_lbl.Location = new System.Drawing.Point(19, 202);
            this.email_lbl.Name = "email_lbl";
            this.email_lbl.Size = new System.Drawing.Size(124, 41);
            this.email_lbl.TabIndex = 22;
            this.email_lbl.Text = "E-mail ";
            // 
            // image_lbl
            // 
            this.image_lbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.image_lbl.AutoSize = true;
            this.image_lbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.image_lbl.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.image_lbl.ForeColor = System.Drawing.Color.Gray;
            this.image_lbl.Location = new System.Drawing.Point(464, 264);
            this.image_lbl.Name = "image_lbl";
            this.image_lbl.Size = new System.Drawing.Size(107, 41);
            this.image_lbl.TabIndex = 24;
            this.image_lbl.Text = "Image";
            // 
            // Customers_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(666, 576);
            this.Controls.Add(this.image_lbl);
            this.Controls.Add(this.cust_email_txt);
            this.Controls.Add(this.email_lbl);
            this.Controls.Add(this.cust_phone_txt);
            this.Controls.Add(this.phone_lbl);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.pic_cover);
            this.Controls.Add(this.cust_name_txt);
            this.Controls.Add(this.supp_name_lbl);
            this.Controls.Add(this.close_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Customers_Add";
            this.Opacity = 0.98D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pic_cover.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.Label supp_name_lbl;
        public DevExpress.XtraEditors.SimpleButton add_btn;
        public System.Windows.Forms.TextBox cust_name_txt;
        public DevExpress.XtraEditors.PictureEdit pic_cover;
        public System.Windows.Forms.TextBox cust_phone_txt;
        private System.Windows.Forms.Label phone_lbl;
        public System.Windows.Forms.TextBox cust_email_txt;
        private System.Windows.Forms.Label email_lbl;
        private System.Windows.Forms.Label image_lbl;
    }
}