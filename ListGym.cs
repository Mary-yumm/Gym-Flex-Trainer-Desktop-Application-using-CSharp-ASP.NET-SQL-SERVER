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

namespace Database_Project
{
    public partial class ListGym : UserControl
    {
        string connectionString = "Server=sql.bsite.net\\MSSQL2016;Database=maryammasood_DatabaseProject2024;User Id=maryammasood_DatabaseProject2024;Password=E#auevEGu9qYHAx;";
        public string Gymid;
        public ListGym()
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
                SqlDataAdapter adapter = new SqlDataAdapter("select * from gym", connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
                    }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void GymListUserControl_Load(object sender, EventArgs e)
        {

        }

        private void button53_Click(object sender, EventArgs e)
        {
            //GymsReport gymsReport = new GymsReport();
            //gymsReport.Show();
            //gymsReport.BringToFront();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int memberID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);

                GymsReport m_Report = new GymsReport(() => this.Show(), memberID);

                m_Report.Show();
                m_Report.BringToFront();

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string updateQuery = @"
        UPDATE GYM
        SET Active_Flag = 1
        WHERE G_OWNERID = @Gymid";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@Gymid", Gymid);

                    try
                    {
                        connection.Open();

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Gym activated.");
                        }
                        else
                        {
                            MessageBox.Show("Gym not found.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            string updateQuery = @"
        UPDATE GYM
        SET Active_Flag = 0
        WHERE G_OWNERID = @Gymid";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@Gymid", Gymid);

                    try
                    {
                        connection.Open();

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Gym activated.");
                        }
                        else
                        {
                            MessageBox.Show("Gym not found.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void button47_Click(object sender, EventArgs e)
        {
            RemoveTrainerFromMember(Gymid);
        }
        private void RemoveTrainerFromMember(string trainerID)
        {
            string updateQuery = @"
        UPDATE GYM
        SET G_OWNERID = NULL
        WHERE G_ID = @Gymid";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@trainerID", trainerID);

                    try
                    {
                        connection.Open();

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Gym removed successfully from Owner.");
                        }
                        else
                        {
                            MessageBox.Show("No Gym found with the provided Gym ID.");
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
}
