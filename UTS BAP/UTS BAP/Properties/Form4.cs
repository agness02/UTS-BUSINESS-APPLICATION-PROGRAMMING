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
using System.IO;

namespace UTS_BAP.Properties
{
    public partial class Fininshbtn : Form
    {
        public Fininshbtn()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-QL38TO4\SQL2019EXPRESS;Initial Catalog=DB_UTS BAP;Integrated Security=True");

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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridViewMenu.CurrentRow.Selected = true;
                    textID.Text = dataGridView2.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString();
                    textFood.Text = dataGridView2.Rows[e.RowIndex].Cells["Food"].FormattedValue.ToString();
                    textQty.Text = dataGridView2.Rows[e.RowIndex].Cells["Qty"].FormattedValue.ToString();
                    textPrice.Text = dataGridView2.Rows[e.RowIndex].Cells["Price"].FormattedValue.ToString();
                    textAbout.Text = dataGridView2.Rows[e.RowIndex].Cells["About"].FormattedValue.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView1.CurrentRow.Selected = true;
                    textID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                    textFood.Text = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                    textQtyd.Text = dataGridView1.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                    textPrice.Text = dataGridView1.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                    textAbout.Text = dataGridView1.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
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

        private void textFood_TextChanged(object sender, EventArgs e)
        {

        }

        private void textQty_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void textAbout_TextChanged(object sender, EventArgs e)
        {

        }

        private void Orderbtn_Click(object sender, EventArgs e)
        {
            string id = textID.Text;
            string food = textFood.Text;
            string quantity = textQty.Text;
            string price = textPrice.Text;
            string about = textAbout.Text;

            int mytempdata = dataGridViewCart.Rows.Add();
            dataGridViewCart.Rows[mytempdata].Cells[0].Value = id;
            dataGridViewCart.Rows[mytempdata].Cells[1].Value = food;
            dataGridViewCart.Rows[mytempdata].Cells[2].Value = quantity;
            dataGridViewCart.Rows[mytempdata].Cells[3].Value = price;
            dataGridViewCart.Rows[mytempdata].Cells[4].Value = about;
            ResetForm4();

        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            try
            {
                txt_TotalAmount.Text = "0";
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    txt_TotalAmount.Text = Convert.ToString(double.Parse(txt_TotalAmount.Text) + double.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 signin = new Form1();
            signin.Show();
        }
    }
}
