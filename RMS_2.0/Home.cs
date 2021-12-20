using System;
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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            Form1 fm1 = new Form1();
            this.Hide();
            fm1.Show();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            this.Hide();
            l.Show();
        }

        private void btnOwner_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            this.Hide();
            l.Show();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            PlaceOrder po = new PlaceOrder("Customer");
            this.Hide();
            po.Show();
        }
    }
}
