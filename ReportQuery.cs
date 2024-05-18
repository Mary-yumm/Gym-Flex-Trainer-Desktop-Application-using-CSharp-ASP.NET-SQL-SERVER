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

namespace FINAL_DB_PROJECT
{
    public partial class ReportQuery : UserControl
    {
        string connectionString = "Server=sql.bsite.net\\MSSQL2016;Database=maryammasood_DatabaseProject2024;User Id=maryammasood_DatabaseProject2024;Password=E#auevEGu9qYHAx;";
        SqlCommand cmd;
        public ReportQuery()
        {
            InitializeComponent();
            loadcombo1();
            loadcombo2();
            loadcombo3();
            loadcombo4();
            loadcombo5();
            loadcombo6();
            loadcombo7();
            loadcombo8();
            loadcombo10();
            loadcombo13();
            loadcombo16();

        }





        private void button53_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                QueryReportDisplay report = new QueryReportDisplay(() => this.Show());
                report.Show();
                report.BringToFront();
                connection.Open();
                string query = @"SELECT member.* 
                    FROM member
                    LEFT JOIN trainer ON member.t_id = trainer.T_ID
                    LEFT JOIN gym ON member.G_ID = gym.G_ID
                    WHERE gym.G_NAME = @GName 
                    AND trainer.T_id = @TID";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@GName", comboBox2.Text);
                command.Parameters.AddWithValue("@TID", comboBox6.Text);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                report.ReportDataGridView.DataSource = dt;

            }
        }
        private void ReportQuery_Load(object sender, EventArgs e)
        {


        }

        private void button54_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                QueryReportDisplay report = new QueryReportDisplay(() => this.Show());
                report.Show();
                report.BringToFront();
                connection.Open();
                string query = @"select member.* from member
                                left join DAILY_DIET_PLAN
                                on member.D_ID = DAILY_DIET_PLAN.D_ID
                                left join gym
                                on member.G_ID =gym.G_ID
                                where gym.G_NAME = @gname and DAILY_DIET_PLAN.D_Name = @dpname";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@gname", comboBox3.Text);
                command.Parameters.AddWithValue("@dpname", comboBox1.Text);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                report.ReportDataGridView.DataSource = dt;
            }
        }

        private void button55_Click1(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                QueryReportDisplay report = new QueryReportDisplay(() => this.Show());
                report.Show();
                report.BringToFront();
                connection.Open();
                string query = @"select member.* from member
                                left join DAILY_DIET_PLAN
                                on member.D_ID = DAILY_DIET_PLAN.D_ID
                                left join trainer
                                on member.T_ID =trainer.T_ID
                                where trainer.t_id =@tid and DAILY_DIET_PLAN.D_Name = @dplan";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@dplan", comboBox4.Text);
                command.Parameters.AddWithValue("@tid", comboBox5.Text);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                report.ReportDataGridView.DataSource = dt;
            }
        }

        private void button56_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                QueryReportDisplay report = new QueryReportDisplay(() => this.Show());
                report.Show();
                report.BringToFront();
                connection.Open();
                string query = @"select member.*  from member
                                     join gym
                                    on member.G_ID = Gym.G_ID
                                    join WORKOUT_PLAN
                                    on member.W_ID = WORKOUT_PLAN.W_ID
                                    join WORKOUTEXERCISE
                                    on WORKOUT_PLAN.W_ID=WORKOUTEXERCISE.W_ID
                                     join EXERCISE
                                    on WORKOUTEXERCISE.E_ID = EXERCISE.E_ID
                                    join MACHINE
                                    on EXERCISE.Machine_ID = MACHINE.MID
                                    where
                                    GYM.G_name =@gymname and machine.Machine_name = @mac
                                     and
                                    (  MEMBER.W_START_DATE < GETDATE()  );";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@gymname", comboBox7.Text);
                command.Parameters.AddWithValue("@mac", comboBox8.Text);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                report.ReportDataGridView.DataSource = dt;
            }
        }

        public void loadcombo6()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                cmd = new SqlCommand("Select t_id from trainer", connection);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                comboBox6.DataSource = dt;
                comboBox6.DisplayMember = "t_id";
                comboBox6.ValueMember = "t_id";
            }
        }
        private void button57_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                QueryReportDisplay report = new QueryReportDisplay(() => this.Show());
                report.Show();
                report.BringToFront();
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("select DAILY_DIET_PLAN.* from DAILY_DIET_PLAN\r\njoin food\r\non DAILY_DIET_PLAN.BREAKFAST = food.F_ID\r\nwhere food.Calories<500;", connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                report.ReportDataGridView.DataSource = dt;
            }
        }

        private void button58_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                QueryReportDisplay report = new QueryReportDisplay(() => this.Show());
                report.Show();
                report.BringToFront();
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT \r\n    DAILY_DIET_PLAN.*,\r\n    d1.breakfast_carbs,\r\n    d2.lunch_carbs,\r\n    d3.dinner_carbs,\r\n    (d1.breakfast_carbs + d2.lunch_carbs + d3.dinner_carbs) AS TOTAL_CARBS \r\nFROM\r\n (   (SELECT D_ID,SUM(CARBS) AS breakfast_carbs \r\n     FROM DAILY_DIET_PLAN \r\n     LEFT JOIN FOOD ON\r\n\t DAILY_DIET_PLAN.BREAKFAST = FOOD.F_ID  \r\n     GROUP BY  D_ID) AS d1\r\nJOIN\r\n    (SELECT D_ID,SUM(CARBS) AS lunch_carbs \r\n     FROM  DAILY_DIET_PLAN \r\n\t LEFT JOIN FOOD \r\n\t ON DAILY_DIET_PLAN.LUNCH = FOOD.F_ID  \r\n     GROUP BY D_ID) AS d2\r\n\t\t ON d1.D_ID = d2.D_ID\r\nJOIN\r\n    (SELECT D_ID, SUM(CARBS) AS dinner_carbs \r\n     FROM DAILY_DIET_PLAN \r\n     LEFT JOIN FOOD \r\n\t ON DAILY_DIET_PLAN.DINNER = FOOD.F_ID  \r\n     GROUP BY D_ID) AS d3 \r\n\t ON d1.D_ID = d3.D_ID)\r\njoin DAILY_DIET_PLAN\r\non d1.D_ID = DAILY_DIET_PLAN.D_ID\r\n\r\nWHERE\r\n    (d1.breakfast_carbs + d2.lunch_carbs + d3.dinner_carbs) < 300;", connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                report.ReportDataGridView.DataSource = dt;
            }
        }



        private void button60_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                QueryReportDisplay report = new QueryReportDisplay(() => this.Show());
                report.Show();
                report.BringToFront();
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT DISTINCT temp.*\r\nFROM (\r\n    SELECT DAILY_DIET_PLAN.*\r\n    FROM DAILY_DIET_PLAN\r\n    WHERE NOT EXISTS (\r\n        SELECT *\r\n        FROM food\r\n        WHERE (DAILY_DIET_PLAN.BREAKFAST = food.F_ID OR DAILY_DIET_PLAN.LUNCH = food.F_ID OR DAILY_DIET_PLAN.DINNER = food.F_ID)\r\n            AND food.FOOD_NAME LIKE '%peanut%'\r\n    )\r\n) AS temp;", connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                report.ReportDataGridView.DataSource = dt;
            }
        }

        private void button61_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                QueryReportDisplay report = new QueryReportDisplay(() => this.Show());
                report.Show();
                report.BringToFront();
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT *  from GYM_OWNER\r\nWHERE O_JOININGDATE >= DATEADD(MONTH, -3, GETDATE());", connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                report.ReportDataGridView.DataSource = dt;
            }
        }
        private void button62_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                QueryReportDisplay report = new QueryReportDisplay(() => this.Show());
                report.Show();
                report.BringToFront();
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT COUNT(*) as total_members_enrolled, GYM.G_NAME  from GYM\r\njoin MEMBER\r\non GYM.G_ID = MEMBER.G_ID\r\nWHERE MEMBER.W_START_DATE >= DATEADD(MONTH, -6, GETDATE())\r\ngroup by GYM.G_NAME", connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                report.ReportDataGridView.DataSource = dt;
            }

        }

        private void button63_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                QueryReportDisplay report = new QueryReportDisplay(() => this.Show());
                report.Show();
                report.BringToFront();
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT *FROM TRAINER\r\nWHERE CAST(SUBSTRING(TRAINER.T_Experience, 1, CHARINDEX(' ', TRAINER.T_Experience)) AS INT) >= 5;", connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                report.ReportDataGridView.DataSource = dt;
            }

        }

        private void button64_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                QueryReportDisplay report = new QueryReportDisplay(() => this.Show());
                report.Show();
                report.BringToFront();
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT MEMBER.* FROM MEMBER\r\nLEFT JOIN Allergens\r\nON MEMBER.M_ID = Allergens.MEMBER_ID\r\nWHERE Allergens.MEMBER_ID IS NULL;", connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                report.ReportDataGridView.DataSource = dt;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                QueryReportDisplay report = new QueryReportDisplay(() => this.Show());
                report.Show();
                report.BringToFront();
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("select * from GYM\r\nwhere GYM.G_RATINGS < 2", connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                report.ReportDataGridView.DataSource = dt;
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                QueryReportDisplay report = new QueryReportDisplay(() => this.Show());
                report.Show();
                report.BringToFront();
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("select * from EXERCISE\r\nwhere EXERCISE.DifficultyLEVEL = 'Intermediate'", connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                report.ReportDataGridView.DataSource = dt;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                QueryReportDisplay report = new QueryReportDisplay(() => this.Show());
                report.Show();
                report.BringToFront();
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("select * from MEMBER\r\nwhere MEMBER.M_MEMBERSHIP_TYPE like '%year%'", connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                report.ReportDataGridView.DataSource = dt;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                QueryReportDisplay report = new QueryReportDisplay(() => this.Show());
                report.Show();
                report.BringToFront();
                connection.Open();
                string query = @"select* from WORKOUT_PLAN
                                where WORKOUT_PLAN.W_GOAL = @goall and
                                WORKOUT_PLAN.W_TARGET_GENDER = @genderr and
                                WORKOUT_PLAN.W_LEVEL =@levell";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@levell", comboBox11.Text);
                command.Parameters.AddWithValue("@genderr", comboBox12.Text);
                command.Parameters.AddWithValue("@goall", comboBox13.Text);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                report.ReportDataGridView.DataSource = dt;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                QueryReportDisplay report = new QueryReportDisplay(() => this.Show());
                report.Show();
                report.BringToFront();
                connection.Open();
                string query = @"select MEMBER.* from MEMBER
                                join BOOKING
                                on MEMBER.M_ID = BOOKING.M_ID
                                join trainer
                                on member.T_ID=TRAINER.T_ID
                                where trainer.t_id = @tid";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@tid", comboBox16.Text);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                report.ReportDataGridView.DataSource = dt;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                QueryReportDisplay report = new QueryReportDisplay(() => this.Show());
                report.Show();
                report.BringToFront();
                connection.Open();
                string query = @"select * from EXERCISE
                                where EXERCISE.DifficultyLEVEL =@intensity and
                                EXERCISE.Ratings > @ratings
                                order by EXERCISE.Ratings desc";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@intensity", comboBox17.Text);
                command.Parameters.AddWithValue("@ratings", comboBox15.Text);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                report.ReportDataGridView.DataSource = dt;
            }
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                QueryReportDisplay report = new QueryReportDisplay(() => this.Show());
                report.Show();
                report.BringToFront();
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("select * from Machine", connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                report.ReportDataGridView.DataSource = dt;
            }
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
        }


        private void button12_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                QueryReportDisplay report = new QueryReportDisplay(() => this.Show());
                report.Show();
                report.BringToFront();
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT EXERCISE.EX_NAME, Intensity, DifficultyLEVEL FROM EXERCISE\r\nLEFT JOIN MACHINE\r\nON EXERCISE.MACHINE_ID = MACHINE.MID\r\nWHERE EXERCISE.MACHINE_ID IS NULL;\r\n\r\n", connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                report.ReportDataGridView.DataSource = dt;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        public void loadcombo2()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                cmd = new SqlCommand("Select g_name from gym", connection);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                comboBox2.DataSource = dt;
                comboBox2.DisplayMember = "g_name";
            }
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void loadcombo3()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                cmd = new SqlCommand("Select d_name from daily_diet_plan", connection);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                comboBox3.DataSource = dt;
                comboBox3.DisplayMember = "d_name";
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void loadcombo1()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                cmd = new SqlCommand("Select g_name from gym", connection);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "g_name";
            }
        }
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void loadcombo4()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                cmd = new SqlCommand("Select d_name from daily_diet_plan", connection);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                comboBox4.DataSource = dt;
                comboBox4.DisplayMember = "d_name";
            }
        }
        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
        public void loadcombo5()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                cmd = new SqlCommand("Select t_id from trainer", connection);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                comboBox5.DataSource = dt;
                comboBox5.DisplayMember = "t_id";
            }
        }
        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
        public void loadcombo7()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                cmd = new SqlCommand("Select g_name from gym", connection);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                comboBox7.DataSource = dt;
                comboBox7.DisplayMember = "g_name";
            }
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void loadcombo8()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                cmd = new SqlCommand("Select machine_name from machine", connection);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                comboBox8.DataSource = dt;
                comboBox8.DisplayMember = "machine_name";
            }
        }
        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void loadcombo10()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                cmd = new SqlCommand("Select machine_name from machine", connection);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                comboBox10.DataSource = dt;
                comboBox10.DisplayMember = "machine_name";
            }
        }
        private void comboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void loadcombo13()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                cmd = new SqlCommand("Select m_goal from member", connection);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                comboBox13.DataSource = dt;
                comboBox13.DisplayMember = "m_goal";
            }
        }
        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox16_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        public void loadcombo16()
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                cmd = new SqlCommand("Select t_id from trainer", connection);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                comboBox16.DataSource = dt;
                comboBox16.DisplayMember = "t_id";
            }
        }

        private void button59_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                QueryReportDisplay report = new QueryReportDisplay(() => this.Show());
                report.Show();
                report.BringToFront();
                connection.Open();
                string query = @"select WORKOUT_PLAN.* from WORKOUT_PLAN
                                join WORKOUTEXERCISE
                                on WORKOUT_PLAN.W_ID = WORKOUTEXERCISE.W_ID
                                join EXERCISE
                                on WORKOUTEXERCISE.E_ID = EXERCISE.E_ID
                                join MACHINE
                                on EXERCISE.MACHINE_ID =MACHINE.MID
                                where MACHINE.MACHINE_NAME != @mac";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@mac", comboBox10.Text);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                report.ReportDataGridView.DataSource = dt;
            }
        }

      
    }
}
