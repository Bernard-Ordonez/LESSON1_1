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
    public partial class Lesson2_Example4 : Form
    {
        public Lesson2_Example4()
        {
            InitializeComponent();
        }

        private void foodBundleA_radioButton_Click(object sender, EventArgs e)
        {
            //code for changing the form background
            this.BackColor = Color.LightCyan;
            //code for food bundle B not to be selected
            foodBundleA_radioButton.Checked = true;
            foodBundleB_radioButton.Checked = false;
            //inserting image insdie the picture box            
            displayImage_pictureBox.Image = Properties.Resources.FamilyComboMealA;
            displayImage_pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            //codes to check the checkboxes
            TenFriedChick_checkBox.Checked = true;
            twoLargeFries_checkBox.Checked = true;
            coke_checkBox.Checked = true;
            fourSideDish_checkBox.Checked = true;
            specialPizza_checkBox.Checked = true;

            //codes to uncheck checkboxes
            haloHalo_checkBox.Checked = false;
            sixFriedChick_checkBox.Checked = false;
            familyCarbonara_checkBox.Checked = false;
            familyFries_checkBox.Checked = false;
            hawaiianPizza_checkBox.Checked = false;

            //codes for displaying data inside the textboxes
            price_textBox.Text = "1,000.00";
            discount_textBox.Text = "P200.00";
        }

        private void foodBundleB_radioButton_Click(object sender, EventArgs e)
        {
            //code for changing the form background
            this.BackColor = Color.LightBlue;
            //code for food bundle A not to be selected
            foodBundleA_radioButton.Checked = false;
            foodBundleB_radioButton.Checked = true;
            //inserting image insdie the picture box  
            displayImage_pictureBox.Image = Properties.Resources.FamilyComboMealB;
            displayImage_pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            //codes to check the checkboxes
            TenFriedChick_checkBox.Checked = false;
            twoLargeFries_checkBox.Checked = false;
            coke_checkBox.Checked = false;
            fourSideDish_checkBox.Checked = false;
            specialPizza_checkBox.Checked = false;

            //codes to uncheck checkboxes
            haloHalo_checkBox.Checked = true;
            sixFriedChick_checkBox.Checked = true;
            familyCarbonara_checkBox.Checked = true;
            familyFries_checkBox.Checked = true;
            hawaiianPizza_checkBox.Checked = true;

            price_textBox.Text = "1,299.00";
            discount_textBox.Text = "P194.85";
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            //codes to uncheck all given checkboxes
            foodBundleA_radioButton.Checked = false;
            foodBundleB_radioButton.Checked = false;
            //code for inserting default image inside the picturebox
            displayImage_pictureBox.Image = Properties.Resources.default_image;

            TenFriedChick_checkBox.Checked = false;
            twoLargeFries_checkBox.Checked = false;
            coke_checkBox.Checked = false;
            fourSideDish_checkBox.Checked = false;
            specialPizza_checkBox.Checked = false;

            haloHalo_checkBox.Checked = false;
            sixFriedChick_checkBox.Checked = false;
            familyCarbonara_checkBox.Checked = false;
            familyFries_checkBox.Checked = false;
            hawaiianPizza_checkBox.Checked = false;

            //codes for clearing the textboxes
            price_textBox.Clear();
            discount_textBox.Clear();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
