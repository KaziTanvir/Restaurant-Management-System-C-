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
    public partial class UpdateMenu : Form
    {
        private bool cellclick = false;
        public UpdateMenu()
        {
            InitializeComponent();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            Menu_DB mdb = new Menu_DB();
            this.Hide();
            mdb.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String category = cbCategory.SelectedItem.ToString();
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-N253613\SQLEXPRESS;Initial Catalog=Los_pollos_hermanos;Integrated Security=True");
                conn.Open();
                string query = "select * from Menu where Category like '%" + category + "%'";
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

        private void btnShowMenu_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-N253613\SQLEXPRESS;Initial Catalog=Los_pollos_hermanos;Integrated Security=True");
                conn.Open();
                string query = "select * from Menu";
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
                string id,price;
                id = dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                price = dataGridView1.Rows[e.RowIndex].Cells["Price"].Value.ToString();
                label2.Text = id;
                txtUpdatedPrice.Text = price;
                label2.Visible = false;
                cellclick = true;
            }
        }

        private void LoadData()
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-N253613\SQLEXPRESS;Initial Catalog=Los_pollos_hermanos;Integrated Security=True");
                conn.Open();
                string query = "select * from Menu";
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

        private void btnUpdateItem_Click(object sender, EventArgs e)
        {
            if (cellclick)
            {
                try
                {
                    SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-N253613\SQLEXPRESS;Initial Catalog=Los_pollos_hermanos;Integrated Security=True");
                    conn.Open();

                    string query = "Update Menu set Price='" + txtUpdatedPrice.Text + "' where ID='" + label2.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                        MessageBox.Show("Price updated successfully","Sucess ! ! !" );
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


    }
}
