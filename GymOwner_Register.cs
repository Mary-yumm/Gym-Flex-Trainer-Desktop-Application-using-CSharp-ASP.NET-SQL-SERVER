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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FINAL_DB_PROJECT
{
    public partial class GymOwner_Register : Form
    {
        string connectionString = "Server=sql.bsite.net\\MSSQL2016;Database=maryammasood_DatabaseProject2024;User Id=maryammasood_DatabaseProject2024;Password=E#auevEGu9qYHAx;";

        public GymOwner_Register(Action onCloseCallback)
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

        private void GymOwner_Register_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //register
            string fName = textBox9.Text;
            string lName = textBox8.Text;
            string DOB = textBox6.Text;
            string CNIC = textBox5.Text;
            string Email = textBox4.Text;
            string Address = textBox2.Text;
            string Username = textBox15.Text;
            string Password = textBox14.Text;
            string ID = textBox6.Text;
            DateTime startdate = DateTime.Now;
            int salary = 156000;

            string getLastIdQuery = "SELECT TOP 1 O_ID FROM OWNER ORDER BY O_ID DESC";

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
            int OWNERID = lastId + 1;

            string insertQuery = @"
        INSERT INTO ADMIN (O_ID,O_FName, O_LName, O_DOB, O_CNIC, O_EMAIL, O_ADDRESS, O_Salary, O_JoiningDate, O_USERNAME, O_PASSWORD)
        VALUES (@OWNERID,@fname, @lname, @DOB, @CNIC, @Email, @Address, @salary, @startdate, @Username, @Password);";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@OWNERID", OWNERID);
                    command.Parameters.AddWithValue("@FName", fName);
                    command.Parameters.AddWithValue("@LName", lName);
                    command.Parameters.AddWithValue("@DOB", DOB);
                    command.Parameters.AddWithValue("@CNIC", CNIC);
                    command.Parameters.AddWithValue("@Email", Email);
                    command.Parameters.AddWithValue("@Address", Address);
                    command.Parameters.AddWithValue("@Username", Username);
                    command.Parameters.AddWithValue("@Password", Password);
                    command.Parameters.AddWithValue("@startdate", startdate);
                    command.Parameters.AddWithValue("@salary", salary);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("oWNER added successfully.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error inserting values into Owner table: " + ex.Message);
                    }
                }
                this.Close();
                LoginPage form1 = new LoginPage(() => this.Show(), "");
                form1.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //add
        //    string phone = textBox3.Text;
        //    string insertQuery = @"
        //INSERT INTO OWNER_CONTACT (O_ID,O_CONTACT)
        //VALUES (@adminID, @phone);";

        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        using (SqlCommand command = new SqlCommand(insertQuery, connection))
        //        {
        //            command.Parameters.AddWithValue("@adminID", adminID);
        //            command.Parameters.AddWithValue("@phone", phone);

        //            try
        //            {
        //                connection.Open();
        //                command.ExecuteNonQuery();
        //                Console.WriteLine("Values inserted into OWNER Contact table successfully!");
        //            }
        //            catch (Exception ex)
        //            {
        //                Console.WriteLine("Error inserting values into OWNER CONTACT table: " + ex.Message);
        //            }
        //        }
        //    }
        }
    }
}
