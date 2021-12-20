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
    public partial class Admin : Form
    {
        public Admin()
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
            Employee_DB empdb = new Employee_DB();
            this.Hide();
            empdb.Show();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Menu_DB mdb = new Menu_DB();
            this.Hide();
            mdb.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
