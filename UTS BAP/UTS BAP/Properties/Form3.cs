using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace UTS_BAP.Properties
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            invoice();
            SqlCommand cmd = new SqlCommand("Select * from UTS BAP", conn);
            DataTable dt = new DataTable();

            conn.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            conn.Close();

            dataGridView.DataSource = dt;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView1.CurrentRow.Selected = true;
                    textID.Text = dataGridView1.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString();
                    textFood.Text = dataGridView1.Rows[e.RowIndex].Cells["Food"].FormattedValue.ToString();
                    textPrice.Text = dataGridView1.Rows[e.RowIndex].Cells["Price"].FormattedValue.ToString();
                    textNoOrder.Text = dataGridView1.Rows[e.RowIndex].Cells["No Order"].FormattedValue.ToString();
                    textQty.Text = dataGridView1.Rows[e.RowIndex].Cells["Qty"].FormattedValue.ToString();
                    textAbout.Text = dataGridView1.Rows[e.RowIndex].Cells["About"].FormattedValue.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textFoodID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT Ordered.ID, Ordered.Food, SalesOrderedCus.NoOrder, SalesOrderedCus.Qty, SalesOrderedCus.Price FROM Ordered inner join SalesOrderedCus ON Ordered.NoOrder = SalesOrderedCus.NoOrder WHERE Ordered.NoOrder = '" + textFoodID.Text + "'", conn);
            DataTable dt2 = new DataTable();

            conn.Open();

            SqlDataReader sdr2 = cmd.ExecuteReader();
            dt2.Load(sdr2);
            conn.Close();

            dataGridView1.DataSource = dt2;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView2.CurrentRow.Selected = true;
                    textFood.Text = dataGridView2.Rows[e.RowIndex].Cells["Food"].FormattedValue.ToString();
                    textPrice.Text = dataGridView2.Rows[e.RowIndex].Cells["Price"].FormattedValue.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Btn_Print_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Want To Print This Order?", "Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Sales Success Printed", "Printed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Want To Print This Order?", "Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Sales Success Printed", "Printed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textFood_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void textNoOrder_TextChanged(object sender, EventArgs e)
        {

        }

        private void textQty_TextChanged(object sender, EventArgs e)
        {

        }

        private void textAbout_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
