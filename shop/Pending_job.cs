using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace shop
{
    public partial class Pending_job : Form
    {
        public Pending_job()
        {
            InitializeComponent();

        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-JLG22QO;Initial Catalog=KandyE;Integrated Security=True");
        string connectionString = "Data Source=DESKTOP-JLG22QO;Initial Catalog=KandyE;Integrated Security=True";
        string tempV, CC;
        string delevery_date = DateTime.Now.ToString("yyyy/MM/dd");
        private void Pending_job_Load(object sender, EventArgs e)
        {
            conn.Open();
            ClearFields();

            repireID_search.Text = "Job ID";
            repireID_search.ForeColor = Color.LightGray;
            search_2.Text = "Job ID";
            search_2.ForeColor = Color.LightGray;

         
            SqlCommand cmd1 = new SqlCommand("Select * from employee where EPF =@EPF ", conn);

            cmd1.Parameters.AddWithValue("@EPF", Manivariable.Mvariable);
            SqlDataReader reader1;
            reader1 = cmd1.ExecuteReader();

            if (reader1.Read())
            {
                tempV = reader1["Elavel"].ToString();
            }



            
            string epfNumber = Manivariable.Mvariable;
            string statas = "Pending job";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();





                if (tempV == "2")
                {
                    string query = "SELECT * FROM repireItem WHERE EPF = @EPF and JobStats = @JobStats";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@EPF", epfNumber);
                    command.Parameters.AddWithValue("@JobStats", statas);



                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = dataTable;
                }
                else
                {
                    string query = "SELECT * FROM repireItem WHERE JobStats = @JobStats";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@JobStats", statas);



                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = dataTable;
                }
            }
            conn.Close();
        }

        private void repiarId_s_b_Click(object sender, EventArgs e)
        {


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM repireItem WHERE repire_id = @repire_id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@repire_id", repireID_search.Text);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);

                // Bind the DataTable to the DataGridView
                dataGridView1.DataSource = dataTable;
            }
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM repireItem WHERE repire_id = @repire_id", conn);
            cmd1.Parameters.AddWithValue("@repire_id", search_2.Text);
            SqlDataReader reader1;
            reader1 = cmd1.ExecuteReader();
            if (reader1.Read())
            {
             
                Customer_Name.Text = reader1["Customer_Name"].ToString();
                phone_number1.Text = reader1["phone_number1"].ToString();
                phone_number2.Text = reader1["phone_number2"].ToString();
                ItemName.Text = reader1["ItemName"].ToString();
                Charges.Text = reader1["Charges"].ToString();
            

                label6.Text = "Rs.";
            }
            else
            {
                MessageBox.Show("not Found job id Number");
            }
            conn.Close();
        }
    
        private void iconButton4_Click(object sender, EventArgs e)
        {
           

            try
            {
                conn.Open();

                if (string.IsNullOrEmpty(statas.Text) || string.IsNullOrEmpty(search_2.Text))
                {
                    MessageBox.Show("Please enter a valid Employee and Status.");
                }
                else
                {
                    string query = "UPDATE repireItem SET JobStats = @JobStats, Cost = @Cost, DeliveryDate = @DeliveryDate WHERE repire_id = @repire_id";

                    using (SqlCommand cmd3 = new SqlCommand(query, conn))
                    {
                        cmd3.Parameters.AddWithValue("@JobStats", statas.Text);
                        cmd3.Parameters.AddWithValue("@repire_id", search_2.Text);
                        if(cost.Text == "")
                        {
                            cmd3.Parameters.AddWithValue("@Cost", 0);
                        }
                        else
                        {
                            cmd3.Parameters.AddWithValue("@Cost", cost.Text);
                        }


                        if (statas.Text != "Cancel job")
                        {
                            cmd3.Parameters.AddWithValue("@DeliveryDate", delevery_date);
                        }
                        else
                        {
                            cmd3.Parameters.AddWithValue("@DeliveryDate", "1111/11/11");
                        }

                        int rowsUpdated = cmd3.ExecuteNonQuery();


                 
                        if (rowsUpdated > 0)
                        {


                            MessageBox.Show("Job Successfully updated.");
                            ClearFields();
                        }
                        else
                        {
                            MessageBox.Show("No records were updated. Check the search criteria.");
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }


        }

        private void ClearFields()
        {
            Customer_Name.Text="";
            ItemName.Text = "";
            phone_number1.Text = "";
            phone_number2.Text = "";
            label6.Text ="";
            Charges.Text = "";
            statas.Text = "";
            label5.Text = "";
            cost.Text = null;
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            ClearFields();
            search_2.Text = "";
        }

        private void repireID_search_Enter(object sender, EventArgs e)
        {
            if (repireID_search.Text == "Job ID")
            {
                repireID_search.Text = string.Empty;
                repireID_search.ForeColor = Color.Black;
            }
        }

        private void repireID_search_Leave(object sender, EventArgs e)
        {
            if (repireID_search.Text == string.Empty)
            {
                repireID_search.Text = "Job ID";
                repireID_search.ForeColor = Color.LightGray;
            }
        }

        private void search_2_Enter(object sender, EventArgs e)
        {

            if (repireID_search.Text == "Job ID")
            {
                search_2.Text = string.Empty;
                search_2.ForeColor = Color.Black;
            }
        }

        private void search_2_Leave(object sender, EventArgs e)
        {
            if (search_2.Text == string.Empty)
            {
                search_2.Text = "Job ID";
                search_2.ForeColor = Color.LightGray;
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            repireID_search.Text = "";
        }

        private void repireID_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            string pattern = @"^\d$";
            Regex regex = new Regex(pattern);
            if (!char.IsControl(e.KeyChar) && !regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true; // Block the keypress if it's not a valid digit
            }
        }

        private void cost_KeyPress(object sender, KeyPressEventArgs e)
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

