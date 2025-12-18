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
    public partial class Lesson3_Example2 : Form
    {
        private double qty_total = 0;
        private double discount_totalgiven = 0;
        private double discounted_total = 0;

        public Lesson3_Example2()
        {
            InitializeComponent();

            // codes for disabling the textboxes
            itemName_textBox.Enabled = false;
            price_textBox.Enabled = false;
            discount_textBox.Enabled = false;
            discounted_textBox.Enabled = false;
            totalQuantity_textBox.Enabled = false;
            totalDiscGiven_textBox.Enabled = false;
            totalDiscAmt_textBox.Enabled = false;
            change_textBox.Enabled = false;

            // codes for loading the images in picture boxes
            pictureBox1.Image = Properties.Resources.BreakfastMeal_A;
            pictureBox2.Image = Properties.Resources.Beef_Tapa;
            pictureBox3.Image = Properties.Resources.BreakfastMealB;
            pictureBox4.Image = Properties.Resources.ChickenMealA;
            pictureBox5.Image = Properties.Resources.FamilyComboMealB;
            pictureBox6.Image = Properties.Resources.FamilyComboMealA;
            pictureBox7.Image = Properties.Resources.FamilyComboMealB;
            pictureBox8.Image = Properties.Resources.JollySpag;
            pictureBox9.Image = Properties.Resources.TwinFries;
            pictureBox10.Image = Properties.Resources.FamilyComboMealA;
            pictureBox11.Image = Properties.Resources.JollySpag;
            pictureBox12.Image = Properties.Resources.JollyShake;
            pictureBox13.Image = Properties.Resources.KFCBurgerCombo;
            pictureBox14.Image = Properties.Resources.ChickenMeal2;
            pictureBox15.Image = Properties.Resources.FamilyComboMealA;
            pictureBox16.Image = Properties.Resources.KFCComboMeal;
            pictureBox17.Image = Properties.Resources.KFCChowFun;
            pictureBox18.Image = Properties.Resources.Burger_Chicken;
            pictureBox19.Image = Properties.Resources.KFCComboMeal;
            pictureBox20.Image = Properties.Resources.FamilyComboMealB;

            // codes for setting the size mode of picture boxes
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox12.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox13.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox14.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox15.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox16.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox17.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox18.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox19.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox20.SizeMode = PictureBoxSizeMode.StretchImage;
        }


        // PictureBox click event handlers: set item name and price for selected menu item
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            itemName_textBox.Text = "Combo Meal A";
            price_textBox.Text = "121.30";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            itemName_textBox.Text = "Breakfast Meal 1";
            price_textBox.Text = "99.00";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            itemName_textBox.Text = "Breakfast Meal 2";
            price_textBox.Text = "99.00";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            itemName_textBox.Text = "Chicken Meal A";
            price_textBox.Text = "119.00";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            itemName_textBox.Text = "Combo Meal B";
            price_textBox.Text = "121.30";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            itemName_textBox.Text = "Group Meal A";
            price_textBox.Text = "140.30";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            itemName_textBox.Text = "Group Meal B";
            price_textBox.Text = "149.30";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            itemName_textBox.Text = "Chicken Spag Meal A";
            price_textBox.Text = "79.00";
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            itemName_textBox.Text = "Twin Fries";
            price_textBox.Text = "109.00";
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            itemName_textBox.Text = "Family Meal A";
            price_textBox.Text = "299.00";
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            itemName_textBox.Text = "Spag Meal 1";
            price_textBox.Text = "79.00";
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            itemName_textBox.Text = "Jolly Shake";
            price_textBox.Text = "59.00";
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            itemName_textBox.Text = "KFC Burger Combo Meal 1";
            price_textBox.Text = "119.00";
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            itemName_textBox.Text = "Chicken Group Meal";
            price_textBox.Text = "149.00";
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            itemName_textBox.Text = "KFC Family Meal A";
            price_textBox.Text = "499.00";
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            itemName_textBox.Text = "KFC Chicken Strips Meal ";
            price_textBox.Text = "109.00";
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            itemName_textBox.Text = "KFC ChowFun Meal";
            price_textBox.Text = "139.00";
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            itemName_textBox.Text = "Burger and Chicken Meal C";
            price_textBox.Text = "129.00";
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            itemName_textBox.Text = "KFC Combo Meal A";
            price_textBox.Text = "159.00";
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            itemName_textBox.Text = "KFC Family Meal B";
            price_textBox.Text = "499.00";
        }

        private void seniorCitizen_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Declaration of variables within a method of an object 
            int qty;
            double price, discount_amt, discounted_amt;

            // convert string data from textboxes to numeric and place it as value of the variable
            qty = Convert.ToInt32(quantity_textBox.Text);
            price = Convert.ToDouble(price_textBox.Text);

            // create a formula needed for computation
            discount_amt = (qty * price) * 0.30;
            discounted_amt = (qty * price) - discount_amt;

            // converting numeric data to string and display it inside the textboxes
            discount_textBox.Text = discount_amt.ToString("n");
            discounted_textBox.Text = discounted_amt.ToString("n");

            // codes for unchecking the other radio buttons in the interface once the senior citizen method executed
            discCard_radioButton.Checked = false;
            empDisc_radioButton.Checked = false;
            noDisc_radioButton.Checked = false;
        }

        private void discCard_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Declaration of variables within a method of an object 
            int qty;
            double price, discount_amt, discounted_amt;

            // convert string data from textboxes to numeric and place it as value of the variable
            qty = Convert.ToInt32(quantity_textBox.Text);
            price = Convert.ToDouble(price_textBox.Text);

            // create a formula needed for computation
            discount_amt = (qty * price) * 0.10;
            discounted_amt = (qty * price) - discount_amt;

            // converting numeric data to string and display it inside the textboxes
            discount_textBox.Text = discount_amt.ToString("n");
            discounted_textBox.Text = discounted_amt.ToString("n");

            // codes for unchecking the other radio buttons in the interface once the disc. card method executed
            seniorCitizen_radioButton.Checked = false;
            empDisc_radioButton.Checked = false;
            noDisc_radioButton.Checked = false;
        }

        private void empDisc_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Declaration of variables within a method of an object 
            int qty;
            double price, discount_amt, discounted_amt;

            // convert string data from textboxes to numeric and place it as value of the variable
            qty = Convert.ToInt32(quantity_textBox.Text);
            price = Convert.ToDouble(price_textBox.Text);

            // create a formula needed for computation
            discount_amt = (qty * price) * 0.15;
            discounted_amt = (qty * price) - discount_amt;

            // converting numeric data to string and display it inside the textboxes
            discount_textBox.Text = discount_amt.ToString("n");
            discounted_textBox.Text = discounted_amt.ToString("n");

            // codes for unchecking the other radio buttons in the interface once the Employee disc method executed
            seniorCitizen_radioButton.Checked = false;
            discCard_radioButton.Checked = false;
            noDisc_radioButton.Checked = false;
        }

        private void noDisc_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Declaration of variables within a method of an object 
            int qty;
            double price, discount_amt, discounted_amt;

            // convert string data from textboxes to numeric and place it as value of the variable
            qty = Convert.ToInt32(quantity_textBox.Text);
            price = Convert.ToDouble(price_textBox.Text);

            // create a formula needed for computation
            discount_amt = (qty * price) * 0;
            discounted_amt = (qty * price) - discount_amt;

            // converting numeric data to string and display it inside the textboxes
            discount_textBox.Text = discount_amt.ToString("n");
            discounted_textBox.Text = discounted_amt.ToString("n");

            // codes for unchecking the other radio buttons in the interface once the senior citizen method executed
            seniorCitizen_radioButton.Checked = false;
            discCard_radioButton.Checked = false;
            empDisc_radioButton.Checked = false;
        }

        private void calculate_button_Click(object sender, EventArgs e)
        {
            //declaration of variables with data types
            int qty;
            double discount_amt, discounted_amt, cash_rendered, change;
            qty = Convert.ToInt32(quantity_textBox.Text);
            discount_amt = Convert.ToDouble(discount_textBox.Text);
            discounted_amt = Convert.ToDouble(discounted_textBox.Text);
            cash_rendered = Convert.ToDouble(cashRendered_textBox.Text);

            qty_total += qty;
            discount_totalgiven += discount_amt;
            discounted_total += discounted_amt;
            change = cash_rendered - discounted_amt;

            // converting string data form textboxes to numeric and place it as value of the variable
            totalQuantity_textBox.Text = qty_total.ToString();
            totalDiscGiven_textBox.Text = discount_totalgiven.ToString("n");
            totalDiscAmt_textBox.Text = discounted_total.ToString("n");
            change_textBox.Text = change.ToString("n");
            cashRendered_textBox.Text = cash_rendered.ToString("n");
        }

        private void new_button_Click(object sender, EventArgs e)
        {
            //codes for clearing specific pointed textboxes
            itemName_textBox.Clear();
            price_textBox.Clear();
            quantity_textBox.Clear();
            discount_textBox.Clear();
            discounted_textBox.Clear();
            change_textBox.Clear();
            cashRendered_textBox.Clear();

            seniorCitizen_radioButton.Checked = false;
            discCard_radioButton.Checked = false;
            empDisc_radioButton.Checked = false;
            noDisc_radioButton.Checked = false;
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
