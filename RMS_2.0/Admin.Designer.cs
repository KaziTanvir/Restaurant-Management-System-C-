namespace RMS_2._0
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.label1 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnMenu = new Guna.UI2.WinForms.Guna2Button();
            this.btnEmployee = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Bisque;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(259, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(464, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome, Admin";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(12, 9);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(66, 62);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 1;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Animated = true;
            this.btnMenu.AutoRoundedCorners = true;
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.BorderColor = System.Drawing.Color.DarkRed;
            this.btnMenu.BorderRadius = 21;
            this.btnMenu.BorderThickness = 2;
            this.btnMenu.CheckedState.Parent = this.btnMenu;
            this.btnMenu.CustomImages.Parent = this.btnMenu;
            this.btnMenu.FillColor = System.Drawing.SystemColors.Control;
            this.btnMenu.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F);
            this.btnMenu.ForeColor = System.Drawing.Color.DarkRed;
            this.btnMenu.HoverState.Parent = this.btnMenu;
            this.btnMenu.Location = new System.Drawing.Point(742, 453);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.ShadowDecoration.Parent = this.btnMenu;
            this.btnMenu.Size = new System.Drawing.Size(180, 45);
            this.btnMenu.TabIndex = 2;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseTransparentBackground = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.Animated = true;
            this.btnEmployee.AutoRoundedCorners = true;
            this.btnEmployee.BackColor = System.Drawing.Color.Transparent;
            this.btnEmployee.BorderColor = System.Drawing.Color.DarkRed;
            this.btnEmployee.BorderRadius = 21;
            this.btnEmployee.BorderThickness = 2;
            this.btnEmployee.CheckedState.Parent = this.btnEmployee;
            this.btnEmployee.CustomImages.Parent = this.btnEmployee;
            this.btnEmployee.FillColor = System.Drawing.SystemColors.Control;
            this.btnEmployee.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F);
            this.btnEmployee.ForeColor = System.Drawing.Color.DarkRed;
            this.btnEmployee.HoverState.Parent = this.btnEmployee;
            this.btnEmployee.Location = new System.Drawing.Point(742, 533);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.ShadowDecoration.Parent = this.btnEmployee;
            this.btnEmployee.Size = new System.Drawing.Size(180, 45);
            this.btnEmployee.TabIndex = 3;
            this.btnEmployee.Text = "Employee";
            this.btnEmployee.UseTransparentBackground = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.btnEmployee);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin - Restaurant";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnMenu;
        private Guna.UI2.WinForms.Guna2Button btnEmployee;
    }
}