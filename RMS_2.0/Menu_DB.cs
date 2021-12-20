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
    public partial class Menu_DB : Form
    {
        public Menu_DB()
        {
            InitializeComponent();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();
            this.Hide();
            a.Show();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            AddItem add = new AddItem();
            this.Hide();
            add.Show();
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            RemoveItems rmv = new RemoveItems();
            this.Hide();
            rmv.Show();
        }

        private void btnShowMenu_Click(object sender, EventArgs e)
        {
            PlaceOrder po = new PlaceOrder("Admin");
            this.Hide();
            po.Show();
        }

        private void btnUpdateItem_Click(object sender, EventArgs e)
        {
            UpdateMenu umenu = new UpdateMenu();
            this.Hide();
            umenu.Show();
        }
    }
}
