namespace SupermarketManagement.PL
{
    partial class Category_Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Category_Add));
            this.title_lbl = new System.Windows.Forms.Label();
            this.item_name_txt = new System.Windows.Forms.TextBox();
            this.pic_cover = new DevExpress.XtraEditors.PictureEdit();
            this.close_btn = new System.Windows.Forms.Button();
            this.add_btn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cover.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // title_lbl
            // 
            this.title_lbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.title_lbl.AutoSize = true;
            this.title_lbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.title_lbl.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lbl.ForeColor = System.Drawing.Color.DimGray;
            this.title_lbl.Location = new System.Drawing.Point(176, 67);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(242, 41);
            this.title_lbl.TabIndex = 16;
            this.title_lbl.Text = "Category Name";
            // 
            // item_name_txt
            // 
            this.item_name_txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.item_name_txt.BackColor = System.Drawing.Color.White;
            this.item_name_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_name_txt.ForeColor = System.Drawing.Color.Black;
            this.item_name_txt.Location = new System.Drawing.Point(138, 125);
            this.item_name_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.item_name_txt.Name = "item_name_txt";
            this.item_name_txt.Size = new System.Drawing.Size(319, 38);
            this.item_name_txt.TabIndex = 17;
            this.item_name_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.item_name_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.item_name_txt_KeyPress);
            // 
            // pic_cover
            // 
            this.pic_cover.Cursor = System.Windows.Forms.Cursors.Default;
            this.pic_cover.EditValue = global::SupermarketManagement.Properties.Resources.Items;
            this.pic_cover.Location = new System.Drawing.Point(138, 189);
            this.pic_cover.Name = "pic_cover";
            this.pic_cover.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.pic_cover.Properties.Appearance.Options.UseBackColor = true;
            this.pic_cover.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pic_cover.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pic_cover.Size = new System.Drawing.Size(319, 260);
            this.pic_cover.TabIndex = 18;
            this.pic_cover.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pic_cover_KeyPress);
            // 
            // close_btn
            // 
            this.close_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_btn.ForeColor = System.Drawing.Color.White;
            this.close_btn.Image = ((System.Drawing.Image)(resources.GetObject("close_btn.Image")));
            this.close_btn.Location = new System.Drawing.Point(552, 0);
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
            this.add_btn.Location = new System.Drawing.Point(464, 468);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(126, 51);
            this.add_btn.TabIndex = 19;
            this.add_btn.Text = "Add";
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            this.add_btn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.add_btn_KeyPress);
            // 
            // Category_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(611, 544);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.pic_cover);
            this.Controls.Add(this.item_name_txt);
            this.Controls.Add(this.title_lbl);
            this.Controls.Add(this.close_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Category_Add";
            this.Opacity = 0.98D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Category_Add_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_cover.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.Label title_lbl;
        public DevExpress.XtraEditors.SimpleButton add_btn;
        public System.Windows.Forms.TextBox item_name_txt;
        public DevExpress.XtraEditors.PictureEdit pic_cover;
    }
}