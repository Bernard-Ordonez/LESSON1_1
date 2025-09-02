using System;
using System.Windows.Forms;

namespace LESSON1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to Chicken, Pork, & Beef Restaurant!","Greeting", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Ashville Hot Chicken";
            textBox2.Text = "₱120";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Indian Chicken 65";
            textBox2.Text = "₱125";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Taiwanese-Popcorn-Chicken";
            textBox2.Text = "₱129";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Korean Fried Chicken";
            textBox2.Text = "₱100";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Southern Fried Chicken";
            textBox2.Text = "₱99";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Chili-Honey Glazed Lechon Kawali";
            textBox2.Text = "₱220";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Bacon-Wrapped Pork Chop";
            textBox2.Text = "₱89";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Pork Tonkatsu";
            textBox2.Text = "₱110";
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Fried Calamansi Pork Chops";
            textBox2.Text = "₱190";
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Breaded Pork Chop";
            textBox2.Text = "₱178";
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Carmalized Onions and Blue Cheese beef";
            textBox2.Text = "₱120";
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Prime Rib Roast";
            textBox2.Text = "₱12";
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Beef Wellington";
            textBox2.Text = "₱1210";
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            textBox1.Text = "The Filet Mignon";
            textBox2.Text = "₱12012";
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Steak Au Poivre";
            textBox2.Text = "₱190";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
