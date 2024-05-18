using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;

namespace FINAL_DB_PROJECT
{
    public partial class A_Register : UserControl
    {
        string connectionString = "Server=sql.bsite.net\\MSSQL2016;Database=maryammasood_DatabaseProject2024;User Id=maryammasood_DatabaseProject2024;Password=E#auevEGu9qYHAx;";

        public A_Register(Action onCloseCallback)
        {
            this.onCloseCallback = onCloseCallback;
            InitializeComponent();
        }
        private Action onCloseCallback;


        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            // Register button
            // Connection string

            // Values obtained from Windows Form text boxes
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
            string adminID = textBox6.Text;

            // SQL query to insert values into ADMIN table
            string insertQuery = @"
        INSERT INTO ADMIN (A_FName, A_LName, A_DOB, A_CNIC, A_EMAIL, A_ADDRESS, A_Role, A_StartDate, A_USERNAME, A_PASSWORD)
        VALUES (@FName, @LName, @DOB, @CNIC, @Email, @Address, @Role, @StartDate, @Username, @Password);";

            // Execute the SQL query
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    // Add parameters
                    command.Parameters.AddWithValue("@adminID", adminID);
                    command.Parameters.AddWithValue("@FName", fName);
                    command.Parameters.AddWithValue("@LName", lName);
                    command.Parameters.AddWithValue("@DOB", DOB);
                    command.Parameters.AddWithValue("@CNIC", CNIC);
                    command.Parameters.AddWithValue("@Email", Email);
                    command.Parameters.AddWithValue("@Address", Address);
                    command.Parameters.AddWithValue("@Role", Role);
                    command.Parameters.AddWithValue("@StartDate", StartDate);
                    command.Parameters.AddWithValue("@Username", Username);
                    command.Parameters.AddWithValue("@Password", Password);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        Console.WriteLine("Values inserted into ADMIN table successfully!");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error inserting values into ADMIN table: " + ex.Message);
                    }
                }
            }


        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string adminID = textBox6.Text;
            string phone = textBox26.Text;
            string insertQuery = @"
        INSERT INTO ADMIN_CONTACT (A_ID,A_CONTACT)
        VALUES (@adminID, @phone);";

            // Execute the SQL query
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    // Add parameters
                    command.Parameters.AddWithValue("@adminID", adminID);
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
