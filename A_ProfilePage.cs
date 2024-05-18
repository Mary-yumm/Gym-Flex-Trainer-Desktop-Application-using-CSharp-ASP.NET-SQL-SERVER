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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace FinalHopefully
{
    public partial class A_ProfilePage : UserControl
    {
        public string AdminID
        {
            get { return textBox7.Text; }
            set { textBox7.Text = value; }
        }
        public string AdminFName
        {
            get { return textBox5.Text; }
            set { textBox5.Text = value; }
        }
        public string AdminLName
        {
            get { return textBox4.Text; }
            set { textBox4.Text = value; }
        }
        public string AdminDob
        {
            get { return textBox3.Text; }
            set { textBox3.Text = value; }
        }
        
        public string AdminAddress
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }
        public string AdminUsername
        {
            get { return textBox16.Text; }
            set { textBox16.Text = value; }
        }
        public string AdminPassword
        {
            get { return textBox15.Text; }
            set { textBox15.Text = value; }
        }
        public string AdminEmail
        {
            get { return textBox8.Text; }
            set { textBox8.Text = value; }
        }
        public string AdminPhone
        {
            get { return textBox6.Text; }
            set { textBox6.Text = value; }
        }
        public string JoiningDate
        {
            get { return textBox10.Text; }
            set { textBox10.Text = value; }
        }
        public string Salary
        {
            get { return textBox9.Text; }
            set { textBox9.Text = value; }
        }
        public string Role
        {
            get { return textBox11.Text; }
            set { textBox11.Text = value; }
        }
        public string AddContact
        {
            get { return textBox14.Text; }
            set { textBox14.Text = value; }
        }
        public event EventHandler Button1Clicked;
        public A_ProfilePage()
        {
            InitializeComponent();
            this.Width = 1561;
            this.Height = 957;
            textBox2.ReadOnly = textBox3.ReadOnly = textBox4.ReadOnly = textBox5.ReadOnly = textBox6.ReadOnly = textBox7.ReadOnly = textBox8.ReadOnly= textBox9.ReadOnly = true;
            textBox10.ReadOnly = textBox11.ReadOnly = textBox15.ReadOnly = textBox16.ReadOnly = true;
            button1.Click += Button1_Click;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            AddContact = textBox14.Text;
            // Raise the Button14Clicked event when button14 is clicked
            Button1Clicked?.Invoke(this, EventArgs.Empty);
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
        private void TextBox11_MouseDown(object sender, MouseEventArgs e)
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

        private void A_HomePage_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
