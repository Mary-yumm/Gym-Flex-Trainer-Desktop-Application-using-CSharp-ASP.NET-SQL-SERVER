using Database_Project;
using DB_FormLab;
using DB_Project;
using FinalHopefully;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINAL_DB_PROJECT
{
    public partial class Gym_MainPage : Form
    {
        private string username;
        private string password;
        private bool isMaximized = false;
        private Button lastClickedButton; // Track the last clicked button
        string connectionString = "Server=sql.bsite.net\\MSSQL2016;Database=maryammasood_DatabaseProject2024;User Id=maryammasood_DatabaseProject2024;Password=E#auevEGu9qYHAx;";
        private string ownerID;
        private string ownerFName;
        private string ownerLName;
        private string ownerDob;
        private string ownerCNIC;
        private string ownerAddress;
        private string ownerUsername;
        private string ownerPassword;
        private string ownerEmail;
        private string ownerPhone;
        private string joiningDate;
        private string salary;
        private string numGyms;
        private string numTrainers;
        private string numMembers;
        private string gymName;
        private string gymEmail;
        private string gymLoc;
        private string gymID;
        private string trainerID;
        private string addContact;
        public event EventHandler Button6Clicked;
        public event EventHandler Button5Clicked;
        public Gym_MainPage(Action onCloseCallback, string username, string password)
        {
            InitializeComponent();
            this.Width = 1920;
            this.Height = 1080;
            lastClickedButton = null;
            this.BackColor = Color.WhiteSmoke;
            button8.BackColor = Color.LightSlateGray;
            button8.ForeColor = Color.WhiteSmoke;
            lastClickedButton = button8;
            this.onCloseCallback = onCloseCallback;
            this.username = username;
            this.password = password;
            Data();
            g_HomePage1.Button6Clicked += HomePage1_Button6Clicked;
            g_HomePage1.Button5Clicked += HomePage1_Button5Clicked;
        }
        private Action onCloseCallback;
        private void Data()
        {
            string selectQuery = @"
                SELECT * FROM GYM_OWNER 
                WHERE O_USERNAME = @username AND O_Password = @password";

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
                            ownerID = reader["O_ID"].ToString();
                            ownerFName = reader["O_FName"].ToString();
                            ownerLName = reader["O_LName"].ToString();
                            ownerDob = reader["O_DOB"].ToString();
                            dobDateTime = DateTime.Parse(ownerDob);
                            ownerDob = dobDateTime.Date.ToString("yyyy-MM-dd");
                            ownerAddress = reader["O_Address"].ToString();
                            ownerUsername = reader["O_Username"].ToString();
                            ownerPassword = reader["O_Password"].ToString();
                            ownerEmail = reader["O_email"].ToString();
                            joiningDate = reader["O_JoiningDate"].ToString();
                            dobDateTime = DateTime.Parse(joiningDate);
                            joiningDate = dobDateTime.Date.ToString("yyyy-MM-dd");
                            ownerCNIC = reader["O_CNIC"].ToString();
                            salary = reader["O_Salary"].ToString();
                            

                        }
                        else
                        {
                            MessageBox.Show("Owner not found.");
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
                SELECT O_CONTACT FROM OWNER_CONTACT
                WHERE O_ID = @ownerID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(selectQuery3, connection))
                {
                    command.Parameters.AddWithValue("@ownerID", ownerID);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            // Retrieve trainer information from database

                            ownerPhone = reader["O_CONTACT"].ToString();
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

            string selectQuery2 = @"
                SELECT G_ID FROM GYM
                WHERE G_OWNERID = @ownerID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(selectQuery2, connection))
                {
                    command.Parameters.AddWithValue("@ownerID", ownerID);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            gymID = reader["G_ID"].ToString();


                        }
                        else
                        {
                            MessageBox.Show("Owner not found.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }

        }

        private void HomePage1_Button6Clicked(object sender, EventArgs e)
        {
            string contactToAdd = g_HomePage1.AddContact;

            // SQL query to insert the contact and adminID into the ADMIN_CONTACT table
            string insertQuery = @"
        INSERT INTO OWNER_CONTACT (O_ID, O_CONTACT)
        VALUES (@ownerID, @contactToAdd)";

            // Create a connection to the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Create a command to execute the SQL query
                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    // Add parameters to the command
                    command.Parameters.AddWithValue("@ownerID", ownerID);
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

        private void HomePage1_Button5Clicked(object sender, EventArgs e)
        {
            gymID = g_HomePage1.GymID;
            gymName = g_HomePage1.GymName;
            gymEmail = g_HomePage1.GymEmail;
            gymLoc = g_HomePage1.GymLoc;
            DateTime reg_date=DateTime.Now;
            int members = 0;
            int ratings = 5;
            int flag = 1;
            // SQL query to insert the contact and adminID into the ADMIN_CONTACT table
            string insertQuery = @"
        INSERT INTO GYM (G_ID, G_NAME,G_LOCATION,G_EMAIL,G_OWNERID,G_REG_DATE,NO_MEMBERS,G_RATINGS,ACTIVE_FLAG)
        VALUES (@gymID,@gymName,@gymLoc,@gymEmail,@ownerID,@reg_date,@members,@ratings,@flag)";

            // Create a connection to the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Create a command to execute the SQL query
                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    // Add parameters to the command
                    command.Parameters.AddWithValue("@gymID", gymID);
                    command.Parameters.AddWithValue("@gymName", gymName);
                    command.Parameters.AddWithValue("@gymEmail", gymEmail);
                    command.Parameters.AddWithValue("@ownerID", ownerID);
                    command.Parameters.AddWithValue("@gymLoc", gymLoc);
                    command.Parameters.AddWithValue("@reg_date", reg_date);
                    command.Parameters.AddWithValue("@members", members);
                    command.Parameters.AddWithValue("@ratings", ratings);
                    command.Parameters.AddWithValue("@flag", flag);

                    try
                    {
                        // Open the connection
                        connection.Open();

                        // Execute the command
                        int rowsAffected = command.ExecuteNonQuery();

                        // Check if any rows were affected
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Gym added successfully.");
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

        private void Gym_MainPage_Load(object sender, EventArgs e)
        {
            g_HomePage1.OwnerID = ownerID ;
            g_HomePage1.OwnerFName = ownerFName;
            g_HomePage1.OwnerLName = ownerLName;
            g_HomePage1.OwnerDob = ownerDob;
            g_HomePage1.OwnerCNIC = ownerCNIC;
            g_HomePage1.OwnerAddress = ownerAddress;
            g_HomePage1.OwnerUsername = ownerUsername;
            g_HomePage1.OwnerPassword = ownerPassword;
            g_HomePage1.OwnerEmail = ownerEmail;
            g_HomePage1.OwnerPhone = ownerPhone;
            g_HomePage1.JoiningDate = joiningDate;
            g_HomePage1.Salary = salary;
            g_HomePage1.NumGyms = numGyms;
            g_HomePage1.NumTrainers = numTrainers;
            g_HomePage1.NumMembers = numMembers;
            //g_HomePage1.GymName = gymName;
            //g_HomePage1.GymEmail = gymEmail;
            //g_HomePage1.GymLoc = gymLoc;
          
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        bool menuexpand = true;


        private void menuTransition_Tick_1(object sender, EventArgs e)
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

  

        private void button8_Click_1(object sender, EventArgs e)
        {
            //Home
            g_HomePage1.Show();
            g_HomePage1.BringToFront();
            
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
            label1.Text = "Gym Profile";
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            //cross button
            AAPPMAINPAGE mainPage = new AAPPMAINPAGE(() => { });
            mainPage.Show();

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Members List 
            memberListUserControl1.Gym_ID = gymID;
            memberListUserControl1.Trainer_ID = trainerID;
            memberListUserControl1.Show();
            memberListUserControl1.BringToFront();
            memberListUserControl1.type = "gym";
            if (memberListUserControl1.type == "gym")
                memberListUserControl1.MembersList2();
            else
            memberListUserControl1.MembersList();
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
            label1.Text = "Members List";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // trainers List
            trainerListUserControl1.GymID = gymID;
            trainerListUserControl1.Show();
            trainerListUserControl1.BringToFront();
            trainerListUserControl1.TrainersList();
            trainerListUserControl1.TrainersList();

            // Reset the appearance of the previously clicked button
            if (lastClickedButton != null)
            {
                lastClickedButton.BackColor = Color.DarkSlateGray;
                lastClickedButton.ForeColor = Color.WhiteSmoke;
            }

            // Change the appearance of the current button
            button1.BackColor = Color.LightSlateGray;
            button1.ForeColor = Color.WhiteSmoke;
            lastClickedButton = button1;
            label1.Text = "Trainers List";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Gym Progress
            gymReportUserControl1.Show();
            gymReportUserControl1.BringToFront();
            // Reset the appearance of the previously clicked button
            if (lastClickedButton != null)
            {
                lastClickedButton.BackColor = Color.DarkSlateGray;
                lastClickedButton.ForeColor = Color.WhiteSmoke;
            }

            label1.Text = "Gym Progress";
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
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

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            if (!menuTransition.Enabled)
            {
                menuTransition.Start();
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void g_HomePage1_Load(object sender, EventArgs e)
        {

        }
    }
}
