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
    public partial class SQL_POS2 : Form
    {
        private double total_amount = 0;
        private int total_qty = 0;

        private int currentItemLastQuantity = 0;
        private double currentItemLastAmount = 0.0;
        private bool updatingQuantity = false;

        //ADDED: Lesson 14 Actvity 3 - 11/5/2025
        pos_dbconnection posdb_connect = new pos_dbconnection();
        Price_Item_Value price_discountamount_value = new Price_Item_Value();
        Variables variables = new Variables();

        public SQL_POS2()
        {
            InitializeComponent();
            //ADDED: Lesson 14 Actvity 3 - 11/5/2025
            posdb_connect.pos_connString();
        }

        private void HandleCheckBoxClick(CheckBox chk, double price)
        {
            // Assign values
            textBox1.Text = price.ToString("N2");  // Set price
            richTextBox1.Text = "0.00";            // No discount

            // Add to listbox
            listBox1.Items.Add(chk.Text + " " + textBox1.Text);
            updatingQuantity = true;
            textBox2.Text = "0";
            updatingQuantity = false;

            currentItemLastQuantity = 0;
            currentItemLastAmount = 0.0;

            textBox2.Focus();
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

                checkBox11.Checked = true;
                checkBox12.Checked = true;
                checkBox13.Checked = true;
                checkBox14.Checked = true; 
                checkBox15.Checked = true;

                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;

                pictureBox22.Image = Image.FromFile(@"C:\Users\Bernard Ordonez\source\DSAL01E\LESSON1_1\LESSON1_1\Resources\Bundle A.jpg");
                pictureBox22.SizeMode = PictureBoxSizeMode.StretchImage;

                textBox1.Enabled = false;      // Price
                richTextBox2.Enabled = false;  // Discounted Amount
                richTextBox1.Enabled = false;  // Discount Amount

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

                checkBox1.Checked = true;
                checkBox2.Checked = true;
                checkBox3.Checked = true;
                checkBox4.Checked = true;
                checkBox5.Checked = true;

                checkBox11.Checked = false;
                checkBox12.Checked = false;
                checkBox13.Checked = false;
                checkBox14.Checked = false;
                checkBox15.Checked = false;



                // Show bundle image (replace with actual path)
                pictureBox22.Image = Image.FromFile(@"C:\Users\Bernard Ordonez\source\DSAL01E\LESSON1_1\LESSON1_1\Resources\Bundle B.jpg");
                pictureBox22.SizeMode = PictureBoxSizeMode.StretchImage;

                // Disable textboxes 1–5
                textBox1.Enabled = false;      // Price
                richTextBox2.Enabled = false;  // Discounted Amount
                richTextBox1.Enabled = false;  // Discount Amount

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
            try
            {
                double cashGiven = Convert.ToDouble(richTextBox5.Text);
                double totalAmountPaid = Convert.ToDouble(richTextBox3.Text);

                double change = cashGiven - totalAmountPaid;
                richTextBox6.Text = change.ToString("N2");

                listBox1.Items.Add("Total Bills: " + richTextBox3.Text);
                listBox1.Items.Add("Cash Given: " + richTextBox5.Text);
                listBox1.Items.Add("Change: " + richTextBox6.Text);
                listBox1.Items.Add("Total No. of Items: " + richTextBox4.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values for Cash Given and Total Bills.",
                    "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form5_Listbox_ print = new Form5_Listbox_();
            print.printDisplaylistBox.Items.AddRange(this.listBox1.Items);
            print.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            total_amount = 0;
            total_qty = 0;
            currentItemLastAmount = 0;
            currentItemLastQuantity = 0;

            richTextBox2.Text = "0.00";
            richTextBox3.Text = "0.00";
            richTextBox4.Text = "0";
            listBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            total_amount = 0;
            total_qty = 0;
            currentItemLastAmount = 0.0;
            currentItemLastQuantity = 0;
            richTextBox3.Text = "0.00";
            richTextBox4.Text = "0";

            radioButton1.Checked = false;
            radioButton2.Checked = false;


            radioButton1.Enabled = true;
            radioButton2.Enabled = true;

            pictureBox22.Image = Image.FromFile(@"C:\Users\Bernard Ordonez\source\DSAL01E\LESSON1_1\LESSON1_1\Resources\images.jpg");
            pictureBox22.SizeMode = PictureBoxSizeMode.StretchImage;


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

          
            textBox1.Text = "";
            textBox2.Text = "0";
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            richTextBox3.Text = "";
            richTextBox4.Text = "";
            richTextBox5.Text = "";
            richTextBox6.Text = "";

            
            listBox1.Items.Clear();

            this.BackColor = SystemColors.Control;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (updatingQuantity) return;

            try
            {
                double price = double.TryParse(textBox1.Text, out double p) ? p : 0;
                int quantity = int.TryParse(textBox2.Text, out int q) ? q : 0;
                double discountAmt = double.TryParse(richTextBox1.Text, out double d) ? d : 0;

                double currentItemAmount = (price * quantity) - discountAmt;
                double amountDelta = currentItemAmount - currentItemLastAmount;
                int qtyDelta = quantity - currentItemLastQuantity;

                total_amount += amountDelta;
                total_qty += qtyDelta;

                currentItemLastAmount = currentItemAmount;
                currentItemLastQuantity = quantity;

                richTextBox2.Text = currentItemAmount.ToString("N2");
                richTextBox3.Text = total_amount.ToString("N2");
                richTextBox4.Text = total_qty.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating totals: " + ex.Message,
                    "Computation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox6_Click(object sender, EventArgs e)
        {
            HandleCheckBoxClick(checkBox6, 500.99);
        }

        private void checkBox7_Click(object sender, EventArgs e)
        {
            HandleCheckBoxClick(checkBox7, 275.50);
        }

        private void checkBox8_Click(object sender, EventArgs e)
        {
            HandleCheckBoxClick(checkBox8, 199.75);
        }

        private void checkBox9_Click(object sender, EventArgs e)
        {
            HandleCheckBoxClick(checkBox9, 350.20);
        }

        private void checkBox10_Click(object sender, EventArgs e)
        {
            HandleCheckBoxClick(checkBox10, 420.60);
        }

        // CheckBox16–CheckBox30
        private void checkBox16_Click(object sender, EventArgs e)
        {
            HandleCheckBoxClick(checkBox16, 145.90);
        }

        private void checkBox17_Click(object sender, EventArgs e)
        {
            HandleCheckBoxClick(checkBox17, 380.60);
        }

        private void checkBox18_Click(object sender, EventArgs e)
        {
            HandleCheckBoxClick(checkBox18, 225.35);
        }

        private void checkBox19_Click(object sender, EventArgs e)
        {
            HandleCheckBoxClick(checkBox19, 410.00);
        }

        private void checkBox20_Click(object sender, EventArgs e)
        {
            HandleCheckBoxClick(checkBox20, 330.45);
        }

        private void checkBox21_Click(object sender, EventArgs e)
        {
            HandleCheckBoxClick(checkBox21, 150.80);
        }

        private void checkBox22_Click(object sender, EventArgs e)
        {
            HandleCheckBoxClick(checkBox22, 295.25);
        }

        private void checkBox23_Click(object sender, EventArgs e)
        {
            HandleCheckBoxClick(checkBox23, 360.90);
        }

        private void checkBox24_Click(object sender, EventArgs e)
        {
            HandleCheckBoxClick(checkBox24, 280.10);
        }

        private void checkBox25_Click(object sender, EventArgs e)
        {
            HandleCheckBoxClick(checkBox25, 315.75);
        }

        private void checkBox26_Click(object sender, EventArgs e)
        {
            HandleCheckBoxClick(checkBox26, 190.60);
        }

        private void checkBox27_Click(object sender, EventArgs e)
        {
            HandleCheckBoxClick(checkBox27, 270.40);
        }

        private void checkBox28_Click(object sender, EventArgs e)
        {
            HandleCheckBoxClick(checkBox28, 385.80);
        }

        private void checkBox29_Click(object sender, EventArgs e)
        {
            HandleCheckBoxClick(checkBox29, 320.50);
        }

        private void checkBox30_Click(object sender, EventArgs e)
        {
            HandleCheckBoxClick(checkBox30, 245.90);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bool bundleASelected = radioButton1.Checked;
            bool bundleBSelected = radioButton2.Checked;
            
            bool bundleA1Selected = checkBox11.Checked;
            bool bundleA2Selected = checkBox12.Checked;
            bool bundleA3Selected = checkBox13.Checked;
            bool bundleA4Selected = checkBox14.Checked;
            bool bundleA5Selected = checkBox15.Checked;

            bool bundleB1Selected = checkBox1.Checked;
            bool bundleB2Selected = checkBox2.Checked;
            bool bundleB3Selected = checkBox3.Checked;
            bool bundleB4Selected = checkBox4.Checked;
            bool bundleB5Selected = checkBox5.Checked;



            PrelimExam_Form5_ summaryForm = new PrelimExam_Form5_(
                textBox1.Text,       // Price
                textBox2.Text,       // Quantity
                richTextBox1.Text,   // Discount Amount
                richTextBox2.Text,   // Discounted Amount
                richTextBox3.Text,   // Total Bills
                richTextBox4.Text,   // Total Quantity
                richTextBox5.Text,   // Cash Given
                richTextBox6.Text,   // Change
                bundleASelected,
                bundleBSelected,
                bundleA1Selected,
                bundleA2Selected,
                bundleA3Selected,
                bundleA4Selected,
                bundleA5Selected,
                bundleB1Selected,
                bundleB2Selected,
                bundleB3Selected,
                bundleB4Selected,
                bundleB5Selected

            );

            summaryForm.Show();
        }
    }
}
