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
    public partial class Lesson5_Example6 : Form
    {
        private bool isloading = true;

        //declaration of global variables
        private string picpath;
        private Double basic_netincome = 0.00,
                basic_numhrs = 0.00,
                basic_rate = 0.00,  
                hono_netincome = 0.00,
                hono_numhrs = 0.00,
                hono_rate = 0.00,
                other_netincome = 0.00,
                other_numhrs = 0.00,
                other_rate = 0.00;

        private Double netincome = 0.00,
                grossincome = 0.00,
                sss_contrib = 0.00,
                pagibig_contrib = 0.00,
                philhealth_contrib = 0.00,
                tax_contrib = 0.00;

        private void others_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (others_comboBox.Text == "Other 1")
            {
                others_textBox.Text = "500.00";
            }
            else if (others_comboBox.Text == "Other 2")
            {
                others_textBox.Text = "550.00";
            }
            else if (others_comboBox.Text == "Other 3")
            {
                others_textBox.Text = "1550.00";
            }
            else if (others_comboBox.Text == "Other 4")
            {
                others_textBox.Text = "1250.00";
            }
            else
            {
                MessageBox.Show("No other loan option selected!");
            }
        }

        private Double sss_loan = 0.00,
                pagibig_loan = 0.00,
                salary_loan = 0.00,
                salary_savings = 0.00,
                faculty_sav_loan = 0.00,
                other_deduction = 0.00,
                total_deduction = 0.00,
                total_contrib = 0.00,
                total_loan = 0.00;

        public Lesson5_Example6()
        {
            InitializeComponent();
        }

        private void CenterPanel()
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
        }

        private void Lesson3_Example5_Load(object sender, EventArgs e)
        {
            CenterPanel();
            this.Resize += (s, ev) => CenterPanel();
            isloading = true;

            //codes for disabling
            incomePerCut_textBox.Enabled = false;
            incomePerCut_textBox2.Enabled = false;
            incomePerCut_textBox3.Enabled = false;
            grossIncome_textBox.Enabled = false;
            netIncome_textBox.Enabled = false;
            totalDeduc_textBox.Enabled = false;

            sssCont_textBox.Text = "0.00";
            pagibigCont_textBox.Text = "0.00";
            phCont_textBox.Text = "0.00";
            tax_textBox.Text = "0.00";

            sssLoan_textBox.Text = "0.00";
            pagibigLoan_textBox.Text = "0.00";
            facSavingsDep_textBox.Text = "0.00";
            facSavingsLoan_textBox.Text = "0.00";
            salaryLoan_textBox.Text = "0.00";
            others_textBox.Text = "0.00";
            
            others_comboBox.Text = "Select other deduction";
            others_comboBox.Items.Add("Other 1");
            others_comboBox.Items.Add("Other 2");
            others_comboBox.Items.Add("Other 3");
            others_comboBox.Items.Add("Other 4");

            picPath_textBox.Hide();

        }

        private void calculate_button_Click(object sender, EventArgs e)
        {
            // codes for converting input data from textboxes as string to numeric

            // codes for putting data from textboxes to variables
            sss_contrib = Convert.ToDouble(sssCont_textBox.Text);
            pagibig_contrib = Convert.ToDouble(pagibigCont_textBox.Text);
            philhealth_contrib = Convert.ToDouble(phCont_textBox.Text);
            tax_contrib = Convert.ToDouble(tax_textBox.Text);
            sss_loan = Convert.ToDouble(sssLoan_textBox.Text);
            pagibig_loan = Convert.ToDouble(pagibigLoan_textBox.Text);
            faculty_sav_loan = Convert.ToDouble(facSavingsLoan_textBox.Text);
            salary_savings = Convert.ToDouble(facSavingsDep_textBox.Text);
            other_deduction = Convert.ToDouble(others_textBox.Text);

            // formula to compute the desired data to be computed
            total_contrib = sss_contrib + pagibig_contrib + philhealth_contrib + tax_contrib;
            total_loan = sss_loan + pagibig_loan + salary_loan + faculty_sav_loan + salary_savings + other_deduction;
            total_deduction = total_contrib + total_loan;

            // codes for converting numeric data to string and displayed it inside the textboxes
            totalDeduc_textBox.Text = total_deduction.ToString("n");
            netincome = grossincome - total_deduction;
            netIncome_textBox.Text = netincome.ToString("n");
        }

        private void previewPayslip_button_Click(object sender, EventArgs e)
        {
            // PREVIEW PAYSLIP button:
            // payslip_viewListBox.Items.Add("");
            payslip_viewListBox.Items.Add("Employee Number: " + " "
                + empNum_textBox.Text);
            payslip_viewListBox.Items.Add("Firstname: " + " "
                + firstname_textBox.Text);

            payslip_viewListBox.Items.Add("Middlename: " + " " + middleName_textBox.Text);
            payslip_viewListBox.Items.Add("Surname: " + " " + surname_textBox.Text);
            payslip_viewListBox.Items.Add("Desigation: " + " " + desig_textBox.Text);
            payslip_viewListBox.Items.Add("Employee Status: " + " " + empStat_textBox.Text);
            payslip_viewListBox.Items.Add("Department: " + " " + dept_textBox.Text);
            payslip_viewListBox.Items.Add("Pay Date: " + " " + paydate_dateTimePicker.Text);
            payslip_viewListBox.Items.Add("------------------------------------------------------------");

            payslip_viewListBox.Items.Add("BP Num. of Hrs.: " + " " + numHours_textBox.Text);
            payslip_viewListBox.Items.Add("BP Rate / Hr.: " + " " + rateHour_textBox.Text);
            payslip_viewListBox.Items.Add("Basic Pay Income: " + " " + incomePerCut_textBox.Text);
            payslip_viewListBox.Items.Add("");

            payslip_viewListBox.Items.Add("HP Num. of Hrs.: " + " " + numHours_textBox2.Text);
            payslip_viewListBox.Items.Add("HP Rate / Hr.: " + " " + rateHour_textBox2.Text);
            payslip_viewListBox.Items.Add("Honorarium Pay Income: " + " " + incomePerCut_textBox2.Text);
            payslip_viewListBox.Items.Add("");

            payslip_viewListBox.Items.Add("OTI Num. of Hrs.: " + " " + numHours_textBox3.Text);
            payslip_viewListBox.Items.Add("OTI Rate / Hr.: " + " " + rateHour_textBox3.Text);
            payslip_viewListBox.Items.Add("Other Income: " + " " + incomePerCut_textBox3.Text);
            payslip_viewListBox.Items.Add("------------------------------------------------------------");

            payslip_viewListBox.Items.Add("SSS Contribution: " + " " + sssCont_textBox.Text);
            payslip_viewListBox.Items.Add("PhilHealth Contribution: " + " " + phCont_textBox.Text);
            payslip_viewListBox.Items.Add("Pag-Ibig Contribution: " + " " + pagibigCont_textBox.Text);
            payslip_viewListBox.Items.Add("Tax Contribution: " + " " + tax_textBox.Text);

            payslip_viewListBox.Items.Add("SSS Loan: " + " " + sssLoan_textBox.Text);
            payslip_viewListBox.Items.Add("Pagibig Loan: " + " " + pagibigLoan_textBox.Text);
            payslip_viewListBox.Items.Add("Faculty Savings Deposit: " + " " + facSavingsDep_textBox.Text);
            payslip_viewListBox.Items.Add("Faculty Savings Loan: " + " " + facSavingsLoan_textBox.Text);
            payslip_viewListBox.Items.Add("Salary Loan: " + " " + salaryLoan_textBox.Text);
            payslip_viewListBox.Items.Add("Other Loan: " + " " + others_textBox.Text);
            payslip_viewListBox.Items.Add("------------------------------------------------------------");


            payslip_viewListBox.Items.Add("Total Deductions: " + " " + totalDeduc_textBox.Text);
            payslip_viewListBox.Items.Add("Gross Income: " + " " + grossIncome_textBox.Text);
            payslip_viewListBox.Items.Add("Net Income: " + " " + netIncome_textBox.Text);
        }

        private void print_button_Click(object sender, EventArgs e)
        {
            Lesson3_Example5_PrintForm print1 = new Lesson3_Example5_PrintForm();
            print1.printDisplayListBox.Items.AddRange(this.payslip_viewListBox.Items);
            print1.Show();
        }

        private void new_button_Click(object sender, EventArgs e)
        {
            // Codes for clearing the textboxes
            empNum_textBox.Clear();
            firstname_textBox.Clear();
            middleName_textBox.Clear();
            surname_textBox.Clear();
            civilStat_textBox.Clear();
            desig_textBox.Clear();
            numDep_textBox.Clear();
            empStat_textBox.Clear();
            dept_textBox.Clear();

            incomePerCut_textBox.Clear();
            numHours_textBox.Clear();
            rateHour_textBox.Clear();

            incomePerCut_textBox2.Clear();
            numHours_textBox2.Clear();
            rateHour_textBox2.Clear();

            incomePerCut_textBox3.Clear();
            numHours_textBox3.Clear();
            rateHour_textBox3.Clear();

            netIncome_textBox.Clear();
            grossIncome_textBox.Clear();

            sssCont_textBox.Clear();
            pagibigCont_textBox.Clear();
            phCont_textBox.Clear();
            tax_textBox.Clear();

            sssLoan_textBox.Clear();
            pagibigLoan_textBox.Clear();
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            // Codes for clearing the textboxes
            empNum_textBox.Clear();
            firstname_textBox.Clear();
            middleName_textBox.Clear();
            surname_textBox.Clear();
            civilStat_textBox.Clear();
            desig_textBox.Clear();
            numDep_textBox.Clear();
            empStat_textBox.Clear();
            dept_textBox.Clear();

            incomePerCut_textBox.Clear();
            numHours_textBox.Clear();
            rateHour_textBox.Clear();

            incomePerCut_textBox2.Clear();
            numHours_textBox2.Clear();
            rateHour_textBox2.Clear();

            incomePerCut_textBox3.Clear();
            numHours_textBox3.Clear();
            rateHour_textBox3.Clear();

            netIncome_textBox.Clear();
            grossIncome_textBox.Clear();

            sssCont_textBox.Clear();
            pagibigCont_textBox.Clear();
            phCont_textBox.Clear();
            tax_textBox.Clear();

            sssLoan_textBox.Clear();
            pagibigLoan_textBox.Clear();
        }

        private void browse_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files | * .gif; * .jpg; * .png; * .bmp";
            openFileDialog.Title = "Select Employee Picture";
            openFileDialog.ShowDialog();
            picpath = openFileDialog.FileName;
            picPath_textBox.Text = picpath;
            pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numHours_textBox_TextChanged(object sender, EventArgs e)
        {

            try
            {
                basic_numhrs = Double.Parse(numHours_textBox.Text);
                basic_rate = Convert.ToDouble(rateHour_textBox.Text);
                basic_netincome = basic_numhrs * basic_rate;
                incomePerCut_textBox.Text = basic_netincome.ToString("n");
            }
            catch (Exception)
            {
                //MessageBox.Show("Invalid data entry");
                numHours_textBox.Clear();
                //numHours_textBox.Focus();
            }

        }

        private void numHours_textBox2_TextChanged(object sender, EventArgs e)
        {

            try
            {
                hono_numhrs = Convert.ToDouble(numHours_textBox2.Text);
                hono_rate = Convert.ToDouble(rateHour_textBox2.Text);
                hono_netincome = hono_numhrs * hono_rate;
                incomePerCut_textBox2.Text = hono_netincome.ToString("n");
            }
            catch (Exception)
            {
                //MessageBox.Show("Invalid data entry");
                numHours_textBox2.Clear();
                //numHours_textBox2.Focus();
            }

        }

        private void numHours_textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                other_numhrs = Convert.ToDouble(numHours_textBox3.Text);
                other_rate = Convert.ToDouble(rateHour_textBox3.Text);
                other_netincome = other_numhrs * other_rate;
                incomePerCut_textBox3.Text = other_netincome.ToString("n");
                grossincome = basic_netincome + hono_netincome + other_netincome;
                grossIncome_textBox.Text = grossincome.ToString("n");
                pagibigCont_textBox.Text = "100.00";

                if (grossincome <= 10000)
                {
                    phCont_textBox.Text = "137.50";
                }
                else if (grossincome > 10000 && grossincome <= 11000)
                {
                    phCont_textBox.Text = "151.25";
                }
                else if (grossincome > 11000 && grossincome <= 12000)
                {
                    phCont_textBox.Text = "165.00";
                }
                else if (grossincome > 12000 && grossincome <= 13000)
                {
                    phCont_textBox.Text = "178.75";
                }
                else if (grossincome > 13000 && grossincome <= 14000)
                {
                    phCont_textBox.Text = "192.50";
                }
                else if (grossincome > 14000 && grossincome <= 15000)
                {
                    phCont_textBox.Text = "206.25";
                }
                else if (grossincome > 15000 && grossincome <= 16000)
                {
                    phCont_textBox.Text = "220.00";
                }
                else if (grossincome > 16000 && grossincome <= 17000)
                {
                    phCont_textBox.Text = "233.75";
                }
                else if (grossincome > 17000 && grossincome <= 18000)
                {
                    phCont_textBox.Text = "247.50";
                }
                else if (grossincome > 18000 && grossincome <= 19000)
                {
                    phCont_textBox.Text = "261.25";
                }
                else if (grossincome > 19000 && grossincome <= 20000)
                {
                    phCont_textBox.Text = "275.00";
                }
                else if (grossincome > 20000 && grossincome <= 21000)
                {
                    phCont_textBox.Text = "288.75";
                }
                else if (grossincome > 21000 && grossincome <= 22000)
                {
                    phCont_textBox.Text = "302.50";
                }
                else if (grossincome > 22000 && grossincome <= 23000)
                {
                    phCont_textBox.Text = "316.25";
                }
                else if (grossincome > 23000 && grossincome <= 24000)
                {
                    phCont_textBox.Text = "330.00";
                }
                else if (grossincome > 24000 && grossincome <= 25000)
                {
                    phCont_textBox.Text = "343.75";
                }
                else if (grossincome > 25000 && grossincome <= 26000)
                {
                    phCont_textBox.Text = "357.50";
                }
                else if (grossincome > 26000 && grossincome <= 27000)
                {
                    phCont_textBox.Text = "371.25";
                }
                else if (grossincome > 27000 && grossincome <= 28000)
                {
                    phCont_textBox.Text = "385.00";
                }
                else if (grossincome > 28000 && grossincome <= 29000)
                {
                    phCont_textBox.Text = "398.75";
                }
                else if (grossincome > 29000 && grossincome <= 30000)
                {
                    phCont_textBox.Text = "412.50";
                }
                else if (grossincome > 30000 && grossincome <= 31000)
                {
                    phCont_textBox.Text = "426.25";
                }
                else if (grossincome > 31000 && grossincome <= 32000)
                {
                    phCont_textBox.Text = "440.00";
                }
                else if (grossincome > 32000 && grossincome <= 33000)
                {
                    phCont_textBox.Text = "453.75";
                }
                else if (grossincome > 33000 && grossincome <= 34000)
                {
                    phCont_textBox.Text = "467.50";
                }
                else if (grossincome > 34000 && grossincome <= 35000)
                {
                    phCont_textBox.Text = "481.25";
                }
                else if (grossincome > 35000 && grossincome <= 36000)
                {
                    phCont_textBox.Text = "495.00";
                }
                else if (grossincome > 36000 && grossincome <= 37000)
                {
                    phCont_textBox.Text = "508.75";
                }
                else if (grossincome > 37000 && grossincome <= 38000)
                {
                    phCont_textBox.Text = "522.50";
                }
                else if (grossincome > 38000 && grossincome <= 39000)
                {
                    phCont_textBox.Text = "536.25";
                }
                else if (grossincome > 39000 && grossincome <= 39999.99)
                {
                    phCont_textBox.Text = "543.13";
                }
                else
                    phCont_textBox.Text = "550.00";

                // SSS contribution based on the current table from SSS
                if (grossincome < 1000)
                {
                    sssCont_textBox.Text = "0.00";
                }
                else if (grossincome >= 1000 && grossincome <= 1249.99)
                {
                    sssCont_textBox.Text = "36.30";
                }
                else if (grossincome > 1250 && grossincome <= 1749.99)
                {
                    sssCont_textBox.Text = "54.50";
                }
                else if (grossincome > 1750 && grossincome <= 2249.99)
                {
                    sssCont_textBox.Text = "72.70";
                }
                else if (grossincome > 2250 && grossincome <= 2749.99)
                {
                    sssCont_textBox.Text = "90.80";
                }
                else if (grossincome > 2750 && grossincome <= 3249.99)
                {
                    sssCont_textBox.Text = "109.00";
                }
                else if (grossincome > 3250 && grossincome <= 3749.99)
                {
                    sssCont_textBox.Text = "127.20";
                }
                else if (grossincome > 3750 && grossincome <= 4249.99)
                {
                    sssCont_textBox.Text = "145.30";
                }
                else if (grossincome > 4250 && grossincome <= 4749.99)
                {
                    sssCont_textBox.Text = "163.50";
                }
                else if (grossincome > 4750 && grossincome <= 5249.99)
                {
                    sssCont_textBox.Text = "181.70";
                }
                else if (grossincome > 5250 && grossincome <= 5749.99)
                {
                    sssCont_textBox.Text = "199.80";
                }
                else if (grossincome > 5750 && grossincome <= 6249.99)
                {
                    sssCont_textBox.Text = "218.00";
                }
                else if (grossincome > 6250 && grossincome <= 6749.99)
                {
                    sssCont_textBox.Text = "236.29";
                }
                else if (grossincome > 6750 && grossincome <= 7249.99)
                {
                    sssCont_textBox.Text = "254.30";
                }
                else if (grossincome > 7250 && grossincome <= 7749.99)
                {
                    sssCont_textBox.Text = "272.50";
                }
                else if (grossincome > 7750 && grossincome <= 8249.99)
                {
                    sssCont_textBox.Text = "290.70";
                }
                else if (grossincome > 8250 && grossincome <= 8749.99)
                {
                    sssCont_textBox.Text = "308.80";
                }
                else if (grossincome > 8750 && grossincome <= 9249.99)
                {
                    sssCont_textBox.Text = "327.00";
                }
                else if (grossincome > 9250 && grossincome <= 9749.99)
                {
                    sssCont_textBox.Text = "345.20";
                }
                else if (grossincome > 9750 && grossincome <= 10249.99)
                {
                    sssCont_textBox.Text = "363.30";
                }
                else if (grossincome > 10250 && grossincome <= 10749.99)
                {
                    sssCont_textBox.Text = "381.50";
                }
                else if (grossincome > 10750 && grossincome <= 11249.99)
                {
                    sssCont_textBox.Text = "399.70";
                }
                else if (grossincome > 11250 && grossincome <= 11749.99)
                {
                    sssCont_textBox.Text = "417.88";
                }
                else if (grossincome > 11750 && grossincome <= 12249.99)
                {
                    sssCont_textBox.Text = "436.00";
                }
                else if (grossincome > 12250 && grossincome <= 12749.99)
                {
                    sssCont_textBox.Text = "454.20";
                }
                else if (grossincome > 12750 && grossincome <= 13249.99)
                {
                    sssCont_textBox.Text = "472.30";
                }
                else if (grossincome > 13250 && grossincome <= 13749.99)
                {
                    sssCont_textBox.Text = "490.50";
                }
                else if (grossincome > 13750 && grossincome <= 14249.99)
                {
                    sssCont_textBox.Text = "508.70";
                }
                else if (grossincome > 14250 && grossincome <= 14749.99)
                {
                    sssCont_textBox.Text = "526.80";
                }
                else if (grossincome > 14750 && grossincome <= 15249.99)
                {
                    sssCont_textBox.Text = "545.00";
                }
                else if (grossincome > 15250 && grossincome <= 15749.99)
                {
                    sssCont_textBox.Text = "563.20";
                }
                else
                {
                    sssCont_textBox.Text = "581.30";
                }

                //tax contribution per month on new table of TAX 2016
                if (grossincome < (250000 / 24))
                {
                    tax_textBox.Text = "0.00";
                }
                else if (grossincome >= 10416.67 && grossincome <= 16666.67)
                {
                    tax_contrib = ((((grossincome * 24) - 250000) * 0.20) / 24);
                    tax_textBox.Text = tax_contrib.ToString("n");
                }
                else if (grossincome > 16666.67 && grossincome <= 33333.33)
                {
                    tax_contrib = ((((grossincome * 24) - 400000) * 0.25) + 30000) / 24;
                    tax_textBox.Text = tax_contrib.ToString("n");
                }
                else if (grossincome > 33333.33 && grossincome <= 83333.33)
                {
                    tax_contrib = ((((grossincome * 24) - 800000) * 0.30) + 130000) / 24;
                    tax_textBox.Text = tax_contrib.ToString("n");
                }
                else if (grossincome > 83333.33 && grossincome <= 333333.33)
                {
                    tax_contrib = ((((grossincome * 24) - 2000000) * 0.32) + 490000) / 24;
                    tax_textBox.Text = tax_contrib.ToString("n");
                }
                else
                {
                    tax_contrib = ((((grossincome * 24) - 8000000) * 0.35) + 2410000) / 24;
                    tax_textBox.Text = tax_contrib.ToString("n");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid data entry");
                numHours_textBox3.Clear();
                numHours_textBox3.Focus();
            }
        }
    }
}
