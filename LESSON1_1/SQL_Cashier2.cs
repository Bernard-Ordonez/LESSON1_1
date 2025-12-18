using LESSON1_1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace LESSON1_1
{
    public partial class SQL_Cashier2 : Form
    {
        // codes for declaring variables that is accessible to the whole form and can be access for one object to another
        private double total_amount = 0;
        private int total_qty = 0;

        private bool isloading = true;

        pos_dbconnection posdb_connect = new pos_dbconnection();
        Price_Item_Value price_discountamount_value = new Price_Item_Value();
        Variables variables = new Variables();

        public SQL_Cashier2()
        {
            InitializeComponent();
            posdb_connect.pos_connString();

            price_textBox.Enabled = false;
            discount_textBox.Enabled = false;
            discounted_textBox.Enabled = false;
            totalQuantity_textBox.Enabled = false;
            change_textBox.Enabled = false;

            Sprite_checkBox.Enabled = false;
            twoOrangeChicken_checkBox.Enabled = false;
            ThreeLargeFries_checkBox.Enabled = false;
            TwoPCsIndianChicken_checkBox.Enabled = false;
            ThreeTaiwaneseChicken_checkBox.Enabled = false;

            OnepointFiveCoke_checkBox.Enabled = false;
            BreadedPorkChop_checkBox.Enabled = false;
            ThreeLargeFries2_checkBox.Enabled = false;
            PrimeRibRoast_checkBox.Enabled = false;
            BeefWellington_checkBox.Enabled = false;

            //codes for hiding the picture path textboxes
            picpath_textBox1.Hide(); picpath_textBox2.Hide();
            picpath_textBox3.Hide(); picpath_textBox4.Hide();
            picpath_textBox5.Hide(); picpath_textBox6.Hide();
            picpath_textBox7.Hide(); picpath_textBox8.Hide();
            picpath_textBox9.Hide(); picpath_textBox10.Hide();
            picpath_textBox11.Hide(); picpath_textBox12.Hide();
            picpath_textBox13.Hide(); picpath_textBox14.Hide();
            picpath_textBox15.Hide(); picpath_textBox16.Hide();
            picpath_textBox17.Hide(); picpath_textBox18.Hide();
            picpath_textBox19.Hide(); picpath_textBox20.Hide();

            // codes for selecting the menu items from database and display in labels
            posdb_connect.pos_sql = "SELECT * FROM pos_nameTbl INNER JOIN pos_picTbl ON pos_nameTbl.pos_id = pos_picTbl.pos_id INNER JOIN pos_priceTbl ON pos_picTbl.pos_id = pos_priceTbl.pos_id WHERE pos_nameTbl.pos_id = 1";
            //posdb_connect.pos_select_cashier();
            posdb_connect.pos_cmd();
            posdb_connect.pos_sqldataadapterSelect();
            posdb_connect.pos_sql_datasetSELECT();


            // codes for displaying the menu items in labels
            checkBox1.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][2].ToString();
            checkBox2.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][3].ToString();
            checkBox3.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][4].ToString();
            checkBox4.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][5].ToString();
            checkBox5.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][6].ToString();
            checkBox6.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][7].ToString();
            checkBox7.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][8].ToString();
            checkBox8.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][9].ToString();
            checkBox9.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][10].ToString();
            checkBox10.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][11].ToString();
            checkBox11.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][12].ToString();
            checkBox12.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][13].ToString();
            checkBox13.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][14].ToString();
            checkBox14.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][15].ToString();
            checkBox15.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][16].ToString();
            checkBox16.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][17].ToString();
            checkBox17.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][18].ToString();
            checkBox18.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][19].ToString();
            checkBox19.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][20].ToString();
            checkBox20.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][21].ToString();


            // codes for displaying the item pictures in picture boxes
            picpath_textBox1.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][24].ToString();
            pictureBox1.Image = Image.FromFile(picpath_textBox1.Text);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            picpath_textBox2.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][25].ToString();
            pictureBox2.Image = Image.FromFile(picpath_textBox2.Text);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            picpath_textBox3.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][26].ToString();
            pictureBox3.Image = Image.FromFile(picpath_textBox3.Text);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;

            picpath_textBox4.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][27].ToString();
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.Image = Image.FromFile(picpath_textBox4.Text);

            picpath_textBox5.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][28].ToString();
            pictureBox5.Image = Image.FromFile(picpath_textBox5.Text);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;

            picpath_textBox6.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][29].ToString();
            pictureBox6.Image = Image.FromFile(picpath_textBox6.Text);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;

            picpath_textBox7.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][30].ToString();
            pictureBox7.Image = Image.FromFile(picpath_textBox7.Text);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;

            picpath_textBox8.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][31].ToString();
            pictureBox8.Image = Image.FromFile(picpath_textBox8.Text);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;

            picpath_textBox9.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][32].ToString();
            pictureBox9.Image = Image.FromFile(picpath_textBox9.Text);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;


            picpath_textBox10.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][33].ToString();
            pictureBox10.Image = Image.FromFile(picpath_textBox10.Text);
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;


            picpath_textBox11.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][34].ToString();
            pictureBox11.Image = Image.FromFile(picpath_textBox11.Text);
            pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;


            picpath_textBox12.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][35].ToString();
            pictureBox12.Image = Image.FromFile(picpath_textBox12.Text);
            pictureBox12.SizeMode = PictureBoxSizeMode.StretchImage;


            picpath_textBox13.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][36].ToString();
            pictureBox13.Image = Image.FromFile(picpath_textBox13.Text);
            pictureBox13.SizeMode = PictureBoxSizeMode.StretchImage;


            picpath_textBox14.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][37].ToString();
            pictureBox14.Image = Image.FromFile(picpath_textBox14.Text);
            pictureBox14.SizeMode = PictureBoxSizeMode.StretchImage;


            picpath_textBox15.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][38].ToString();
            pictureBox15.Image = Image.FromFile(picpath_textBox15.Text);
            pictureBox15.SizeMode = PictureBoxSizeMode.StretchImage;


            picpath_textBox16.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][39].ToString();
            pictureBox16.Image = Image.FromFile(picpath_textBox16.Text);
            pictureBox16.SizeMode = PictureBoxSizeMode.StretchImage;


            picpath_textBox17.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][40].ToString();
            pictureBox17.Image = Image.FromFile(picpath_textBox17.Text);
            pictureBox17.SizeMode = PictureBoxSizeMode.StretchImage;


            picpath_textBox18.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][41].ToString();
            pictureBox18.Image = Image.FromFile(picpath_textBox18.Text);
            pictureBox18.SizeMode = PictureBoxSizeMode.StretchImage;


            picpath_textBox19.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][42].ToString();
            pictureBox19.Image = Image.FromFile(picpath_textBox19.Text);
            pictureBox19.SizeMode = PictureBoxSizeMode.StretchImage;


            picpath_textBox20.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][43].ToString();
            pictureBox20.Image = Image.FromFile(picpath_textBox20.Text);
            pictureBox20.SizeMode = PictureBoxSizeMode.StretchImage;

            // codes for displaying the prices in price textboxes
            price_label1.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][46].ToString();
            price_label2.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][47].ToString();
            price_label3.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][48].ToString();
            price_label4.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][49].ToString();
            price_label5.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][50].ToString();
            price_label6.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][51].ToString();
            price_label7.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][52].ToString();
            price_label8.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][53].ToString();
            price_label9.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][54].ToString();
            price_label10.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][55].ToString();
            price_label11.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][56].ToString();
            price_label12.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][57].ToString();
            price_label13.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][58].ToString();
            price_label14.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][59].ToString();
            price_label15.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][60].ToString();
            price_label16.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][61].ToString();
            price_label17.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][62].ToString();
            price_label18.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][63].ToString();
            price_label19.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][64].ToString();
            price_label20.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][65].ToString();

        }

        private void quantityTxtbox()
        {
            quantity_textBox.Text = "0";
            quantity_textBox.Focus();
        }

        private void GetPriceDiscountAmoount()
        {
            price_textBox.Text = (price_discountamount_value.GetPriceItem());
            discount_textBox.Text = (price_discountamount_value.GetDiscountAmount());
            variables.price = Convert.ToDouble(price_textBox.Text);
        }

        private void CenterPanel()
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
        }

        private void foodBundleA_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            this.BackColor = Color.AliceBlue;
            foodBundleB_radioButton.Checked = false;          
            orderImage_pictureBox.Image = Image.FromFile(@"C:\Users\Bernard Ordonez\source\DSAL01E\LESSON1_1\LESSON1_1\Resources\Bundle A.jpg");
            orderImage_pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            Sprite_checkBox.Checked = true;
            twoOrangeChicken_checkBox.Checked = true;
            ThreeLargeFries_checkBox.Checked = true;
            TwoPCsIndianChicken_checkBox.Checked = true;
            ThreeTaiwaneseChicken_checkBox.Checked = true;

            OnepointFiveCoke_checkBox.Checked = false;
            BreadedPorkChop_checkBox.Checked = false;
            ThreeLargeFries2_checkBox.Checked = false;
            PrimeRibRoast_checkBox.Checked = false;
            BeefWellington_checkBox.Checked = false;

            foodOrderChoice_textBox.Text = foodBundleA_radioButton.Text;
            price_textBox.Text = "3,500.00";
            discount_textBox.Text = "400.00";
            price = Convert.ToDouble(price_textBox.Text);
            displayListBox.Items.Add(foodBundleA_radioButton.Text + "                                                                                                           " + price_textBox.Text);
            displayListBox.Items.Add("          Discount Amount: " + "                                                                                                  " + discount_textBox.Text);
            quantity_textBox.Text = "0";
            quantity_textBox.Focus();

        }

        private void foodBundleB_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            this.BackColor = Color.IndianRed;
            foodBundleA_radioButton.Checked = false; 
            orderImage_pictureBox.Image = Image.FromFile(@"C:\Users\Bernard Ordonez\source\DSAL01E\LESSON1_1\LESSON1_1\Resources\Bundle B.jpg");
            orderImage_pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            Sprite_checkBox.Checked = false;
            twoOrangeChicken_checkBox.Checked = false;
            ThreeLargeFries_checkBox.Checked = false;
            TwoPCsIndianChicken_checkBox.Checked = false;
            ThreeTaiwaneseChicken_checkBox.Checked = false;

            OnepointFiveCoke_checkBox.Checked = true;
            BreadedPorkChop_checkBox.Checked = true;
            ThreeLargeFries2_checkBox.Checked = true;
            PrimeRibRoast_checkBox.Checked = true;
            BeefWellington_checkBox.Checked = true;

            foodOrderChoice_textBox.Text = foodBundleB_radioButton.Text;
            price_textBox.Text = "3,700.00";
            discount_textBox.Text = "350.00";

            price = Convert.ToDouble(price_textBox.Text);
            displayListBox.Items.Add(foodBundleB_radioButton.Text + "                                                                                                           " + price_textBox.Text);
            displayListBox.Items.Add("          Discount Amount: " + "                                                                                                  " + discount_textBox.Text);
            quantity_textBox.Text = "0";
            quantity_textBox.Focus();
        }

        private void cleartextboxes()
        {
            foodBundleA_radioButton.Checked = false;
            foodBundleB_radioButton.Checked = false;
            orderImage_pictureBox.Image = Image.FromFile(@"C:\Users\Bernard Ordonez\source\DSAL01E\LESSON1_1\LESSON1_1\Resources\images.jpg");
            orderImage_pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            Sprite_checkBox.Checked = false;
            twoOrangeChicken_checkBox.Checked = false;
            ThreeLargeFries_checkBox.Checked = false;
            TwoPCsIndianChicken_checkBox.Checked = false;
            ThreeTaiwaneseChicken_checkBox.Checked = false;

            OnepointFiveCoke_checkBox.Checked = false;
            BreadedPorkChop_checkBox.Checked = false;
            ThreeLargeFries2_checkBox.Checked = false;
            PrimeRibRoast_checkBox.Checked = false;
            BeefWellington_checkBox.Checked = false;

            price_textBox.Clear();
            discount_textBox.Clear();
            discount_textBox.Clear();
            discounted_textBox.Clear();
            totalBills_textBox.Clear();
            totalQuantity_textBox.Clear();
            cashGiven_textBox.Clear();
            change_textBox.Clear();

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
            displayListBox.Items.Clear();
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            foodBundleA_radioButton.Checked = false;
            foodBundleB_radioButton.Checked = false;
            orderImage_pictureBox.Image = Image.FromFile(@"C:\Users\Bernard Ordonez\source\DSAL01E\LESSON1_1\LESSON1_1\Resources\images.jpg");
            orderImage_pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            Sprite_checkBox.Checked = false;
            twoOrangeChicken_checkBox.Checked = false;
            ThreeLargeFries_checkBox.Checked = false;
            TwoPCsIndianChicken_checkBox.Checked = false;
            ThreeTaiwaneseChicken_checkBox.Checked = false;

            OnepointFiveCoke_checkBox.Checked = false;
            BreadedPorkChop_checkBox.Checked = false;
            ThreeLargeFries2_checkBox.Checked = false;
            PrimeRibRoast_checkBox.Checked = false;
            BeefWellington_checkBox.Checked = false;

            price_textBox.Clear();
            discount_textBox.Clear();
            discount_textBox.Clear();
            discounted_textBox.Clear();
            totalBills_textBox.Clear();
            totalQuantity_textBox.Clear();
            cashGiven_textBox.Clear();
            change_textBox.Clear();

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
            SQL_Cashier2_Print print = new SQL_Cashier2_Print();
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
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            price_discountamount_value.SetPriceDiscountAmountValue("0.00", price_label1.Text);
            GetPriceDiscountAmoount();
            quantityTxtbox();
            displayListBox.Items.Add(checkBox1.Text + "                 " + price_textBox.Text);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            price_discountamount_value.SetPriceDiscountAmountValue("0.00", price_label2.Text);
            GetPriceDiscountAmoount();
            quantityTxtbox();
            displayListBox.Items.Add(checkBox2.Text + "                 " + price_textBox.Text);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            price_discountamount_value.SetPriceDiscountAmountValue("0.00", price_label3.Text);
            GetPriceDiscountAmoount();
            quantityTxtbox();
            displayListBox.Items.Add(checkBox3.Text + "                 " + price_textBox.Text);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            price_discountamount_value.SetPriceDiscountAmountValue("0.00", price_label4.Text);
            GetPriceDiscountAmoount();
            quantityTxtbox();
            displayListBox.Items.Add(checkBox4.Text + "                 " + price_textBox.Text);
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            price_discountamount_value.SetPriceDiscountAmountValue("0.00", price_label5.Text);
            GetPriceDiscountAmoount();
            quantityTxtbox();
            displayListBox.Items.Add(checkBox5.Text + "                 " + price_textBox.Text);
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            price_discountamount_value.SetPriceDiscountAmountValue("0.00", price_label6.Text);
            GetPriceDiscountAmoount();
            quantityTxtbox();
            displayListBox.Items.Add(checkBox6.Text + "                 " + price_textBox.Text);
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            price_discountamount_value.SetPriceDiscountAmountValue("0.00", price_label7.Text);
            GetPriceDiscountAmoount();
            quantityTxtbox();
            displayListBox.Items.Add(checkBox7.Text + "                 " + price_textBox.Text);
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            price_discountamount_value.SetPriceDiscountAmountValue("0.00", price_label8.Text);
            GetPriceDiscountAmoount();
            quantityTxtbox();
            displayListBox.Items.Add(checkBox8.Text + "                 " + price_textBox.Text);
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            price_discountamount_value.SetPriceDiscountAmountValue("0.00", price_label9.Text);
            GetPriceDiscountAmoount();
            quantityTxtbox();
            displayListBox.Items.Add(checkBox9.Text + "                 " + price_textBox.Text);
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            price_discountamount_value.SetPriceDiscountAmountValue("0.00", price_label10.Text);
            GetPriceDiscountAmoount();
            quantityTxtbox();
            displayListBox.Items.Add(checkBox10.Text + "                " + price_textBox.Text);
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            price_discountamount_value.SetPriceDiscountAmountValue("0.00", price_label11.Text);
            GetPriceDiscountAmoount();
            quantityTxtbox();
            displayListBox.Items.Add(checkBox11.Text + "                " + price_textBox.Text);
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            price_discountamount_value.SetPriceDiscountAmountValue("0.00", price_label12.Text);
            GetPriceDiscountAmoount();
            quantityTxtbox();
            displayListBox.Items.Add(checkBox12.Text + "                " + price_textBox.Text);
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            price_discountamount_value.SetPriceDiscountAmountValue("0.00", price_label13.Text);
            GetPriceDiscountAmoount();
            quantityTxtbox();
            displayListBox.Items.Add(checkBox13.Text + "                " + price_textBox.Text);
        }
        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            price_discountamount_value.SetPriceDiscountAmountValue("0.00", price_label14.Text);
            GetPriceDiscountAmoount();
            quantityTxtbox();
            displayListBox.Items.Add(checkBox14.Text + "                " + price_textBox.Text);
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            price_discountamount_value.SetPriceDiscountAmountValue("0.00", price_label15.Text);
            GetPriceDiscountAmoount();
            quantityTxtbox();
            displayListBox.Items.Add(checkBox15.Text + "                " + price_textBox.Text);
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            price_discountamount_value.SetPriceDiscountAmountValue("0.00", price_label16.Text);
            GetPriceDiscountAmoount();
            quantityTxtbox();
            displayListBox.Items.Add(checkBox16.Text + "                " + price_textBox.Text);
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            price_discountamount_value.SetPriceDiscountAmountValue("0.00", price_label17.Text);
            GetPriceDiscountAmoount();
            quantityTxtbox();
            displayListBox.Items.Add(checkBox17.Text + "                " + price_textBox.Text);
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            price_discountamount_value.SetPriceDiscountAmountValue("0.00", price_label18.Text);
            GetPriceDiscountAmoount();
            quantityTxtbox();
            displayListBox.Items.Add(checkBox18.Text + "                " + price_textBox.Text);
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            price_discountamount_value.SetPriceDiscountAmountValue("0.00", price_label19.Text);
            GetPriceDiscountAmoount();
            quantityTxtbox();
            displayListBox.Items.Add(checkBox19.Text + "                " + price_textBox.Text);
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            price_discountamount_value.SetPriceDiscountAmountValue("0.00", price_label20.Text);
            GetPriceDiscountAmoount();
            quantityTxtbox();
            displayListBox.Items.Add(checkBox20.Text + "                " + price_textBox.Text);
        }

        private void Lesson14_Activity3_Load(object sender, EventArgs e)
        {
            CenterPanel();
            this.Resize += (s, ev) => CenterPanel();
            isloading = true;
        }

        private void submit_button_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(
        "Data saved successfully (SalesTBL).",
        "Confirmation",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information
    );
            posdb_connect.pos_sql = "INSERT INTO sales2Tbl (food_order_choice, " +
                "price, discount_amount, discounted_amount, " +
                "total_bills, total_quantity, " +
                "cash_given, change) " +
                "VALUES ('" + foodOrderChoice_textBox.Text + "', '" + price_textBox.Text +
                "', '" + discount_textBox.Text + "', '" + discounted_textBox.Text + "', '" +
                totalBills_textBox.Text + "', '" + totalQuantity_textBox.Text + "', '" +
                cashGiven_textBox.Text + "', '" + change_textBox.Text + "')";

            posdb_connect.pos_cmd();
            posdb_connect.pos_sqldataadapterInsert();
            cleartextboxes();
        }

        private void SQL_Cashier2_Load(object sender, EventArgs e)
        {

            PC_IDComboBox.Items.AddRange(new object[]
            {
                "1",
                "2",
                "3",
                "4"
            });
            CenterPanel();
            this.Resize += (s, ev) => CenterPanel();
            isloading = true;
            picpath_textBox1.Hide(); picpath_textBox2.Hide();
            picpath_textBox3.Hide(); picpath_textBox4.Hide();
            picpath_textBox5.Hide(); picpath_textBox6.Hide();
            picpath_textBox7.Hide(); picpath_textBox8.Hide();
            picpath_textBox9.Hide(); picpath_textBox10.Hide();
            picpath_textBox11.Hide(); picpath_textBox12.Hide();
            picpath_textBox13.Hide(); picpath_textBox14.Hide();
            picpath_textBox15.Hide(); picpath_textBox16.Hide();
            picpath_textBox17.Hide(); picpath_textBox18.Hide();
            picpath_textBox19.Hide(); picpath_textBox20.Hide();
        }

        private void PC_IDComboBox_SelectedIndex(object sender, EventArgs e)
        {
            posdb_connect.pos_sql = "SELECT * FROM pos_nameTbl INNER JOIN pos_picTbl ON pos_nameTbl.pos_id = pos_picTbl.pos_id INNER JOIN pos_priceTbl ON pos_picTbl.pos_id = pos_priceTbl.pos_id WHERE pos_nameTbl.pos_id = '" + PC_IDComboBox.Text + "'";
            //posdb_connect.pos_select_cashier();
            posdb_connect.pos_cmd();
            posdb_connect.pos_sqldataadapterSelect();
            posdb_connect.pos_sql_datasetSELECT();


            // codes for displaying the menu items in labels
            checkBox1.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][2].ToString();
            checkBox2.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][3].ToString();
            checkBox3.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][4].ToString();
            checkBox4.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][5].ToString();
            checkBox5.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][6].ToString();
            checkBox6.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][7].ToString();
            checkBox7.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][8].ToString();
            checkBox8.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][9].ToString();
            checkBox9.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][10].ToString();
            checkBox10.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][11].ToString();
            checkBox11.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][12].ToString();
            checkBox12.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][13].ToString();
            checkBox13.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][14].ToString();
            checkBox14.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][15].ToString();
            checkBox15.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][16].ToString();
            checkBox16.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][17].ToString();
            checkBox17.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][18].ToString();
            checkBox18.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][19].ToString();
            checkBox19.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][20].ToString();
            checkBox20.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][21].ToString();


            // codes for displaying the item pictures in picture boxes
            picpath_textBox1.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][24].ToString();
            pictureBox1.Image = Image.FromFile(picpath_textBox1.Text);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            picpath_textBox2.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][25].ToString();
            pictureBox2.Image = Image.FromFile(picpath_textBox2.Text);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            picpath_textBox3.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][26].ToString();
            pictureBox3.Image = Image.FromFile(picpath_textBox3.Text);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;

            picpath_textBox4.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][27].ToString();
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.Image = Image.FromFile(picpath_textBox4.Text);

            picpath_textBox5.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][28].ToString();
            pictureBox5.Image = Image.FromFile(picpath_textBox5.Text);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;

            picpath_textBox6.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][29].ToString();
            pictureBox6.Image = Image.FromFile(picpath_textBox6.Text);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;

            picpath_textBox7.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][30].ToString();
            pictureBox7.Image = Image.FromFile(picpath_textBox7.Text);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;

            picpath_textBox8.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][31].ToString();
            pictureBox8.Image = Image.FromFile(picpath_textBox8.Text);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;

            picpath_textBox9.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][32].ToString();
            pictureBox9.Image = Image.FromFile(picpath_textBox9.Text);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;


            picpath_textBox10.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][33].ToString();
            pictureBox10.Image = Image.FromFile(picpath_textBox10.Text);
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;


            picpath_textBox11.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][34].ToString();
            pictureBox11.Image = Image.FromFile(picpath_textBox11.Text);
            pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;


            picpath_textBox12.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][35].ToString();
            pictureBox12.Image = Image.FromFile(picpath_textBox12.Text);
            pictureBox12.SizeMode = PictureBoxSizeMode.StretchImage;


            picpath_textBox13.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][36].ToString();
            pictureBox13.Image = Image.FromFile(picpath_textBox13.Text);
            pictureBox13.SizeMode = PictureBoxSizeMode.StretchImage;


            picpath_textBox14.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][37].ToString();
            pictureBox14.Image = Image.FromFile(picpath_textBox14.Text);
            pictureBox14.SizeMode = PictureBoxSizeMode.StretchImage;


            picpath_textBox15.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][38].ToString();
            pictureBox15.Image = Image.FromFile(picpath_textBox15.Text);
            pictureBox15.SizeMode = PictureBoxSizeMode.StretchImage;


            picpath_textBox16.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][39].ToString();
            pictureBox16.Image = Image.FromFile(picpath_textBox16.Text);
            pictureBox16.SizeMode = PictureBoxSizeMode.StretchImage;


            picpath_textBox17.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][40].ToString();
            pictureBox17.Image = Image.FromFile(picpath_textBox17.Text);
            pictureBox17.SizeMode = PictureBoxSizeMode.StretchImage;


            picpath_textBox18.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][41].ToString();
            pictureBox18.Image = Image.FromFile(picpath_textBox18.Text);
            pictureBox18.SizeMode = PictureBoxSizeMode.StretchImage;


            picpath_textBox19.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][42].ToString();
            pictureBox19.Image = Image.FromFile(picpath_textBox19.Text);
            pictureBox19.SizeMode = PictureBoxSizeMode.StretchImage;


            picpath_textBox20.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][43].ToString();
            pictureBox20.Image = Image.FromFile(picpath_textBox20.Text);
            pictureBox20.SizeMode = PictureBoxSizeMode.StretchImage;

            // codes for displaying the prices in price textboxes
            price_label1.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][46].ToString();
            price_label2.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][47].ToString();
            price_label3.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][48].ToString();
            price_label4.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][49].ToString();
            price_label5.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][50].ToString();
            price_label6.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][51].ToString();
            price_label7.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][52].ToString();
            price_label8.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][53].ToString();
            price_label9.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][54].ToString();
            price_label10.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][55].ToString();
            price_label11.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][56].ToString();
            price_label12.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][57].ToString();
            price_label13.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][58].ToString();
            price_label14.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][59].ToString();
            price_label15.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][60].ToString();
            price_label16.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][61].ToString();
            price_label17.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][62].ToString();
            price_label18.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][63].ToString();
            price_label19.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][64].ToString();
            price_label20.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][65].ToString();
        }

    }
}
