using System;
using System.Windows.Forms;
using System.Drawing;

namespace LESSON1_1
{
    public partial class POS1_Classfrm : Form
    {
        private POS1Class1 pos = new POS1Class1();

        private int currentQty = 0;
        private decimal discountRate = 0;

        public POS1_Classfrm()
        {
            InitializeComponent();
            textBox2.Focus();
        }

        private void Form2_1_Load(object sender, EventArgs e)
        {
            pictureBox16.Image = Image.FromFile("C:\\Users\\Bernard Ordonez\\source\\DSAL01E\\LESSON1_1\\LESSON1_1\\Resources\\Hawaiian Shoyu Chicken.jpg");
            pictureBox17.Image = Image.FromFile("C:\\Users\\Bernard Ordonez\\source\\DSAL01E\\LESSON1_1\\LESSON1_1\\Resources\\Chicken & Rice Casserole.jpg");
            pictureBox18.Image = Image.FromFile("C:\\Users\\Bernard Ordonez\\source\\DSAL01E\\LESSON1_1\\LESSON1_1\\Resources\\Orange Chicken.jpg");
            pictureBox19.Image = Image.FromFile("C:\\Users\\Bernard Ordonez\\source\\DSAL01E\\LESSON1_1\\LESSON1_1\\Resources\\Chicken Enchiladas.jpg");
            pictureBox20.Image = Image.FromFile("C:\\Users\\Bernard Ordonez\\source\\DSAL01E\\LESSON1_1\\LESSON1_1\\Resources\\Caprese Chicken Gnocchi Skillet.jpg");

            textBox1.ReadOnly = true;
            textBox2.ReadOnly = false;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
            textBox5.ReadOnly = true;
            textBox10.ReadOnly = true;
            textBox11.ReadOnly = true;
            textBox12.ReadOnly = true;
            textBox13.ReadOnly = false;
            textBox14.ReadOnly = true;

            radioButton4.Checked = true; // Default 0%
            textBox2.Focus();
        }

        // --- When picture is clicked ---
        private void SelectFood(string name)
        {
            if (pos.SetFoodItem(name))
            {
                textBox1.Text = pos.CurrentItem;
                textBox3.Text = pos.CurrentPrice.ToString("F2");
            }
            else
            {
                MessageBox.Show("Item not found in menu!");
            }
        }

        // --- Compute Discount (using class) ---
        private void ComputeDiscounts()
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text)) return;
            if (!int.TryParse(textBox2.Text, out currentQty) || currentQty <= 0)
            {
                MessageBox.Show("Enter a valid quantity.");
                return;
            }

            var (discountAmt, discountedAmt) = pos.ComputeDiscount(pos.CurrentPrice, currentQty, discountRate);
            textBox4.Text = discountAmt.ToString("F2");
            textBox5.Text = discountedAmt.ToString("F2");
        }

        // --- Discount Buttons ---
        private void radioButton1_CheckedChanged(object sender, EventArgs e) { if (radioButton1.Checked) { discountRate = 0.20m; ComputeDiscounts(); } }
        private void radioButton2_CheckedChanged(object sender, EventArgs e) { if (radioButton2.Checked) { discountRate = 0.15m; ComputeDiscounts(); } }
        private void radioButton3_CheckedChanged(object sender, EventArgs e) { if (radioButton3.Checked) { discountRate = 0.10m; ComputeDiscounts(); } }
        private void radioButton4_CheckedChanged(object sender, EventArgs e) { if (radioButton4.Checked) { discountRate = 0.00m; ComputeDiscounts(); } }

        // --- Calculate Button ---
        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                if (!decimal.TryParse(textBox5.Text, out decimal discountedAmount) || discountedAmount <= 0)
                {
                    MessageBox.Show("Select item, quantity, and discount first.");
                    return;
                }

                if (!decimal.TryParse(textBox13.Text, out decimal cash))
                {
                    MessageBox.Show("Enter valid cash amount.");
                    return;
                }

                decimal change = pos.ComputeChange(cash, discountedAmount);
                textBox14.Text = change.ToString("F2");

                decimal discountAmt = decimal.Parse(textBox4.Text);
                pos.UpdateTotals(currentQty, discountAmt, discountedAmount);

                textBox10.Text = pos.TotalQuantity.ToString();
                textBox11.Text = pos.TotalDiscount.ToString("F2");
                textBox12.Text = pos.TotalDiscountedAmount.ToString("F2");

                textBox2.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // --- New Transaction (Reset All) ---
        private void buttonNew_Click(object sender, EventArgs e)
        {
            pos.ResetAll();
            ClearFields();
            UpdateTotalsDisplay();
            textBox2.ReadOnly = false;
        }

        // --- Cancel (only clears current order, keeps totals) ---
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            pos.ResetCurrentItem();
            ClearFields();
        }

        // --- Exit ---
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // --- Helper Methods ---
        private void ClearFields()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox13.Clear();
            textBox14.Clear();
        }

        private void UpdateTotalsDisplay()
        {
            textBox10.Text = pos.TotalQuantity.ToString();
            textBox11.Text = pos.TotalDiscount.ToString("F2");
            textBox12.Text = pos.TotalDiscountedAmount.ToString("F2");
        }

        // --- PictureBox Clicks (simplified) ---
        private void pictureBox1_Click(object sender, EventArgs e) { SelectFood("Nashville Hot Chicken"); }
        private void pictureBox2_Click(object sender, EventArgs e) { SelectFood("Indian Chicken 65"); }
        private void pictureBox3_Click(object sender, EventArgs e) { SelectFood("Taiwanese Popcorn Chicken"); }
        private void pictureBox4_Click(object sender, EventArgs e) { SelectFood("Korean Fried Chicken"); }
        private void pictureBox5_Click(object sender, EventArgs e) { SelectFood("Southern Fried Chicken"); }
        private void pictureBox6_Click(object sender, EventArgs e) { SelectFood("Chili-Honey Glazed Lechon Kawali"); }
        private void pictureBox7_Click(object sender, EventArgs e) { SelectFood("Bacon-Wrapped Pork Chop"); }
        private void pictureBox8_Click(object sender, EventArgs e) { SelectFood("Pork Tonkatsu"); }
        private void pictureBox9_Click(object sender, EventArgs e) { SelectFood("Fried Calamansi Pork Chops"); }
        private void pictureBox10_Click(object sender, EventArgs e) { SelectFood("Breaded Pork Chop"); }
        private void pictureBox11_Click(object sender, EventArgs e) { SelectFood("Caramelized Onions and Blue Cheese Beef"); }
        private void pictureBox12_Click(object sender, EventArgs e) { SelectFood("Prime Rib Roast"); }
        private void pictureBox13_Click(object sender, EventArgs e) { SelectFood("Beef Wellington"); }
        private void pictureBox14_Click(object sender, EventArgs e) { SelectFood("The Filet Mignon"); }
        private void pictureBox15_Click(object sender, EventArgs e) { SelectFood("Steak Au Poivre"); }
        private void pictureBox16_Click(object sender, EventArgs e) { SelectFood("Hawaiian Shoyu Chicken"); }
        private void pictureBox17_Click(object sender, EventArgs e) { SelectFood("Chicken & Rice Casserole"); }
        private void pictureBox18_Click(object sender, EventArgs e) { SelectFood("Orange Chicken"); }
        private void pictureBox19_Click(object sender, EventArgs e) { SelectFood("Chicken Enchiladas"); }
        private void pictureBox20_Click(object sender, EventArgs e) { SelectFood("Caprese Chicken Gnocchi Skillet"); }
    }
}
