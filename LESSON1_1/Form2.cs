using LESSON1_1.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LESSON1_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to Chicken, Pork, & Beef Restaurant!", "Greeting", MessageBoxButtons.OK, MessageBoxIcon.Information);

            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;

            pictureBox16.Image = Image.FromFile("C:\\Users\\Bernard Ordonez\\source\\DSAL01E\\LESSON1_1\\LESSON1_1\\Resources\\Hawaiian Shoyu Chicken.jpg");
            pictureBox17.Image = Image.FromFile("C:\\Users\\Bernard Ordonez\\source\\DSAL01E\\LESSON1_1\\LESSON1_1\\Resources\\Chicken & Rice Casserole.jpg");
            pictureBox18.Image = Image.FromFile("C:\\Users\\Bernard Ordonez\\source\\DSAL01E\\LESSON1_1\\LESSON1_1\\Resources\\Orange Chicken.jpg");
            pictureBox19.Image = Image.FromFile("C:\\Users\\Bernard Ordonez\\source\\DSAL01E\\LESSON1_1\\LESSON1_1\\Resources\\Chicken Enchiladas.jpg");
            pictureBox20.Image = Image.FromFile("C:\\Users\\Bernard Ordonez\\source\\DSAL01E\\LESSON1_1\\LESSON1_1\\Resources\\Caprese Chicken Gnocchi Skillet.jpg");


            pictureBox1.Text = "Nashville Hot Chicken";
            pictureBox2.Text = "Indian Chicken 65";
            pictureBox3.Text = "Taiwanese-Popcorn-Chicken";
            pictureBox4.Text = "Korean Fried Chicken";
            pictureBox5.Text = "Southern Fried Chicken";
            pictureBox6.Text = "Chili-Honey Glazed Lechon Kawali";
            pictureBox7.Text = "Bacon-Wrapped Pork Chop";
            pictureBox8.Text = "Pork Tonkatsu";
            pictureBox9.Text = "Fried Calamansi Pork Chops";
            pictureBox10.Text = "Breaded Pork Chop";
            pictureBox11.Text = "Carmalized Onions and Blue Cheese beef";
            pictureBox12.Text = "Prime Rib Roast";
            pictureBox13.Text = "Beef Wellington";
            pictureBox14.Text = "The Filet Mignon";
            pictureBox15.Text = "Steak Au Poivre";
            pictureBox16.Text = "Hawaiian Shoyu Chicken";
            pictureBox17.Text = "Chicken & Rice Casserole";
            pictureBox18.Text = "Orange Chicken";
            pictureBox19.Text = "Chicken Enchiladas";
            pictureBox20.Text = "Caprese Chicken Gnocchi Skillet";

        }
    }
}
