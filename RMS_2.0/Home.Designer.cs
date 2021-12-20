namespace RMS_2._0
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.btnOwner = new Guna.UI2.WinForms.Guna2Button();
            this.btnStaff = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Animated = true;
            this.btnCustomer.AutoRoundedCorners = true;
            this.btnCustomer.BackColor = System.Drawing.Color.Transparent;
            this.btnCustomer.BorderRadius = 21;
            this.btnCustomer.BorderThickness = 2;
            this.btnCustomer.CheckedState.Parent = this.btnCustomer;
            this.btnCustomer.CustomImages.Parent = this.btnCustomer;
            this.btnCustomer.FillColor = System.Drawing.Color.LightBlue;
            this.btnCustomer.Font = new System.Drawing.Font("Lucida Handwriting", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnCustomer.ForeColor = System.Drawing.Color.Black;
            this.btnCustomer.HoverState.Parent = this.btnCustomer;
            this.btnCustomer.Location = new System.Drawing.Point(110, 478);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.ShadowDecoration.Parent = this.btnCustomer;
            this.btnCustomer.Size = new System.Drawing.Size(180, 45);
            this.btnCustomer.TabIndex = 1;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.UseTransparentBackground = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnOwner
            // 
            this.btnOwner.Animated = true;
            this.btnOwner.AutoRoundedCorners = true;
            this.btnOwner.BackColor = System.Drawing.Color.Transparent;
            this.btnOwner.BorderRadius = 21;
            this.btnOwner.BorderThickness = 2;
            this.btnOwner.CheckedState.Parent = this.btnOwner;
            this.btnOwner.CustomImages.Parent = this.btnOwner;
            this.btnOwner.FillColor = System.Drawing.Color.LightBlue;
            this.btnOwner.Font = new System.Drawing.Font("Lucida Handwriting", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnOwner.ForeColor = System.Drawing.Color.Black;
            this.btnOwner.HoverState.Parent = this.btnOwner;
            this.btnOwner.Location = new System.Drawing.Point(110, 612);
            this.btnOwner.Name = "btnOwner";
            this.btnOwner.ShadowDecoration.Parent = this.btnOwner;
            this.btnOwner.Size = new System.Drawing.Size(180, 45);
            this.btnOwner.TabIndex = 2;
            this.btnOwner.Text = "Owner";
            this.btnOwner.UseTransparentBackground = true;
            this.btnOwner.Click += new System.EventHandler(this.btnOwner_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.Animated = true;
            this.btnStaff.AutoRoundedCorners = true;
            this.btnStaff.BackColor = System.Drawing.Color.Transparent;
            this.btnStaff.BorderRadius = 21;
            this.btnStaff.BorderThickness = 2;
            this.btnStaff.CheckedState.Parent = this.btnStaff;
            this.btnStaff.CustomImages.Parent = this.btnStaff;
            this.btnStaff.FillColor = System.Drawing.Color.LightBlue;
            this.btnStaff.Font = new System.Drawing.Font("Lucida Handwriting", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnStaff.ForeColor = System.Drawing.Color.Black;
            this.btnStaff.HoverState.Parent = this.btnStaff;
            this.btnStaff.Location = new System.Drawing.Point(110, 546);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.ShadowDecoration.Parent = this.btnStaff;
            this.btnStaff.Size = new System.Drawing.Size(180, 45);
            this.btnStaff.TabIndex = 3;
            this.btnStaff.Text = "Staff";
            this.btnStaff.UseTransparentBackground = true;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.btnStaff);
            this.Controls.Add(this.btnOwner);
            this.Controls.Add(this.btnCustomer);
            this.Controls.Add(this.guna2PictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home - Restaurant";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnCustomer;
        private Guna.UI2.WinForms.Guna2Button btnOwner;
        private Guna.UI2.WinForms.Guna2Button btnStaff;
    }
}