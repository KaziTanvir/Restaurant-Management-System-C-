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
    public partial class AddEmp : Form
    {
        public AddEmp()
        {
            InitializeComponent();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            Employee_DB db = new Employee_DB();
            this.Hide();
            db.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void refresh()
        {
            txtAddress.Text = "";
            txtemail.Text = "";
            txtName.Text = "";
            txtPass.Text = "";
            txtSalary.Text = "";
            txtUserName.Text = "";
            lblStatus.Text = "";
            guna2ComboBox1.StartIndex = -1;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            String designation = "";
            DateTime doj;


            designation = guna2ComboBox1.SelectedItem.ToString();
            doj = Convert.ToDateTime(guna2DateTimePicker1.Text);

            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-N253613\SQLEXPRESS;Initial Catalog=Los_pollos_hermanos;Integrated Security=True");
                con.Open();
                String query = "insert into Employee(Name, Username, Password,Address,Designation,Salary,Email,DOJ) Values('" + txtName.Text + "','" + txtUserName.Text + "','" + txtPass.Text + "','" + txtAddress.Text + "','" + designation + "'," + txtSalary.Text + ",'" + txtemail.Text + "','" + doj + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                    lblStatus.Text="Sucessfully Added";
                else
                {
                    MessageBox.Show("Error occured");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            
                
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
