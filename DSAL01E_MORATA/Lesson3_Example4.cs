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
    public partial class Lesson3_Example4 : Form
    {
        //declare global variables here
        private double amount_paid, price, cash_given, change;
        private int quantity;

        public Lesson3_Example4()
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

            quantity_textBox.Focus();
            quantity_textBox.Clear();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a textbox
            itemName_textBox.Text = "Friend Meal A";
            price_textBox.Text = "391.90";

            quantity_textBox.Focus();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a textbox
            itemName_textBox.Text = "Double Value Meal A";
            price_textBox.Text = "191.00";

            quantity_textBox.Focus();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a textbox
            itemName_textBox.Text = "Family Combo Meal B";
            price_textBox.Text = "799.30";

            quantity_textBox.Focus();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a textbox
            itemName_textBox.Text = "Breakfast Meal A";
            price_textBox.Text = "91.30";

            quantity_textBox.Focus();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a textbox
            itemName_textBox.Text = "Breakfast Meal A";
            price_textBox.Text = "91.30";

            quantity_textBox.Focus();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a textbox
            itemName_textBox.Text = "Pasta Meal 101";
            price_textBox.Text = "98.00";

            quantity_textBox.Focus();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a textbox
            itemName_textBox.Text = "Family Combo Meal B";
            price_textBox.Text = "999.90";

            quantity_textBox.Focus();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a textbox
            itemName_textBox.Text = "Chicken Meal A";
            price_textBox.Text = "177.30";

            quantity_textBox.Focus();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a textbox
            itemName_textBox.Text = "Lunch Value Meal 1";
            price_textBox.Text = "199.10";

            quantity_textBox.Focus();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a textbox
            itemName_textBox.Text = "Double Palaboc Meal";
            price_textBox.Text = "120.50";

            quantity_textBox.Focus();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a textbox
            itemName_textBox.Text = "Chicken Meal 2";
            price_textBox.Text = "191.30";

            quantity_textBox.Focus();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a textbox
            itemName_textBox.Text = "Pancake Value Meal A";
            price_textBox.Text = "97.30";

            quantity_textBox.Focus();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a textbox
            itemName_textBox.Text = "Breakfast Meal B";
            price_textBox.Text = "133.30";

            quantity_textBox.Focus();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a textbox
            itemName_textBox.Text = "Lunch Value Meal B";
            price_textBox.Text = "191.30";

            quantity_textBox.Focus();
        }

        private void calculate_button_Click(object sender, EventArgs e)
        {
            cash_given = Convert.ToDouble(cashGiven_textBox.Text);
            change = cash_given - amount_paid;
            change_textBox.Text = change.ToString("n");
        }

        private void quantity_textBox_TextChanged(object sender, EventArgs e)
        {
            price = Convert.ToDouble(price_textBox.Text);
            quantity = Convert.ToInt32(quantity_textBox.Text);
            amount_paid = price * quantity;
            amountPaid_textBox.Text = amount_paid.ToString("n");
            cashGiven_textBox.Focus();
        }

        private void new_button_Click(object sender, EventArgs e)
        {
            // Code for clearing or emptying the value of the Text property of a textbox
            itemName_textBox.Clear();
            price_textBox.Clear();

            quantity_textBox.Clear();
            amountPaid_textBox.Clear();
            cashGiven_textBox.Clear();
            change_textBox.Clear();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            // Code for closing the execution of the Windows Application 
            this.Close();
        }

        private void Lesson3_Example4_Load(object sender, EventArgs e)
        {
            change_textBox.Enabled = false;
            this.Location = new Point(0, 0); // Set the form's location on the screen
            this.Size = Screen.PrimaryScreen.WorkingArea.Size; // Set the form's size to the working area of the screen
        }
    }
}
