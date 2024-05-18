using FINAL_DB_PROJECT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Database_Project
{
    public partial class ListTrainer : UserControl
    {
        private bool isCollapsed = false;
        string connectionString = "Server=sql.bsite.net\\MSSQL2016;Database=maryammasood_DatabaseProject2024;User Id=maryammasood_DatabaseProject2024;Password=E#auevEGu9qYHAx;";
        public string GymID;

        public ListTrainer()
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
                SqlDataAdapter adapter = new SqlDataAdapter("select * from trainer", connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                
            }
        }
        private void label7_Click(object sender, EventArgs e)
        {
          //    trainerreport_usercontrol1.Show();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FilterbyDropDown_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void TrainerListUserControl_Load(object sender, EventArgs e)
        {
        }

        private void label3_Click_2(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label43_Click(object sender, EventArgs e)
        {

        }

        private void label57_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button39_Click(object sender, EventArgs e)
        {

        }

        private void button40_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void button53_Click(object sender, EventArgs e)
        {
            //TrainersReport m_Report = new TrainersReport(() => this.Show());

            //m_Report.Show();
            //m_Report.BringToFront();

        }
        public void TrainersList()
        {
            string selectQuery = @"
        SELECT T_ID
        FROM TRAINER
        WHERE G_ID = @GymID";

            comboBox2.Items.Clear();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@GymID", GymID);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int memberID = reader.GetInt32(0);

                                comboBox2.Items.Add(memberID);
                            }
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


            RemoveTrainerFromMember(GymID);
        }
        private void RemoveTrainerFromMember(string trainerID)
        {
            string updateQuery = @"
        UPDATE TRAINER
        SET G_ID = NULL
        WHERE G_ID = @trainerID";

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
                            MessageBox.Show("Gym removed successfully from Trainer.");
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

        private void button27_Click(object sender, EventArgs e)
        {
            string updateQuery = @"
        UPDATE TRAINER
        SET T_ActiveFlag = 0
        WHERE G_ID = @GymID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@GymID", GymID);

                    try
                    {
                        connection.Open();

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Trainer deactivated.");
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
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string updateQuery = @"
        UPDATE TRAINER
        SET T_ActiveFlag = 1
        WHERE G_ID = @GymID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@GymID", GymID);

                    try
                    {
                        connection.Open();

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Trainer activated.");
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
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int memberID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);

                TrainersReport m_Report = new TrainersReport(() => this.Show(), memberID);

                m_Report.Show();
                m_Report.BringToFront();

            }
        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
