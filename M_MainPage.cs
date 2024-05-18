using DB_FormLab;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Project
{
    public partial class M_MainPage : Form
    {
        private bool isMaximized = false;
        private Button lastClickedButton; // Track the last clicked button

        public M_MainPage()
        {
            InitializeComponent();
            this.Width = 1920;
            this.Height = 1080;
            lastClickedButton = null;
            button8.BackColor = Color.LightSlateGray;
            button8.ForeColor = Color.WhiteSmoke;
            lastClickedButton = button8;

        }
  

  
        bool menuexpand = true;
        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuexpand)
            {
                flowLayoutPanel1.Width -= 10;
                if (flowLayoutPanel1.Width <= 60)
                {
                    menuTransition.Stop();
                    menuexpand = false;
                }
            }
            else
            {
                flowLayoutPanel1.Width += 10;
                if(flowLayoutPanel1.Width >= 230)
                {
                    menuTransition.Stop();
                    menuexpand=true;
                }
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (!menuTransition.Enabled) 
            {
                menuTransition.Start();
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }


        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            if (isMaximized)
            {
                this.WindowState = FormWindowState.Normal;
                isMaximized = false;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                isMaximized = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Diet Plan
            m_DietPage1.Show();
            m_DietPage1.BringToFront();

            // Reset the appearance of the previously clicked button
            if (lastClickedButton != null)
            {
                lastClickedButton.BackColor = Color.DarkSlateGray;
                lastClickedButton.ForeColor = Color.WhiteSmoke;
            }

            // Change the appearance of the current button
            button1.BackColor = Color.LightSlateGray;
            button1.ForeColor = Color.WhiteSmoke;
            lastClickedButton = button1;
            label1.Text = "Diet Plan";

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            // workout plan 
            m_WorkoutPlan1.Show();
            m_WorkoutPlan1.BringToFront();
            // Reset the appearance of the previously clicked button
            if (lastClickedButton != null)
            {
                lastClickedButton.BackColor = Color.DarkSlateGray;
                lastClickedButton.ForeColor = Color.WhiteSmoke;
            }

            // Change the appearance of the current button
            button2.BackColor = Color.LightSlateGray;
            button2.ForeColor = Color.WhiteSmoke;
            lastClickedButton = button2;
            label1.Text = "Workout Plan";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            // Booking Page
            m_BookingPage1.Show();
            m_BookingPage1.BringToFront();
            // Reset the appearance of the previously clicked button
            if (lastClickedButton != null)
            {
                lastClickedButton.BackColor = Color.DarkSlateGray;
                lastClickedButton.ForeColor = Color.WhiteSmoke;
            }

            // Change the appearance of the current button
            button3.BackColor = Color.LightSlateGray;
            button3.ForeColor = Color.WhiteSmoke;
            lastClickedButton = button3;
            label1.Text = "Bookings Page";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Feedback
            m_Feedback1.Show();
            m_Feedback1.BringToFront();
            // Reset the appearance of the previously clicked button
            if (lastClickedButton != null)
            {
                lastClickedButton.BackColor = Color.DarkSlateGray;
                lastClickedButton.ForeColor = Color.WhiteSmoke;
            }

            // Change the appearance of the current button
            button6.BackColor = Color.LightSlateGray;
            button6.ForeColor = Color.WhiteSmoke;
            lastClickedButton = button6;
            label1.Text = "Feedback";            
        }
        private void button5_Click(object sender, EventArgs e)
        {
            //Progress Report

            m_Report1.Show();
            m_Report1.BringToFront();
            // Reset the appearance of the previously clicked button
            if (lastClickedButton != null)
            {
                lastClickedButton.BackColor = Color.DarkSlateGray;
                lastClickedButton.ForeColor = Color.WhiteSmoke;
            }

            // Change the appearance of the current button
            button5.BackColor = Color.LightSlateGray;
            button5.ForeColor = Color.WhiteSmoke;
            lastClickedButton = button5;
            label1.Text = "Progress Report";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Home
            m_HomePage1.Show();
            m_HomePage1.BringToFront();
            // Reset the appearance of the previously clicked button
            if (lastClickedButton != null)
            {
                lastClickedButton.BackColor = Color.DarkSlateGray;
                lastClickedButton.ForeColor = Color.WhiteSmoke;
            }

            // Change the appearance of the current button
            button8.BackColor = Color.LightSlateGray;
            button8.ForeColor = Color.WhiteSmoke;
            lastClickedButton = button8;
            label1.Text = "Member Profile";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Change the appearance of the current button
            button7.BackColor = Color.LightSlateGray;
            button7.ForeColor = Color.WhiteSmoke;
            lastClickedButton = button7;

            this.Close();
        }
    }
}
