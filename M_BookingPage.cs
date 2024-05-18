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

namespace DB_FormLab
{
    public partial class M_BookingPage : UserControl
    {
        string connectionString = "Server=sql.bsite.net\\MSSQL2016;Database=maryammasood_DatabaseProject2024;User Id=maryammasood_DatabaseProject2024;Password=E#auevEGu9qYHAx;";
        public string Member_ID;
        public M_BookingPage()
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
                SqlDataAdapter adapter = new SqlDataAdapter("select * from Booking", connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        public void DataTrainer()
        {
            //add trainers
            string query = "SELECT T_ID FROM TRAINER";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string trainerID = reader["T_ID"].ToString();
                                comboBox1.Items.Add(trainerID);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error fetching trainer IDs: " + ex.Message);
                    }
                }
            }
        }
        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void M_BookingPage_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           DateTime date= dateTimePicker4.Value;
           string time =  comboBox2.Text;
           string duration =   comboBox3.Text;
            string trainer = comboBox1.Text;

            int bookingId = GenerateBookingId(connectionString);

            // SQL query
            string query = "INSERT INTO BOOKING (B_ID, Datee, StartTime, Duration, T_ID, M_ID) VALUES (@bookingId, @date, @time, @duration, @trainer, @Member_ID)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@bookingId", bookingId);
                command.Parameters.AddWithValue("@date", date);
                command.Parameters.AddWithValue("@time", time);
                command.Parameters.AddWithValue("@duration", duration);
                command.Parameters.AddWithValue("@trainer", comboBox1.Text); 
                command.Parameters.AddWithValue("@Member_ID", Member_ID);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    MessageBox.Show("Booking has been inserted successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error.");
                }
            }
        }
        static int GenerateBookingId(string connectionString)
        {
            string query = "SELECT TOP 1 B_ID FROM BOOKING ORDER BY B_ID DESC";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    return Convert.ToInt32(result) + 1;
                }
                else
                {
                    return 1; 
                }
            }
        }

        
    
}
}
