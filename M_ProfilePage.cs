using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DB_FormLab
{
    public partial class M_ProfilePage : UserControl
    {
        public string MemberID
        {
            get { return textBox7.Text; }
            set { textBox7.Text = value; }
        }
        public string MemberFName
        {
            get { return textBox5.Text; }
            set { textBox5.Text = value; }
        }
        public string MemberLName
        {
            get { return textBox4.Text; }
            set { textBox4.Text = value; }
        }
        public string MemberDob
        {
            get { return textBox3.Text; }
            set { textBox3.Text = value; }
        }
        public string MemberAddress
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }
        public string MemberUsername
        {
            get { return textBox15.Text; }
            set { textBox15.Text = value; }
        }
        public string MemberPassword
        {
            get { return textBox14.Text; }
            set { textBox14.Text = value; }
        }
        

        public string MemberEmail
        {
            get { return textBox27.Text; }
            set { textBox27.Text = value; }
        }
        public string MemberPhone
        {
            get { return textBox26.Text; }
            set { textBox26.Text = value; }
        }
        public string MemberGoal
        {
            get { return textBox19.Text; }
            set { textBox19.Text = value; }
        }
        public string MembershipType
        {
            get { return textBox18.Text; }
            set { textBox18.Text = value; }
        }
        public string GymID
        {
            get { return textBox17.Text; }
            set { textBox17.Text = value; }
        }
        public string GymName
        {
            get { return textBox13.Text; }
            set { textBox13.Text = value; }
        }
        public string GymLoc
        {
            get { return textBox6.Text; }
            set { textBox6.Text = value; }
        }
        public string WorkoutID
        {
            get { return textBox25.Text; }
            set { textBox25.Text = value; }
        }
        public string WorkoutName
        {
            get { return textBox24.Text; }
            set { textBox24.Text = value; }
        }

        public string TrainerID
        {
            get { return textBox10.Text; }
            set { textBox10.Text = value; }
        }
        public string TrainerName
        {
            get { return textBox9.Text; }
            set { textBox9.Text = value; }
        }
        public string DietPlanID
        {
            get { return textBox8.Text; }
            set { textBox8.Text = value; }
        }
        public string DietPlanName
        {
            get { return textBox21.Text; }
            set { textBox21.Text = value; }
        }
        public string MemberStartDate
        {
            get { return textBox12.Text; }
            set { textBox12.Text = value; }
        }
        
        
        public M_ProfilePage()
        {
            InitializeComponent();
            this.Width = 1561;
            this.Height = 957;
            textBox2.ReadOnly=textBox3.ReadOnly = textBox4.ReadOnly = textBox5.ReadOnly = textBox6.ReadOnly = textBox7.ReadOnly = textBox8.ReadOnly = textBox9.ReadOnly = true;
            textBox10.ReadOnly = textBox12.ReadOnly = textBox13.ReadOnly = textBox14.ReadOnly= textBox15.ReadOnly = textBox16.ReadOnly = textBox17.ReadOnly = textBox18.ReadOnly = textBox19.ReadOnly = true;
            textBox21.ReadOnly = textBox24.ReadOnly = textBox25.ReadOnly = textBox26.ReadOnly = textBox27.ReadOnly =  true;
        }
        private void TextBox2_MouseDown(object sender, MouseEventArgs e)
        {
            panel3.Focus();
        }
        private void TextBox3_MouseDown(object sender, MouseEventArgs e)
        {
            panel3.Focus();
        }
        private void TextBox4_MouseDown(object sender, MouseEventArgs e)
        {
            panel3.Focus();
        }
        private void TextBox5_MouseDown(object sender, MouseEventArgs e)
        {
            panel3.Focus();
        }
        private void TextBox6_MouseDown(object sender, MouseEventArgs e)
        {
            panel3.Focus();
        }
        private void TextBox7_MouseDown(object sender, MouseEventArgs e)
        {
            panel3.Focus();
        }
        private void TextBox8_MouseDown(object sender, MouseEventArgs e)
        {
            panel3.Focus();
        }
        private void TextBox9_MouseDown(object sender, MouseEventArgs e)
        {
            panel3.Focus();
        }
        private void TextBox10_MouseDown(object sender, MouseEventArgs e)
        {
            panel3.Focus();
        }
        
        private void TextBox12_MouseDown(object sender, MouseEventArgs e)
        {
            panel3.Focus();
        }
        private void TextBox13_MouseDown(object sender, MouseEventArgs e)
        {
            panel3.Focus();
        }
        private void TextBox14_MouseDown(object sender, MouseEventArgs e)
        {
            panel3.Focus();
        }
        private void TextBox15_MouseDown(object sender, MouseEventArgs e)
        {
            panel3.Focus();
        }
        private void TextBox16_MouseDown(object sender, MouseEventArgs e)
        {
            panel3.Focus();
        }
        private void TextBox17_MouseDown(object sender, MouseEventArgs e)
        {
            panel3.Focus();
        }
        private void TextBox18_MouseDown(object sender, MouseEventArgs e)
        {
            panel3.Focus();
        }
        private void TextBox19_MouseDown(object sender, MouseEventArgs e)
        {
            panel3.Focus();
        }
        private void TextBox21_MouseDown(object sender, MouseEventArgs e)
        {
            panel3.Focus();
        }
        private void TextBox24_MouseDown(object sender, MouseEventArgs e)
        {
            panel3.Focus();
        }
        private void TextBox25_MouseDown(object sender, MouseEventArgs e)
        {
            panel3.Focus();
        }
        private void TextBox26_MouseDown(object sender, MouseEventArgs e)
        {
            panel3.Focus();
        }
        private void TextBox27_MouseDown(object sender, MouseEventArgs e)
        {
            panel3.Focus();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void M_HomePage_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }
    }
}
