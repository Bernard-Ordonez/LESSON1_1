using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSAL01E_MORATA
{
    public partial class Lesson5_Example7 : Form
    {
        // codes for declaring variables that is accessible to the whole form and can be access for one object to another
        private double total_amount = 0;
        private int total_qty = 0;

        private bool isloading = true;

        public Lesson5_Example7()
        {
            InitializeComponent();

            // codes for disabling textboxes
            price_textBox.Enabled = false;
            discount_textBox.Enabled = false;
            discounted_textBox.Enabled = false;
            totalQuantity_textBox.Enabled = false;
            change_textBox.Enabled = false;

            // codes for inputting default image inside the picturebox
            pictureBox1.Image = Properties.Resources.hawaiianPizza;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox2.Image = Properties.Resources.newYorkStylePizza;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox3.Image = Properties.Resources.pepperoniPizza;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox4.Image = Properties.Resources.cauliflowerCrustPizza;
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox5.Image = Properties.Resources.dominosPizza;
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox6.Image = Properties.Resources.pizzaSpecialA;
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox7.Image = Properties.Resources.pizzaSpecialB;
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox8.Image = Properties.Resources.pizzaSpecialC;
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox9.Image = Properties.Resources.pizzaSpecialD;
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox10.Image = Properties.Resources.pizzaBBQ;
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox11.Image = Properties.Resources.pizza1;
            pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox12.Image = Properties.Resources.pizza2;
            pictureBox12.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox13.Image = Properties.Resources.pizza3;
            pictureBox13.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox14.Image = Properties.Resources.pizza4;
            pictureBox14.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox15.Image = Properties.Resources.pizza5;
            pictureBox15.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox16.Image = Properties.Resources.pizza6;
            pictureBox16.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox17.Image = Properties.Resources.pizza7;
            pictureBox17.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox18.Image = Properties.Resources.pizza8;
            pictureBox18.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox19.Image = Properties.Resources.pizza9;
            pictureBox19.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox20.Image = Properties.Resources.amanosPizza;
            pictureBox20.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void foodBundleA_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            //code for changing the form background
            this.BackColor = Color.LightCyan;
            //code for food bundle B not to be selected
            foodBundleB_radioButton.Checked = false;
            //inserting image insdie the picture box            
            orderImage_pictureBox.Image = Properties.Resources.FamilyComboMealA;
            orderImage_pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

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
            discount_textBox.Text = "200.00";
            price = Convert.ToDouble(price_textBox.Text);
            //codes for inserting data inside the listbox
            displayListBox.Items.Add(foodBundleA_radioButton.Text + "                                                                                                           " + price_textBox.Text);
            displayListBox.Items.Add("          Discount Amount: " + "                                                                                                  " + discount_textBox.Text);
            quantity_textBox.Text = "0";
            quantity_textBox.Focus();

        }

        private void foodBundleB_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            //code for changing the form background
            this.BackColor = Color.LightBlue;
            //code for food bundle A not to be selected
            foodBundleA_radioButton.Checked = false;
            //inserting image insdie the picture box  
            orderImage_pictureBox.Image = Properties.Resources.FamilyComboMealB;
            orderImage_pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

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
            discount_textBox.Text = "194.85";

            price = Convert.ToDouble(price_textBox.Text);
            //codes for inserting data inside the listbox
            displayListBox.Items.Add(foodBundleB_radioButton.Text + "                                                                                                           " + price_textBox.Text);
            displayListBox.Items.Add("          Discount Amount: " + "                                                                                                  " + discount_textBox.Text);
            quantity_textBox.Text = "0";
            quantity_textBox.Focus();
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            //codes to uncheck all given checkboxes
            foodBundleA_radioButton.Checked = false;
            foodBundleB_radioButton.Checked = false;
            //code for inserting default image inside the picturebox
            orderImage_pictureBox.Image = Properties.Resources.default_image;
            orderImage_pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

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
            hawaiianPizza_checkBox.Checked = false;
            newYork_checkBox.Checked = false;
            pepperoni_checkBox.Checked = false;
            cauliflowerCrust_checkBox.Checked = false;
            dominos_checkBox.Checked = false;
            pizzaSpecA_checkBox.Checked = false;
            pizzaSpecB_checkBox.Checked = false;
            pizzaSpecC_checkBox.Checked = false;
            pizzaSpecD_checkBox.Checked = false;
            pizzaBBQ_checkBox.Checked = false;
            pizza1_checkBox.Checked = false;
            pizza2_checkBox.Checked = false;
            pizza3_checkBox.Checked = false;
            pizza4_checkBox.Checked = false;
            pizza5_checkBox.Checked = false;
            pizza6_checkBox.Checked = false;
            pizza7_checkBox.Checked = false;
            pizza8_checkBox.Checked = false;
            pizza9_checkBox.Checked = false;
            amanosPizza_checkBox.Checked = false;

            //removing the contents of the listbox
            displayListBox.Items.Clear();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calculate_button_Click(object sender, EventArgs e)
        {
            double cash_given, change, total_amountPaid;
            try
            {
                cash_given = Convert.ToDouble(cashGiven_textBox.Text);
                total_amountPaid = Convert.ToDouble(totalBills_textBox.Text);
                change = cash_given - total_amountPaid;
                change_textBox.Text = change.ToString("n");
                displayListBox.Items.Add("Total Bills: " + "                                                                                                           " + totalBills_textBox.Text);
                displayListBox.Items.Add("Cash Given: " + "                                                                                                           " + cashGiven_textBox.Text);
                displayListBox.Items.Add("Change: " + "                                                                                                           " + change_textBox.Text);
                displayListBox.Items.Add("Total No. of Items: " + "                                                                                                           " + totalQuantity_textBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Enter valid data in cash given textbox!");
                cashGiven_textBox.Clear();
                cashGiven_textBox.Focus();
            }
        }

        private void print_button_Click(object sender, EventArgs e)
        {
            //codes for calling the other form connected to the current form
            Lesson5_Example7_PrintForm print = new Lesson5_Example7_PrintForm();
            //codes for displaying the contents of the listbox from other form to the current form
            print.printDisplayListBox.Items.AddRange(this.displayListBox.Items);
            print.Show();
        }

        private void remove_button_Click(object sender, EventArgs e)
        {
            displayListBox.Items.RemoveAt(displayListBox.SelectedIndex);
        }

        private void quantity_textBox_TextChanged(object sender, EventArgs e)
        {
            double price, discounted_amount, discount_amount;
            int qty;
            try
            {
                price = Convert.ToDouble(price_textBox.Text);
                qty = Convert.ToInt32(quantity_textBox.Text);
                switch (qty)
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    {
                        discount_amount = ((price * qty) * 0.05);
                        discount_textBox.Text = discount_amount.ToString("n");

                        discounted_amount = (price * qty) - discount_amount;
                        discounted_textBox.Text = discounted_amount.ToString("n");

                        total_qty += qty;
                        totalQuantity_textBox.Text = total_qty.ToString();

                        total_amount += discounted_amount;
                        totalBills_textBox.Text = total_amount.ToString("n");
                        break;
                    }
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                    case 10:
                    {
                        discount_amount = ((price * qty) * 0.10);
                        discount_textBox.Text = discount_amount.ToString("n");

                        discounted_amount = (price * qty) - discount_amount;
                        discounted_textBox.Text = discounted_amount.ToString("n");

                        total_qty += qty;
                        totalQuantity_textBox.Text = total_qty.ToString();

                        total_amount += discounted_amount;
                        totalBills_textBox.Text = total_amount.ToString("n");
                        break;
                    }
                    case 11:
                    case 12:
                    case 13:
                    case 14:
                    case 15:
                    case 16:
                    case 17:
                    case 18:
                    case 19:
                    case 20:
                    {
                        discount_amount = ((price * qty) * 0.20);
                        discount_textBox.Text = discount_amount.ToString("n");

                        discounted_amount = (price * qty) - discount_amount;
                        discounted_textBox.Text = discounted_amount.ToString("n");

                        total_qty += qty;
                        totalQuantity_textBox.Text = total_qty.ToString();

                        total_amount += discounted_amount;
                        totalBills_textBox.Text = total_amount.ToString("n");
                        break;
                    }
                    default:
                    {
                        discount_amount = ((price * qty) * 0.30);
                        discount_textBox.Text = discount_amount.ToString("n");

                        discounted_amount = (price * qty) - discount_amount;
                        discounted_textBox.Text = discounted_amount.ToString("n");

                        total_qty += qty;
                        totalQuantity_textBox.Text = total_qty.ToString();

                        total_amount += discounted_amount;
                        totalBills_textBox.Text = total_amount.ToString("n");
                        break;
                    }
                    
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Enter number of quantity ordered!");
                quantity_textBox.Focus();
            }
        }

        private void hawaiian_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            //codes to declare a variable with specific data type
            double price;
            //codes for putting text property value of the textbox
            discount_textBox.Text = "0.00";
            price_textBox.Text = "500.99";
            //codes to convert string data inside the texbox to numeric data to store inside the variable
            price = Convert.ToDouble(price_textBox.Text);
            //codes to display the value of the variable inside the listbox
            displayListBox.Items.Add(hawaiian_checkBox.Text + "                                                                                                           " + price.ToString("n"));
            //codes for putting text property value of the textbox
            quantity_textBox.Text = "0";
            //codes for the cursor inside the textbox once the event of the object is triggered
            quantity_textBox.Focus();
        }

        private void newYork_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            price_textBox.Text = "550.00";
            discount_textBox.Text = "0.00";
            price = Convert.ToDouble(price_textBox.Text);
            displayListBox.Items.Add(newYork_checkBox.Text + "                                                                                                           " + price.ToString("n"));
            quantity_textBox.Text = "0";
            quantity_textBox.Focus();
        }

        private void pepperoni_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            price_textBox.Text = "600.99";
            discount_textBox.Text = "0.00";
            price = Convert.ToDouble(price_textBox.Text);
            displayListBox.Items.Add(pepperoni_checkBox.Text + "                                                                                                           " + price.ToString("n"));
            quantity_textBox.Text = "0";
            quantity_textBox.Focus();
        }

        private void cauliflowerCrust_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            price_textBox.Text = "700.50";
            discount_textBox.Text = "0.00";
            price = Convert.ToDouble(price_textBox.Text);
            displayListBox.Items.Add(cauliflowerCrust_checkBox.Text + "                                                                                                           " + price.ToString("n"));
            quantity_textBox.Text = "0";
            quantity_textBox.Focus();
        }

        private void dominos_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            price_textBox.Text = "500.00";
            discount_textBox.Text = "0.00";
            price = Convert.ToDouble(price_textBox.Text);
            displayListBox.Items.Add(dominos_checkBox.Text + "                                                                                                           " + price.ToString("n"));
            quantity_textBox.Text = "0";
            quantity_textBox.Focus();
        }

        private void pizzaSpecA_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            price_textBox.Text = "750.00";
            discount_textBox.Text = "0.00";
            price = Convert.ToDouble(price_textBox.Text);
            displayListBox.Items.Add(pizzaSpecA_checkBox.Text + "                                                                                                           " + price.ToString("n"));
            quantity_textBox.Text = "0";
            quantity_textBox.Focus();
        }

        private void pizzaSpecB_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            price_textBox.Text = "700.00";
            discount_textBox.Text = "0.00";
            price = Convert.ToDouble(price_textBox.Text);
            displayListBox.Items.Add(pizzaSpecB_checkBox.Text + "                                                                                                           " + price.ToString("n"));
            quantity_textBox.Text = "0";
            quantity_textBox.Focus();
        }

        private void pizzaSpecC_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            price_textBox.Text = "850.00";
            discount_textBox.Text = "0.00";
            price = Convert.ToDouble(price_textBox.Text);
            displayListBox.Items.Add(pizzaSpecC_checkBox.Text + "                                                                                                           " + price.ToString("n"));
            quantity_textBox.Text = "0";
            quantity_textBox.Focus();
        }

        private void pizzaSpecD_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            price_textBox.Text = "450.00";
            discount_textBox.Text = "0.00";
            price = Convert.ToDouble(price_textBox.Text);
            displayListBox.Items.Add(pizzaSpecD_checkBox.Text + "                                                                                                           " + price.ToString("n"));
            quantity_textBox.Text = "0";
            quantity_textBox.Focus();
        }

        private void pizzaBBQ_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            price_textBox.Text = "650.00";
            discount_textBox.Text = "0.00";
            price = Convert.ToDouble(price_textBox.Text);
            displayListBox.Items.Add(pizzaBBQ_checkBox.Text + "                                                                                                           " + price.ToString("n"));
            quantity_textBox.Text = "0";
            quantity_textBox.Focus();
        }

        private void pizza1_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            price_textBox.Text = "575.00";
            discount_textBox.Text = "0.00";
            price = Convert.ToDouble(price_textBox.Text);
            displayListBox.Items.Add(pizza1_checkBox.Text + "                                                                                                           " + price.ToString("n"));
            quantity_textBox.Text = "0";
            quantity_textBox.Focus();
        }

        private void pizza2_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            price_textBox.Text = "575.00";
            discount_textBox.Text = "0.00";
            price = Convert.ToDouble(price_textBox.Text);
            displayListBox.Items.Add(pizza2_checkBox.Text + "                                                                                                           " + price.ToString("n"));
            quantity_textBox.Text = "0";
            quantity_textBox.Focus();
        }

        private void pizza3_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            price_textBox.Text = "575.00";
            discount_textBox.Text = "0.00";
            price = Convert.ToDouble(price_textBox.Text);
            displayListBox.Items.Add(pizza3_checkBox.Text + "                                                                                                           " + price.ToString("n"));
            quantity_textBox.Text = "0";
            quantity_textBox.Focus();
        }

        private void pizza4_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            price_textBox.Text = "575.00";
            discount_textBox.Text = "0.00";
            price = Convert.ToDouble(price_textBox.Text);
            displayListBox.Items.Add(pizza4_checkBox.Text + "                                                                                                           " + price.ToString("n"));
            quantity_textBox.Text = "0";
            quantity_textBox.Focus();
        }

        private void pizza5_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            price_textBox.Text = "575.00";
            discount_textBox.Text = "0.00";
            price = Convert.ToDouble(price_textBox.Text);
            displayListBox.Items.Add(pizza5_checkBox.Text + "                                                                                                           " + price.ToString("n"));
            quantity_textBox.Text = "0";
            quantity_textBox.Focus();
        }

        private void pizza6_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            price_textBox.Text = "575.00";
            discount_textBox.Text = "0.00";
            price = Convert.ToDouble(price_textBox.Text);
            displayListBox.Items.Add(pizza6_checkBox.Text + "                                                                                                           " + price.ToString("n"));
            quantity_textBox.Text = "0";
            quantity_textBox.Focus();
        }

        private void pizza7_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            price_textBox.Text = "575.00";
            discount_textBox.Text = "0.00";
            price = Convert.ToDouble(price_textBox.Text);
            displayListBox.Items.Add(pizza7_checkBox.Text + "                                                                                                           " + price.ToString("n"));
            quantity_textBox.Text = "0";
            quantity_textBox.Focus();
        }

        private void pizza8_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            price_textBox.Text = "575.00";
            discount_textBox.Text = "0.00";
            price = Convert.ToDouble(price_textBox.Text);
            displayListBox.Items.Add(pizza8_checkBox.Text + "                                                                                                           " + price.ToString("n"));
            quantity_textBox.Text = "0";
            quantity_textBox.Focus();
        }

        private void pizza9_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            price_textBox.Text = "575.00";
            discount_textBox.Text = "0.00";
            price = Convert.ToDouble(price_textBox.Text);
            displayListBox.Items.Add(pizza9_checkBox.Text + "                                                                                                           " + price.ToString("n"));
            quantity_textBox.Text = "0";
            quantity_textBox.Focus();
        }

        private void amanosPizza_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            price_textBox.Text = "575.00";
            discount_textBox.Text = "0.00";
            price = Convert.ToDouble(price_textBox.Text);
            displayListBox.Items.Add(amanosPizza_checkBox.Text + "                                                                                                           " + price.ToString("n"));
            quantity_textBox.Text = "0";
            quantity_textBox.Focus();
        }

        private void Lesson4_Example3_Load(object sender, EventArgs e)
        {
            CenterPanel();
            this.Resize += (s, ev) => CenterPanel();
            isloading = true;
        }

        private void CenterPanel()
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
        }
    }
}
