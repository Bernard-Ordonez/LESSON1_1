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
    public partial class Lesson3_Example5 : Form
    {
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

        private Double sss_loan = 0.00,
                pagibig_loan = 0.00,
                salary_loan = 0.00,
                salary_savings = 0.00,
                faculty_sav_loan = 0.00,
                other_deduction = 0.00,
                total_deduction = 0.00,
                total_contrib = 0.00,
                total_loan = 0.00;

        public Lesson3_Example5()
        {
            InitializeComponent();
        }

        private void Lesson3_Example5_Load(object sender, EventArgs e)
        {
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

            basic_numhrs = Double.Parse(numHours_textBox.Text);
            basic_rate = Convert.ToDouble(rateHour_textBox.Text);
            basic_netincome = basic_numhrs * basic_rate;
            incomePerCut_textBox.Text = basic_netincome.ToString("n");

        }

        private void numHours_textBox2_TextChanged(object sender, EventArgs e)
        {

            hono_numhrs = Convert.ToDouble(numHours_textBox2.Text);
            hono_rate = Convert.ToDouble(rateHour_textBox2.Text);
            hono_netincome = hono_numhrs * hono_rate;
            incomePerCut_textBox2.Text = hono_netincome.ToString("n");

        }

        private void numHours_textBox3_TextChanged(object sender, EventArgs e)
        {

            other_numhrs = Convert.ToDouble(numHours_textBox3.Text);
            other_rate = Convert.ToDouble(rateHour_textBox3.Text);
            other_netincome = other_numhrs * other_rate;
            incomePerCut_textBox3.Text = other_netincome.ToString("n");


            grossincome = basic_netincome + hono_netincome + other_netincome;
            grossIncome_textBox.Text = grossincome.ToString("n");
        }
    }
}
