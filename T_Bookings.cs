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

namespace FinalHopefully
{
    public partial class T_Bookings : UserControl
    {
        public string val;
        string connectionString = "Server=sql.bsite.net\\MSSQL2016;Database=maryammasood_DatabaseProject2024;User Id=maryammasood_DatabaseProject2024;Password=E#auevEGu9qYHAx;";
        public T_Bookings()

        {
            InitializeComponent();
            this.Width = 1561;
            this.Height = 957;
            showdata();
        }

        public string TrainerID
        {
            set { val = value; }
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
                /*
                 connection.Open();
        // Create a parameterized query
        string query = "select * from Booking where t_id = @val";
        SqlCommand command = new SqlCommand(query, connection);
        command.Parameters.AddWithValue("@val", val); // Add the parameter value

        SqlDataAdapter adapter = new SqlDataAdapter(command);
        DataTable dt = new DataTable();
        adapter.Fill(dt);
        dataGridView1.DataSource = dt;*/
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void T_Bookings_Load(object sender, EventArgs e)
        {

        }

        private void button27_Click(object sender, EventArgs e)
        {
            //reject session
            string booking = textBox2.Text;
            DeleteBooking(booking);

        }
        private void DeleteBooking(string bookingID)
        {
            string deleteQuery = @"
        DELETE FROM BOOKING
        WHERE B_ID = @bookingID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                {
                    // Add parameter to the command
                    command.Parameters.AddWithValue("@bookingID", bookingID);

                    try
                    {
                        connection.Open();

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Booking deleted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No booking found with the provided ID.");
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

        }
    }
}
