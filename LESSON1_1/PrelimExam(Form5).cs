using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LESSON1_1
{
    public partial class PrelimExam_Form5_ : Form
    {
        public PrelimExam_Form5_()
        {
        }

        public PrelimExam_Form5_(
            string price, string quantity, string discountAmount, string discountedAmount,
        string totalBills, string totalQuantity, string cashGiven, string change,
        bool bundleASelected, bool bundleBSelected,
        bool bundleA1Selected, bool bundleA2Selected, bool bundleA3Selected, bool bundleA4Selected, bool bundleA5Selected,
        bool bundleB1Selected, bool bundleB2Selected, bool bundleB3Selected, bool bundleB4Selected, bool bundleB5Selected)
        {
            InitializeComponent();

            // Display values in TextBoxes or Labels
            textBox1.Text = price;
            textBox2.Text = quantity;
            richTextBox1.Text = discountAmount;
            richTextBox2.Text = discountedAmount;
            richTextBox3.Text = totalBills;
            richTextBox4.Text = totalQuantity;
            richTextBox5.Text = cashGiven;
            richTextBox6.Text = change;

            // Set CheckBoxes for bundles
            radioButton1.Checked = bundleASelected;
            radioButton2.Checked = bundleBSelected;

            // Set CheckBoxes for bundle Items
            checkBox11.Checked = bundleA1Selected;
            checkBox12.Checked = bundleA2Selected;
            checkBox13.Checked = bundleA3Selected;  
            checkBox14.Checked = bundleA4Selected;
            checkBox15.Checked = bundleA5Selected;

            checkBox1.Checked = bundleB1Selected;
            checkBox2.Checked = bundleB2Selected;
            checkBox3.Checked = bundleB3Selected;
            checkBox4.Checked = bundleB4Selected;
            checkBox5.Checked = bundleB5Selected;

            // Make fields read-only if needed
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            richTextBox1.Enabled = false;
            richTextBox2.Enabled = false;
            richTextBox3.Enabled = false;
            richTextBox4.Enabled = false;
            richTextBox5.Enabled = false;
            richTextBox6.Enabled = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;

            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            checkBox3.Enabled = false;
            checkBox4.Enabled = false;
            checkBox5.Enabled = false;
            checkBox11.Enabled = false;
            checkBox12.Enabled = false;
            checkBox13.Enabled = false;
            checkBox14.Enabled = false;
            checkBox15.Enabled = false;

        }

        private void PrelimExam_Form5__Load(object sender, EventArgs e)
        {

        }
    }
}
