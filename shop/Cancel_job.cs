using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shop
{
    public partial class Cancel_job : Form
    {
        public Cancel_job()
        {
            InitializeComponent();
        }
        string connectionString = "Data Source=DESKTOP-JLG22QO;Initial Catalog=KandyE;Integrated Security=True";
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-JLG22QO;Initial Catalog=KandyE;Integrated Security=True");
       
        string tempV;
        string statas = "Cancel job";
        private void Cancel_job_Load(object sender, EventArgs e)
        {

            ID_search.Text = "Job ID";
            ID_search.ForeColor = Color.LightGray;


            conn.Open();
            SqlCommand cmd1 = new SqlCommand("Select * from employee where EPF =@EPF ", conn);

            cmd1.Parameters.AddWithValue("@EPF", Manivariable.Mvariable);
            SqlDataReader reader1;
            reader1 = cmd1.ExecuteReader();

            if (reader1.Read())
            {
                tempV = reader1["Elavel"].ToString();
            }




            string epfNumber = Manivariable.Mvariable;

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

        private void iconButton2_Click(object sender, EventArgs e)
        {

           

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM repireItem WHERE repire_id = @repire_id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@repire_id", ID_search.Text);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);

                // Bind the DataTable to the DataGridView
                dataGridView1.DataSource = dataTable;
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
          

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM repireItem WHERE DeliveryDate = @DeliveryDate and JobStats = @JobStats";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@DeliveryDate", dateTimePicker2.Text);
                command.Parameters.AddWithValue("@JobStats", statas);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);

                // Bind the DataTable to the DataGridView
                dataGridView1.DataSource = dataTable;
            }
        }

        private void ID_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            string pattern = @"^\d$";
            Regex regex = new Regex(pattern);
            if (!char.IsControl(e.KeyChar) && !regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true; // Block the keypress if it's not a valid digit
            }
        }

        private void ID_search_Enter(object sender, EventArgs e)
        {
            if (ID_search.Text == "Job ID")
            {
                ID_search.Text = string.Empty;
                ID_search.ForeColor = Color.Black;
            }
        }

        private void ID_search_Leave(object sender, EventArgs e)
        {
            if (ID_search.Text == string.Empty)
            {
                ID_search.Text = "Job ID";
                ID_search.ForeColor = Color.LightGray;
            }
        }
    }
}
