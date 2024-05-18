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

namespace DB_Project
{
    public partial class Member_MainPage : Form
    {
        private bool isMaximized = false;
        private Button lastClickedButton; // Track the last clicked button
        private string username;
        private string password;
        string connectionString = "Server=sql.bsite.net\\MSSQL2016;Database=maryammasood_DatabaseProject2024;User Id=maryammasood_DatabaseProject2024;Password=E#auevEGu9qYHAx;";
        private string memberID;
        private string memberFName;
        private string memberLName;
        private string memberDob;
        private string memberAddress;
        private string memberUsername;
        private string memberPassword;
        private string memberEmail;
        private string memberPhone;
        private string memberGoal;
        private string membershipType;
        private string gymID;
        private string gymName;
        private string gymLoc;
        private string workoutID;
        private string workoutName;
        private string trainerID;
        private string trainerName;
        private string dietPlanID;
        private string dietPlanName;
        private string memberStartDate;
        public Member_MainPage(Action onCloseCallback, string username, string password)
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

        }
        private Action onCloseCallback;
        private void Data()
        {
            string selectQuery = @"
                SELECT * FROM MEMBER 
                WHERE M_USERNAME = @username AND M_Password = @password";

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
                            memberID = reader["M_ID"].ToString();
                            memberFName = reader["M_FName"].ToString();
                            memberLName = reader["M_LName"].ToString();
                            memberDob = reader["M_DOB"].ToString();
                            dobDateTime = DateTime.Parse(memberDob);
                            memberDob = dobDateTime.Date.ToString("yyyy-MM-dd");
                            memberAddress = reader["M_Address"].ToString();
                            memberUsername = reader["M_Username"].ToString();
                            memberPassword = reader["M_Password"].ToString();
                            memberEmail = reader["M_email"].ToString();
                            memberGoal = reader["M_goal"].ToString();
                            membershipType = reader["M_Membership_Type"].ToString();
                            memberStartDate = reader["W_Start_Date"].ToString();
                            dobDateTime = DateTime.Parse(memberStartDate);
                            memberStartDate = dobDateTime.Date.ToString("yyyy-MM-dd");

                            gymID = reader["G_ID"].ToString();
                            workoutID = reader["W_ID"].ToString();
                            trainerID = reader["T_ID"].ToString();
                            dietPlanID = reader["D_ID"].ToString();

                        }
                        else
                        {
                            MessageBox.Show("Member not found.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }

            //from GYM table
            string selectQuery2 = @"
                SELECT G_NAME,G_LOCATION FROM GYM 
                WHERE G_ID = @gymID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(selectQuery2, connection))
                {
                    command.Parameters.AddWithValue("@gymID", gymID);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            // Retrieve trainer information from database
                            gymName = reader["G_Name"].ToString();
                            gymLoc = reader["G_Location"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Member not found.");
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
                SELECT M_CONTACT FROM MEMBER_CONTACT
                WHERE M_ID = @memberID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(selectQuery3, connection))
                {
                    command.Parameters.AddWithValue("@memberID", memberID);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            // Retrieve trainer information from database

                            memberPhone = reader["M_CONTACT"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Member not found.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            //from WORKOUT table
            string selectQuery4 = @"
                SELECT W_NAME,W_ID FROM WORKOUT_PLAN
                WHERE W_ID = @workoutID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(selectQuery4, connection))
                {
                    command.Parameters.AddWithValue("@workoutID", workoutID);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            // Retrieve trainer information from database
                            workoutName = reader["W_NAME"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Workout not found.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }

            //from Trainer's table
            string selectQuery5 = @"
                SELECT T_FNAME,T_LNAME, T_ID FROM TRAINER
                WHERE T_ID = @trainerID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(selectQuery5, connection))
                {
                    command.Parameters.AddWithValue("@trainerID", trainerID);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            // Retrieve trainer information from database
                            trainerName = reader["T_FNAME"].ToString();
                            trainerName += " ";
                            trainerName += reader["T_LNAME"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Trainer not found.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }

            //from Diet Plan table
            string selectQuery6 = @"
                SELECT D_NAME,D_ID FROM DAILY_DIET_PLAN
                WHERE D_ID = @dietPlanID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(selectQuery6, connection))
                {
                    command.Parameters.AddWithValue("@dietPlanID", dietPlanID);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            // Retrieve trainer information from database
                            dietPlanName = reader["D_NAME"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Diet plan not found.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void m_HomePage1_Load(object sender, EventArgs e)
        {
            m_HomePage1.MemberAddress = memberAddress;
            m_HomePage1.MemberDob= memberDob;
            m_HomePage1.MemberEmail = memberEmail;
            m_HomePage1.MemberFName = memberFName;
            m_HomePage1.MemberLName = memberLName;
            m_HomePage1.MembershipType = membershipType;
            m_HomePage1.MemberPassword = memberPassword;
            m_HomePage1.MemberPhone = memberPhone;
            m_HomePage1.MemberStartDate = memberStartDate;
            m_HomePage1.MemberUsername = memberUsername;
            m_HomePage1.MemberID = memberID;
            m_HomePage1.MemberGoal = memberGoal;

            m_HomePage1.TrainerID = trainerID;
            m_HomePage1.TrainerName = trainerName;
            m_HomePage1.DietPlanID = dietPlanID;
            m_HomePage1.DietPlanName = dietPlanName;
            m_HomePage1.WorkoutID = workoutID;
            m_HomePage1.WorkoutName = workoutName;
            m_HomePage1.GymID = gymID;
            m_HomePage1.GymName = gymName;
            m_HomePage1.GymLoc= gymLoc;

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
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (!menuTransition.Enabled)
            {
                menuTransition.Start();
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //cross button
            AAPPMAINPAGE mainPage = new AAPPMAINPAGE(() => { });
            mainPage.Show();

            this.Close();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }


        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            if (isMaximized)
            {
                this.WindowState = FormWindowState.Normal;
                isMaximized = false;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                isMaximized = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Diet Plan
            m_DietPage1.Show();
            m_DietPage1.BringToFront();
            m_DietPage1.MemberID = memberID;
            m_DietPage1.DataDiet();
            m_DietPage1.FetchDietDetailsFromMember(memberID);


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
            label1.Text = "Diet Plan";

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            // workout plan 
            m_WorkoutPlan1.Show();
            m_WorkoutPlan1.BringToFront();
            m_WorkoutPlan1.memberid = memberID;
            m_WorkoutPlan1.type = "member";
            if (m_WorkoutPlan1.type == "trainer")
            {

            }
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
            label1.Text = "Workout Plan";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            // Booking Page
            m_BookingPage1.Show();
            m_BookingPage1.BringToFront();
            m_BookingPage1.DataTrainer();
            m_BookingPage1.Member_ID= memberID;
            // Reset the appearance of the previously clicked button
            if (lastClickedButton != null)
            {
                lastClickedButton.BackColor = Color.DarkSlateGray;
                lastClickedButton.ForeColor = Color.WhiteSmoke;
            }

            // Change the appearance of the current button
            button3.BackColor = Color.LightSlateGray;
            button3.ForeColor = Color.WhiteSmoke;
            lastClickedButton = button3;
            label1.Text = "Bookings Page";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Feedback
            m_Feedback1.Show();
            m_Feedback1.BringToFront();
            m_Feedback1.Memberid = memberID;
            m_Feedback1.Trainerid = trainerID;
            // Reset the appearance of the previously clicked button
            if (lastClickedButton != null)
            {
                lastClickedButton.BackColor = Color.DarkSlateGray;
                lastClickedButton.ForeColor = Color.WhiteSmoke;
            }

            // Change the appearance of the current button
            button6.BackColor = Color.LightSlateGray;
            button6.ForeColor = Color.WhiteSmoke;
            lastClickedButton = button6;
            label1.Text = "Feedback";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            //Progress Report

            m_Report1.Show();
            m_Report1.BringToFront();
            // Reset the appearance of the previously clicked button
            if (lastClickedButton != null)
            {
                lastClickedButton.BackColor = Color.DarkSlateGray;
                lastClickedButton.ForeColor = Color.WhiteSmoke;
            }

            // Change the appearance of the current button
          
            label1.Text = "Progress Report";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Home
            m_HomePage1.Show();
            m_HomePage1.BringToFront();
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
            label1.Text = "Member Profile";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //cross button
            AAPPMAINPAGE mainPage = new AAPPMAINPAGE(() => { });
            mainPage.Show();

            this.Close();
        }


    }
}
