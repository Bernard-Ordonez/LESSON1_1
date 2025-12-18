using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace DSAL01E_MORATA
{
    public partial class Lesson14_Activity2 : Form
    {
        private double qty_total = 0;
        private double discount_totalgiven = 0;
        private double discounted_total = 0;

        private bool isloading = true;

        //ADDED: Lesson 14 Example 2 - 11/4/2025
        pos_dbconnection posdb_connect =new pos_dbconnection();
        Price_Item_Value price_item_value = new Price_Item_Value();
        Variables variables = new Variables();

        public Lesson14_Activity2()
        {
            //ADDED: Lesson 14 Example 2 - 11/4/2025
            posdb_connect.pos_connString();

            InitializeComponent();

            // codes for disabling the textboxes
            itemName_textBox.Enabled = false;
            price_textBox.Enabled = false;
            discount_textBox.Enabled = false;
            discounted_textBox.Enabled = false;
            totalQuantity_textBox.Enabled = false;
            totalDiscGiven_textBox.Enabled = false;
            totalDiscAmt_textBox.Enabled = false;
            change_textBox.Enabled = false;

            //ADDED: Lesson 14 Example 2 - 11/4/2025
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
            // Dinagdag ito!
            posdb_connect.pos_sql = "SELECT * FROM pos_nameTbl INNER JOIN pos_picTbl ON pos_nameTbl.pos_id = pos_picTbl.pos_id INNER JOIN pos_priceTbl ON pos_picTbl.pos_id = pos_priceTbl.pos_id WHERE pos_nameTbl.pos_id = 1";
            
            //posdb_connect.pos_select_cashier();
            posdb_connect.pos_cmd();
            posdb_connect.pos_sqladapterSelect();
            posdb_connect.pos_sqldatasetSELECT();

            // codes for displaying the menu items in labels
            item1_label.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][2].ToString();
            item2_label.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][3].ToString();
            item3_label.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][4].ToString();
            item4_label.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][5].ToString();
            item5_label.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][6].ToString();
            item6_label.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][7].ToString();
            item7_label.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][8].ToString();
            item8_label.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][9].ToString();
            item9_label.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][10].ToString();
            item10_label.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][11].ToString();
            item11_label.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][12].ToString();
            item12_label.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][13].ToString();
            item13_label.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][14].ToString();
            item14_label.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][15].ToString();
            item15_label.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][16].ToString();
            item16_label.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][17].ToString();
            item17_label.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][18].ToString();
            item18_label.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][19].ToString();
            item19_label.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][20].ToString();
            item20_label.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][21].ToString();

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

            /*
            // codes for retrieving data from the database and display it in the interface objects
            posdb_connect.pos_select_cashier_display();
            posdb_connect.pos_cmd();
            posdb_connect.pos_sqladapterSelect();
            posdb_connect.pos_select_cashier_SELECTdisplay();

            // codes for throwing data from tables inside the database to the textboxes
            pcTerminal_INPUT_label.Text =
                posdb_connect.pos_sql_dataset.Tables[0].Rows[0][3].ToString();
            empIDINPUT_label.Text =
                posdb_connect.pos_sql_dataset.Tables[0].Rows[0][0].ToString();
            empFNameINPUT_label.Text =
                posdb_connect.pos_sql_dataset.Tables[0].Rows[0][1].ToString();
            empSNameINPUT_label.Text =
                posdb_connect.pos_sql_dataset.Tables[0].Rows[0][2].ToString();

            DateTime dateTime = DateTime.Now;
            dateINPUT_label.Text = dateTime.ToString("MMMM dd, yyyy");
            */
        }

        private void CenterPanel()
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
        }



        // Function methods for clearing quantity textbox putting the cursor inside
        private void quantityTxtbox()
        {
            quantity_textBox.Clear();
            quantity_textBox.Focus();
        }

        // Function methods for converting quantity and price input from string to numeric value
        private void quantity_price_Convert()
        {
            variables.quantity = Convert.ToInt32(quantity_textBox.Text);
            variables.price = Convert.ToDouble(price_textBox.Text);
        }

        // Function methods for the formula needed in the program computations
        private void computation_Formula_and_DisplayData()
        {
            variables.discounted_amt = (variables.quantity * variables.price) - variables.discount_amt;
            discount_textBox.Text = variables.discount_amt.ToString("n");
            discounted_textBox.Text = variables.discounted_amt.ToString("n");
        }

        // Function with return value for item name and price textbox
        public void GetPriceItemValue()
        {
            itemName_textBox.Text = (price_item_value.GetItemName());
            price_textBox.Text = (price_item_value.GetPrice());
        }

        private void cleartextboxes()
        {
            itemName_textBox.Clear();
            price_textBox.Clear();
            quantity_textBox.Clear();
            discounted_textBox.Clear();
            discount_textBox.Clear();
            change_textBox.Clear();
            cashRendered_textBox.Clear();
        }


        // PictureBox click event handlers: set item name and price for selected menu item
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            /*
            itemName_textBox.Text = "Combo Meal A";
            price_textBox.Text = "121.30";
            */

            price_item_value.SetPriceItemValue(item1_label.Text, price_label1.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(item2_label.Text, price_label2.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(item3_label.Text, price_label3.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(item4_label.Text, price_label4.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(item5_label.Text, price_label5.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(item6_label.Text, price_label6.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(item7_label.Text, price_label7.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(item8_label.Text, price_label8.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(item9_label.Text, price_label9.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(item10_label.Text, price_label10.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(item11_label.Text, price_label11.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(item12_label.Text, price_label12.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(item13_label.Text, price_label13.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(item14_label.Text, price_label14.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(item15_label.Text, price_label15.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(item16_label.Text, price_label16.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(item17_label.Text, price_label17.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(item18_label.Text, price_label18.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(item19_label.Text, price_label19.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(item20_label.Text, price_label20.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void seniorCitizen_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            /*
            // Declaration of variables within a method of an object 
            int qty;
            double price, discount_amt, discounted_amt;
            */

            // convert string data from textboxes to numeric and place it as value of the variable
            try
            {
                /*
                qty = Convert.ToInt32(quantity_textBox.Text);
                price = Convert.ToDouble(price_textBox.Text);

                // create a formula needed for computation
                discount_amt = (qty * price) * 0.30;
                discounted_amt = (qty * price) - discount_amt;

                // converting numeric data to string and display it inside the textboxes
                discount_textBox.Text = discount_amt.ToString("n");
                discounted_textBox.Text = discounted_amt.ToString("n");

                // codes for unchecking the other radio buttons in the interface once the senior citizen method executed
                discCard_radioButton.Checked = false;
                empDisc_radioButton.Checked = false;
                noDisc_radioButton.Checked = false;
                */

                // Modified from Lesson 14 Activity 2 - 12/3/2025
                quantity_price_Convert();
                variables.discount_amt = (variables.quantity * variables.price) * 0.30;
                computation_Formula_and_DisplayData();
                discCard_radioButton.Checked = false;
                empDisc_radioButton.Checked = false;
                noDisc_radioButton.Checked = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Input is invalid");
                quantityTxtbox();
            }
        }

        private void discCard_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            /*
            // Declaration of variables within a method of an object 
            int qty;
            double price, discount_amt, discounted_amt;
            */

            // convert string data from textboxes to numeric and place it as value of the variable
            try
            {
                /*
                qty = Convert.ToInt32(quantity_textBox.Text);
                price = Convert.ToDouble(price_textBox.Text);

                // create a formula needed for computation
                discount_amt = (qty * price) * 0.10;
                discounted_amt = (qty * price) - discount_amt;

                // converting numeric data to string and display it inside the textboxes
                discount_textBox.Text = discount_amt.ToString("n");
                discounted_textBox.Text = discounted_amt.ToString("n");

                // codes for unchecking the other radio buttons in the interface once the disc. card method executed
                seniorCitizen_radioButton.Checked = false;
                empDisc_radioButton.Checked = false;
                noDisc_radioButton.Checked = false;
                */

                // Modified from Lesson 14 Activity 2 - 12/3/2025
                quantity_price_Convert();
                variables.discount_amt = (variables.quantity * variables.price) * 0.10;
                computation_Formula_and_DisplayData();
                seniorCitizen_radioButton.Checked = false;
                empDisc_radioButton.Checked = false;
                noDisc_radioButton.Checked = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Input is invalid");
                quantityTxtbox();
            }
        }

        private void empDisc_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            /*
            // Declaration of variables within a method of an object 
            int qty;
            double price, discount_amt, discounted_amt;
            */

            // convert string data from textboxes to numeric and place it as value of the variable
            try
            {
                /*
                qty = Convert.ToInt32(quantity_textBox.Text);
                price = Convert.ToDouble(price_textBox.Text);

                // create a formula needed for computation
                discount_amt = (qty * price) * 0.15;
                discounted_amt = (qty * price) - discount_amt;

                // converting numeric data to string and display it inside the textboxes
                discount_textBox.Text = discount_amt.ToString("n");
                discounted_textBox.Text = discounted_amt.ToString("n");

                // codes for unchecking the other radio buttons in the interface once the Employee disc method executed
                seniorCitizen_radioButton.Checked = false;
                discCard_radioButton.Checked = false;
                noDisc_radioButton.Checked = false;
                */

                // Modified from Lesson 14 Activity 2 - 12/3/2025
                quantity_price_Convert();
                variables.discount_amt = (variables.quantity * variables.price) * 0.15;
                computation_Formula_and_DisplayData();
                seniorCitizen_radioButton.Checked = false;
                discCard_radioButton.Checked = false;
                noDisc_radioButton.Checked = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid data input in quantity");
                quantityTxtbox();
            }
        }

        private void noDisc_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            /*
            // Declaration of variables within a method of an object 
            int qty;
            double price, discount_amt, discounted_amt;
            */

            // convert string data from textboxes to numeric and place it as value of the variable
            try
            {
                /*
                qty = Convert.ToInt32(quantity_textBox.Text);
                price = Convert.ToDouble(price_textBox.Text);

                // create a formula needed for computation
                discount_amt = (qty * price) * 0;
                discounted_amt = (qty * price) - discount_amt;

                // converting numeric data to string and display it inside the textboxes
                discount_textBox.Text = discount_amt.ToString("n");
                discounted_textBox.Text = discounted_amt.ToString("n");
                */

                // Modified from Lesson 14 Activity 2 - 12/3/2025
                quantity_price_Convert();
                variables.discount_amt = (variables.quantity * variables.price) * 0;
                computation_Formula_and_DisplayData();
                seniorCitizen_radioButton.Checked = false;
                discCard_radioButton.Checked = false;
                empDisc_radioButton.Checked = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid data input in quantity");
                quantityTxtbox();
            }
        }

        private void calculate_button_Click(object sender, EventArgs e)
        {
            /*
            //declaration of variables with data types
            int qty;
            double discount_amt, discounted_amt, cash_rendered, change;
            */

            try
            {
                /*
                qty = Convert.ToInt32(quantity_textBox.Text);
                discount_amt = Convert.ToDouble(discount_textBox.Text);
                discounted_amt = Convert.ToDouble(discounted_textBox.Text);
                cash_rendered = Convert.ToDouble(cashRendered_textBox.Text);

                qty_total += qty;
                discount_totalgiven += discount_amt;
                discounted_total += discounted_amt;
                change = cash_rendered - discounted_amt;

                // converting string data form textboxes to numeric and place it as value of the variable
                totalQuantity_textBox.Text = qty_total.ToString();
                totalDiscGiven_textBox.Text = discount_totalgiven.ToString("n");
                totalDiscAmt_textBox.Text = discounted_total.ToString("n");
                change_textBox.Text = change.ToString("n");
                cashRendered_textBox.Text = cash_rendered.ToString("n");
                */

                // Parse input values
                variables.quantity = Convert.ToInt32(quantity_textBox.Text);
                variables.discount_amt = Convert.ToDouble(discount_textBox.Text);
                variables.discounted_amt = Convert.ToDouble(discounted_textBox.Text);
                variables.cash_given = Convert.ToDouble(cashRendered_textBox.Text);

                // Accumulate totals
                variables.qty_total += variables.quantity;
                variables.discount_totalgiven += variables.discount_amt;
                variables.discounted_total += variables.discounted_amt;

                // Calculate change
                variables.change = variables.cash_given - variables.discounted_amt;

                // Update UI
                totalQuantity_textBox.Text = variables.qty_total.ToString();
                totalDiscGiven_textBox.Text = variables.discount_totalgiven.ToString("n");
                totalDiscAmt_textBox.Text = variables.discounted_total.ToString("n");
                change_textBox.Text = variables.change.ToString("n");
                cashRendered_textBox.Text = variables.cash_given.ToString("n");
            }
            catch (Exception)
            {
                MessageBox.Show("Make sure cash given textbox is not empty invalid");
                cashRendered_textBox.Clear();
                cashRendered_textBox.Focus();
            }
        }

        private void new_button_Click(object sender, EventArgs e)
        {
            //codes for clearing specific pointed textboxes
            itemName_textBox.Clear();
            price_textBox.Clear();
            quantity_textBox.Clear();
            discount_textBox.Clear();
            discounted_textBox.Clear();
            change_textBox.Clear();
            cashRendered_textBox.Clear();

            seniorCitizen_radioButton.Checked = false;
            discCard_radioButton.Checked = false;
            empDisc_radioButton.Checked = false;
            noDisc_radioButton.Checked = false;
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {

        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void enter_button_Click(object sender, EventArgs e)
        {
            if (seniorCitizen_radioButton.Checked == true)
            {
                posdb_connect.pos_sql = "INSERT INTO salesTbl (product_name, " +
                "product_quantity_per_transaction, product_price, discount_option, " +
                "discount_amount_per_transaction, discounted_amount_per_transaction, " +
                "summary_total_quantity, summary_total_disc_given, " +
                "summary_total_discounted_amount, terminal_no, time_date, emp_id) " +
                "VALUES ('" + itemName_textBox.Text + "', '" + quantity_textBox.Text +
                "', '" + price_textBox.Text + "', '" + seniorCitizen_radioButton.Text + "', '" +
                discount_textBox.Text + "', '" + discounted_textBox.Text + "', '" +
                totalQuantity_textBox.Text + "', '" + totalDiscGiven_textBox.Text + "', '" +
                totalDiscAmt_textBox.Text + "', '" + pcTerminal_INPUT_label.Text + "', '" +
                dateINPUT_label.Text + "', '" + empIDINPUT_label.Text + "')";

                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterInsert();
                cleartextboxes();
            }

            else if (discCard_radioButton.Checked == true)
            {
                posdb_connect.pos_sql = "INSERT INTO salesTbl (product_name, " +
                "product_quantity_per_transaction, product_price, discount_option, " +
                "discount_amount_per_transaction, discounted_amount_per_transaction, " +
                "summary_total_quantity, summary_total_disc_given, " +
                "summary_total_discounted_amount, terminal_no, time_date, emp_id) " +
                "VALUES ('" + itemName_textBox.Text + "', '" + quantity_textBox.Text +
                "', '" + price_textBox.Text + "', '" + discCard_radioButton.Text + "', '" +
                discount_textBox.Text + "', '" + discounted_textBox.Text + "', '" +
                totalQuantity_textBox.Text + "', '" + totalDiscGiven_textBox.Text + "', '" +
                totalDiscAmt_textBox.Text + "', '" + pcTerminal_INPUT_label.Text + "', '" +
                dateINPUT_label.Text + "', '" + empIDINPUT_label.Text + "')";

                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterInsert();
                cleartextboxes();
            }

            else if (discCard_radioButton.Checked == true)
            {
                posdb_connect.pos_sql = "INSERT INTO salesTbl (product_name, " +
                "product_quantity_per_transaction, product_price, discount_option, " +
                "discount_amount_per_transaction, discounted_amount_per_transaction, " +
                "summary_total_quantity, summary_total_disc_given, " +
                "summary_total_discounted_amount, terminal_no, time_date, emp_id) " +
                "VALUES ('" + itemName_textBox.Text + "', '" + quantity_textBox.Text +
                "', '" + price_textBox.Text + "', '" + discCard_radioButton.Text + "', '" +
                discount_textBox.Text + "', '" + discounted_textBox.Text + "', '" +
                totalQuantity_textBox.Text + "', '" + totalDiscGiven_textBox.Text + "', '" +
                totalDiscAmt_textBox.Text + "', '" + pcTerminal_INPUT_label.Text + "', '" +
                dateINPUT_label.Text + "', '" + empIDINPUT_label.Text + "')";

                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterInsert();
                cleartextboxes();
            }

            else if (empDisc_radioButton.Checked == true)
            {
                posdb_connect.pos_sql = "INSERT INTO salesTbl (product_name, " +
                "product_quantity_per_transaction, product_price, discount_option, " +
                "discount_amount_per_transaction, discounted_amount_per_transaction, " +
                "summary_total_quantity, summary_total_disc_given, " +
                "summary_total_discounted_amount, terminal_no, time_date, emp_id) " +
                "VALUES ('" + itemName_textBox.Text + "', '" + quantity_textBox.Text +
                "', '" + price_textBox.Text + "', '" + empDisc_radioButton.Text + "', '" +
                discount_textBox.Text + "', '" + discounted_textBox.Text + "', '" +
                totalQuantity_textBox.Text + "', '" + totalDiscGiven_textBox.Text + "', '" +
                totalDiscAmt_textBox.Text + "', '" + pcTerminal_INPUT_label.Text + "', '" +
                dateINPUT_label.Text + "', '" + empIDINPUT_label.Text + "')";

                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterInsert();
                cleartextboxes();
            }

            else if (noDisc_radioButton.Checked == true)
            {
                posdb_connect.pos_sql = "INSERT INTO salesTbl (product_name, " +
                "product_quantity_per_transaction, product_price, discount_option, " +
                "discount_amount_per_transaction, discounted_amount_per_transaction, " +
                "summary_total_quantity, summary_total_disc_given, " +
                "summary_total_discounted_amount, terminal_no, time_date, emp_id) " +
                "VALUES ('" + itemName_textBox.Text + "', '" + quantity_textBox.Text +
                "', '" + price_textBox.Text + "', '" + noDisc_radioButton.Text + "', '" +
                discount_textBox.Text + "', '" + discounted_textBox.Text + "', '" +
                totalQuantity_textBox.Text + "', '" + totalDiscGiven_textBox.Text + "', '" +
                totalDiscAmt_textBox.Text + "', '" + pcTerminal_INPUT_label.Text + "', '" +
                dateINPUT_label.Text + "', '" + empIDINPUT_label.Text + "')";

                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterInsert();
                cleartextboxes();
            }

            else
            { 
                MessageBox.Show("No selected discount option");
            }

        }

        private void Lesson14_Example2_Load(object sender, EventArgs e)
        {
            CenterPanel();
            this.Resize += (s, ev) => CenterPanel();
            isloading = true;

            this.BackgroundImageLayout = ImageLayout.Stretch;

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
    }
}
