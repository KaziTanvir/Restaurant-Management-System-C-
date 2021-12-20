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
    public partial class UpdateEmp : Form
    {
        private bool cellclick = false;
        public UpdateEmp()
        {
            InitializeComponent();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            Employee_DB db = new Employee_DB();
            this.Hide();
            db.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
                MessageBox.Show("Nothing to search");
            else
            {
                try
                {
                    SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-N253613\SQLEXPRESS;Initial Catalog=Los_pollos_hermanos;Integrated Security=True");
                    conn.Open();
                    string query = "select ID,Name,Designation,Salary,Email,DOJ from Employee where Name like '%" + txtSearch.Text + "%'";
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

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-N253613\SQLEXPRESS;Initial Catalog=Los_pollos_hermanos;Integrated Security=True");
                conn.Open();
                string query = "select ID,Name,Designation,Salary,DOJ from Employee";
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string id, salary,designation;
                id = dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                salary = dataGridView1.Rows[e.RowIndex].Cells["Salary"].Value.ToString();
                designation = dataGridView1.Rows[e.RowIndex].Cells["Designation"].Value.ToString();
                label4.Text = id;
                label4.Visible = false;
                txtSalary.Text = salary;
                cbDesignation.Text = designation;
                cellclick = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cellclick)
            {
                try
                {
                    SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-N253613\SQLEXPRESS;Initial Catalog=Los_pollos_hermanos;Integrated Security=True");
                    conn.Open();

                    string query = "Update Employee set Salary='" + txtSalary.Text + "',Designation='" + cbDesignation.SelectedItem.ToString() + "' where ID='" +label4.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                        MessageBox.Show("User information updated successfully","Sucess ! ! !");
                    else
                    {
                        MessageBox.Show("Error occured");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                dataGridView1.ClearSelection();
                
                LoadData();
            }
        }
        private void LoadData()
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-N253613\SQLEXPRESS;Initial Catalog=Los_pollos_hermanos;Integrated Security=True");
                conn.Open();
                string query = "select ID,Name,Designation,Salary,DOJ from Employee";
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
}
