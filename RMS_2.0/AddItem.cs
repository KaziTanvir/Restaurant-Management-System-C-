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
    public partial class AddItem : Form
    {
        public AddItem()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            Menu_DB mdb = new Menu_DB();
            this.Hide();
            mdb.Show();
        }
        private void refresh()
        {
            txtItemName.Text = "";
            txtItemPrice.Text = "";
            cmbCategory.StartIndex = -1;
        }


        private void btnAddItem_Click(object sender, EventArgs e)
        {
            String category = "", name = "";
            int price = 0;

            category = cmbCategory.SelectedItem.ToString();

            if (txtItemName.Text != "")
            {
                name = txtItemName.Text;
            }
            if (txtItemPrice.Text != "")
            {
                price = Convert.ToInt32(txtItemPrice.Text);
            }


            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-N253613\SQLEXPRESS;Initial Catalog=Los_pollos_hermanos;Integrated Security=True");
                con.Open();
                String query = "Insert into Menu(Category,Name,Price) Values('" + category + "','" + name + "'," + price + ")";
                SqlCommand cmd = new SqlCommand(query, con);
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                    lblStatus.Text = "Item Added Sucessfully";
                else
                {
                    MessageBox.Show("Error occured");
                }
                refresh();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbCategory_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "";
        }
    }
}
