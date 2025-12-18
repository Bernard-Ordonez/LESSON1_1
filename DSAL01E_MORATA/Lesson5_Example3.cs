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
    public partial class Lesson5_Example3 : Form
    {
        public Lesson5_Example3()
        {
            InitializeComponent();
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
                MessageBox.Show("You are successfully accessing your home page!!!");
                //MainFrm adminFrm = new MainFrm();
                //adminFrm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid user account. Please contact your administrator!!!");
                username_textBox.Clear();
                password_textBox.Clear();
                username_textBox.Focus();
            }
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
