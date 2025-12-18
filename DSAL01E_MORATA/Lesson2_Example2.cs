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
    public partial class Lesson2_Example2 : Form
    {
        public Lesson2_Example2()
        {
            InitializeComponent();

            pictureBox1.Image = Properties.Resources.Beef_Tapa;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox2.Image = Properties.Resources.FriendMealA;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox3.Image = Properties.Resources.DoubleValueMealA;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox4.Image = Properties.Resources.FamilyComboMealB;
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox5.Image = Properties.Resources.BreakfastMeal_A;
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox6.Image = Properties.Resources.BreakfastMeal_A;
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox7.Image = Properties.Resources.PastaMeal101;
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox8.Image = Properties.Resources.FamilyComboMealA;
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox9.Image = Properties.Resources.ChickenMealA;
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox10.Image = Properties.Resources.LunchValueMeal1;
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox11.Image = Properties.Resources.DoublePalabocMeal;
            pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox12.Image = Properties.Resources.ChickenMeal2;
            pictureBox12.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox13.Image = Properties.Resources.PancakeValueMealA;
            pictureBox13.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox14.Image = Properties.Resources.BreakfastMealB;
            pictureBox14.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox15.Image = Properties.Resources.LunchValueMealB;
            pictureBox15.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a textbox
            itemName_textBox.Text = "Breakfast Meal B";
            price_textBox.Text = "121.30";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a textbox
            itemName_textBox.Text = "Friend Meal A";
            price_textBox.Text = "391.90";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a textbox
            itemName_textBox.Text = "Double Value Meal A";
            price_textBox.Text = "191.00";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a textbox
            itemName_textBox.Text = "Family Combo Meal B";
            price_textBox.Text = "799.30";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a textbox
            itemName_textBox.Text = "Breakfast Meal A";
            price_textBox.Text = "91.30";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a textbox
            itemName_textBox.Text = "Breakfast Meal A";
            price_textBox.Text = "91.30";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a textbox
            itemName_textBox.Text = "Pasta Meal 101";
            price_textBox.Text = "98.00";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a textbox
            itemName_textBox.Text = "Family Combo Meal B";
            price_textBox.Text = "999.90";
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a textbox
            itemName_textBox.Text = "Chicken Meal A";
            price_textBox.Text = "177.30";
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a textbox
            itemName_textBox.Text = "Lunch Value Meal 1";
            price_textBox.Text = "199.10";
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a textbox
            itemName_textBox.Text = "Double Palaboc Meal";
            price_textBox.Text = "120.50";
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a textbox
            itemName_textBox.Text = "Chicken Meal 2";
            price_textBox.Text = "191.30";
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a textbox
            itemName_textBox.Text = "Pancake Value Meal A";
            price_textBox.Text = "97.30";
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a textbox
            itemName_textBox.Text = "Breakfast Meal B";
            price_textBox.Text = "133.30";
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a textbox
            itemName_textBox.Text = "Lunch Value Meal B";
            price_textBox.Text = "191.30";
        }

        private void new_button_Click(object sender, EventArgs e)
        {
            // Code for clearing or emptying the value of the Text property of a textbox
            itemName_textBox.Clear();
            price_textBox.Clear();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            // Code for closing the execution of the Windows Application 
            this.Close();
        }
    }
}
