using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace LESSON1_1
{
    public partial class POS1__Function__F2_1_ : Form
    {
        // Global variables
        private string currentItem = "";
        private decimal currentPrice = 0m;
        private decimal discountRate = 0m;

        public POS1__Function__F2_1_()
        {
            InitializeComponent();
        }

        // ================================
        // HELPER FUNCTIONS
        // ================================
        private void DisplayItem(string itemName, decimal price)
        {
            currentItem = itemName;
            currentPrice = price;

            textBox1.Text = currentItem;                 // Item Name
            textBox3.Text = currentPrice.ToString("F2"); // Price
        }

        private void PrepareForQuantity()
        {
            textBox2.Clear();    // Quantity
            textBox2.Focus();    // Focus cursor
        }

        private void SetDiscount(decimal rate)
        {
            discountRate = rate;
            ComputeDiscounts();
        }

        private void ComputeDiscounts()
        {
            if (decimal.TryParse(textBox3.Text, out decimal price) &&
                int.TryParse(textBox2.Text, out int qty))
            {
                decimal gross = price * qty;
                decimal discountAmount = gross * discountRate;
                decimal net = gross - discountAmount;

                textBox4.Text = discountAmount.ToString("F2");  // Discount
                textBox5.Text = net.ToString("F2");             // Net
            }
        }

        // ================================
        // PICTUREBOX CLICKS (FOODS)
        // ================================
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DisplayItem("Nashville Hot Chicken", 150);
            PrepareForQuantity();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DisplayItem("Indian Chicken 65", 180);
            PrepareForQuantity();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DisplayItem("Taiwanese Popcorn Chicken", 160);
            PrepareForQuantity();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            DisplayItem("Japanese Karaage", 175);
            PrepareForQuantity();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            DisplayItem("Korean Yangnyeom Chicken", 185);
            PrepareForQuantity();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            DisplayItem("Buffalo Wings", 170);
            PrepareForQuantity();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            DisplayItem("Honey Butter Fried Chicken", 160);
            PrepareForQuantity();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            DisplayItem("Garlic Parmesan Chicken", 190);
            PrepareForQuantity();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            DisplayItem("Crispy Chicken Sandwich", 200);
            PrepareForQuantity();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            DisplayItem("Spicy Chicken Sandwich", 210);
            PrepareForQuantity();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            DisplayItem("Chicken Adobo Rice", 140);
            PrepareForQuantity();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            DisplayItem("Chicken Sisig", 150);
            PrepareForQuantity();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            DisplayItem("Chicken Inasal", 160);
            PrepareForQuantity();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            DisplayItem("Chicken BBQ", 170);
            PrepareForQuantity();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            DisplayItem("Chicken Curry", 175);
            PrepareForQuantity();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            DisplayItem("Chicken Teriyaki", 185);
            PrepareForQuantity();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            DisplayItem("Chicken Tenders", 190);
            PrepareForQuantity();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            DisplayItem("Chicken Nuggets", 120);
            PrepareForQuantity();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            DisplayItem("Chicken Katsu", 180);
            PrepareForQuantity();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            DisplayItem("Chicken Shawarma", 200);
            PrepareForQuantity();
        }

        // ================================
        // DISCOUNT RADIO BUTTONS
        // ================================
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked) SetDiscount(0.20m); // 20%
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked) SetDiscount(0.15m); // 15%
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked) SetDiscount(0.10m); // 10%
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked) SetDiscount(0.00m); // No discount
        }

        // ================================
        // QUANTITY CHANGE EVENT
        // ================================
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            ComputeDiscounts();
        }

        private void POS1__Function__F2_1__Load(object sender, EventArgs e)
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
    }
}
