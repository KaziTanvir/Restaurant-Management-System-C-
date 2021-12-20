namespace RMS_2._0
{
    partial class UpdateMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateMenu));
            this.label2 = new System.Windows.Forms.Label();
            this.cbCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnUpdateItem = new Guna.UI2.WinForms.Guna2Button();
            this.btnShowMenu = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearch = new Guna.UI2.WinForms.Guna2CircleButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUpdatedPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(746, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 32;
            // 
            // cbCategory
            // 
            this.cbCategory.Animated = true;
            this.cbCategory.AutoRoundedCorners = true;
            this.cbCategory.BackColor = System.Drawing.Color.Transparent;
            this.cbCategory.BorderRadius = 17;
            this.cbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCategory.FocusedState.Parent = this.cbCategory;
            this.cbCategory.Font = new System.Drawing.Font("Poppins", 11.25F);
            this.cbCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbCategory.HoverState.Parent = this.cbCategory;
            this.cbCategory.ItemHeight = 30;
            this.cbCategory.Items.AddRange(new object[] {
            "Thai",
            "Chinese",
            "Indian",
            "Bangla",
            "Soft Drink",
            "Juice",
            "Desserts"});
            this.cbCategory.ItemsAppearance.Parent = this.cbCategory;
            this.cbCategory.Location = new System.Drawing.Point(106, 179);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.ShadowDecoration.Parent = this.cbCategory;
            this.cbCategory.Size = new System.Drawing.Size(278, 36);
            this.cbCategory.TabIndex = 31;
            // 
            // btnUpdateItem
            // 
            this.btnUpdateItem.Animated = true;
            this.btnUpdateItem.AutoRoundedCorners = true;
            this.btnUpdateItem.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateItem.BorderColor = System.Drawing.Color.OrangeRed;
            this.btnUpdateItem.BorderRadius = 21;
            this.btnUpdateItem.BorderThickness = 2;
            this.btnUpdateItem.CheckedState.Parent = this.btnUpdateItem;
            this.btnUpdateItem.CustomImages.Parent = this.btnUpdateItem;
            this.btnUpdateItem.FillColor = System.Drawing.Color.PapayaWhip;
            this.btnUpdateItem.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F);
            this.btnUpdateItem.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnUpdateItem.HoverState.Parent = this.btnUpdateItem;
            this.btnUpdateItem.Location = new System.Drawing.Point(342, 557);
            this.btnUpdateItem.Name = "btnUpdateItem";
            this.btnUpdateItem.ShadowDecoration.Parent = this.btnUpdateItem;
            this.btnUpdateItem.Size = new System.Drawing.Size(180, 45);
            this.btnUpdateItem.TabIndex = 30;
            this.btnUpdateItem.Text = "Update Item";
            this.btnUpdateItem.UseTransparentBackground = true;
            this.btnUpdateItem.Click += new System.EventHandler(this.btnUpdateItem_Click);
            // 
            // btnShowMenu
            // 
            this.btnShowMenu.Animated = true;
            this.btnShowMenu.AutoRoundedCorners = true;
            this.btnShowMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnShowMenu.BorderColor = System.Drawing.Color.OrangeRed;
            this.btnShowMenu.BorderRadius = 21;
            this.btnShowMenu.BorderThickness = 2;
            this.btnShowMenu.CheckedState.Parent = this.btnShowMenu;
            this.btnShowMenu.CustomImages.Parent = this.btnShowMenu;
            this.btnShowMenu.FillColor = System.Drawing.Color.PapayaWhip;
            this.btnShowMenu.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F);
            this.btnShowMenu.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnShowMenu.HoverState.Parent = this.btnShowMenu;
            this.btnShowMenu.Location = new System.Drawing.Point(106, 557);
            this.btnShowMenu.Name = "btnShowMenu";
            this.btnShowMenu.ShadowDecoration.Parent = this.btnShowMenu;
            this.btnShowMenu.Size = new System.Drawing.Size(180, 45);
            this.btnShowMenu.TabIndex = 29;
            this.btnShowMenu.Text = "Show ";
            this.btnShowMenu.UseTransparentBackground = true;
            this.btnShowMenu.Click += new System.EventHandler(this.btnShowMenu_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Animated = true;
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BorderColor = System.Drawing.Color.OrangeRed;
            this.btnSearch.BorderThickness = 1;
            this.btnSearch.CheckedState.Parent = this.btnSearch;
            this.btnSearch.CustomImages.Parent = this.btnSearch;
            this.btnSearch.FillColor = System.Drawing.Color.PapayaWhip;
            this.btnSearch.Font = new System.Drawing.Font("Poppins", 14.25F);
            this.btnSearch.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnSearch.HoverState.Parent = this.btnSearch;
            this.btnSearch.Location = new System.Drawing.Point(416, 179);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnSearch.ShadowDecoration.Parent = this.btnSearch;
            this.btnSearch.Size = new System.Drawing.Size(42, 41);
            this.btnSearch.TabIndex = 28;
            this.btnSearch.Text = "GO";
            this.btnSearch.UseTransparentBackground = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(106, 248);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(425, 287);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(12, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(89, 63);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 26;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(309, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 62);
            this.label1.TabIndex = 25;
            this.label1.Text = "Update Items";
            // 
            // txtUpdatedPrice
            // 
            this.txtUpdatedPrice.Animated = true;
            this.txtUpdatedPrice.AutoRoundedCorners = true;
            this.txtUpdatedPrice.BackColor = System.Drawing.Color.Transparent;
            this.txtUpdatedPrice.BorderColor = System.Drawing.Color.OrangeRed;
            this.txtUpdatedPrice.BorderRadius = 18;
            this.txtUpdatedPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUpdatedPrice.DefaultText = "";
            this.txtUpdatedPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUpdatedPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUpdatedPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUpdatedPrice.DisabledState.Parent = this.txtUpdatedPrice;
            this.txtUpdatedPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUpdatedPrice.FillColor = System.Drawing.SystemColors.Control;
            this.txtUpdatedPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUpdatedPrice.FocusedState.Parent = this.txtUpdatedPrice;
            this.txtUpdatedPrice.Font = new System.Drawing.Font("Poppins", 14.25F);
            this.txtUpdatedPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUpdatedPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUpdatedPrice.HoverState.Parent = this.txtUpdatedPrice;
            this.txtUpdatedPrice.Location = new System.Drawing.Point(625, 292);
            this.txtUpdatedPrice.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtUpdatedPrice.Name = "txtUpdatedPrice";
            this.txtUpdatedPrice.PasswordChar = '\0';
            this.txtUpdatedPrice.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUpdatedPrice.PlaceholderText = "Enter Updated Price";
            this.txtUpdatedPrice.SelectedText = "";
            this.txtUpdatedPrice.ShadowDecoration.Parent = this.txtUpdatedPrice;
            this.txtUpdatedPrice.Size = new System.Drawing.Size(300, 39);
            this.txtUpdatedPrice.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Calligraphy", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(619, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 36);
            this.label3.TabIndex = 34;
            this.label3.Text = "Updated Price";
            // 
            // UpdateMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUpdatedPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.btnUpdateItem);
            this.Controls.Add(this.btnShowMenu);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Menu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cbCategory;
        private Guna.UI2.WinForms.Guna2Button btnUpdateItem;
        private Guna.UI2.WinForms.Guna2Button btnShowMenu;
        private Guna.UI2.WinForms.Guna2CircleButton btnSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtUpdatedPrice;
        private System.Windows.Forms.Label label3;
    }
}