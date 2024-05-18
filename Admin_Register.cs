using DB_FormLab;
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

namespace FINAL_DB_PROJECT
{
    public partial class Admin_Register : Form
    {
        string connectionString = "Server=sql.bsite.net\\MSSQL2016;Database=maryammasood_DatabaseProject2024;User Id=maryammasood_DatabaseProject2024;Password=E#auevEGu9qYHAx;";
        int AdminID;
        public Admin_Register(Action onCloseCallback)
        {
            InitializeComponent();
            this.onCloseCallback = onCloseCallback;
            panel1.Focus();
            this.Width = 1920;
            this.Height = 1080;
        }
        private Action onCloseCallback;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginPage form1 = new LoginPage(() => this.Show(), "");
            form1.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string fName = textBox7.Text;
            string lName = textBox5.Text;
            string DOB = textBox4.Text;
            string CNIC = textBox2.Text;
            string Email = textBox23.Text;
            string Address = textBox22.Text;
            string Role = comboBox5.Text;
            string StartDate = textBox3.Text;
            string Username = textBox15.Text;
            string Password = textBox14.Text;
            // string adminID = textBox6.Text;
            string getLastIdQuery = "SELECT TOP 1 A_ID FROM ADMIN ORDER BY A_ID DESC";

            int lastId = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(getLastIdQuery, connection))
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        lastId = Convert.ToInt32(result);
                    }
                }
            }
            AdminID = lastId + 1;
            string sal = "15000";
            string insertQuery = @"
        INSERT INTO ADMIN (A_ID,A_FName, A_LName, A_DOB, A_CNIC, A_EMAIL, A_ADDRESS, A_Role, A_StartDate,A_Salary, A_USERNAME, A_PASSWORD)
        VALUES (@AdminID,@fName, @lName, @DOB, @CNIC, @Email, @Address, @Role, @StartDate,@sal, @Username, @Password);";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@AdminID", AdminID);
                    command.Parameters.AddWithValue("@fName", fName);
                    command.Parameters.AddWithValue("@lName", lName);
                    command.Parameters.AddWithValue("@DOB", DOB);
                    command.Parameters.AddWithValue("@CNIC", CNIC);
                    command.Parameters.AddWithValue("@Email", Email);
                    command.Parameters.AddWithValue("@Address", Address);
                    command.Parameters.AddWithValue("@Role", Role);
                    command.Parameters.AddWithValue("@StartDate", StartDate);
                    command.Parameters.AddWithValue("@sal", sal);
                    command.Parameters.AddWithValue("@Username", Username);
                    command.Parameters.AddWithValue("@Password", Password);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Admin added successfully.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error inserting values into ADMIN table: " + ex.Message);
                    }
                }
            }
            this.Close();
            LoginPage form1 = new LoginPage(() => this.Show(), "");
            form1.Show();
        }

        private void Admin_Register_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          //  string adminID = textBox6.Text;
            string phone = textBox26.Text;
            string insertQuery = @"
        INSERT INTO ADMIN_CONTACT (A_ID,A_CONTACT)
        VALUES (@adminID, @phone);";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                 //   command.Parameters.AddWithValue("@adminID", adminID);
                    command.Parameters.AddWithValue("@phone", phone);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        Console.WriteLine("Values inserted into ADMIN Contact table successfully!");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error inserting values into ADMIN table: " + ex.Message);
                    }
                }
            }
        }
    }
}
