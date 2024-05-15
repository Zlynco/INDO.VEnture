using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ticketing_IDN
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=SR\\sqlexpress;Initial Catalog=IDNVENTURE;Integrated Security=True");

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ShadowPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblreg_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormRegister formRegister = new FormRegister();
            formRegister.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String username, user_password;

            username = txtUSN.Text;
            user_password = txtPsw.Text;

            try
            {
                String query = "SELECT * Register_new WHERE username = '" + txtUSN.Text + "' AND password = '" + txtPsw.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    username = txtUSN.Text;
                    user_password = txtPsw.Text;

                    this.Hide();

                    FormLogin formLogin = new FormLogin();
                    formLogin.Show();
                }
                else
                {
                    MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUSN.Clear();
                    txtPsw.Clear();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}

