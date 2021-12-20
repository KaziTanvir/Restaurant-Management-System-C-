using DGVPrinterHelper;
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
    public partial class PlaceOrder : Form
    {
        Sqlfunction fn = new Sqlfunction();
        String query;
        public PlaceOrder()
        {
            InitializeComponent();
        }

        public PlaceOrder(String user)
        {
            InitializeComponent();

            if (user == "Staff")
            {
                guna2PictureBox1.Visible = false;
                pb3.Visible = false;
            }
            if (user == "Customer")
            {
                guna2PictureBox1.Visible = false;
                pb2.Visible = false;
            }
            if (user == "Admin")
            {
                pb3.Visible = false;
                pb2.Visible = false;
            }
        }


        private void showItemsList(string query)
        {
            listBox1.Items.Clear();
            DataSet ds = fn.getData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++) 
            {
                listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void ComboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            String category = cbCategory.Text;
            query = "select name from Menu where category ='" +category+"'";
           showItemsList(query);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
              listBox1.Items.Clear();
            String category = cbCategory.Text;
            query = "select name from Menu where category ='" +category+"' and name like'"+txtSearch.Text+"%'";
           showItemsList(query);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtQuantityUpDown.ResetText();
            txtTotal.Clear();

            String text = listBox1.GetItemText(listBox1.SelectedItem);
            txtItemName.Text = text;
            query = "select price from Menu where name = '" + text + "'";
            DataSet ds = fn.getData(query);

            try
            {
                txtPrice.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            
            }
        }

        private void txtQuantityUpDown_ValueChanged(object sender, EventArgs e)
        {
            Int64 quan = Int64.Parse(txtQuantityUpDown.Value.ToString());
            Int64 price = Int64.Parse(txtPrice.Text);
            txtTotal.Text = (quan * price).ToString();
        }

        protected int n, total = 0;

        private void btnAddtoCart_Click(object sender, EventArgs e)
        {
             if (txtTotal.Text != "0" && txtTotal.Text != "")
            {
                n = guna2DataGridView1.Rows.Add();
                guna2DataGridView1.Rows[n].Cells[0].Value = txtItemName.Text;
                guna2DataGridView1.Rows[n].Cells[1].Value = txtPrice.Text;
                guna2DataGridView1.Rows[n].Cells[2].Value = txtQuantityUpDown.Text;
                guna2DataGridView1.Rows[n].Cells[3].Value = txtTotal.Text;

                total += int.Parse(txtTotal.Text);
                labelTotalAmount.Text = "taka." + total;
            }
            else 
            {
                MessageBox.Show("Minimum Quantity Need to be 1" , "Information" , MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        int amount;

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                amount = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {

                guna2DataGridView1.Rows.RemoveAt(this.guna2DataGridView1.SelectedRows[0].Index);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            total -= amount;
            labelTotalAmount.Text = "taka." + total;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Customer Bill";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Total Payable Amount : " + labelTotalAmount.Text;
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(guna2DataGridView1);

            total = 0;
            guna2DataGridView1.Rows.Clear();
            labelTotalAmount.Text = "taka. " + total;
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            Menu_DB mdb = new Menu_DB();
            this.Hide();
            mdb.Show();
        }

        private void pb3_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            this.Hide();
            h.Show();
        }

        private void pb2_Click(object sender, EventArgs e)
        {
            Staff st = new Staff();
            this.Hide();
            st.Show();
        }




    }
}
