using DB_Project;
using FINAL_DB_PROJECT;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace DB_FormLab
{
    public partial class LoginPage : Form
    {
        string button_text;
        public bool focus_Set;
        public LoginPage(Action onCloseCallback, string buttonText)
        {
            InitializeComponent();
            focus_Set = true;
            this.Width = 1920;
            this.Height = 1080;
            this.onCloseCallback = onCloseCallback;
            this.button_text = buttonText;
            textBox1.Text = "Enter Password"; // Set default text
            textBox2.Text = "Enter Username";
            textBox1.GotFocus += TextBox1_GotFocus; // Add event handler for GotFocus
            textBox1.TextChanged += textBox1_TextChanged;
            textBox2.GotFocus += TextBox2_GotFocus;
            textBox2.LostFocus += TextBox2_LostFocus;
        }
        private Action onCloseCallback;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Set PasswordChar to '*' when the user starts typing
            textBox1.PasswordChar = '*';
        }
        private void TextBox1_GotFocus(object sender, EventArgs e)
        {
            // Clear default text when TextBox receives focus
            if (focus_Set)
            {
                focus_Set = false;
                label1.Focus();
            }
            else if (textBox1.Text == "Enter Password")
            {
                textBox1.Text = "";
            }
        }
        private void TextBox2_GotFocus(object sender, EventArgs e)
        {
            // Clear default text when TextBox receives focus
            if (textBox2.Text == "Enter Username")
            {
                textBox2.Text = "";
            }
        }

        private void TextBox2_LostFocus(object sender, EventArgs e)
        {
            if (textBox2.Text != null && string.IsNullOrWhiteSpace(textBox2.Text))
            {
                textBox2.Text = "Enter Username";
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {


        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("I don't care!");
        }

   

        private void textBox2_Click(object sender, EventArgs e)
        {
            // Clear the default text when the TextBox receives focus
            textBox2.Text = "";
        }


        private void textBox1_Click(object sender, EventArgs e)
        {
            // Clear the default text when the TextBox receives focus
            textBox1.Text = "";
            textBox1.PasswordChar = '*';
        }

   

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Cross button
            AAPPMAINPAGE mainPage = new AAPPMAINPAGE(() => { });
            mainPage.Show();

            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Close the login form
            string connectionString = "Server=sql.bsite.net\\MSSQL2016;Database=maryammasood_DatabaseProject2024;User Id=maryammasood_DatabaseProject2024;Password=E#auevEGu9qYHAx;";
            string Username = textBox2.Text;
            string Password = textBox1.Text;

            if (this.button_text == "Admin")
            {
                string selectQuery = @"
            SELECT A_USERNAME, A_PASSWORD FROM ADMIN 
            WHERE A_USERNAME = @Username AND A_PASSWORD = @Password;";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Username", Username);
                        command.Parameters.AddWithValue("@Password", Password);

                        try
                        {
                            connection.Open();
                            SqlDataReader reader = command.ExecuteReader();
                            if (reader.Read())
                            {
                                // Login successful, get the username and password
                                string username = reader["A_USERNAME"].ToString();
                                string password = reader["A_PASSWORD"].ToString();

                                AdminMain_Page admin = new AdminMain_Page(() => this.Show(), username, password);
                                admin.Show();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Incorrect username or password!");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                }
            }
            else if (this.button_text == "Owner")
            {

                string selectQuery = @"
            SELECT O_USERNAME, O_PASSWORD FROM GYM_OWNER 
            WHERE O_USERNAME = @Username AND O_PASSWORD = @Password;";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Username", Username);
                        command.Parameters.AddWithValue("@Password", Password);

                        try
                        {
                            connection.Open();
                            SqlDataReader reader = command.ExecuteReader();
                            if (reader.Read())
                            {
                                // Login successful, get the username and password
                                string username = reader["O_USERNAME"].ToString();
                                string password = reader["O_PASSWORD"].ToString();

                                Gym_MainPage owner = new Gym_MainPage(() => this.Show(), username, password);
                                owner.Show();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Incorrect username or password!");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                }
            }
            else if (this.button_text == "Trainer")
            {

                string selectQuery = @"
        SELECT T_USERNAME, T_PASSWORD FROM TRAINER 
        WHERE T_USERNAME = @Username AND T_PASSWORD = @Password;";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Username", Username);
                        command.Parameters.AddWithValue("@Password", Password);

                        try
                        {
                            connection.Open();
                            SqlDataReader reader = command.ExecuteReader();
                            if (reader.Read())
                            {
                                string trainerUsername = reader["T_USERNAME"].ToString();
                                string trainerPassword = reader["T_PASSWORD"].ToString();

                                Trainer_MainPage trainer = new Trainer_MainPage(() => this.Show(), trainerUsername, trainerPassword);
                                trainer.Show();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Incorrect username or password!");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                }
            }
            else if (this.button_text == "Member")
            {

                string selectQuery = @"
            SELECT M_USERNAME, M_PASSWORD FROM MEMBER 
            WHERE M_USERNAME = @Username AND M_PASSWORD = @Password;";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Username", Username);
                        command.Parameters.AddWithValue("@Password", Password);

                        try
                        {
                            connection.Open();
                            SqlDataReader reader = command.ExecuteReader();
                            if (reader.Read())
                            {
                                // Login successful, get the username and password
                                string username = reader["M_USERNAME"].ToString();
                                string password = reader["M_PASSWORD"].ToString();

                                Member_MainPage mem = new Member_MainPage(() => this.Show(), username, password);
                                mem.Show();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Incorrect username or password!");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                }
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Hide the current form
            this.Close();
            if (button_text == "Admin")
            {
                Admin_Register register = new Admin_Register(()=>this.Show());
                register.Show();
            }
            else if(button_text == "Owner")
            {
                GymOwner_Register register = new GymOwner_Register(() => this.Show());
                register.Show();

            }
            else if (button_text == "Trainer")
            {
                Trainer_Register register = new Trainer_Register(() => this.Show());
                register.Show();

            }
            else if (button_text == "Member")
            {
                Member_Register register = new Member_Register(() => this.Show());
                register.Show();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            // Hide the current form
            this.Close();

            SignupPage signupPage = new SignupPage(() => this.Show());

            signupPage.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
