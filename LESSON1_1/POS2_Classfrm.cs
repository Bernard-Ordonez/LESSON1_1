using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LESSON1_1
{
    public partial class POS2_Classfrm : Form
    {
        private double total_amount = 0;
        private int total_qty = 0;

        private int currentItemLastQuantity = 0;
        private double currentItemLastAmount = 0.0;
        private bool updatingQuantity = false;

        private POS2Class1 helper;

        public POS2_Classfrm()
        {
            InitializeComponent();
            helper = new POS2Class1(this);
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // disable/enable the same controls as original
            textBox1.Enabled = false;        // Price
            richTextBox2.Enabled = false;    // Discounted Amount
            richTextBox6.Enabled = false;    // Change
            richTextBox3.Enabled = false;    // Total Bills
            richTextBox1.Enabled = false;    // Discount Amount
            richTextBox4.Enabled = false;    // Total Quantity

            // Load product images using exact paths you specified
            helper.LoadImages(
                (pictureBox6, @"C:\Users\Bernard Ordonez\source\DSAL01E\LESSON1_1\LESSON1_1\Resources\Chili-Honey Glazed Lechon Kawali.jpg"),
                (pictureBox7, @"C:\Users\Bernard Ordonez\source\DSAL01E\LESSON1_1\LESSON1_1\Resources\Bacon-Wrapped Pork Chop.jpg"),
                (pictureBox8, @"C:\Users\Bernard Ordonez\source\DSAL01E\LESSON1_1\LESSON1_1\Resources\Pork Tonkatsu.jpg"),
                (pictureBox9, @"C:\Users\Bernard Ordonez\source\DSAL01E\LESSON1_1\LESSON1_1\Resources\Fried Calamansi Pork Chops.jpg"),
                (pictureBox10, @"C:\Users\Bernard Ordonez\source\DSAL01E\LESSON1_1\LESSON1_1\Resources\Breaded Pork Chop.jpg"),
                (pictureBox11, @"C:\Users\Bernard Ordonez\source\DSAL01E\LESSON1_1\LESSON1_1\Resources\Carmalized Onions and Blue Cheese beef.jpg"),
                (pictureBox12, @"C:\Users\Bernard Ordonez\source\DSAL01E\LESSON1_1\LESSON1_1\Resources\Prime Rib Roast.jpg"),
                (pictureBox13, @"C:\Users\Bernard Ordonez\source\DSAL01E\LESSON1_1\LESSON1_1\Resources\Beef Wellington.jpg"),
                (pictureBox14, @"C:\Users\Bernard Ordonez\source\DSAL01E\LESSON1_1\LESSON1_1\Resources\The Filet Mignon.jpg"),
                (pictureBox15, @"C:\Users\Bernard Ordonez\source\DSAL01E\LESSON1_1\LESSON1_1\Resources\Steak Au Poivre.jpg"),
                (pictureBox16, @"C:\Users\Bernard Ordonez\source\DSAL01E\LESSON1_1\LESSON1_1\Resources\Hawaiian Shoyu Chicken.jpg"),
                (pictureBox17, @"C:\Users\Bernard Ordonez\source\DSAL01E\LESSON1_1\LESSON1_1\Resources\Chicken & Rice Casserole.jpg"),
                (pictureBox18, @"C:\Users\Bernard Ordonez\source\DSAL01E\LESSON1_1\LESSON1_1\Resources\Orange Chicken.jpg"),
                (pictureBox19, @"C:\Users\Bernard Ordonez\source\DSAL01E\LESSON1_1\LESSON1_1\Resources\Chicken Enchiladas.jpg"),
                (pictureBox20, @"C:\Users\Bernard Ordonez\source\DSAL01E\LESSON1_1\LESSON1_1\Resources\Caprese Chicken Gnocchi Skillet.jpg")
            );

            // Ensure all picture boxes stretch images
            foreach (Control c in this.Controls)
            {
                if (c is PictureBox pb)
                {
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        // RADIO BUTTONS: apply bundles
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButton1.Checked) return;

            helper.ApplyBundle(
                radioButton1,
                1000.00,
                200.00,
                Color.LightCyan,
                new[] { checkBox11, checkBox12, checkBox13, checkBox14, checkBox15 },
                new[] { checkBox1, checkBox2, checkBox3, checkBox4, checkBox5 },
                pictureBox22,
                @"C:\Users\Bernard Ordonez\source\DSAL01E\LESSON1_1\LESSON1_1\Resources\Bundle A.jpg",
                textBox1,
                richTextBox1,
                listBox1,
                textBox2);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButton2.Checked) return;

            double price = 1299.00;
            double discount = price * 0.15;

            helper.ApplyBundle(
                radioButton2,
                price,
                discount,
                Color.LightBlue,
                new[] { checkBox1, checkBox2, checkBox3, checkBox4, checkBox5 },
                new[] { checkBox11, checkBox12, checkBox13, checkBox14, checkBox15 },
                pictureBox22,
                @"C:\Users\Bernard Ordonez\source\DSAL01E\LESSON1_1\LESSON1_1\Resources\Bundle B.jpg",
                textBox1,
                richTextBox1,
                listBox1,
                textBox2);
        }

        // CHECKBOX CLICK HANDLERS (major items)
        private void checkBox6_Click(object sender, EventArgs e) =>
            helper.HandleCheckBoxClick(checkBox6, 500.99, textBox1, richTextBox1, listBox1, textBox2, ref updatingQuantity, ref currentItemLastQuantity, ref currentItemLastAmount);

        private void checkBox7_Click(object sender, EventArgs e) =>
            helper.HandleCheckBoxClick(checkBox7, 275.50, textBox1, richTextBox1, listBox1, textBox2, ref updatingQuantity, ref currentItemLastQuantity, ref currentItemLastAmount);

        private void checkBox8_Click(object sender, EventArgs e) =>
            helper.HandleCheckBoxClick(checkBox8, 199.75, textBox1, richTextBox1, listBox1, textBox2, ref updatingQuantity, ref currentItemLastQuantity, ref currentItemLastAmount);

        private void checkBox9_Click(object sender, EventArgs e) =>
            helper.HandleCheckBoxClick(checkBox9, 350.20, textBox1, richTextBox1, listBox1, textBox2, ref updatingQuantity, ref currentItemLastQuantity, ref currentItemLastAmount);

        private void checkBox10_Click(object sender, EventArgs e) =>
            helper.HandleCheckBoxClick(checkBox10, 420.60, textBox1, richTextBox1, listBox1, textBox2, ref updatingQuantity, ref currentItemLastQuantity, ref currentItemLastAmount);

        // CHECKBOX 16–30 (other items) - mirror original prices
        private void checkBox16_Click(object sender, EventArgs e) => helper.HandleCheckBoxClick(checkBox16, 145.90, textBox1, richTextBox1, listBox1, textBox2, ref updatingQuantity, ref currentItemLastQuantity, ref currentItemLastAmount);
        private void checkBox17_Click(object sender, EventArgs e) => helper.HandleCheckBoxClick(checkBox17, 380.60, textBox1, richTextBox1, listBox1, textBox2, ref updatingQuantity, ref currentItemLastQuantity, ref currentItemLastAmount);
        private void checkBox18_Click(object sender, EventArgs e) => helper.HandleCheckBoxClick(checkBox18, 225.35, textBox1, richTextBox1, listBox1, textBox2, ref updatingQuantity, ref currentItemLastQuantity, ref currentItemLastAmount);
        private void checkBox19_Click(object sender, EventArgs e) => helper.HandleCheckBoxClick(checkBox19, 410.00, textBox1, richTextBox1, listBox1, textBox2, ref updatingQuantity, ref currentItemLastQuantity, ref currentItemLastAmount);
        private void checkBox20_Click(object sender, EventArgs e) => helper.HandleCheckBoxClick(checkBox20, 330.45, textBox1, richTextBox1, listBox1, textBox2, ref updatingQuantity, ref currentItemLastQuantity, ref currentItemLastAmount);
        private void checkBox21_Click(object sender, EventArgs e) => helper.HandleCheckBoxClick(checkBox21, 150.80, textBox1, richTextBox1, listBox1, textBox2, ref updatingQuantity, ref currentItemLastQuantity, ref currentItemLastAmount);
        private void checkBox22_Click(object sender, EventArgs e) => helper.HandleCheckBoxClick(checkBox22, 295.25, textBox1, richTextBox1, listBox1, textBox2, ref updatingQuantity, ref currentItemLastQuantity, ref currentItemLastAmount);
        private void checkBox23_Click(object sender, EventArgs e) => helper.HandleCheckBoxClick(checkBox23, 360.90, textBox1, richTextBox1, listBox1, textBox2, ref updatingQuantity, ref currentItemLastQuantity, ref currentItemLastAmount);
        private void checkBox24_Click(object sender, EventArgs e) => helper.HandleCheckBoxClick(checkBox24, 280.10, textBox1, richTextBox1, listBox1, textBox2, ref updatingQuantity, ref currentItemLastQuantity, ref currentItemLastAmount);
        private void checkBox25_Click(object sender, EventArgs e) => helper.HandleCheckBoxClick(checkBox25, 315.75, textBox1, richTextBox1, listBox1, textBox2, ref updatingQuantity, ref currentItemLastQuantity, ref currentItemLastAmount);
        private void checkBox26_Click(object sender, EventArgs e) => helper.HandleCheckBoxClick(checkBox26, 190.60, textBox1, richTextBox1, listBox1, textBox2, ref updatingQuantity, ref currentItemLastQuantity, ref currentItemLastAmount);
        private void checkBox27_Click(object sender, EventArgs e) => helper.HandleCheckBoxClick(checkBox27, 270.40, textBox1, richTextBox1, listBox1, textBox2, ref updatingQuantity, ref currentItemLastQuantity, ref currentItemLastAmount);
        private void checkBox28_Click(object sender, EventArgs e) => helper.HandleCheckBoxClick(checkBox28, 385.80, textBox1, richTextBox1, listBox1, textBox2, ref updatingQuantity, ref currentItemLastQuantity, ref currentItemLastAmount);
        private void checkBox29_Click(object sender, EventArgs e) => helper.HandleCheckBoxClick(checkBox29, 320.50, textBox1, richTextBox1, listBox1, textBox2, ref updatingQuantity, ref currentItemLastQuantity, ref currentItemLastAmount);
        private void checkBox30_Click(object sender, EventArgs e) => helper.HandleCheckBoxClick(checkBox30, 245.90, textBox1, richTextBox1, listBox1, textBox2, ref updatingQuantity, ref currentItemLastQuantity, ref currentItemLastAmount);

        // PRINT / OPEN LISTBOX FORM (button2 original)
        private void button2_Click(object sender, EventArgs e)
        {
            Form5_Listbox_ print = new Form5_Listbox_();
            print.printDisplaylistBox.Items.AddRange(this.listBox1.Items);
            print.Show();
        }

        // CLEAR (button3)
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

        // RESET ALL (button4)
        private void button4_Click(object sender, EventArgs e)
        {
            // Use helper.ResetAll to mirror original reset behavior
            helper.ResetAll(this);
        }

        // EXIT (button5)
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // SHOW SUMMARY (button6) — opens PrelimExam_Form5_ with flags and fields
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
