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
    
    public partial class M_TFeedback : UserControl
    {
        public string Memberid;
        public string Trainerid;
        string connectionString = "Server=sql.bsite.net\\MSSQL2016;Database=maryammasood_DatabaseProject2024;User Id=maryammasood_DatabaseProject2024;Password=E#auevEGu9qYHAx;";

        int[] clicked = { 0, 0, 0, 0, 0 };

        public M_TFeedback()
        {
            InitializeComponent();
            this.Width = 1561;
            this.Height = 957;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Feedback_Load(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Submit feedback
            int Q1, Q2, Q3, Q4, Q5;
            Q1 = Q2 = Q3 = Q4 = Q5 = 0;
            int lastFId = GetLastFeedbackId(connectionString);

            string query = "INSERT INTO FEEDBACK (F_ID, M_ID, T_ID, G_ID, Q1, Q2, Q3, Q4, Q5) VALUES (@lastFId, @Memberid, @Trainerid, @G_ID, @Q1, @Q2, @Q3, @Q4, @Q5)";

            // Create connection and command objects
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                // Add parameters
                command.Parameters.AddWithValue("@lastFId", lastFId + 1);
                command.Parameters.AddWithValue("@Memberid", Memberid);
                command.Parameters.AddWithValue("@Trainerid", Trainerid);
                command.Parameters.AddWithValue("@G_ID", DBNull.Value); // Setting G_ID to null
                command.Parameters.AddWithValue("@Q1", clicked[0]);
                command.Parameters.AddWithValue("@Q2", clicked[1]);
                command.Parameters.AddWithValue("@Q3", clicked[2]);
                command.Parameters.AddWithValue("@Q4", clicked[3]);
                command.Parameters.AddWithValue("@Q5", clicked[4]);

                // Open connection and execute command
                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    MessageBox.Show("Feedback Submitted successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        private int GetLastFeedbackId(string connectionString)
        {
            string query = "SELECT TOP 1 F_ID FROM FEEDBACK ORDER BY F_ID DESC";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    return Convert.ToInt32(result);
                }
                else
                {
                    return 0; // If no feedback exists yet, start with 0
                }
            }
        }

            private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            clicked[0] = 1;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            clicked[0] = 2;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            clicked[0] = 3;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            clicked[0] = 4;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            clicked[0] = 5;
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            clicked[1] = 1;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            clicked[1] = 2;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            clicked[1] = 3;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            clicked[1] = 4;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            clicked[1] = 5;
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            clicked[2] = 1;
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            clicked[2] = 2;
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            clicked[2] = 3;
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            clicked[2] = 4;
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            clicked[2] = 5;
        }

        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {
            clicked[3] = 1;
        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            clicked[3] = 2;
        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {
            clicked[3] = 3;
        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            clicked[3] = 4;
        }

        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {
            clicked[3] = 5;
        }

        private void radioButton25_CheckedChanged(object sender, EventArgs e)
        {
            clicked[4] = 1;
        }

        private void radioButton21_CheckedChanged(object sender, EventArgs e)
        {
            clicked[4] = 2;
        }

        private void radioButton22_CheckedChanged(object sender, EventArgs e)
        {
            clicked[4] = 3;
        }

        private void radioButton23_CheckedChanged(object sender, EventArgs e)
        {
            clicked[4] = 4;
        }

        private void radioButton24_CheckedChanged(object sender, EventArgs e)
        {
            clicked[4] = 5;
        }
    }
}
