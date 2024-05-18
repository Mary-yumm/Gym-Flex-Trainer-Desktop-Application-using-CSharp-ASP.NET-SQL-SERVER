using DB_FormLab;
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

namespace FINAL_DB_PROJECT
{
    public partial class MembersReport : Form
    {
        private int memberID;
        string connectionString = "Server=sql.bsite.net\\MSSQL2016;Database=maryammasood_DatabaseProject2024;User Id=maryammasood_DatabaseProject2024;Password=E#auevEGu9qYHAx;";

        public MembersReport(Action onCloseCallback,int memberid)
        {
            InitializeComponent();
            this.onCloseCallback = onCloseCallback;
            memberID=memberid;
            Data();
        }
        private Action onCloseCallback;
        
        private void Data()
        {
            string memberName = label34.Text;
            string id = label29.Text;
            string startdate = label12.Text;
            string gymid="";
            string email = label28.Text;
            string trainerID = label1.Text;
            string goal = label21.Text;

            string selectQuery = @"
        SELECT M_ID, M_FNAME, M_LNAME, M_DOB, M_EMAIL, M_ADDRESS, M_USERNAME, M_PASSWORD, M_GOAL, M_MEMBERSHIP_TYPE, W_START_DATE, T_ID,G_ID
        FROM MEMBER
        WHERE M_ID = @memberID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    // Add parameter to the command
                    command.Parameters.AddWithValue("@memberID", memberID);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Populate labels with fetched data
                                label34.Text = $"{reader["M_FNAME"]} {reader["M_LNAME"]}";
                                label12.Text = reader["W_START_DATE"].ToString();
                                label28.Text = reader["M_EMAIL"].ToString();
                                label1.Text = reader["T_ID"].ToString();
                                label21.Text = reader["M_GOAL"].ToString();
                                label29.Text = reader["M_ID"].ToString();
                                gymid = reader["G_ID"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Member not found.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            label10.Text = GymName(gymid);

        }
        private string GymName(string gymID)
        {
            string gymName = "";

            string selectQuery = @"
        SELECT G_NAME
        FROM GYM
        WHERE G_ID = @gymID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    // Add parameter to the command
                    command.Parameters.AddWithValue("@gymID", gymID);

                    try
                    {
                        connection.Open();

                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            gymName = result.ToString();
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

            return gymName;

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }


        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            //cross button
            

            this.Close();
        }

        private void label37_Click_1(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void MembersReport_Load(object sender, EventArgs e)
        {

        }
    }
}
