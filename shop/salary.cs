using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace shop
{
    public partial class salary : Form
    {
        public salary()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-JLG22QO;Initial Catalog=KandyE;Integrated Security=True");
        string connectionString = "Data Source = DESKTOP-JLG22QO; Initial Catalog = KandyE; Integrated Security = True";
        string temp, temp_Elavel;
        private void store_Load(object sender, EventArgs e)
        {
           


        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Check if the employee with EPF exists in the 'employee' table.
                    string selectEmployeeQuery = "SELECT Elavel FROM employee WHERE EPF = @EPF";
                    SqlCommand cmd1 = new SqlCommand(selectEmployeeQuery, conn);
                    cmd1.Parameters.AddWithValue("@EPF", Manivariable.Mvariable);

                    string temp_Elavel = string.Empty; // Initialize temp_Elavel
                    SqlDataReader reader1 = cmd1.ExecuteReader();

                    if (reader1.Read())
                    {
                        temp_Elavel = reader1["Elavel"].ToString();
                    }
                    reader1.Close(); // Close the reader when done.

                    if (temp_Elavel == "1")
                    {
                        string ggg = "Complite job";
                        // Case 1: Elavel is 1
                        string query = "SELECT * FROM repireItem WHERE JobStats = @JobStats AND DeliveryDate BETWEEN @d1 AND @d2";
                        SqlCommand command = new SqlCommand(query, conn);
                        command.Parameters.AddWithValue("@JobStats", ggg);
                        command.Parameters.Add("@d1", SqlDbType.Date).Value = dateTimePicker1.Value;
                        command.Parameters.Add("@d2", SqlDbType.Date).Value = dateTimePicker2.Value;

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();

                        adapter.Fill(dataTable);

                        // Bind the DataTable to the DataGridView
                        dataGridView1.DataSource = dataTable;
                    }
                    else
                    {
                        // Case 2: Elavel is not 1
                        string query = "SELECT * FROM repireItem WHERE EPF = @EPF AND DeliveryDate BETWEEN @d1 AND @d2";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@EPF", Manivariable.Mvariable);
                        cmd.Parameters.Add("@d1", SqlDbType.Date).Value = dateTimePicker1.Value;
                        cmd.Parameters.Add("@d2", SqlDbType.Date).Value = dateTimePicker2.Value;

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // Bind the DataTable to the DataGridView
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions here
                Console.WriteLine("An error occurred: " + ex.Message);
            }
           

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            double total1 = 0.0;
            double total2 = 0.0;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[7].Value != null)
                {
                    if (double.TryParse(dataGridView1.Rows[i].Cells[7].Value.ToString(), out double cellValue1))
                    {
                        total1 += cellValue1;
                    }
                }

                if (dataGridView1.Rows[i].Cells[9].Value != null)
                {
                    if (double.TryParse(dataGridView1.Rows[i].Cells[9].Value.ToString(), out double cellValue2))
                    {
                        total2 += cellValue2;
                    }
                }
            }

            double difference = total1 - total2; // Calculate the difference
            double discount = difference * 0.5; // Apply a 50% discount

            labalTotal.Text = discount.ToString();


        }
    }
    }

