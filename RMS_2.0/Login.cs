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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            this.Hide();
            h.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-N253613\SQLEXPRESS;Initial Catalog=Los_pollos_hermanos;Integrated Security=True");
                con.Open();
                String query1 = "select * from Employee where Username= '" + txtUsername.Text.Trim() + "' and Password='" + txtPass.Text.Trim() + "'";
                String query2 = "select * from Admin_Login where Username= '" + txtUsername.Text.Trim() + "' and Password='" + txtPass.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query1, con);
                SqlDataAdapter sda2 = new SqlDataAdapter(query2, con);
                DataTable dtbl1 = new DataTable();
                DataTable dtbl2 = new DataTable();
                sda.Fill(dtbl1);
                sda2.Fill(dtbl2);

                if (dtbl1.Rows.Count == 1)
                {
                    Staff stf = new Staff();
                    this.Hide();
                    stf.Show();
                }
                else if (dtbl2.Rows.Count == 1)
                {
                    Admin a = new Admin();
                    this.Hide();
                    a.Show();
                }
                else
                {
                    lblLoginStatus.Text = "Invalid Combination";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
