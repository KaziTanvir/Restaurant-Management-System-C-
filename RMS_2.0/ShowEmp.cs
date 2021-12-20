using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RMS_2._0
{
    public partial class ShowEmp : Form
    {
        public ShowEmp()
        {
            InitializeComponent();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            Employee_DB empdb = new Employee_DB();
            this.Hide();
            empdb.Show();
        }

        private void btnShowEmp_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-N253613\SQLEXPRESS;Initial Catalog=Classwork;Integrated Security=True");
                con.Open();
                String query = "Select * from Student";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable a = new DataTable();
                sda.Fill(a);

                dataGridView1.DataSource = a;
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
            }
        }
    }
}
