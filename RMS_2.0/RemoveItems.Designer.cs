namespace RMS_2._0
{
    partial class RemoveItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveItems));
            this.btnSearch = new Guna.UI2.WinForms.Guna2CircleButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemoveItem = new Guna.UI2.WinForms.Guna2Button();
            this.btnShowMenu = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.btnSearch.Location = new System.Drawing.Point(608, 141);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnSearch.ShadowDecoration.Parent = this.btnSearch;
            this.btnSearch.Size = new System.Drawing.Size(42, 41);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "GO";
            this.btnSearch.UseTransparentBackground = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(275, 210);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(438, 287);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(8, 8);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(89, 63);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 17;
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
            this.label1.Location = new System.Drawing.Point(291, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 62);
            this.label1.TabIndex = 16;
            this.label1.Text = "Item Removal";
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Animated = true;
            this.btnRemoveItem.AutoRoundedCorners = true;
            this.btnRemoveItem.BackColor = System.Drawing.Color.Transparent;
            this.btnRemoveItem.BorderColor = System.Drawing.Color.OrangeRed;
            this.btnRemoveItem.BorderRadius = 21;
            this.btnRemoveItem.BorderThickness = 2;
            this.btnRemoveItem.CheckedState.Parent = this.btnRemoveItem;
            this.btnRemoveItem.CustomImages.Parent = this.btnRemoveItem;
            this.btnRemoveItem.FillColor = System.Drawing.Color.PapayaWhip;
            this.btnRemoveItem.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F);
            this.btnRemoveItem.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnRemoveItem.HoverState.Parent = this.btnRemoveItem;
            this.btnRemoveItem.Location = new System.Drawing.Point(500, 519);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.ShadowDecoration.Parent = this.btnRemoveItem;
            this.btnRemoveItem.Size = new System.Drawing.Size(180, 45);
            this.btnRemoveItem.TabIndex = 22;
            this.btnRemoveItem.Text = "Remove Item";
            this.btnRemoveItem.UseTransparentBackground = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
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
            this.btnShowMenu.Location = new System.Drawing.Point(298, 519);
            this.btnShowMenu.Name = "btnShowMenu";
            this.btnShowMenu.ShadowDecoration.Parent = this.btnShowMenu;
            this.btnShowMenu.Size = new System.Drawing.Size(180, 45);
            this.btnShowMenu.TabIndex = 21;
            this.btnShowMenu.Text = "Show ";
            this.btnShowMenu.UseTransparentBackground = true;
            this.btnShowMenu.Click += new System.EventHandler(this.btnShowMenu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(742, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 24;
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
            this.cbCategory.Location = new System.Drawing.Point(298, 141);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.ShadowDecoration.Parent = this.cbCategory;
            this.cbCategory.Size = new System.Drawing.Size(278, 36);
            this.cbCategory.TabIndex = 23;
            // 
            // RemoveItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.btnShowMenu);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RemoveItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remove Items from Menu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleButton btnSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnRemoveItem;
        private Guna.UI2.WinForms.Guna2Button btnShowMenu;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cbCategory;
    }
}