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
    public partial class Employee_DB : Form
    {
        public Employee_DB()
        {
            InitializeComponent();
        }
        public Employee_DB(String user)
        {
            InitializeComponent();
            if (user == "Staff")
            {
                btnAddEmp.Hide();
                btnRemoveEmp.Hide();
                btnUpdateEmp.Hide();
            }

        }

        private void Employee_DB_Load(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();
            this.Hide();
            a.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnShowEmp_Click(object sender, EventArgs e)
        {
            Employee_Info info = new Employee_Info();
            this.Hide();
            info.Show();
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            AddEmp add = new AddEmp();
            this.Hide();
            add.Show();
        }

        private void btnRemoveEmp_Click(object sender, EventArgs e)
        {
            RemoveEmp rev = new RemoveEmp();
            this.Hide();
            rev.Show();
        }

        private void btnUpdateEmp_Click(object sender, EventArgs e)
        {
            UpdateEmp up = new UpdateEmp();
            this.Hide();
            up.Show();
        }
    }
}
