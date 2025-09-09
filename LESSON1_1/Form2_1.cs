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
    public partial class Form2_1 : Form
    {
        public Form2_1()
        {
            InitializeComponent();
        }

        private int totalQuantity = 0;
        private decimal totalDiscount = 0;
        private decimal totalDiscountedAmount = 0;

        // Current item values
        private string currentItem = "";
        private decimal currentPrice = 0;
        private int currentQty = 0;
        private decimal discountRate = 0;

        private void Form2_1_Load(object sender, EventArgs e)
        {
            pictureBox16.Image = Image.FromFile("C:\\Users\\Bernard Ordonez\\source\\DSAL01E\\LESSON1_1\\LESSON1_1\\Resources\\Hawaiian Shoyu Chicken.jpg");
            pictureBox17.Image = Image.FromFile("C:\\Users\\Bernard Ordonez\\source\\DSAL01E\\LESSON1_1\\LESSON1_1\\Resources\\Chicken & Rice Casserole.jpg");
            pictureBox18.Image = Image.FromFile("C:\\Users\\Bernard Ordonez\\source\\DSAL01E\\LESSON1_1\\LESSON1_1\\Resources\\Orange Chicken.jpg");
            pictureBox19.Image = Image.FromFile("C:\\Users\\Bernard Ordonez\\source\\DSAL01E\\LESSON1_1\\LESSON1_1\\Resources\\Chicken Enchiladas.jpg");
            pictureBox20.Image = Image.FromFile("C:\\Users\\Bernard Ordonez\\source\\DSAL01E\\LESSON1_1\\LESSON1_1\\Resources\\Caprese Chicken Gnocchi Skillet.jpg");

            textBox1.ReadOnly = true;   // Name
            textBox2.ReadOnly = false;  // Quantity (editable)
            textBox3.ReadOnly = true;   // Price
            textBox4.ReadOnly = true;   // Discount
            textBox5.ReadOnly = true;   // Discounted Amount
            textBox10.ReadOnly = true;  // Total Quantity
            textBox11.ReadOnly = true;  // Total Discount
            textBox12.ReadOnly = true;  // Total Discounted Amount
            textBox13.ReadOnly = false; // Cash Rendered (editable)
            textBox14.ReadOnly = true;  // Change 

            radioButton4.Checked = true; // Default to "None (0%)"
        }

        // Discount Calculation 
        private void ComputeDiscounts()
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text)) return; // No quantity entered

            if (!int.TryParse(textBox2.Text, out currentQty) || currentQty <= 0)
            {
                MessageBox.Show("Enter a valid quantity.");
                return;
            }

            decimal subtotal = currentPrice * currentQty;
            decimal discountAmount = subtotal * discountRate;
            decimal discountedAmount = subtotal - discountAmount;

            textBox4.Text = discountAmount.ToString("F2");     // Discount Amount
            textBox5.Text = discountedAmount.ToString("F2");   // Discounted Amount
        }
        private void buttonNew_Click(object sender, EventArgs e)
        {
            ClearCurrentOrder();
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            ClearCurrentOrder();
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close(); // Close
        }


        //  Discount Radio Buttons 
        private void radioButton1_CheckedChanged(object sender, EventArgs e) // None (0%)
        {
            if (radioButton1.Checked)
            {
                discountRate = 0.20m;
                ComputeDiscounts();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) // 10%
        {
            if (radioButton2.Checked)
            {
                discountRate = 0.15m;
                ComputeDiscounts();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e) // 20%
        {
            if (radioButton3.Checked)
            {
                discountRate = 0.10m;
                ComputeDiscounts();
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e) // 30%
        {
            if (radioButton4.Checked)
            {
                discountRate = 0.00m;
                ComputeDiscounts();
            }
        }


        // Calculate Button
        private void button17_Click(object sender, EventArgs e) // Calculate
        {
            if (!decimal.TryParse(textBox5.Text, out decimal discountedAmount) || discountedAmount <= 0)
            {
                MessageBox.Show("Please select an item, enter quantity, and apply discount first.");
                return;
            }

            if (!decimal.TryParse(textBox13.Text, out decimal cash))
            {
                MessageBox.Show("Enter valid cash amount.");
                return;
            }

            decimal change = cash - discountedAmount;
            if (change < 0)
            {
                MessageBox.Show("Insufficient cash.");
                return;
            }

            textBox14.Text = change.ToString("F2");

            // Update running totals
            totalQuantity += currentQty;
            totalDiscount += decimal.Parse(textBox4.Text);
            totalDiscountedAmount += discountedAmount;

            textBox10.Text = totalQuantity.ToString();               // Total Quantity
            textBox11.Text = totalDiscount.ToString("F2");           // Total Discount
            textBox12.Text = totalDiscountedAmount.ToString("F2");   // Total Discounted Amount
        }

        // Clear Order 
        private void ClearCurrentOrder()
        {
            textBox1.Clear();  // Name
            textBox2.Clear();  // Quantity
            textBox3.Clear();  // Price
            textBox4.Clear();  // Discount
            textBox5.Clear();  // Discounted Amount
            textBox13.Clear(); // Cash Rendered
            textBox14.Clear(); // Change
                               // KEEP totals in textBox10, textBox11, textBox12
        }

        // Food Items
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            currentItem = "Nashville Hot Chicken";
            currentPrice = 150;
            textBox1.Text = currentItem;
            textBox3.Text = currentPrice.ToString("F2");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            currentItem = "Indian Chicken 65";
            currentPrice = 180;
            textBox1.Text = currentItem;
            textBox3.Text = currentPrice.ToString("F2");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            currentItem = "Taiwanese Popcorn Chicken";
            currentPrice = 160;
            textBox1.Text = currentItem;
            textBox3.Text = currentPrice.ToString("F2");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            currentItem = "Korean Fried Chicken";
            currentPrice = 200;
            textBox1.Text = currentItem;
            textBox3.Text = currentPrice.ToString("F2");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            currentItem = "Southern Fried Chicken";
            currentPrice = 170;
            textBox1.Text = currentItem;
            textBox3.Text = currentPrice.ToString("F2");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            currentItem = "Chili-Honey Glazed Lechon Kawali";
            currentPrice = 220;
            textBox1.Text = currentItem;
            textBox3.Text = currentPrice.ToString("F2");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            currentItem = "Bacon-Wrapped Pork Chop";
            currentPrice = 190;
            textBox1.Text = currentItem;
            textBox3.Text = currentPrice.ToString("F2");
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            currentItem = "Pork Tonkatsu";
            currentPrice = 180;
            textBox1.Text = currentItem;
            textBox3.Text = currentPrice.ToString("F2");
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            currentItem = "Fried Calamansi Pork Chops";
            currentPrice = 175;
            textBox1.Text = currentItem;
            textBox3.Text = currentPrice.ToString("F2");
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            currentItem = "Breaded Pork Chop";
            currentPrice = 160;
            textBox1.Text = currentItem;
            textBox3.Text = currentPrice.ToString("F2");
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            currentItem = "Caramelized Onions and Blue Cheese Beef";
            currentPrice = 250;
            textBox1.Text = currentItem;
            textBox3.Text = currentPrice.ToString("F2");
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            currentItem = "Prime Rib Roast";
            currentPrice = 300;
            textBox1.Text = currentItem;
            textBox3.Text = currentPrice.ToString("F2");
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            currentItem = "Beef Wellington";
            currentPrice = 350;
            textBox1.Text = currentItem;
            textBox3.Text = currentPrice.ToString("F2");
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            currentItem = "The Filet Mignon";
            currentPrice = 320;
            textBox1.Text = currentItem;
            textBox3.Text = currentPrice.ToString("F2");
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            currentItem = "Steak Au Poivre";
            currentPrice = 280;
            textBox1.Text = currentItem;
            textBox3.Text = currentPrice.ToString("F2");
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            currentItem = "Hawaiian Shoyu Chicken";
            currentPrice = 200;
            textBox1.Text = currentItem;
            textBox3.Text = currentPrice.ToString("F2");
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            currentItem = "Chicken & Rice Casserole";
            currentPrice = 180;
            textBox1.Text = currentItem;
            textBox3.Text = currentPrice.ToString("F2");
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            currentItem = "Orange Chicken";
            currentPrice = 190;
            textBox1.Text = currentItem;
            textBox3.Text = currentPrice.ToString("F2");
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            currentItem = "Chicken Enchiladas";
            currentPrice = 210;
            textBox1.Text = currentItem;
            textBox3.Text = currentPrice.ToString("F2");
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            currentItem = "Caprese Chicken Gnocchi Skillet";
            currentPrice = 230;
            textBox1.Text = currentItem;
            textBox3.Text = currentPrice.ToString("F2");
        }
    }
}