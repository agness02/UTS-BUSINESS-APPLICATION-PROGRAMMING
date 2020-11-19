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

namespace UTS_BAP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int kesempatan = 0;
        private void OKbtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-QL38TO4\SQL2019EXPRESS;Initial Catalog=DB_UTS BAP;Integrated Security=True");
            string query = "SELECT * FROM Form1 WHERE username = '" + textUser.Text.Trim() + "' AND Password = '" + textPass.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                this.Hide();
                Form2 adminpage = new Form2();
                adminpage.Show();
            }
            else if (this.textUser.Text.Trim() == "")
            {
                MessageBox.Show("Sorry, Username tidak boleh kosong ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textUser.Focus();
                kesempatan++;
            }
            else if (this.textPass.Text.Trim() == "")
            {
                MessageBox.Show("Sorry, Password tidak boleh kosong ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textPass.Focus();
                kesempatan++;
            }
            else
            {
                MessageBox.Show("Have Problen When Sign In, Please Check Username or Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetLogin();
                kesempatan++;
            }
            if (kesempatan == 3)
            {
                MessageBox.Show("Try It Later, Blocked", "Blocked", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            this.textUser.Clear();
            this.textPass.Clear();
        }

        private void Cusbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 FRG = new Form4();
            FRG.Show();

        }

        private void Show_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckView.Checked)
            {
                textPass.UseSystemPasswordChar = false;
                var checkBox = (CheckBox)sender;
                checkBox.Text = "Show Password";
            }
            else
            {
                textPass.UseSystemPasswordChar = true;
                var checkBox = (CheckBox)sender;
                checkBox.Text = "Show Password";
            }
    }
}
