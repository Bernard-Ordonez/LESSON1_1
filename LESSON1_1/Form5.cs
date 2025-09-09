using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LESSON1_1
{
    public partial class Form5 : Form
    {
        private double total_amount = 0;
        private int total_qty = 0;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false; // Price
            richTextBox2.Enabled = false; // Discounted Amount
            richTextBox6.Enabled = false; // Change
            richTextBox3.Enabled = false; // Total Bills
            richTextBox1.Enabled = false; // Discount Amount
            richTextBox4.Enabled = false; // Total Quantity

            pictureBox6.Image = Image.FromFile(@"C:\Users\Bernard Ordonez\source\DSAL01E\LESSON1_1\LESSON1_1\Resources\Chili-Honey Glazed Lechon Kawali.jpg");
            pictureBox7.Image = Image.FromFile(@"C:\Users\Bernard Ordonez\source\DSAL01E\LESSON1_1\LESSON1_1\Resources\Bacon-Wrapped Pork Chop.jpg");
            pictureBox8.Image = Image.FromFile(@"C:\Users\Bernard Ordonez\source\DSAL01E\LESSON1_1\LESSON1_1\Resources\Pork Tonkatsu.jpg");
            pictureBox9.Image = Image.FromFile(@"C:\Users\Bernard Ordonez\source\DSAL01E\LESSON1_1\LESSON1_1\Resources\Fried Calamansi Pork Chops.jpg");
            pictureBox10.Image = Image.FromFile(@"C:\Users\Bernard Ordonez\source\DSAL01E\LESSON1_1\LESSON1_1\Resources\Breaded Pork Chop.jpg");

            pictureBox11.Image = Image.FromFile(@"C:\Users\Bernard Ordonez\source\DSAL01E\LESSON1_1\LESSON1_1\Resources\Carmalized Onions and Blue Cheese beef.jpg");
            pictureBox12.Image = Image.FromFile(@"C:\Users\Bernard Ordonez\source\DSAL01E\LESSON1_1\LESSON1_1\Resources\Prime Rib Roast.jpg");
            pictureBox13.Image = Image.FromFile(@"C:\Users\Bernard Ordonez\source\DSAL01E\LESSON1_1\LESSON1_1\Resources\Beef Wellington.jpg");
            pictureBox14.Image = Image.FromFile(@"C:\Users\Bernard Ordonez\source\DSAL01E\LESSON1_1\LESSON1_1\Resources\The Filet Mignon.jpg");
            pictureBox15.Image = Image.FromFile(@"C:\Users\Bernard Ordonez\source\DSAL01E\LESSON1_1\LESSON1_1\Resources\Steak Au Poivre.jpg");

            pictureBox16.Image = Image.FromFile(@"C:\Users\Bernard Ordonez\source\DSAL01E\LESSON1_1\LESSON1_1\Resources\Hawaiian Shoyu Chicken.jpg");
            pictureBox17.Image = Image.FromFile(@"C:\Users\Bernard Ordonez\source\DSAL01E\LESSON1_1\LESSON1_1\Resources\Chicken & Rice Casserole.jpg");
            pictureBox18.Image = Image.FromFile(@"C:\Users\Bernard Ordonez\source\DSAL01E\LESSON1_1\LESSON1_1\Resources\Orange Chicken.jpg");
            pictureBox19.Image = Image.FromFile(@"C:\Users\Bernard Ordonez\source\DSAL01E\LESSON1_1\LESSON1_1\Resources\Chicken Enchiladas.jpg");
            pictureBox20.Image = Image.FromFile(@"C:\Users\Bernard Ordonez\source\DSAL01E\LESSON1_1\LESSON1_1\Resources\Caprese Chicken Gnocchi Skillet.jpg");

            foreach (Control c in this.Controls)
            {
                if (c is PictureBox pb)
                {
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                double price = 1000.00;   // given bundle price
                double discount = 200.00; // given discount

                // Change background
                this.BackColor = Color.LightCyan;

                pictureBox22.Image = Image.FromFile(@"C:\Users\Bernard Ordonez\source\DSAL01E\LESSON1_1\LESSON1_1\Resources\Bundle A.jpg");
                pictureBox22.SizeMode = PictureBoxSizeMode.StretchImage;

                textBox1.Enabled = false;      // Price
                textBox2.Enabled = false;      // Quantity
                richTextBox2.Enabled = false;  // Discounted Amount
                richTextBox1.Enabled = false;  // Discount Amount
                richTextBox5.Enabled = false;  // Cash Given

                textBox1.Text = price.ToString("N2");         // Price textbox
                richTextBox1.Text = discount.ToString("N2");  // Discount Amount

                // Add to ListBox
                listBox1.Items.Add(radioButton1.Text + " " + textBox1.Text);
                listBox1.Items.Add("         Discount Amount: " + richTextBox1.Text);

                // Reset quantity
                textBox2.Text = "0";
                textBox2.Focus();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                double price = 1299.00;                  // given bundle price
                double discount = price * 0.15;          // 15% discount

                // Change background
                this.BackColor = Color.LightBlue;

                // Show bundle image (replace with actual path)
                pictureBox22.Image = Image.FromFile(@"C:\Users\Bernard Ordonez\source\DSAL01E\LESSON1_1\LESSON1_1\Resources\Bundle B.jpg");
                pictureBox22.SizeMode = PictureBoxSizeMode.StretchImage;

                // Disable textboxes 1–5
                textBox1.Enabled = false;      // Price
                textBox2.Enabled = false;      // Quantity
                richTextBox2.Enabled = false;  // Discounted Amount
                richTextBox1.Enabled = false;  // Discount Amount
                richTextBox5.Enabled = false;  // Cash Given

                // Fill values
                textBox1.Text = price.ToString("N2");        // Price textbox
                richTextBox1.Text = discount.ToString("N2"); // Discount Amount

                // Add to ListBox
                listBox1.Items.Add(radioButton2.Text + " " + textBox1.Text);
                listBox1.Items.Add("         Discount Amount: " + richTextBox1.Text);

                // Reset quantity
                textBox2.Text = "0";
                textBox2.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                // Convert inputs to double
                double cashGiven = Convert.ToDouble(richTextBox5.Text);
                double totalAmountPaid = Convert.ToDouble(richTextBox3.Text);

                // Calculate change
                double change = cashGiven - totalAmountPaid;

                // Display change
                richTextBox6.Text = change.ToString("N2");

                // Add summary to ListBox
                listBox1.Items.Add("Total Bills: " + richTextBox3.Text);
                listBox1.Items.Add("Cash Given: " + richTextBox5.Text);
                listBox1.Items.Add("Change: " + richTextBox6.Text);
                listBox1.Items.Add("Total No. of Items: " + richTextBox4.Text);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form5_Listbox_ print = new Form5_Listbox_();
            print.listBox2.items.AddRange(this.listBox1.Items);
            print.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // 1. Uncheck both food bundles
            radioButton1.Checked = false;
            radioButton2.Checked = false;

            // 2. Enable both bundles again
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;

            // 3. Reset PB22 to default image
            pictureBox22.Image = Image.FromFile(@"C:\Users\Bernard Ordonez\source\DSAL01E\LESSON1_1\LESSON1_1\Resources\images.jpg");
            pictureBox22.SizeMode = PictureBoxSizeMode.StretchImage;

            // 4. Uncheck individual food checkboxes manually (1–30)
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox14.Checked = false;
            checkBox15.Checked = false;
            checkBox16.Checked = false;
            checkBox17.Checked = false;
            checkBox18.Checked = false;
            checkBox19.Checked = false;
            checkBox20.Checked = false;
            checkBox21.Checked = false;
            checkBox22.Checked = false;
            checkBox23.Checked = false;
            checkBox24.Checked = false;
            checkBox25.Checked = false;
            checkBox26.Checked = false;
            checkBox27.Checked = false;
            checkBox28.Checked = false;
            checkBox29.Checked = false;
            checkBox30.Checked = false;

            // 5. Reset textboxes/richTextboxes
            textBox1.Text = "";
            textBox2.Text = "0";
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            richTextBox3.Text = "";
            richTextBox4.Text = "";
            richTextBox5.Text = "";
            richTextBox6.Text = "";

            // 6. Clear listbox
            listBox1.Items.Clear();

            // 7. Reset form background
            this.BackColor = SystemColors.Control;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Declare variables
            double price, discountedAmt, discountAmt;
            int quantity;

            // Convert values from textboxes/richTextBoxes
            price = Convert.ToDouble(textBox1.Text);               // Price textbox
            quantity = Convert.ToInt32(textBox2.Text);            // Quantity textbox
            discountAmt = Convert.ToDouble(richTextBox1.Text);    // Discount Amount textbox

            // Calculate discounted amount for current item
            discountedAmt = (price * quantity) - discountAmt;

            // Update running totals
            total_qty += quantity;
            total_amount += discountedAmt;

            // Display results in textboxes/richTextBoxes
            richTextBox2.Text = discountedAmt.ToString("N2");     // Discounted Amount for this item
            richTextBox3.Text = total_amount.ToString("N2");      // Total Bills
            richTextBox4.Text = total_qty.ToString();             // Total Quantity
        }

        // CheckBox6–CheckBox10
        private void checkBox6_Click(object sender, EventArgs e)
        {
            double price;
            textBox1.Text = "500.99";
            richTextBox1.Text = "0.00";
            price = Convert.ToDouble(textBox1.Text);
            listBox1.Items.Add(checkBox6.Text + " " + textBox1.Text);
            textBox2.Text = "0";
            textBox2.Focus();
        }

        private void checkBox7_Click(object sender, EventArgs e)
        {
            double price;
            textBox1.Text = "275.50";
            richTextBox1.Text = "0.00";
            price = Convert.ToDouble(textBox1.Text);
            listBox1.Items.Add(checkBox7.Text + " " + textBox1.Text);
            textBox2.Text = "0";
            textBox2.Focus();
        }

        private void checkBox8_Click(object sender, EventArgs e)
        {
            double price;
            textBox1.Text = "199.75";
            richTextBox1.Text = "0.00";
            price = Convert.ToDouble(textBox1.Text);
            listBox1.Items.Add(checkBox8.Text + " " + textBox1.Text);
            textBox2.Text = "0";
            textBox2.Focus();
        }

        private void checkBox9_Click(object sender, EventArgs e)
        {
            double price;
            textBox1.Text = "350.20";
            richTextBox1.Text = "0.00";
            price = Convert.ToDouble(textBox1.Text);
            listBox1.Items.Add(checkBox9.Text + " " + textBox1.Text);
            textBox2.Text = "0";
            textBox2.Focus();
        }

        private void checkBox10_Click(object sender, EventArgs e)
        {
            double price;
            textBox1.Text = "420.60";
            richTextBox1.Text = "0.00";
            price = Convert.ToDouble(textBox1.Text);
            listBox1.Items.Add(checkBox10.Text + " " + textBox1.Text);
            textBox2.Text = "0";
            textBox2.Focus();
        }

        // CheckBox16–CheckBox30
        private void checkBox16_Click(object sender, EventArgs e)
        {
            double price;
            textBox1.Text = "145.90";
            richTextBox1.Text = "0.00";
            price = Convert.ToDouble(textBox1.Text);
            listBox1.Items.Add(checkBox16.Text + " " + textBox1.Text);
            textBox2.Text = "0";
            textBox2.Focus();
        }

        private void checkBox17_Click(object sender, EventArgs e)
        {
            double price;
            textBox1.Text = "380.60";
            richTextBox1.Text = "0.00";
            price = Convert.ToDouble(textBox1.Text);
            listBox1.Items.Add(checkBox17.Text + " " + textBox1.Text);
            textBox2.Text = "0";
            textBox2.Focus();
        }

        private void checkBox18_Click(object sender, EventArgs e)
        {
            double price;
            textBox1.Text = "225.35";
            richTextBox1.Text = "0.00";
            price = Convert.ToDouble(textBox1.Text);
            listBox1.Items.Add(checkBox18.Text + " " + textBox1.Text);
            textBox2.Text = "0";
            textBox2.Focus();
        }

        private void checkBox19_Click(object sender, EventArgs e)
        {
            double price;
            textBox1.Text = "410.00";
            richTextBox1.Text = "0.00";
            price = Convert.ToDouble(textBox1.Text);
            listBox1.Items.Add(checkBox19.Text + " " + textBox1.Text);
            textBox2.Text = "0";
            textBox2.Focus();
        }

        private void checkBox20_Click(object sender, EventArgs e)
        {
            double price;
            textBox1.Text = "330.45";
            richTextBox1.Text = "0.00";
            price = Convert.ToDouble(textBox1.Text);
            listBox1.Items.Add(checkBox20.Text + " " + textBox1.Text);
            textBox2.Text = "0";
            textBox2.Focus();
        }

        private void checkBox21_Click(object sender, EventArgs e)
        {
            double price;
            textBox1.Text = "150.80";
            richTextBox1.Text = "0.00";
            price = Convert.ToDouble(textBox1.Text);
            listBox1.Items.Add(checkBox21.Text + " " + textBox1.Text);
            textBox2.Text = "0";
            textBox2.Focus();
        }

        private void checkBox22_Click(object sender, EventArgs e)
        {
            double price;
            textBox1.Text = "295.25";
            richTextBox1.Text = "0.00";
            price = Convert.ToDouble(textBox1.Text);
            listBox1.Items.Add(checkBox22.Text + " " + textBox1.Text);
            textBox2.Text = "0";
            textBox2.Focus();
        }

        private void checkBox23_Click(object sender, EventArgs e)
        {
            double price;
            textBox1.Text = "360.90";
            richTextBox1.Text = "0.00";
            price = Convert.ToDouble(textBox1.Text);
            listBox1.Items.Add(checkBox23.Text + " " + textBox1.Text);
            textBox2.Text = "0";
            textBox2.Focus();
        }

        private void checkBox24_Click(object sender, EventArgs e)
        {
            double price;
            textBox1.Text = "280.10";
            richTextBox1.Text = "0.00";
            price = Convert.ToDouble(textBox1.Text);
            listBox1.Items.Add(checkBox24.Text + " " + textBox1.Text);
            textBox2.Text = "0";
            textBox2.Focus();
        }

        private void checkBox25_Click(object sender, EventArgs e)
        {
            double price;
            textBox1.Text = "315.75";
            richTextBox1.Text = "0.00";
            price = Convert.ToDouble(textBox1.Text);
            listBox1.Items.Add(checkBox25.Text + " " + textBox1.Text);
            textBox2.Text = "0";
            textBox2.Focus();
        }

        private void checkBox26_Click(object sender, EventArgs e)
        {
            double price;
            textBox1.Text = "190.60";
            richTextBox1.Text = "0.00";
            price = Convert.ToDouble(textBox1.Text);
            listBox1.Items.Add(checkBox26.Text + " " + textBox1.Text);
            textBox2.Text = "0";
            textBox2.Focus();
        }

        private void checkBox27_Click(object sender, EventArgs e)
        {
            double price;
            textBox1.Text = "270.40";
            richTextBox1.Text = "0.00";
            price = Convert.ToDouble(textBox1.Text);
            listBox1.Items.Add(checkBox27.Text + " " + textBox1.Text);
            textBox2.Text = "0";
            textBox2.Focus();
        }

        private void checkBox28_Click(object sender, EventArgs e)
        {
            double price;
            textBox1.Text = "385.80";
            richTextBox1.Text = "0.00";
            price = Convert.ToDouble(textBox1.Text);
            listBox1.Items.Add(checkBox28.Text + " " + textBox1.Text);
            textBox2.Text = "0";
            textBox2.Focus();
        }

        private void checkBox29_Click(object sender, EventArgs e)
        {
            double price;
            textBox1.Text = "320.50";
            richTextBox1.Text = "0.00";
            price = Convert.ToDouble(textBox1.Text);
            listBox1.Items.Add(checkBox29.Text + " " + textBox1.Text);
            textBox2.Text = "0";
            textBox2.Focus();
        }

        private void checkBox30_Click(object sender, EventArgs e)
        {
            double price;
            textBox1.Text = "245.90";
            richTextBox1.Text = "0.00";
            price = Convert.ToDouble(textBox1.Text);
            listBox1.Items.Add(checkBox30.Text + " " + textBox1.Text);
            textBox2.Text = "0";
            textBox2.Focus();
        }
    }
}
