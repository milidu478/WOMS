using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace shop
{
    public partial class login2 : Form
    {
        public login2()
        {
            InitializeComponent();
        }

     
        private void login2_Load(object sender, EventArgs e)
        {
            EPF.Text = "EPF no";
            Password.Text = "Password";

            EPF.ForeColor = Color.LightGray;
            Password.ForeColor = Color.LightGray;
            label3.Select();
        }

        private void EPF_Enter(object sender, EventArgs e)
        {
            if (EPF.Text == "EPF no")
            {
                EPF.Text = string.Empty;
                EPF.ForeColor = Color.Black;
            }
        }

        private void Password_Enter(object sender, EventArgs e)
        {
            if (Password.Text == "Password")
            {
                Password.Text = string.Empty;
                Password.ForeColor = Color.Black;
            }
        }

        private void EPF_Leave(object sender, EventArgs e)
        {
            if (EPF.Text == string.Empty)
            {
                EPF.Text = "EPF no";
                EPF.ForeColor = Color.LightGray;
            }
        }

        private void Password_Leave(object sender, EventArgs e)
        {
            if (Password.Text == string.Empty)
            {
                Password.Text = "Password";
                Password.ForeColor = Color.LightGray;
            }
        }

        private void login_Click(object sender, EventArgs e)
        {

            string connectionString = "Data Source=DESKTOP-JLG22QO;Initial Catalog=KandyE;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string username = EPF.Text;
                string user_password = Password.Text;

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(user_password))
                {
                    MessageBox.Show("Please enter both username and password.");
                }
                else
                {
                    try
                    {
                        conn.Open();

                        string query = "SELECT * FROM employee WHERE EPF = @EPF AND Epassword = @Epassword";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@EPF", username);
                        cmd.Parameters.AddWithValue("@Epassword", user_password);

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            // Valid credentials
                            Manivariable.Mvariable = EPF.Text;
                            main_menu Form2 = new main_menu();
                            Form2.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password. Please try again.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Invalid username or password. Please try again.");
                    }
                }
            }


        }

        private void EPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            string pattern = @"^\d$";
            Regex regex = new Regex(pattern);
            if (!char.IsControl(e.KeyChar) && !regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true; // Block the keypress if it's not a valid digit
            }
        }
    }
}
