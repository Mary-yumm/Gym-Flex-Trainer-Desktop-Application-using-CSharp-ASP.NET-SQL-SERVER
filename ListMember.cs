using DB_FormLab;
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
    public partial class ListMember : UserControl
    {
       public string Trainer_ID;
        public string type;
        public string Gym_ID;

        string connectionString = "Server=sql.bsite.net\\MSSQL2016;Database=maryammasood_DatabaseProject2024;User Id=maryammasood_DatabaseProject2024;Password=E#auevEGu9qYHAx;";
        public ListMember()
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
                SqlDataAdapter adapter = new SqlDataAdapter("select m_id as Member_ID, m_fname as First_Name, m_lname as Last_Name,m_goal as Goal ,t_id as Trainer_id, g_id as Gym_id, w_id as Workout_plan_id, d_id as Diet_plan_id from member", connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button38_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FilterbyDropDown_Click(object sender, EventArgs e)
        {

        }

        private void button53_Click(object sender, EventArgs e)
        {

        }


        private void MemberListUserControl_Load(object sender, EventArgs e)
        {

        }

        private void button47_Click(object sender, EventArgs e)
        {
            // remove trainer in member table
            if (type == "gym")
            {
                RemoveMemberFromGym(Gym_ID);
            }
            else
            RemoveTrainerFromMember(Trainer_ID);
        }
        private void RemoveMemberFromGym(string trainerID)
        {
            string updateQuery = @"
        UPDATE MEMBER
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
                            MessageBox.Show("Gym removed successfully from member.");
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
        private void RemoveTrainerFromMember(string trainerID)
        {
            string updateQuery = @"
        UPDATE MEMBER
        SET T_ID = NULL
        WHERE T_ID = @trainerID";

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
                            MessageBox.Show("Trainer removed successfully from member.");
                        }
                        else
                        {
                            MessageBox.Show("No member found with the provided trainer ID.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        public void MembersList()
        {
            string selectQuery = @"
        SELECT M_ID
        FROM MEMBER
        WHERE T_ID = @Trainer_ID";

            comboBox2.Items.Clear();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@Trainer_ID", Trainer_ID);

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
        public void MembersList2()
        {
            string selectQuery = @"
        SELECT M_ID
        FROM MEMBER
        WHERE G_ID = @Gym_ID";

            comboBox2.Items.Clear();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@Gym_ID", Gym_ID);

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int memberID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);

                MembersReport m_Report = new MembersReport(() => this.Show(), memberID);

                m_Report.Show();
                m_Report.BringToFront();
                
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
