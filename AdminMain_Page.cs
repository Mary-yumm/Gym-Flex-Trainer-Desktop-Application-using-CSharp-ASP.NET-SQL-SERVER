using DB_FormLab;
using FinalHopefully;
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

namespace FINAL_DB_PROJECT
{
    public partial class AdminMain_Page : Form
    {
        private string username;
        private string password;
        private bool isMaximized = false;
        private Button lastClickedButton; // Track the last clicked button
        string connectionString = "Server=sql.bsite.net\\MSSQL2016;Database=maryammasood_DatabaseProject2024;User Id=maryammasood_DatabaseProject2024;Password=E#auevEGu9qYHAx;";
        private string adminID;
        private string adminFName;
        private string adminLName;
        private string adminDob;
        private string role;
        private string adminAddress;
        private string adminUsername;
        private string adminPassword;
        private string adminEmail;
        private string adminPhone;
        private string joiningDate;
        private string salary;
        private string addContact;
        public event EventHandler Button1Clicked;

        public AdminMain_Page(Action onCloseCallback, string username, string password)
        {
            InitializeComponent();
            this.Width = 1920;
            this.Height = 1080;
            lastClickedButton = null;
            button8.BackColor = Color.LightSlateGray;
            button8.ForeColor = Color.WhiteSmoke;
            lastClickedButton = button8;
            this.onCloseCallback = onCloseCallback;
            this.username = username;
            this.password = password;
            Data();
            a_HomePage1.Button1Clicked += HomePage1_Button1Clicked;
            panel1.Focus();

        }
        private Action onCloseCallback;
        private void HomePage1_Button1Clicked(object sender, EventArgs e)
        {
            string contactToAdd = a_HomePage1.AddContact;

            // SQL query to insert the contact and adminID into the ADMIN_CONTACT table
            string insertQuery = @"
        INSERT INTO ADMIN_CONTACT (A_ID, A_CONTACT)
        VALUES (@adminID, @contactToAdd)";

            // Create a connection to the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Create a command to execute the SQL query
                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    // Add parameters to the command
                    command.Parameters.AddWithValue("@adminID", adminID);
                    command.Parameters.AddWithValue("@contactToAdd", contactToAdd);

                    try
                    {
                        // Open the connection
                        connection.Open();

                        // Execute the command
                        int rowsAffected = command.ExecuteNonQuery();

                        // Check if any rows were affected
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Contact added successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to add contact.");
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle any exceptions
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }

        }
        private void Data()
        {
            string selectQuery = @"
                SELECT * FROM ADMIN 
                WHERE A_USERNAME = @username AND A_Password = @password";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    DateTime dobDateTime;
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            // Retrieve trainer information from database
                            adminID = reader["A_ID"].ToString();
                            adminFName = reader["A_FName"].ToString();
                            adminLName = reader["A_LName"].ToString();
                            adminDob = reader["A_DOB"].ToString();
                            dobDateTime = DateTime.Parse(adminDob);
                            adminDob = dobDateTime.Date.ToString("yyyy-MM-dd");
                            adminAddress = reader["A_Address"].ToString();
                            adminUsername = reader["A_Username"].ToString();
                            adminPassword = reader["A_Password"].ToString();
                            adminEmail = reader["A_email"].ToString();
                            joiningDate = reader["A_StartDate"].ToString();
                            dobDateTime = DateTime.Parse(joiningDate);
                            joiningDate = dobDateTime.Date.ToString("yyyy-MM-dd");
                            role = reader["A_Role"].ToString();
                            salary = reader["A_Salary"].ToString();


                        }
                        else
                        {
                            MessageBox.Show("Admin not found.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }



            //from contact table
            string selectQuery3 = @"
                SELECT A_CONTACT FROM ADMIN_CONTACT
                WHERE A_ID = @adminID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(selectQuery3, connection))
                {
                    command.Parameters.AddWithValue("@adminID", adminID);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            // Retrieve trainer information from database

                            adminPhone = reader["A_CONTACT"].ToString();
                        }
                        //else
                        //{
                        //    MessageBox.Show("Contact not found.");
                        //}
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }

        }


        private void Admin_MainPage_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //cross button
            AAPPMAINPAGE mainPage = new AAPPMAINPAGE(() => { });
            mainPage.Show();

            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (!menuTransition.Enabled)
            {
                menuTransition.Start();
            }
        }
        bool menuexpand = true;
        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuexpand)
            {
                flowLayoutPanel1.Width -= 10;
                if (flowLayoutPanel1.Width <= 60)
                {
                    menuTransition.Stop();
                    menuexpand = false;
                }
            }
            else
            {
                flowLayoutPanel1.Width += 10;
                if (flowLayoutPanel1.Width >= 230)
                {
                    menuTransition.Stop();
                    menuexpand = true;
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Home
            a_HomePage1.Show();
            a_HomePage1.BringToFront();

            // Reset the appearance of the previously clicked button
            if (lastClickedButton != null)
            {
                lastClickedButton.BackColor = Color.DarkSlateGray;
                lastClickedButton.ForeColor = Color.WhiteSmoke;
            }

            // Change the appearance of the current button
            button8.BackColor = Color.LightSlateGray;
            button8.ForeColor = Color.WhiteSmoke;
            lastClickedButton = button8;
            label1.Text = "Admin Profile";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //report button
            //queryReport2.Show();
            //queryReport2.BringToFront();
            reportQuery1.Show();
            reportQuery1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Gyms List
            A_GymList.Show();
            A_GymList.BringToFront();
           // A_GymList.Gymid = gym

            // Reset the appearance of the previously clicked button
            if (lastClickedButton != null)
            {
                lastClickedButton.BackColor = Color.DarkSlateGray;
                lastClickedButton.ForeColor = Color.WhiteSmoke;
            }

            // Change the appearance of the current button
            button2.BackColor = Color.LightSlateGray;
            button2.ForeColor = Color.WhiteSmoke;
            lastClickedButton = button2;
            label1.Text = "Gyms List";
        }

        private void a_HomePage1_Load(object sender, EventArgs e)
        {
            a_HomePage1.AdminID = adminID;
            a_HomePage1.AdminFName = adminFName;
            a_HomePage1.AdminLName = adminLName;
            a_HomePage1.AdminDob = adminDob;
            a_HomePage1.Role = role;
            a_HomePage1.AdminAddress = adminAddress;
            a_HomePage1.AdminUsername = adminUsername;
            a_HomePage1.AdminPassword = adminPassword;
            a_HomePage1.AdminEmail = adminEmail;
            a_HomePage1.AdminPhone = adminPhone;
            a_HomePage1.JoiningDate = joiningDate;
            a_HomePage1.Salary = salary;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Gyms List
            A_GymList.Show();
            A_GymList.BringToFront();

            // Reset the appearance of the previously clicked button
            if (lastClickedButton != null)
            {
                lastClickedButton.BackColor = Color.DarkSlateGray;
                lastClickedButton.ForeColor = Color.WhiteSmoke;
            }

            // Change the appearance of the current button
            button2.BackColor = Color.LightSlateGray;
            button2.ForeColor = Color.WhiteSmoke;
            lastClickedButton = button2;
            label1.Text = "Gyms List";
        }

        private void queryReport1_Load(object sender, EventArgs e)
        {

        }

        private void A_GymList_Load(object sender, EventArgs e)
        {

        }
    }
}
