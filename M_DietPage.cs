using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DB_Project
{
    public partial class M_DietPage : UserControl
    {
        private string dietID;
        private string dietPlanName;
        private string day;
        private string breakfast;
        private string lunch;
        private string dinner;
        private string member;
        public string MemberID;
        string connectionString = "Server=sql.bsite.net\\MSSQL2016;Database=maryammasood_DatabaseProject2024;User Id=maryammasood_DatabaseProject2024;Password=E#auevEGu9qYHAx;";

        public M_DietPage()
        {
            InitializeComponent();
            this.Width = 1561;
            this.Height = 957;
        }
        public void DataDiet()
        {
            

            ///FOOD 
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            comboBox1.Items.Clear();

            string selectQuery2 = @"
        SELECT FOOD_NAME 
        FROM FOOD ";

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
                                comboBox2.Items.Add(reader["FOOD_NAME"].ToString());
                                comboBox3.Items.Add(reader["FOOD_NAME"].ToString());
                                comboBox1.Items.Add(reader["FOOD_NAME"].ToString());
                            }
                        }
                        else
                        {
                            MessageBox.Show("No food found.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }

        }


        public void FetchDietDetailsFromMember(string memberId)
        {
            string dietId = FetchDietIdFromMember(memberId);

            if (!string.IsNullOrEmpty(dietId))
            {
                string day = FetchDayFromDailyDietPlan(dietId);
                textBox14.Text = day;

                if (!string.IsNullOrEmpty(day))
                {
                    string breakfastId, lunchId, dinnerId;
                    FetchMealIdsFromDailyDietPlan(dietId, out breakfastId, out lunchId, out dinnerId);

                    string breakfastName = FetchFoodName(breakfastId);
                    string lunchName = FetchFoodName(lunchId);
                    string dinnerName = FetchFoodName(dinnerId);
                    textBox5.Text=breakfastName;
                    textBox8.Text = lunchName;
                    textBox9.Text=dinnerName;

                }
                else
                {
                    MessageBox.Show("Day not found in DAILY_DIET_PLAN table for the given D_ID.");
                }
            }
            else
            {
                MessageBox.Show("Diet ID not found in MEMBER table for the given member ID.");
            }
        }

        private string FetchDietIdFromMember(string memberId)
        {
            string dietId = null;
            string query = "SELECT D_ID FROM MEMBER WHERE M_ID = @memberId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@memberId", memberId);
                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            dietId = result.ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error fetching diet ID: " + ex.Message);
                    }
                }
            }

            return dietId;
        }

        private string FetchDayFromDailyDietPlan(string dietId)
        {
            string day = null;
            string query = "SELECT D_DAY FROM DAILY_DIET_PLAN WHERE D_ID = @dietId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@dietId", dietId);
                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            day = result.ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error fetching day: " + ex.Message);
                    }
                }
            }

            return day;
        }

        private void FetchMealIdsFromDailyDietPlan(string dietId, out string breakfastId, out string lunchId, out string dinnerId)
        {
            breakfastId = lunchId = dinnerId = null;
            string query = "SELECT BREAKFAST, LUNCH, DINNER FROM DAILY_DIET_PLAN WHERE D_ID = @dietId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@dietId", dietId);
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                breakfastId = reader["BREAKFAST"].ToString();
                                lunchId = reader["LUNCH"].ToString();
                                dinnerId = reader["DINNER"].ToString();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error fetching meal IDs: " + ex.Message);
                    }
                }
            }
        }

        private string FetchFoodName(string foodId)
        {
            string foodName = null;
            string query = "SELECT FOOD_NAME FROM FOOD WHERE F_ID = @foodId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@foodId", foodId);
                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            foodName = result.ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error fetching food name: " + ex.Message);
                    }
                }
            }

            return foodName;
        }


        private void UpdateMemberWithDietID(int dietID, string memberID)
        {
            string updateQuery = @"
        UPDATE MEMBER
        SET D_ID = @dietID
        WHERE M_ID = @memberID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@dietID", dietID);
                    command.Parameters.AddWithValue("@memberID", memberID);

                    try
                    {
                        connection.Open();

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Diet ID updated successfully for the member.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to update member with diet ID.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
        private int GetFoodId(string foodName)
        {
            int foodId = 0;

            string searchQuery = @"SELECT F_ID FROM FOOD WHERE FOOD_NAME = @foodName";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(searchQuery, connection))
                {
                    command.Parameters.AddWithValue("@foodName", foodName);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            foodId = Convert.ToInt32(result);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }

            return foodId;

        }
        private void DietPlanMember_Load(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void M_DietPage_Load(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // When Create is pressed 
            DateTime dateTime = DateTime.Now;

            string getLastIdQuery = "SELECT TOP 1 D_ID FROM DAILY_DIET_PLAN ORDER BY D_ID DESC";

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
            int dietID = lastId + 1;


            dietPlanName = textBox3.Text;
            day = comboBox5.Text;
            breakfast = comboBox1.Text;
            lunch = comboBox2.Text;
            dinner = comboBox3.Text;


            int breakfastId = GetFoodId(breakfast);
            int lunchId = GetFoodId(lunch);
            int dinnerId = GetFoodId(dinner);

            DateTime created = DateTime.Now;

            // SQL query to insert the contact and adminID into the ADMIN_CONTACT table
            string insertQuery = @"
        INSERT INTO DAILY_DIET_PLAN (D_ID, D_NAME,D_DAY,DateCreated,T_ID,M_ID,Breakfast,Lunch,Dinner)
        VALUES (@dietID, @dietPlanName,@day,@created,@TrainerID,@MemberID,@breakfastId,@lunchId,@dinnerId)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    // Add parameters to the command
                    command.Parameters.AddWithValue("@dietID", dietID);
                    command.Parameters.AddWithValue("@dietPlanName", dietPlanName);
                    command.Parameters.AddWithValue("@day", day);
                    command.Parameters.AddWithValue("@created", created);
                    command.Parameters.AddWithValue("@TrainerID", DBNull.Value);
                    command.Parameters.AddWithValue("@MemberID", MemberID);
                    command.Parameters.AddWithValue("@breakfastId", breakfastId);
                    command.Parameters.AddWithValue("@lunchId", lunchId);
                    command.Parameters.AddWithValue("@dinnerId", dinnerId);

                    try
                    {
                        connection.Open();

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Diet Plan added successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to add contact.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            UpdateMemberWithDietID(dietID, MemberID);

        }
    }
}
