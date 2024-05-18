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

namespace FinalHopefully
{
    
    public partial class G_ProfilePage : UserControl
    {
        public string OwnerID
        {
            get { return textBox7.Text; }
            set { textBox7.Text = value; }
        }
        public string OwnerFName
        {
            get { return textBox5.Text; }
            set { textBox5.Text = value; }
        }
        public string OwnerLName
        {
            get { return textBox4.Text; }
            set { textBox4.Text = value; }
        }
        public string OwnerDob
        {
            get { return textBox22.Text; }
            set { textBox22.Text = value; }
        }
        public string OwnerCNIC
        {
            get { return textBox3.Text; }
            set { textBox3.Text = value; }
        }
        public string OwnerAddress
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }
        public string OwnerUsername
        {
            get { return textBox16.Text; }
            set { textBox16.Text = value; }
        }
        public string OwnerPassword
        {
            get { return textBox15.Text; }
            set { textBox15.Text = value; }
        }
        public string GymID
        {
            get { return textBox27.Text; }
            set { textBox27.Text = value; }
        }
        public string OwnerPhone
        {
            get { return textBox14.Text; }
            set { textBox14.Text = value; }
        }
        public string JoiningDate
        {
            get { return textBox25.Text; }
            set { textBox25.Text = value; }
        }
        public string Salary
        {
            get { return textBox19.Text; }
            set { textBox19.Text = value; }
        }
        public string NumGyms
        {
            get { return textBox18.Text; }
            set { textBox18.Text = value; }
        }
        public string NumTrainers
        {
            get { return textBox6.Text; }
            set { textBox6.Text = value; }
        }
        public string NumMembers
        {
            get { return textBox13.Text; }
            set { textBox13.Text = value; }
        }
        public string GymName
        {
            get { return textBox10.Text; }
            set { textBox10.Text = value; }
        }
        public string GymEmail
        {
            get { return textBox26.Text; }
            set { textBox26.Text = value; }
        }
        public string GymLoc
        {
            get { return textBox9.Text; }
            set { textBox9.Text = value; }
        }
        public string OwnerEmail
        {
            get { return textBox11.Text; }
            set { textBox11.Text = value; }
        }
        public string AddContact
        {
            get { return textBox14.Text; }
            set { textBox14.Text = value; }
        }
        public event EventHandler Button6Clicked;
        public event EventHandler Button5Clicked;
        public G_ProfilePage()
        {
            InitializeComponent();
            this.Width = 1561;
            this.Height = 957;
            textBox2.ReadOnly = textBox3.ReadOnly = textBox4.ReadOnly = textBox5.ReadOnly = textBox6.ReadOnly = textBox7.ReadOnly = true;
            textBox13.ReadOnly = textBox14.ReadOnly = textBox15.ReadOnly = textBox16.ReadOnly = textBox18.ReadOnly = textBox19.ReadOnly = true;
            textBox22.ReadOnly= textBox25.ReadOnly = textBox11.ReadOnly = true;
            button6.Click += Button6_Click;
            button5.Click += Button5_Click;
        }
        private void Button6_Click(object sender, EventArgs e)
        {
            AddContact = textBox14.Text;
            // Raise the Button14Clicked event when button14 is clicked
            Button6Clicked?.Invoke(this, EventArgs.Empty);
        }
        private void Button5_Click(object sender, EventArgs e)
        {
            GymID = textBox27.Text;
            GymName = textBox10.Text;
            GymEmail = textBox26.Text;
            GymLoc = textBox9.Text;
            // Raise the Button14Clicked event when button14 is clicked
            Button5Clicked?.Invoke(this, EventArgs.Empty);
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
        private void TextBox11_MouseDown(object sender, MouseEventArgs e)
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
        private void TextBox18_MouseDown(object sender, MouseEventArgs e)
        {
            panel3.Focus();
        }
        private void TextBox19_MouseDown(object sender, MouseEventArgs e)
        {
            panel3.Focus();
        }
        private void TextBox22_MouseDown(object sender, MouseEventArgs e)
        {
            panel3.Focus();
        }
        private void TextBox25_MouseDown(object sender, MouseEventArgs e)
        {
            panel3.Focus();
        }
      
        private void G_HomePage_Load(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
