using FINAL_DB_PROJECT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_FormLab
{
    public partial class M_WorkoutPlan : UserControl
    {
        string connectionString = "Server=sql.bsite.net\\MSSQL2016;Database=maryammasood_DatabaseProject2024;User Id=maryammasood_DatabaseProject2024;Password=E#auevEGu9qYHAx;";
        public string type;
        int workOutID;
        public string memberid;
        int WorkoutID;
        public string Trainerid;
        public M_WorkoutPlan()
        {
            InitializeComponent();
            this.Width = 1561;
            this.Height = 957;
            showdata();
        }
        public void showdata()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("select * from WORKOUT_PLAN", connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
        public void Data1()
        {


        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void M_WorkoutPlan_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // create
            string name = textBox4.Text;
            string goal = comboBox2.Text;
            string level = comboBox3.Text;
            string duration = comboBox6.Text;
            string daysPerWeek = comboBox5.Text;
            string gender = comboBox4.Text;
            string timePerWorkout = comboBox9.Text;
            string exercise = comboBox8.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Open the connection
                if (type != "trainer")
                {
                    connection.Open();

                    // Step 1: Retrieve the last W_ID from the WORKOUT_PLAN table
                    string selectLastIDQuery = "SELECT MAX(W_ID) FROM WORKOUT_PLAN";
                    SqlCommand command = new SqlCommand(selectLastIDQuery, connection);
                    int lastID = Convert.ToInt32(command.ExecuteScalar());

                    // Step 2: Increment the last W_ID to get the next available W_ID
                    int nextID = lastID + 1;

                    // Step 3: Use the current date for W_DATE_CREATED
                    DateTime dateCreated = DateTime.Now;

                    // Step 4: Set TRAINER_ID to NULL
                    int? trainerID = null;

                    // SQL query to insert data into the WORKOUT_PLAN table
                    string insertQuery = @"
            INSERT INTO WORKOUT_PLAN (W_ID, W_NAME, W_GOAL, W_LEVEL, W_DURATION, W_TARGET_GENDER, W_DATE_CREATED, DAYS_PER_WEEK, TRAINER_ID, MEMBER_ID)
            VALUES (@id, @name, @goal, @level, @duration, @gender, @dateCreated, @daysPerWeek, @trainerID, @memberid)";

                    // Create a command to execute the SQL query
                    command = new SqlCommand(insertQuery, connection);

                    // Add parameters to the command
                    command.Parameters.AddWithValue("@id", nextID);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@goal", goal);
                    command.Parameters.AddWithValue("@level", level);
                    command.Parameters.AddWithValue("@duration", duration);
                    command.Parameters.AddWithValue("@gender", gender);
                    command.Parameters.AddWithValue("@dateCreated", dateCreated);
                    command.Parameters.AddWithValue("@daysPerWeek", daysPerWeek);
                    command.Parameters.AddWithValue("@trainerID", (object)trainerID ?? DBNull.Value);
                    command.Parameters.AddWithValue("@memberid", memberid);

                    try
                    {
                        // Execute the command
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Workout plan created successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to create workout plan.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
                else
                {
                    connection.Open();

                    // Step 1: Retrieve the last W_ID from the WORKOUT_PLAN table
                    string selectLastIDQuery = "SELECT MAX(W_ID) FROM WORKOUT_PLAN";
                    SqlCommand command = new SqlCommand(selectLastIDQuery, connection);
                    int lastID = Convert.ToInt32(command.ExecuteScalar());

                    // Step 2: Increment the last W_ID to get the next available W_ID
                    int nextID = lastID + 1;

                    // Step 3: Use the current date for W_DATE_CREATED
                    DateTime dateCreated = DateTime.Now;

                    // Step 4: Set TRAINER_ID to NULL
                    int? trainerID = null;

                    // SQL query to insert data into the WORKOUT_PLAN table
                    string insertQuery = @"
            INSERT INTO WORKOUT_PLAN (W_ID, W_NAME, W_GOAL, W_LEVEL, W_DURATION, W_TARGET_GENDER, W_DATE_CREATED, DAYS_PER_WEEK, TRAINER_ID, MEMBER_ID)
            VALUES (@id, @name, @goal, @level, @duration, @gender, @dateCreated, @daysPerWeek, @Trainerid, @trainerID)";

                    // Create a command to execute the SQL query
                    command = new SqlCommand(insertQuery, connection);

                    // Add parameters to the command
                    command.Parameters.AddWithValue("@id", nextID);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@goal", goal);
                    command.Parameters.AddWithValue("@level", level);
                    command.Parameters.AddWithValue("@duration", duration);
                    command.Parameters.AddWithValue("@gender", gender);
                    command.Parameters.AddWithValue("@dateCreated", dateCreated);
                    command.Parameters.AddWithValue("@daysPerWeek", daysPerWeek);
                    command.Parameters.AddWithValue("@trainerID", (object)trainerID ?? DBNull.Value);
                    command.Parameters.AddWithValue("@memberid", memberid);

                    try
                    {
                        // Execute the command
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Workout plan created successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to create workout plan.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            
            
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //add exercise

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int workoutID = workOutID; // Method to get workout ID
            string memberID = memberid; // Method to get member ID

            // SQL query to insert data into the WORKOUTEXERCISE table
            string insertQuery = @"
        INSERT INTO WORKOUTEXERCISE (W_ID, E_ID)
        VALUES (@workoutID, @memberID)";

            // Create a connection to the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Create a command to execute the SQL query
                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    // Add parameters to the command
                    command.Parameters.AddWithValue("@workoutID", workoutID);
                    command.Parameters.AddWithValue("@memberID", memberID);

                    try
                    {
                        connection.Open();

                        // Execute the command
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Workout exercise stored successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to store workout exercise.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                WorkoutID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //
            if (WorkoutID != 0)
            {
                string updateQuery = @"
            UPDATE MEMBER
            SET W_ID = @WorkoutID
            WHERE M_ID = @memberid";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        // Add parameters to the command
                        command.Parameters.AddWithValue("@WorkoutID", WorkoutID);
                        command.Parameters.AddWithValue("@memberid", memberid);

                        try
                        {
                            connection.Open();

                            // Execute the command
                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Workout ID stored in MEMBER table successfully.");
                            }
                            else
                            {
                                MessageBox.Show("Failed to store Workout ID in MEMBER table.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a Workout ID.");
            }

        }
    }

        
    }

