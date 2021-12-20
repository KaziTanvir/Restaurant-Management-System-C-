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
    public partial class Employee_Info : Form
    {
        public Employee_Info()
        {
            InitializeComponent();
            guna2PictureBox2.Hide();
        }
        public Employee_Info(String user)
        {
            InitializeComponent();
            if (user == "Staff")
            {
                guna2PictureBox1.Hide();
            }
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            Employee_DB db = new Employee_DB();
            this.Hide();
            db.Show();
        }
        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            Staff db = new Staff();
            this.Hide();
            db.Show();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-N253613\SQLEXPRESS;Initial Catalog=Los_pollos_hermanos;Integrated Security=True");
                conn.Open();
                string query = "select ID,Name,Designation,Email,Address from Employee";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                dataGridView1.DataSource = dt;
                //dataGridView1.AutoGenerateColumns = false;

                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
                MessageBox.Show("Nothing to search");
            else
            {
                try
                {
                    SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-N253613\SQLEXPRESS;Initial Catalog=Los_pollos_hermanos;Integrated Security=True");
                    conn.Open();
                    string query = "select ID,Name,Designation,Email,Address from Employee where Name like '%" + txtSearch.Text + "%'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adp.Fill(ds);
                    DataTable dt = ds.Tables[0];
                    dataGridView1.DataSource = dt;
                    //dataGridView1.AutoGenerateColumns = false;

                    dataGridView1.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox2_Click_1(object sender, EventArgs e)
        {
            Staff st = new Staff();
            this.Hide();
            st.Show();
        }
    }
}
