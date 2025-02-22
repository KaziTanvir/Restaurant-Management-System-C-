﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMS_2._0
{
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            this.Hide();
            h.Show();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            Employee_Info info = new Employee_Info("Staff");
            this.Hide();
            info.Show();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            PlaceOrder po = new PlaceOrder("Staff");
            this.Hide();
            po.Show();
        }
    }
}
