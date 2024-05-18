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

    public partial class Member_Register : Form
    {
        string connectionString = "Server=sql.bsite.net\\MSSQL2016;Database=maryammasood_DatabaseProject2024;User Id=maryammasood_DatabaseProject2024;Password=E#auevEGu9qYHAx;";
        int ID;
        public Member_Register(Action onCloseCallback)
        {
            this.Width = 1920;
            this.Height = 1080;
            InitializeComponent();
            this.onCloseCallback = onCloseCallback;
            string selectQuery2 = @"
        SELECT G_ID, G_NAME 
        FROM GYM ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(selectQuery2, connection))
                {

                    try
                    {
                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                comboBox5.Items.Add(reader["G_NAME"].ToString());
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
        private Action onCloseCallback;

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginPage form1 = new LoginPage(() => this.Show(), "");
            form1.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //REGISTER
            string fName = textBox7.Text;
            string lName = textBox5.Text;
            string DOB = textBox4.Text;
            string Email = textBox23.Text;
            string Address = textBox22.Text;
            string Username = textBox15.Text;
            string Password = textBox14.Text;
            string MemType = textBox8.Text;
            DateTime startdate = DateTime.Now;
            string gym = comboBox5.Text;
            string goal = comboBox1.Text;

            string getLastIdQuery = "SELECT TOP 1 M_ID FROM MEMBER ORDER BY M_ID DESC";

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
            ID = lastId + 1;
            string insertQuery = @"
        INSERT INTO ADMIN (M_ID,M_FName, M_LName, M_DOB, M_CNIC, M_EMAIL, M_ADDRESS, M_JoiningDate, M_USERNAME, M_PASSWORD)
        VALUES (@ID,@fname, @lname, @DOB, @CNIC, @Email, @Address, @startdate, @Username, @Password);";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@ID", ID);
                    command.Parameters.AddWithValue("@FName", fName);
                    command.Parameters.AddWithValue("@LName", lName);
                    command.Parameters.AddWithValue("@DOB", DOB);
                    command.Parameters.AddWithValue("@Email", Email);
                    command.Parameters.AddWithValue("@Address", Address);
                    command.Parameters.AddWithValue("@Username", Username);
                    command.Parameters.AddWithValue("@Password", Password);
                    command.Parameters.AddWithValue("@startdate", startdate);
                    command.Parameters.AddWithValue("@MemType", MemType);
                    command.Parameters.AddWithValue("@gym", gym);
                    command.Parameters.AddWithValue("@goal", goal);
                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        Console.WriteLine("Values inserted into Owner table successfully!");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error inserting values into Owner table: " + ex.Message);
                    }
                }
            }

           
            this.Close();
            LoginPage form1 = new LoginPage(() => this.Show(), "");
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ADD PHONE
            string phone = textBox26.Text;
            string insertQuery = @"
        INSERT INTO MEMBER_CONTACT (M_ID,M_CONTACT)
        VALUES (@ID, @phone);";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@ID", ID);
                    command.Parameters.AddWithValue("@phone", phone);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        Console.WriteLine("Values inserted into MEMBER Contact table successfully!");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error inserting values into MEMBER CONTACT table: " + ex.Message);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //allergens
            //string ID = textBox6.Text;
            string allergyy = comboBox2.Text;
            string insertQuery = @"
        INSERT INTO ALLERGENS (MEMBER_ID,ALLERGY)
        VALUES (@ID, @phone);";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@ID", ID);
                    command.Parameters.AddWithValue("@allergyy", allergyy);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        Console.WriteLine("Values inserted into ALLERGENS table successfully!");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error inserting values into ALLERGENS table: " + ex.Message);
                    }
                }
            }

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Member_Register_Load(object sender, EventArgs e)
        {
            
        }
    }
}
