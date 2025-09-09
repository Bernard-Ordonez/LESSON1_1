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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        private int quantity = 0;
        private decimal itemPrice = 0;
        private string itemName = "";
        private int totalQuantity = 0;
        private decimal totalDiscount = 0;
        private decimal totalDiscountedAmount = 0;

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            int qty;
            double price;

            if (!int.TryParse(textBox2.Text, out qty) || !double.TryParse(textBox3.Text, out price))
            {
                MessageBox.Show("Enter valid Quantity and Price first.");
                return;
            }

        }

        private string lastItemName = "";
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            itemName = "Nashville Hot Chicken";
            itemPrice = 150;
            textBox1.Text = itemName;

            if (lastItemName != itemName)
            {
                quantity = 0;
                lastItemName = itemName;
            }

            quantity++;
            textBox2.Text = quantity.ToString();
            textBox3.Text = (itemPrice * quantity).ToString("N2");

            totalQuantity += 1;
            totalDiscount += 0;
            totalDiscountedAmount += itemPrice;

            textBox10.Text = totalQuantity.ToString();
            textBox11.Text = totalDiscount.ToString("N2");
            textBox12.Text = totalDiscountedAmount.ToString("N2");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            itemName = "Indian Chicken 65";
            itemPrice = 160;
            textBox1.Text = itemName;

            if (lastItemName != itemName)
            {
                quantity = 0;
                lastItemName = itemName;
            }

            quantity++;
            textBox2.Text = quantity.ToString();
            textBox3.Text = (itemPrice * quantity).ToString("N2");

            totalQuantity += 1;
            totalDiscount += 0;
            totalDiscountedAmount += itemPrice;

            textBox10.Text = totalQuantity.ToString();
            textBox11.Text = totalDiscount.ToString("N2");
            textBox12.Text = totalDiscountedAmount.ToString("N2");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            itemName = "Taiwanese Popcorn Chicken";
            itemPrice = 140;
            textBox1.Text = itemName;

            if (lastItemName != itemName)
            {
                quantity = 0;
                lastItemName = itemName;
            }

            quantity++;
            textBox2.Text = quantity.ToString();
            textBox3.Text = (itemPrice * quantity).ToString("N2");

            totalQuantity += 1;
            totalDiscount += 0;
            totalDiscountedAmount += itemPrice;

            textBox10.Text = totalQuantity.ToString();
            textBox11.Text = totalDiscount.ToString("N2");
            textBox12.Text = totalDiscountedAmount.ToString("N2");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            itemName = "Korean Fried Chicken";
            itemPrice = 180;
            textBox1.Text = itemName;

            if (lastItemName != itemName)
            {
                quantity = 0;
                lastItemName = itemName;
            }

            quantity++;
            textBox2.Text = quantity.ToString();
            textBox3.Text = (itemPrice * quantity).ToString("N2");

            totalQuantity += 1;
            totalDiscount += 0;
            totalDiscountedAmount += itemPrice;

            textBox10.Text = totalQuantity.ToString();
            textBox11.Text = totalDiscount.ToString("N2");
            textBox12.Text = totalDiscountedAmount.ToString("N2");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            itemName = "Southern Fried Chicken";
            itemPrice = 170;
            textBox1.Text = itemName;

            if (lastItemName != itemName)
            {
                quantity = 0;
                lastItemName = itemName;
            }

            quantity++;
            textBox2.Text = quantity.ToString();
            textBox3.Text = (itemPrice * quantity).ToString("N2");

            totalQuantity += 1;
            totalDiscount += 0;
            totalDiscountedAmount += itemPrice;

            textBox10.Text = totalQuantity.ToString();
            textBox11.Text = totalDiscount.ToString("N2");
            textBox12.Text = totalDiscountedAmount.ToString("N2");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            itemName = "Chili-Honey Glazed Lechon Kawali";
            itemPrice = 200;
            textBox1.Text = itemName;

            if (lastItemName != itemName)
            {
                quantity = 0;
                lastItemName = itemName;
            }

            quantity++;
            textBox2.Text = quantity.ToString();
            textBox3.Text = (itemPrice * quantity).ToString("N2");

            totalQuantity += 1;
            totalDiscount += 0;
            totalDiscountedAmount += itemPrice;

            textBox10.Text = totalQuantity.ToString();
            textBox11.Text = totalDiscount.ToString("N2");
            textBox12.Text = totalDiscountedAmount.ToString("N2");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            itemName = "Bacon-Wrapped Pork Chop";
            itemPrice = 220;
            textBox1.Text = itemName;

            if (lastItemName != itemName)
            {
                quantity = 0;
                lastItemName = itemName;
            }

            quantity++;
            textBox2.Text = quantity.ToString();
            textBox3.Text = (itemPrice * quantity).ToString("N2");

            totalQuantity += 1;
            totalDiscount += 0;
            totalDiscountedAmount += itemPrice;

            textBox10.Text = totalQuantity.ToString();
            textBox11.Text = totalDiscount.ToString("N2");
            textBox12.Text = totalDiscountedAmount.ToString("N2");
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            itemName = "Pork Tonkatsu";
            itemPrice = 180;
            textBox1.Text = itemName;

            if (lastItemName != itemName)
            {
                quantity = 0;
                lastItemName = itemName;
            }

            quantity++;
            textBox2.Text = quantity.ToString();
            textBox3.Text = (itemPrice * quantity).ToString("N2");

            totalQuantity += 1;
            totalDiscount += 0;
            totalDiscountedAmount += itemPrice;

            textBox10.Text = totalQuantity.ToString();
            textBox11.Text = totalDiscount.ToString("N2");
            textBox12.Text = totalDiscountedAmount.ToString("N2");
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            itemName = "Fried Calamansi Pork Chops";
            itemPrice = 190;
            textBox1.Text = itemName;

            if (lastItemName != itemName)
            {
                quantity = 0;
                lastItemName = itemName;
            }

            quantity++;
            textBox2.Text = quantity.ToString();
            textBox3.Text = (itemPrice * quantity).ToString("N2");

            totalQuantity += 1;
            totalDiscount += 0;
            totalDiscountedAmount += itemPrice;

            textBox10.Text = totalQuantity.ToString();
            textBox11.Text = totalDiscount.ToString("N2");
            textBox12.Text = totalDiscountedAmount.ToString("N2");
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            itemName = "Breaded Pork Chop";
            itemPrice = 160;
            textBox1.Text = itemName;

            if (lastItemName != itemName)
            {
                quantity = 0;
                lastItemName = itemName;
            }

            quantity++;
            textBox2.Text = quantity.ToString();
            textBox3.Text = (itemPrice * quantity).ToString("N2");

            totalQuantity += 1;
            totalDiscount += 0;
            totalDiscountedAmount += itemPrice;

            textBox10.Text = totalQuantity.ToString();
            textBox11.Text = totalDiscount.ToString("N2");
            textBox12.Text = totalDiscountedAmount.ToString("N2");
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            itemName = "Caramelized Onions and Blue Cheese Beef";
            itemPrice = 250;
            textBox1.Text = itemName;

            if (lastItemName != itemName)
            {
                quantity = 0;
                lastItemName = itemName;
            }

            quantity++;
            textBox2.Text = quantity.ToString();
            textBox3.Text = (itemPrice * quantity).ToString("N2");

            totalQuantity += 1;
            totalDiscount += 0;
            totalDiscountedAmount += itemPrice;

            textBox10.Text = totalQuantity.ToString();
            textBox11.Text = totalDiscount.ToString("N2");
            textBox12.Text = totalDiscountedAmount.ToString("N2");
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            itemName = "Prime Rib Roast";
            itemPrice = 300;
            textBox1.Text = itemName;

            if (lastItemName != itemName)
            {
                quantity = 0;
                lastItemName = itemName;
            }

            quantity++;
            textBox2.Text = quantity.ToString();
            textBox3.Text = (itemPrice * quantity).ToString("N2");

            totalQuantity += 1;
            totalDiscount += 0;
            totalDiscountedAmount += itemPrice;

            textBox10.Text = totalQuantity.ToString();
            textBox11.Text = totalDiscount.ToString("N2");
            textBox12.Text = totalDiscountedAmount.ToString("N2");
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            itemName = "Beef Wellington";
            itemPrice = 400;
            textBox1.Text = itemName;

            if (lastItemName != itemName)
            {
                quantity = 0;
                lastItemName = itemName;
            }

            quantity++;
            textBox2.Text = quantity.ToString();
            textBox3.Text = (itemPrice * quantity).ToString("N2");

            totalQuantity += 1;
            totalDiscount += 0;
            totalDiscountedAmount += itemPrice;

            textBox10.Text = totalQuantity.ToString();
            textBox11.Text = totalDiscount.ToString("N2");
            textBox12.Text = totalDiscountedAmount.ToString("N2");
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            itemName = "The Filet Mignon";
            itemPrice = 380;
            textBox1.Text = itemName;

            if (lastItemName != itemName)
            {
                quantity = 0;
                lastItemName = itemName;
            }

            quantity++;
            textBox2.Text = quantity.ToString();
            textBox3.Text = (itemPrice * quantity).ToString("N2");

            totalQuantity += 1;
            totalDiscount += 0;
            totalDiscountedAmount += itemPrice;

            textBox10.Text = totalQuantity.ToString();
            textBox11.Text = totalDiscount.ToString("N2");
            textBox12.Text = totalDiscountedAmount.ToString("N2");
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            itemName = "Steak Au Poivre";
            itemPrice = 350;
            textBox1.Text = itemName;

            if (lastItemName != itemName)
            {
                quantity = 0;
                lastItemName = itemName;
            }

            quantity++;
            textBox2.Text = quantity.ToString();
            textBox3.Text = (itemPrice * quantity).ToString("N2");

            totalQuantity += 1;
            totalDiscount += 0;
            totalDiscountedAmount += itemPrice;

            textBox10.Text = totalQuantity.ToString();
            textBox11.Text = totalDiscount.ToString("N2");
            textBox12.Text = totalDiscountedAmount.ToString("N2");
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            itemName = "Hawaiian Shoyu Chicken";
            itemPrice = 200;
            textBox1.Text = itemName;

            if (lastItemName != itemName)
            {
                quantity = 0;
                lastItemName = itemName;
            }

            quantity++;
            textBox2.Text = quantity.ToString();
            textBox3.Text = (itemPrice * quantity).ToString("N2");

            totalQuantity += 1;
            totalDiscount += 0;
            totalDiscountedAmount += itemPrice;

            textBox10.Text = totalQuantity.ToString();
            textBox11.Text = totalDiscount.ToString("N2");
            textBox12.Text = totalDiscountedAmount.ToString("N2");
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            itemName = "Chicken Rice Casserole";
            itemPrice = 210;
            textBox1.Text = itemName;

            if (lastItemName != itemName)
            {
                quantity = 0;
                lastItemName = itemName;
            }

            quantity++;
            textBox2.Text = quantity.ToString();
            textBox3.Text = (itemPrice * quantity).ToString("N2");

            totalQuantity += 1;
            totalDiscount += 0;
            totalDiscountedAmount += itemPrice;

            textBox10.Text = totalQuantity.ToString();
            textBox11.Text = totalDiscount.ToString("N2");
            textBox12.Text = totalDiscountedAmount.ToString("N2");
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            itemName = "Orange Chicken";
            itemPrice = 180;
            textBox1.Text = itemName;

            if (lastItemName != itemName)
            {
                quantity = 0;
                lastItemName = itemName;
            }

            quantity++;
            textBox2.Text = quantity.ToString();
            textBox3.Text = (itemPrice * quantity).ToString("N2");

            totalQuantity += 1;
            totalDiscount += 0;
            totalDiscountedAmount += itemPrice;

            textBox10.Text = totalQuantity.ToString();
            textBox11.Text = totalDiscount.ToString("N2");
            textBox12.Text = totalDiscountedAmount.ToString("N2");
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            itemName = "Chicken Enchiladas";
            itemPrice = 230;
            textBox1.Text = itemName;

            if (lastItemName != itemName)
            {
                quantity = 0;
                lastItemName = itemName;
            }

            quantity++;
            textBox2.Text = quantity.ToString();
            textBox3.Text = (itemPrice * quantity).ToString("N2");

            totalQuantity += 1;
            totalDiscount += 0;
            totalDiscountedAmount += itemPrice;

            textBox10.Text = totalQuantity.ToString();
            textBox11.Text = totalDiscount.ToString("N2");
            textBox12.Text = totalDiscountedAmount.ToString("N2");
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            itemName = "Caprese Chicken Gnocchi Skillet";
            itemPrice = 240;
            textBox1.Text = itemName;

            if (lastItemName != itemName)
            {
                quantity = 0;
                lastItemName = itemName;
            }

            quantity++;
            textBox2.Text = quantity.ToString();
            textBox3.Text = (itemPrice * quantity).ToString("N2");

            totalQuantity += 1;
            totalDiscount += 0;
            totalDiscountedAmount += itemPrice;

            textBox10.Text = totalQuantity.ToString();
            textBox11.Text = totalDiscount.ToString("N2");
            textBox12.Text = totalDiscountedAmount.ToString("N2");
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            decimal totalPrice = decimal.Parse(textBox3.Text);

            decimal discountRate = 0;

            if (radioButton1.Checked) // Senior Citizen
                discountRate = 0.30m;
            else if (radioButton2.Checked) // With Disc. Card (Regular Discount)
                discountRate = 0.10m;
            else if (radioButton3.Checked) // Employee Discount
                discountRate = 0.15m;
            else if (radioButton4.Checked) // No Discount
                discountRate = 0.00m;

            // Compute discount
            decimal discountAmount = totalPrice * discountRate;
            decimal discountedTotal = totalPrice - discountAmount;

            // Display in Textboxes
            textBox4.Text = discountAmount.ToString("N2");
            textBox5.Text = discountedTotal.ToString("N2");
        }
        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBox13.Text, out decimal cashRendered) &&
        decimal.TryParse(textBox5.Text, out decimal discountedTotal))
            {
                decimal change = cashRendered - discountedTotal;
                textBox14.Text = change.ToString("N2");
            }
            else
            {
                textBox14.Text = "0.00";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            decimal totalPrice = 0;
            decimal discountRate = 0;

            decimal.TryParse(textBox3.Text, out totalPrice);

            if (radioButton1.Checked) // Senior Citizen
                discountRate = 0.30m;
            else if (radioButton2.Checked) // With Disc. Card (Regular Discount)
                discountRate = 0.10m;
            else if (radioButton3.Checked) // Employee Discount
                discountRate = 0.15m;
            else if (radioButton4.Checked) // No Discount
                discountRate = 0.00m;

            decimal discountAmount = totalPrice * discountRate;
            decimal discountedTotal = totalPrice - discountAmount;

            textBox4.Text = discountAmount.ToString("N2");
            textBox5.Text = discountedTotal.ToString("N2");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Clear();  // Item Name
            textBox2.Clear();  // Quantity
            textBox3.Clear();  // Total Price (before discount)
            textBox4.Clear();  // Discount Amount
            textBox5.Clear();  // Discounted Total
            textBox13.Clear();  // Cash Rendered
            textBox14.Clear(); // Change

            // Reset radio buttons
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = true;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            button18_Click(sender, e);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


