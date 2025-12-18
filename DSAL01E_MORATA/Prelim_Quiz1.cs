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

namespace DSAL01E_MORATA
{
    public partial class Prelim_Quiz1 : Form
    {
        public Prelim_Quiz1()
        {
            InitializeComponent();

            // Disable output and summary textboxes on form load
            creditUnits_textBox.Enabled = false;
            totalNumUnits_textBox.Enabled = false;
            totalTuitionFee_textBox.Enabled = false;
            totalMiscFee_textBox.Enabled = false;
            totalTuitionAndFee_textBox.Enabled = false;

            hashtag_textBox.Enabled = false;
            courseCode_textBox2.Enabled = false;
            courseDesc_textBox2.Enabled = false;
            unitLecture_textBox2.Enabled = false;
            unitLab_textBox2.Enabled = false;
            creditUnits_textBox2.Enabled = false;
            time_textBox2.Enabled = false;
            day_textBox2.Enabled = false;
            totalTuitionFee_textBox2.Enabled = false;
            totalMiscFee_textBox2.Enabled = false;
            totalNumUnits_textBox2.Enabled = false;
            totalTuitionAndFee_textBox2.Enabled = false;
            compLabFee_textBox.Enabled = false;
            ciscoLabFee_textBox2.Enabled = false;
            examBookletFee_textBox2.Enabled = false;
            totalOtherSchoolFees_textBox.Enabled = false;
        }

        // Handles Browse button click to select and display an image in the PictureBox.
        private void browse_button_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select an Image";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    displayImage_pictureBox.Image = Image.FromFile(openFileDialog.FileName);
                    displayImage_pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        /// Handles Exit button click to close the form.
        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// Handles New/Cancel button click to clear all textboxes on the form.
        private void new_button_Click(object sender, EventArgs e)
        {
            ClearAllTextBoxes(this);
        }

        /// Recursively clears all TextBox controls within the given parent control.
        private void ClearAllTextBoxes(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is System.Windows.Forms.TextBox tb)
                {
                    tb.Text = string.Empty;
                }
                else
                {
                    // Recursively clear textboxes in child containers
                    ClearAllTextBoxes(c);
                }
            }
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            // Right side inputs connecting to their designated labels displays
            totalTuitionFee_textBox2.Text = totalTuitionFee_textBox.Text;
            totalMiscFee_textBox2.Text = totalMiscFee_textBox.Text;
            totalNumUnits_textBox2.Text = totalNumUnits_textBox.Text;
            totalTuitionAndFee_textBox2.Text = totalTuitionAndFee_textBox.Text;
            compLabFee_textBox.Text = laboratoryFee_textBox.Text;
            ciscoLabFee_textBox2.Text = ciscoLabFee_textBox.Text;
            examBookletFee_textBox2.Text = examBookletFee_textBox.Text;

            // Total Other School Fees Calculation
            decimal compLabFee = 0, ciscoLabFee = 0, examBookletFee = 0;
            decimal.TryParse(compLabFee_textBox.Text, out compLabFee);
            decimal.TryParse(ciscoLabFee_textBox2.Text, out ciscoLabFee);
            decimal.TryParse(examBookletFee_textBox2.Text, out examBookletFee);

            decimal totalOtherSchoolFees = compLabFee + ciscoLabFee + examBookletFee;
            totalOtherSchoolFees_textBox.Text = totalOtherSchoolFees.ToString("F2");
        }

        // declare global variables for accumulation
        private int totalNumUnits = 0;
        private double totalTuitionFeeAcc = 0;
        private double totalMiscFeeAcc = 0;
        private double totalTuitionAndFee = 0;

        private void calculate_button_Click(object sender, EventArgs e)
        {
            // declaration of variables needed for the program
            int unitLect, unitLab, labFee, creditUnits, ciscoLabFee, examBookletFee;
            //int totalNumUnits = 0;
            double totalTuitionFee, totalMiscFee;
            double tuitionFeePerUnit = 1500;

            // convert string data from textboxes to numeric and place it as value of the variable
            unitLect = Convert.ToInt32(unitLecture_textBox.Text);
            unitLab = Convert.ToInt32(unitLaboratory_textBox.Text);
            labFee = Convert.ToInt32(laboratoryFee_textBox.Text);
            ciscoLabFee = Convert.ToInt32(ciscoLabFee_textBox.Text);
            examBookletFee = Convert.ToInt32(examBookletFee_textBox.Text);

            // create formula needed for computation
            creditUnits = unitLect + unitLab;
            totalNumUnits += creditUnits;
            totalTuitionFee = tuitionFeePerUnit * creditUnits;
            totalTuitionFeeAcc += totalTuitionFee;
            totalMiscFee = labFee + ciscoLabFee + examBookletFee;
            totalMiscFeeAcc += totalMiscFee;
            totalTuitionAndFee += (totalTuitionFee + totalMiscFee);

            // converting numeric data to string and display it inside the textboxes
            creditUnits_textBox.Text = creditUnits.ToString("d");
            totalNumUnits_textBox.Text = totalNumUnits.ToString("d");
            totalTuitionFee_textBox.Text = totalTuitionFeeAcc.ToString("n");
            totalMiscFee_textBox.Text = totalMiscFeeAcc.ToString("n");
            totalTuitionAndFee_textBox.Text = totalTuitionAndFee.ToString("n");
        }

        private void Prelim_Quiz1_Load(object sender, EventArgs e)
        {

        }
    }
}
