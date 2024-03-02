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
using System.Xml.Linq;

namespace shop
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-JLG22QO;Initial Catalog=KandyE;Integrated Security=True");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();

            string psswd = textBox3.Text;
            string repsswd = textBox2.Text;
            string getEpf = textBox1.Text;
            string getName = textBox5.Text;
            string getphone = textBox4.Text;
            string lvl = "2";


            try
            {
                if (psswd != repsswd)
                {
                    MessageBox.Show("Passwords do not match. Please re-enter passwords.");
                }
                else
                {
                    if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox5.Text) || string.IsNullOrEmpty(textBox4.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox2.Text))
                    {
                        MessageBox.Show("Please fill in all fields");
                    }
                    else
                    {

                        SqlCommand insertCommand = new SqlCommand("INSERT INTO employee (EPF, EName, phone_number, Epassword, Elavel) " +
                                "VALUES (@epf, @name, @phone, @pwd, @El)", conn);

                        insertCommand.Parameters.AddWithValue("@epf", getEpf);
                        insertCommand.Parameters.AddWithValue("@name", getName);
                        insertCommand.Parameters.AddWithValue("@phone", getphone);
                        insertCommand.Parameters.AddWithValue("@pwd", psswd);
                        insertCommand.Parameters.AddWithValue("@El", lvl);

                        int rows = insertCommand.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Employee data inserted successfully.");
                            
                            ClearFields();
                        
                        }
                        else
                        {
                            MessageBox.Show("Employee data not inserted. Please check your input.");
                        }

                        select();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }




        }

        private void ClearFields()
        {
            textBox1.Clear();
            textBox5.Clear();
            textBox4.Clear();
            textBox3.Clear();
            textBox2.Clear();
        }


        public void select()
        {

            try
            {

                conn.Open();
                string query = "SELECT * FROM employee";
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;

            }
            catch
            {

            }
            finally { conn.Close(); }

        }



        private void Employee_Load(object sender, EventArgs e)
        {
            select();
        }
    }
}
