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
using System.Xml.Linq;

namespace shop
{
    public partial class Create_job : Form
    {
      
        public Create_job()
        {
            InitializeComponent();
            comboBox1.Text = "";

            SqlCommand cmd = new SqlCommand("Select EPF,EName from employee",conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable table1 = new DataTable();
            da.Fill(table1);
            comboBox1.DataSource = table1;
            comboBox1.DisplayMember = "EName";
            comboBox1.ValueMember = "EPF";
            Employee_name_Lable.Text = "";

            string id = DateTime.Now.ToString("yyMMddHHmmss");
            ID.Text = id;

        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-JLG22QO;Initial Catalog=KandyE;Integrated Security=True");

        private void iconButton2_Click(object sender, EventArgs e)
        {
            conn.Open();

            string receive_date = DateTime.Now.ToString("yyyy/MM/dd");
            string job_status = "Pending job";

            if (string.IsNullOrEmpty(CName.Text) || string.IsNullOrEmpty(PhoneNumber1.Text) || string.IsNullOrEmpty(comboBox1.Text) || string.IsNullOrEmpty(comboBox2.Text) || string.IsNullOrEmpty(PhoneNumber2.Text) || string.IsNullOrEmpty(Item_name.Text) || string.IsNullOrEmpty(Serialname.Text) || string.IsNullOrEmpty(Problem.Text) || string.IsNullOrEmpty(Charges.Text) || string.IsNullOrEmpty(Employee_name_Lable.Text))
            {
                MessageBox.Show("Please fill in all fields");
            }
            else
            {
                try
                {
                    SqlCommand insertCommand = new SqlCommand("INSERT INTO repireItem (repire_id, Customer_Name, phone_number1, phone_number2, ItemName, Brand, SerialNumber, Discription, EPF, ReceiveDate, Charges, JobStats) " +
                        "VALUES (@repire_id, @Customer_Name, @phone_number1, @phone_number2, @ItemName, @Brand, @SerialNumber, @Discription, @EPF, @ReceiveDate, @Charges, @JobStats)", conn);

                    insertCommand.Parameters.AddWithValue("@repire_id", ID.Text);
                    insertCommand.Parameters.AddWithValue("@Customer_Name", CName.Text);
                    insertCommand.Parameters.AddWithValue("@phone_number1", PhoneNumber1.Text);
                    insertCommand.Parameters.AddWithValue("@phone_number2", PhoneNumber2.Text);
                    insertCommand.Parameters.AddWithValue("@ItemName", Item_name.Text);
                    insertCommand.Parameters.AddWithValue("@Brand", comboBox2.Text);
                    insertCommand.Parameters.AddWithValue("@SerialNumber", Serialname.Text);
                    insertCommand.Parameters.AddWithValue("@Discription", Problem.Text);
                    insertCommand.Parameters.AddWithValue("@EPF", Employee_name_Lable.Text);
                    insertCommand.Parameters.AddWithValue("@ReceiveDate", receive_date);
                    insertCommand.Parameters.AddWithValue("@Charges", Charges.Text);
                    insertCommand.Parameters.AddWithValue("@JobStats", job_status);

                    int rowsAffected = insertCommand.ExecuteNonQuery();
                    MessageBox.Show(ID.Text + " is inserted.");
                    ClearFields();
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
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            
                Employee_name_Lable.Text = comboBox1.SelectedValue.ToString();
        }

        private void Create_job_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "";
        }
        private void ClearFields()
        {
            ID.Clear();
            CName.Clear();
            PhoneNumber1.Clear();
            PhoneNumber2.Clear();
            Item_name.Clear();
            comboBox1.Text= "";
            comboBox2.SelectedIndex=-1;
            Charges.Clear();
            Serialname.Clear();
            Problem.Clear();
            Employee_name_Lable.Text = "";
            
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            string pattern = @"^\d$";
            Regex regex = new Regex(pattern);
            if (!char.IsControl(e.KeyChar) && !regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true; // Block the keypress if it's not a valid digit
            }
        }

        private void CName_KeyPress(object sender, KeyPressEventArgs e)
        {
            string pattern = @"^(?! )[\w\s]+(?<! )";
            Regex regex = new Regex(pattern);
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // Block the keypress if it's not a letter, space, or control key
            }
        }

        private void PhoneNumber1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string pattern = @"^\d$";
            Regex regex = new Regex(pattern);
            if (!char.IsControl(e.KeyChar) && !regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true; // Block the keypress if it's not a valid digit
            }
        }

        private void PhoneNumber2_KeyPress(object sender, KeyPressEventArgs e)
        {
            string pattern = @"^\d$";
            Regex regex = new Regex(pattern);
            if (!char.IsControl(e.KeyChar) && !regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true; // Block the keypress if it's not a valid digit
            }
        }

        private void Charges_KeyPress(object sender, KeyPressEventArgs e)
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
