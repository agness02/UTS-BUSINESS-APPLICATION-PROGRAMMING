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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-QL38TO4\SQL2019EXPRESS;Initial Catalog=DB_UTS BAP;Integrated Security=True");

        private void NFood_Enter(object sender, EventArgs e)
        {
            if (this.Food.Text.Equals("Nama"))
            {
                this.Food.Text = string.Empty;
                this.Name.ForeColor = Color.FromKnownColor(KnownColor.ControlText);
            }
        }

        private void Name_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.Name.Text.Trim()))
            {
                this.Name.ForeColor = Color.FromKnownColor(KnownColor.ScrollBar);
                this.Name.Text = "Nama";
            }
            else
            {
                this.Name.BackColor = Color.FromKnownColor(KnownColor.Window);
            }
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            if (this.textID.Text.Trim() == "")
            {
                MessageBox.Show("Mohon diisi", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textID.Focus();
            }

            else if (this.textFood.Text.Trim() == "")
            {
                MessageBox.Show("Mohon diisi", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textFood.Focus();
            }

            else if (this.textPrice.Text.Trim() == "")
            {
                MessageBox.Show("Mohon diisi", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textPrice.Focus();
            }

            else if (this.textAbout.Text.Trim() == "")
            {
                MessageBox.Show("Mohon diisi", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textAbout.Focus();
            }


            else
            {
                try
                {
                    byte[] picture = null;
                    BinaryReader brs = new BinaryReader(streem);

                    SqlCommand cmd = new SqlCommand("INSERT INTO UTS BAP VALUES " +
                        "(@ID, @FoodName, @Price, @Description, @Picture)", conn);

                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@ID", this.textID.Trim());
                    cmd.Parameters.AddWithValue("@Food", this.textFood.Text.Trim());
                    cmd.Parameters.AddWithValue("@Price", this.textPrice.Text.Trim());
                    cmd.Parameters.AddWithValue("@About", this.textAbout.Text.Trim());

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("New Food Successfully created and saved in database", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ResetFormClean();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            private void Clearbtn_Click(object sender, EventArgs e)
            {
                this.textID.Text = "";
                this.textID.ForeColor = Color.FromKnownColor(KnownColor.Black);

                this.textFood.Text = "";
                this.textFood.ForeColor = Color.FromKnownColor(KnownColor.Black);

                this.textPrice.Text = "";
                this.textPrice.ForeColor = Color.FromKnownColor(KnownColor.Black);

                this.textAbout.Text = "";
                this.textAbout.ForeColor = Color.FromKnownColor(KnownColor.Black);
            }

            private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
                if (e.Button == MouseButtons.Right)
                {
                    ContextMenu m = new ContextMenu();
                    m.MenuItems.Add(new MenuItem("Edit"));
                    m.MenuItems.Add(new MenuItem("Delete"));

                    int currentMouseOverRow = dataGridView1.HitTest(e.X, e.Y).RowIndex;

                    if (currentMouseOverRow >= 0)
                    {
                        m.MenuItems.Remove(new MenuItem(string.Format("Do something to row {0}", currentMouseOverRow.ToString())));
                    }

                    m.Show(dataGridView1, new Point(e.X, e.Y));
                }
            }

            private void Listbtn_Click(object sender, EventArgs e)
            {
                this.Hide();
                Listbtn listorder = new Listbtn();
                listorder.Show();
            }

            private void LogOut_Click(object sender, EventArgs e)
            {
                this.Hide();
                Form1 signin = new Form1();
                signin.Show();
            }
        }
    }
}
