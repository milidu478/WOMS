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

namespace shop
{
    public partial class Complite_job : Form
    {
        public Complite_job()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-JLG22QO;Initial Catalog=KandyE;Integrated Security=True");
        string tempV;
        string connectionString = "Data Source=DESKTOP-JLG22QO;Initial Catalog=KandyE;Integrated Security=True";
        string statas = "Complite job";

        private void Complite_job_Load(object sender, EventArgs e)
        {


            ID_Search.Text = "Job ID";
            ID_Search.ForeColor = Color.LightGray;



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
            string statas = "Complite job";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                if (tempV == "2") {
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
                command.Parameters.AddWithValue("@repire_id", ID_Search.Text);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);

                // Bind the DataTable to the DataGridView
                dataGridView1.DataSource = dataTable;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
             
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM repireItem WHERE DeliveryDate = @DeliveryDate and JobStats = @JobStats";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@DeliveryDate", dateTimePicker1.Text);
                command.Parameters.AddWithValue("@JobStats", statas);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);

                // Bind the DataTable to the DataGridView
                dataGridView1.DataSource = dataTable;
            }
        }

        private void ID_Search_Enter(object sender, EventArgs e)
        {
            if (ID_Search.Text == "Job ID")
            {
                ID_Search.Text = string.Empty;
                ID_Search.ForeColor = Color.Black;
            }
        }

        private void ID_Search_Leave(object sender, EventArgs e)
        {
            if (ID_Search.Text == string.Empty)
            {
                ID_Search.Text = "Job ID";
                ID_Search.ForeColor = Color.LightGray;
            }
        }
    }
}
