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
using System.Configuration;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection;

namespace DB_Project
{
    public partial class DietPlanS : UserControl
    {
        public string TrainerID;
        public string MemberID
        {
            get { return comboBox1.Text; }
            set { comboBox1.Text = value; }
        }
        
        private int dietID;
        private string dietPlanName;
        private string day;
        private string breakfast;
        private string lunch;
        private string dinner;
        private string member;
        public event EventHandler Button3ClickedDiet;
        string connectionString = "Server=sql.bsite.net\\MSSQL2016;Database=maryammasood_DatabaseProject2024;User Id=maryammasood_DatabaseProject2024;Password=E#auevEGu9qYHAx;";

        public DietPlanS()
        {
            InitializeComponent();
            this.Width = 1561;
            this.Height = 957;
            button3.Click += Button3_Click;
            showdata();
        }
        public void DataDiet()
        {
            comboBox1.Items.Clear();

            string selectQuery = @"
        SELECT M_ID 
        FROM MEMBER 
        WHERE T_ID = @TrainerID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@TrainerID", TrainerID);

                    try
                    {
                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                comboBox1.Items.Add(reader["M_ID"].ToString());
                            }
                        }
                        else
                        {
                            MessageBox.Show("No members found for the selected trainer.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }

            ///FOOD 
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            comboBox4.Items.Clear();

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
                                comboBox4.Items.Add(reader["FOOD_NAME"].ToString());
                            }
                        }
                        else
                        {
                            MessageBox.Show("No members found for the selected trainer.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }

        }
        public void showdata()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open ();
                SqlDataAdapter adapter= new SqlDataAdapter("select * from DAILY_DIET_PLAN", connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }


        }
        private void Button3_Click(object sender, EventArgs e)
        {
            
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DietPlan_Load(object sender, EventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
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


            dietPlanName = textBox7.Text;
            day = comboBox7.Text;
            member = comboBox1.Text;
            breakfast = comboBox4.Text;
            lunch = comboBox2.Text;
            dinner = comboBox3.Text;
            

            int breakfastId = GetFoodId(breakfast);
            int lunchId = GetFoodId(lunch);
            int dinnerId = GetFoodId(dinner);

            DateTime created = DateTime.Now;

            // SQL query to insert the contact and adminID into the ADMIN_CONTACT table
            string insertQuery = @"
        INSERT INTO DAILY_DIET_PLAN (D_ID, D_NAME,D_DAY,DateCreated,T_ID,M_ID,Breakfast,Lunch,Dinner)
        VALUES (@dietID, @dietPlanName,@day,@created,@TrainerID,@member,@breakfastId,@lunchId,@dinnerId)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    // Add parameters to the command
                    command.Parameters.AddWithValue("@dietID", dietID);
                    command.Parameters.AddWithValue("@dietPlanName", dietPlanName);
                    command.Parameters.AddWithValue("@day", day);
                    command.Parameters.AddWithValue("@created", created);
                    command.Parameters.AddWithValue("@TrainerID", TrainerID);
                    command.Parameters.AddWithValue("@member", DBNull.Value);
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
            UpdateMemberWithDietID(dietID, member);
           
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
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void DietPlanS_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
