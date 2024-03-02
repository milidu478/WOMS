using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shop
{
    public partial class main_menu : Form
    {
        public main_menu()
        {
            InitializeComponent();
            timer1.Start();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-JLG22QO;Initial Catalog=KandyE;Integrated Security=True");

        public void loadform(object Form)
        {

            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();

        }


       

        private void main_menu_Load(object sender, EventArgs e)
        {
            string temp;
            
            
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM employee WHERE EPF = @EPF", conn);
            cmd1.Parameters.AddWithValue("@EPF", Manivariable.Mvariable);
            SqlDataReader reader1;
            reader1 = cmd1.ExecuteReader();
            if (reader1.Read())
            {
                EEName.Text = reader1["EName"].ToString();
                Pnumber.Text = reader1["phone_number"].ToString();
                temp = reader1["Elavel"].ToString();
                string level_names;
                if (temp == "1")
                {
                    level_names = "Manager";
                }
                else
                {
                    level_names = "Technician";
                    iconButton2.Visible = false;
                    iconButton7.Visible = false;
                }
                leval_labal.Text = level_names;


            }
            else
            {
                MessageBox.Show("not Found job id Number");
            }
            conn.Close();

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            loadform(new Create_job());
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            loadform(new Pending_job());
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            loadform(new Complite_job());
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            loadform(new Cancel_job());
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            login2 Form1 = new login2();
            Form1.Show();
            this.Hide();
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            loadform(new salary());
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.time_lbl.Text = dateTime.ToString();
        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            loadform(new Employee());
        }
    }
}
