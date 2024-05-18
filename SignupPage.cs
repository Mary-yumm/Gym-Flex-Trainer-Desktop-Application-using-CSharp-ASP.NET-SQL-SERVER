using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace DB_FormLab
{
    public partial class SignupPage : Form
    {
        public SignupPage(Action onCloseCallback)
        {
            InitializeComponent();
            this.Width = 1900;
            this.Height = 1080;
            this.onCloseCallback = onCloseCallback;

        }
        private Action onCloseCallback;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //Namee
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //email
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            // Hide the current form
            this.Hide();

            LoginPage signupPage = new LoginPage(() => this.Show(),"");

            // Show the new form
            signupPage.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //calls button 1 
            button1_Click(sender, e);
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox2.PasswordChar = '*';
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //cross button
            AAPPMAINPAGE mainPage = new AAPPMAINPAGE(() => { });
            mainPage.Show();

            this.Close();

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
            LoginPage form1 = new LoginPage(() => this.Show(), "");
            form1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginPage form1 = new LoginPage(() => this.Show(), "");
            form1.Show();
        }

        private void button5_Click_2(object sender, EventArgs e)
        {
            this.Close();
            LoginPage form1 = new LoginPage(() => this.Show(),"");
            form1.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void SignupPage_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }
    }
}
