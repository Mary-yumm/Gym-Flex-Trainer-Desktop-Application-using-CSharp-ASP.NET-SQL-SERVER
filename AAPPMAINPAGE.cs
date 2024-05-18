using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_FormLab
{
    public partial class AAPPMAINPAGE : Form
    {
        private Action onCloseCallback;

        public AAPPMAINPAGE(Action onCloseCallback)
        {
            InitializeComponent();
            this.Width = 1920;
            this.Height = 1080;
            this.onCloseCallback = onCloseCallback;
            pictureBox1.Focus();
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainnPage_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Hide the current form
            this.Hide();

            // Create an instance of the new form you want to open
            LoginPage loginp = new LoginPage(() => this.Show(),button2.Text);

            // Show the new form
            loginp.Show();

        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            onCloseCallback?.Invoke();
        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            //cross button
            Application.Exit();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Hide the current form
            this.Hide();

            // Create an instance of the new form you want to open
            LoginPage loginp = new LoginPage(() => this.Show(), button3.Text);

            // Show the new form
            loginp.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Hide the current form
            this.Hide();

            // Create an instance of the new form you want to open
            LoginPage loginp = new LoginPage(() => this.Show(), button4.Text);

            // Show the new form
            loginp.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Hide the current form
            this.Hide();

            // Create an instance of the new form you want to open
            LoginPage loginp = new LoginPage(() => this.Show(), button5.Text);

            // Show the new form
            loginp.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
