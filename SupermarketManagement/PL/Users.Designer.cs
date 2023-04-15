namespace SupermarketManagement.PL
{
    partial class Users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            this.container_pan = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUser_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUser_Pass = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUser_Role = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUser_State = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.item_search_txt = new System.Windows.Forms.TextBox();
            this.update_btn = new DevExpress.XtraEditors.SimpleButton();
            this.delete_btn = new DevExpress.XtraEditors.SimpleButton();
            this.edit_btn = new DevExpress.XtraEditors.SimpleButton();
            this.add_btn = new DevExpress.XtraEditors.SimpleButton();
            this.container_pan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // container_pan
            // 
            this.container_pan.Controls.Add(this.gridControl1);
            this.container_pan.Controls.Add(this.panel2);
            this.container_pan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container_pan.Location = new System.Drawing.Point(0, 0);
            this.container_pan.Name = "container_pan";
            this.container_pan.Size = new System.Drawing.Size(1153, 629);
            this.container_pan.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(SupermarketManagement.USER_TB);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1153, 572);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.GroupRow.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.GroupRow.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUser_Name,
            this.colUser_Pass,
            this.colUser_Role,
            this.colUser_State});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colUser_State, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colUser_Name
            // 
            this.colUser_Name.Caption = "UserName";
            this.colUser_Name.FieldName = "User_Name";
            this.colUser_Name.Name = "colUser_Name";
            this.colUser_Name.Visible = true;
            this.colUser_Name.VisibleIndex = 0;
            // 
            // colUser_Pass
            // 
            this.colUser_Pass.Caption = "Password";
            this.colUser_Pass.FieldName = "User_Pass";
            this.colUser_Pass.Name = "colUser_Pass";
            this.colUser_Pass.Visible = true;
            this.colUser_Pass.VisibleIndex = 1;
            // 
            // colUser_Role
            // 
            this.colUser_Role.Caption = "Role";
            this.colUser_Role.FieldName = "User_Role";
            this.colUser_Role.Name = "colUser_Role";
            this.colUser_Role.Visible = true;
            this.colUser_Role.VisibleIndex = 2;
            // 
            // colUser_State
            // 
            this.colUser_State.Caption = "State";
            this.colUser_State.FieldName = "User_State";
            this.colUser_State.Name = "colUser_State";
            this.colUser_State.Visible = true;
            this.colUser_State.VisibleIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.simpleButton1);
            this.panel2.Controls.Add(this.item_search_txt);
            this.panel2.Controls.Add(this.update_btn);
            this.panel2.Controls.Add(this.delete_btn);
            this.panel2.Controls.Add(this.edit_btn);
            this.panel2.Controls.Add(this.add_btn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 572);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1153, 57);
            this.panel2.TabIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Papyrus", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.simpleButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.simpleButton1.ImageOptions.Image = global::SupermarketManagement.Properties.Resources.loupe;
            this.simpleButton1.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.simpleButton1.Location = new System.Drawing.Point(1111, 11);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(42, 38);
            this.simpleButton1.TabIndex = 19;
            // 
            // item_search_txt
            // 
            this.item_search_txt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.item_search_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_search_txt.ForeColor = System.Drawing.Color.Black;
            this.item_search_txt.Location = new System.Drawing.Point(772, 11);
            this.item_search_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.item_search_txt.Name = "item_search_txt";
            this.item_search_txt.Size = new System.Drawing.Size(333, 38);
            this.item_search_txt.TabIndex = 18;
            this.item_search_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.item_search_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.item_search_txt_KeyPress);
            // 
            // update_btn
            // 
            this.update_btn.Appearance.Font = new System.Drawing.Font("Papyrus", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.Appearance.Options.UseFont = true;
            this.update_btn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.update_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update_btn.ImageOptions.Image = global::SupermarketManagement.Properties.Resources.refresh;
            this.update_btn.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.update_btn.Location = new System.Drawing.Point(585, 3);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(181, 51);
            this.update_btn.TabIndex = 4;
            this.update_btn.Text = "Update";
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Appearance.Font = new System.Drawing.Font("Papyrus", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.Appearance.Options.UseFont = true;
            this.delete_btn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.delete_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_btn.ImageOptions.Image = global::SupermarketManagement.Properties.Resources.delete;
            this.delete_btn.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.delete_btn.Location = new System.Drawing.Point(392, 3);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(181, 51);
            this.delete_btn.TabIndex = 3;
            this.delete_btn.Text = "Delete";
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.Appearance.Font = new System.Drawing.Font("Papyrus", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_btn.Appearance.Options.UseFont = true;
            this.edit_btn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.edit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edit_btn.ImageOptions.Image = global::SupermarketManagement.Properties.Resources.edit;
            this.edit_btn.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.edit_btn.Location = new System.Drawing.Point(199, 3);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(181, 51);
            this.edit_btn.TabIndex = 2;
            this.edit_btn.Text = "Edit";
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.Appearance.Font = new System.Drawing.Font("Papyrus", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.Appearance.Options.UseFont = true;
            this.add_btn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.add_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_btn.ImageOptions.Image = global::SupermarketManagement.Properties.Resources.plus;
            this.add_btn.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.add_btn.Location = new System.Drawing.Point(6, 3);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(181, 51);
            this.add_btn.TabIndex = 1;
            this.add_btn.Text = "Add";
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 629);
            this.Controls.Add(this.container_pan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Users";
            this.ShowInTaskbar = false;
            this.container_pan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton update_btn;
        private DevExpress.XtraEditors.SimpleButton delete_btn;
        private DevExpress.XtraEditors.SimpleButton edit_btn;
        private DevExpress.XtraEditors.SimpleButton add_btn;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.TextBox item_search_txt;
        public System.Windows.Forms.Panel container_pan;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colUser_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colUser_Pass;
        private DevExpress.XtraGrid.Columns.GridColumn colUser_Role;
        private DevExpress.XtraGrid.Columns.GridColumn colUser_State;
        public DevExpress.XtraGrid.GridControl gridControl1;
    }
}