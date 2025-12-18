using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSAL01E_MORATA
{
    public partial class Lesson5_Example5 : Form
    {
        public Lesson5_Example5()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Lesson5_Example1_Load(object sender, EventArgs e)
        {
            username_textBox.Focus();

            this.BackgroundImage = Properties.Resources.GUI_BG; // Replace with your actual image name
            this.BackgroundImageLayout = ImageLayout.Stretch; // Makes the image fit the form size

            pictureBox1.Image = Properties.Resources.LAB_login;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            string username, password;
            password = "02162003";
            username = "tristanlloydmorata";
            if (username_textBox.Text == username && password_textBox.Text == password)
            {
                MessageBox.Show("Welcome Admin Page!!!");
                Lesson6_MainForm adminFrm = new Lesson6_MainForm();
                adminFrm.Show();
                username_textBox.Clear();
                password_textBox.Clear();
            }

            else if (username_textBox.Text == "cashier" && password_textBox.Text == "12345")
            {
                MessageBox.Show("Welcome Cashier Point of Sale Page");
                Lesson4_Example2 cashierfrm = new Lesson4_Example2();
                cashierfrm.Show();
                username_textBox.Clear();
                password_textBox.Clear();
            }

            else if (username_textBox.Text == "cashier1" && password_textBox.Text == "22222")
            {
                MessageBox.Show("Welcome Cashier Ordering POS Page");
                Lesson4_Example3 cashierfrm = new Lesson4_Example3();
                cashierfrm.Show();
                username_textBox.Clear();
                password_textBox.Clear();
            }

            else if (username_textBox.Text == "payroll" && password_textBox.Text == "11111")
            {
                MessageBox.Show("Welcome Payroll Page");
                Lesson3_Example5 cashierfrm = new Lesson3_Example5();
                cashierfrm.Show();
                username_textBox.Clear();
                password_textBox.Clear();
            }

            else
            {
                MessageBox.Show("Invalid user account!!!");
                username_textBox.Clear();
                password_textBox.Clear();
            }
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
