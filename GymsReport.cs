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
    public partial class GymsReport : Form
    {
        string connectionString = "Server=sql.bsite.net\\MSSQL2016;Database=maryammasood_DatabaseProject2024;User Id=maryammasood_DatabaseProject2024;Password=E#auevEGu9qYHAx;";
        public int GymID;
        public GymsReport(Action onCloseCallback, int gymid)
        {
            InitializeComponent();
            this.onCloseCallback = onCloseCallback;
            this.GymID = gymid;

        }
        private Action onCloseCallback;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GymsReport_Load(object sender, EventArgs e)
        {
            
                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    connection.Open();
                    DataTable dt = new DataTable();
                    customer_satisfaction_chart.Series["Series"].XValueMember = "Satisfaction";
                    customer_satisfaction_chart.Series["Series"].YValueMembers = "Customer";
                    customer_satisfaction_chart.DataSource = dt;
                    customer_satisfaction_chart.DataBind();
                } 
        }

        private void customer_satisfaction_chart_Click(object sender, EventArgs e)
        {

        }
    }
}
