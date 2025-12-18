using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSAL01E_MORATA
{
    public partial class Prelim_Exam2_Lesson5Activity : Form
    {
        private bool isloading = true;

        public Prelim_Exam2_Lesson5Activity()
        {
            InitializeComponent();

            //apply default image in picture box
            empPicBox.Image = Properties.Resources.default_image;
            empPicBox.SizeMode = PictureBoxSizeMode.StretchImage;

            // Disable text boxes required in the left side of the form
            income_textBox.Enabled = false;
            income_textBox2.Enabled = false;
            income_textBox3.Enabled = false;
            netInc_textBox.Enabled = false;
            grossInc_textBox.Enabled = false;

            // Disable text boxes required in the right side of the form
            SSSContrib_textBox.Enabled = false;
            philHealthCont_textBox.Enabled = false;
            pagibigCont_textBox.Enabled = false;
            incomeTaxCont_textBox.Enabled = false;

            totalDeduc_textBox.Enabled = false;
        }

        //creating necessary global variables
        private double gross_income;
        private double total_regular_deductions;

        private void grossInc_button_Click(object sender, EventArgs e)
        {
            double basic_rate_per_hour, basic_num_of_hours_cutoff;
            double honorarium_rate_per_hour, honorarium_num_of_hours_cutoff;
            double other_rate_per_hour, other_num_of_hours_cutoff;
            double basic_income_cutoff, honorarium_income_cutoff, other_income_cutoff;
            //double gross_income;
            
            double sss_contribution;
            double philHealth_contribution;
            double income_tax_contribution;
            

            basic_rate_per_hour = Convert.ToDouble(rateHour_textBox.Text);
            basic_num_of_hours_cutoff = Convert.ToDouble(numHours_textBox.Text);
            basic_income_cutoff = basic_rate_per_hour * basic_num_of_hours_cutoff;

            honorarium_rate_per_hour = Convert.ToDouble(rateHour_textBox2.Text);
            honorarium_num_of_hours_cutoff = Convert.ToDouble(numHours_textBox2.Text);
            honorarium_income_cutoff = honorarium_rate_per_hour * honorarium_num_of_hours_cutoff;

            other_rate_per_hour = Convert.ToDouble(rateHour_textBox3.Text);
            other_num_of_hours_cutoff = Convert.ToDouble(numHours_textBox3.Text);
            other_income_cutoff = other_rate_per_hour * other_num_of_hours_cutoff;

            gross_income = basic_income_cutoff + honorarium_income_cutoff + other_income_cutoff;

            income_textBox.Text = basic_income_cutoff.ToString("n");
            income_textBox2.Text = honorarium_income_cutoff.ToString("n");
            income_textBox3.Text = other_income_cutoff.ToString("n");
            grossInc_textBox.Text = gross_income.ToString("n");

            //fixed pagibig contribution
            pagibigCont_textBox.Text = "200.00";

            //philHealth contribution based from the gross income
            if (gross_income < 100000)
            {
                philHealth_contribution = 0.025 * gross_income;
                philHealthCont_textBox.Text = philHealth_contribution.ToString("n");
            }
            else
            { 
                philHealth_contribution = 5000;
                philHealthCont_textBox.Text = philHealth_contribution.ToString("n");
            }

            //SSS contribution based from the gross income
            if (gross_income < 5250)
            {
                sss_contribution = 250.00 / 2;
                SSSContrib_textBox.Text = sss_contribution.ToString("n");
            }
            else if (gross_income >= 5250 && gross_income <= 5749.99)
            {
                sss_contribution = 275.00 / 2;
                SSSContrib_textBox.Text = sss_contribution.ToString("n");
            }
            else if (gross_income >= 5750 && gross_income <= 6249.99)
            {
                sss_contribution = 300.00 / 2;
                SSSContrib_textBox.Text = sss_contribution.ToString("n");
            }
            else if (gross_income >= 6250 && gross_income <= 6749.99)
            {
                sss_contribution = 325.00 / 2;
                SSSContrib_textBox.Text = sss_contribution.ToString("n");
            }
            else if (gross_income >= 6750 && gross_income <= 7249.99)
            {
                sss_contribution = 350.00 / 2;
                SSSContrib_textBox.Text = sss_contribution.ToString("n");
            }
            else if (gross_income >= 7250 && gross_income <= 7749.99)
            {
                sss_contribution = 375.00 / 2;
                SSSContrib_textBox.Text = sss_contribution.ToString("n");
            }
            else if (gross_income >= 7750 && gross_income <= 8249.99)
            {
                sss_contribution = 400.00 / 2;
                SSSContrib_textBox.Text = sss_contribution.ToString("n");
            }
            else if (gross_income >= 8250 && gross_income <= 8749.99)
            {
                sss_contribution = 425.00 / 2;
                SSSContrib_textBox.Text = sss_contribution.ToString("n");
            }
            else if (gross_income >= 8750 && gross_income <= 9249.99)
            {
                sss_contribution = 450.00 / 2;
                SSSContrib_textBox.Text = sss_contribution.ToString("n");
            }
            else if (gross_income >= 9250 && gross_income <= 9749.99)
            {
                sss_contribution = 475.00 / 2;
                SSSContrib_textBox.Text = sss_contribution.ToString("n");
            }
            else if (gross_income >= 9750 && gross_income <= 10249.99)
            {
                sss_contribution = 500.00 / 2;
                SSSContrib_textBox.Text = sss_contribution.ToString("n");
            }
            else if (gross_income >= 10250 && gross_income <= 10749.99)
            {
                sss_contribution = 525.00 / 2;
                SSSContrib_textBox.Text = sss_contribution.ToString("n");
            }
            else if (gross_income >= 10750 && gross_income <= 11249.99)
            {
                sss_contribution = 550.00 / 2;
                SSSContrib_textBox.Text = sss_contribution.ToString("n");
            }
            else if (gross_income >= 11250 && gross_income <= 11749.99)
            {
                sss_contribution = 575.00 / 2;
                SSSContrib_textBox.Text = sss_contribution.ToString("n");
            }
            else if (gross_income >= 11750 && gross_income <= 12749.99)
            {
                sss_contribution = 600.00 / 2;
                SSSContrib_textBox.Text = sss_contribution.ToString("n");
            }
            else if (gross_income >= 12750 && gross_income <= 13249.99)
            {
                sss_contribution = 625.00 / 2;
                SSSContrib_textBox.Text = sss_contribution.ToString("n");
            }
            else if (gross_income >= 13250 && gross_income <= 13749.99)
            {
                sss_contribution = 675.00 / 2;
                SSSContrib_textBox.Text = sss_contribution.ToString("n");
            }
            else if (gross_income >= 13750 && gross_income <= 14249.99)
            {
                sss_contribution = 700.00 / 2;
                SSSContrib_textBox.Text = sss_contribution.ToString("n");
            }
            else if (gross_income >= 14250 && gross_income <= 14749.99)
            {
                sss_contribution = 725.00 / 2;
                SSSContrib_textBox.Text = sss_contribution.ToString("n");
            }
            else if (gross_income >= 14750 && gross_income <= 15249.99)
            {
                sss_contribution = 750.00 / 2;
                SSSContrib_textBox.Text = sss_contribution.ToString("n");
            }
            else if (gross_income >= 15250 && gross_income <= 15749.99)
            {
                sss_contribution = 775.00 / 2;
                SSSContrib_textBox.Text = sss_contribution.ToString("n");
            }
            else if (gross_income >= 15750 && gross_income <= 16249.99)
            {
                sss_contribution = 800.00 / 2;
                SSSContrib_textBox.Text = sss_contribution.ToString("n");
            }
            else if (gross_income >= 16250 && gross_income <= 16749.99)
            {
                sss_contribution = 825.00 / 2;
                SSSContrib_textBox.Text = sss_contribution.ToString("n");
            }
            else if (gross_income >= 16750 && gross_income <= 17249.99)
            {
                sss_contribution = 850.00 / 2;
                SSSContrib_textBox.Text = sss_contribution.ToString("n");
            }
            else if (gross_income >= 17250 && gross_income <= 17749.99)
            {
                sss_contribution = 875.00 / 2;
                SSSContrib_textBox.Text = sss_contribution.ToString("n");
            }
            else if (gross_income >= 17750 && gross_income <= 18249.99)
            {
                sss_contribution = 900.00 / 2;
                SSSContrib_textBox.Text = sss_contribution.ToString("n");
            }
            else if (gross_income >= 18250 && gross_income <= 18749.99)
            {
                sss_contribution = 925.00 / 2;
                SSSContrib_textBox.Text = sss_contribution.ToString("n");
            }
            else if (gross_income >= 18750 && gross_income <= 19249.99)
            {
                sss_contribution = 950.00 / 2;
                SSSContrib_textBox.Text = sss_contribution.ToString("n");
            }
            else if (gross_income >= 19250 && gross_income <= 19749.99)
            {
                sss_contribution = 975.00 / 2;
                SSSContrib_textBox.Text = sss_contribution.ToString("n");
            }
            else if (gross_income >= 19750 && gross_income <= 20249.99)
            {
                sss_contribution = 1000.00 / 2;
                SSSContrib_textBox.Text = sss_contribution.ToString("n");
            }
            else if (gross_income >= 20250 && gross_income <= 20749.99)
            {
                sss_contribution = 1025.00 / 2;
                SSSContrib_textBox.Text = sss_contribution.ToString("n");
            }
            else if (gross_income >= 20750 && gross_income <= 21249.99)
            {
                sss_contribution = 1050.00 / 2;
                SSSContrib_textBox.Text = sss_contribution.ToString("n");
            }
            else if (gross_income >= 21250 && gross_income <= 21749.99)
            {
                sss_contribution = 1075.00 / 2;
                SSSContrib_textBox.Text = sss_contribution.ToString("n");
            }
            else if (gross_income >= 21750 && gross_income <= 22249.99)
            {
                sss_contribution = 1100.00 / 2;
                SSSContrib_textBox.Text = sss_contribution.ToString("n");
            }
            else if (gross_income >= 22250 && gross_income <= 22749.99)
            {
                sss_contribution = 1125.00 / 2;
                SSSContrib_textBox.Text = sss_contribution.ToString("n");
            }
            else if (gross_income >= 22750 && gross_income <= 23249.99)
            {
                sss_contribution = 1150.00 / 2;
                SSSContrib_textBox.Text = sss_contribution.ToString("n");
            }
            else if (gross_income >= 23250 && gross_income <= 23749.99)
            {
                sss_contribution = 1175.00 / 2;
                SSSContrib_textBox.Text = sss_contribution.ToString("n");
            }
            else if (gross_income >= 23750 && gross_income <= 24249.99)
            {
                sss_contribution = 1200.00 / 2;
                SSSContrib_textBox.Text = sss_contribution.ToString("n");
            }
            else if (gross_income >= 24250 && gross_income <= 24749.99)
            {
                sss_contribution = 1225.00 / 2;
                SSSContrib_textBox.Text = sss_contribution.ToString("n");
            }
            else if (gross_income >= 24750 && gross_income <= 25249.99)
            {
                sss_contribution = 1250.00 / 2;
                SSSContrib_textBox.Text = sss_contribution.ToString("n");
            }
            else if (gross_income >= 25250 && gross_income <= 25749.99)
            {
                sss_contribution = 1275.00 / 2;
                SSSContrib_textBox.Text = sss_contribution.ToString("n");
            }
            else if (gross_income >= 25750 && gross_income <= 26249.99)
            {
                sss_contribution = 1300.00 / 2;
                SSSContrib_textBox.Text = sss_contribution.ToString("n");
            }
            else if (gross_income >= 26250 && gross_income <= 26749.99)
            {
                sss_contribution = 1325.00 / 2;
                SSSContrib_textBox.Text = sss_contribution.ToString("n");
            }
            else if (gross_income >= 26750 && gross_income <= 27249.99)
            {
                sss_contribution = 1350.00 / 2;
                SSSContrib_textBox.Text = sss_contribution.ToString("n");
            }
            else if (gross_income >= 27250 && gross_income <= 27749.99)
            {
                sss_contribution = 1375.00 / 2;
                SSSContrib_textBox.Text = sss_contribution.ToString("n");
            }
            else if (gross_income >= 27750 && gross_income <= 28249.99)
            {
                sss_contribution = 1400.00 / 2;
                SSSContrib_textBox.Text = sss_contribution.ToString("n");
            }
            else if (gross_income >= 28250 && gross_income <= 28749.99)
            {
                sss_contribution = 1425.00 / 2;
                SSSContrib_textBox.Text = sss_contribution.ToString("n");
            }
            else if (gross_income >= 28750 && gross_income <= 29249.99)
            {
                sss_contribution = 1450.00 / 2;
                SSSContrib_textBox.Text = sss_contribution.ToString("n");
            }
            else if (gross_income >= 29250 && gross_income <= 29749.99)
            {
                sss_contribution = 1475.00 / 2;
                SSSContrib_textBox.Text = sss_contribution.ToString("n");
            }
            else if (gross_income >= 29750 && gross_income <= 30249.99)
            {
                sss_contribution = 1500.00 / 2;
                SSSContrib_textBox.Text = sss_contribution.ToString("n");
            }
            else if (gross_income >= 30250 && gross_income <= 30749.99)
            {
                sss_contribution = 1525.00 / 2;
                SSSContrib_textBox.Text = sss_contribution.ToString("n");
            }
            else if (gross_income >= 30750 && gross_income <= 31249.99)
            {
                sss_contribution = 1550.00 / 2;
                SSSContrib_textBox.Text = sss_contribution.ToString("n");
            }
            else if (gross_income >= 31250 && gross_income <= 31749.99)
            {
                sss_contribution = 1575.00 / 2;
                SSSContrib_textBox.Text = sss_contribution.ToString("n");
            }
            else if (gross_income >= 31750 && gross_income <= 32249.99)
            {
                sss_contribution = 1600.00 / 2;
                SSSContrib_textBox.Text = sss_contribution.ToString("n");
            }
            else if (gross_income >= 32250 && gross_income <= 32749.99)
            {
                sss_contribution = 1625.00 / 2;
                SSSContrib_textBox.Text = sss_contribution.ToString("n");
            }
            else if (gross_income >= 32750 && gross_income <= 33249.99)
            {
                sss_contribution = 1650.00 / 2;
                SSSContrib_textBox.Text = sss_contribution.ToString("n");
            }
            else if (gross_income >= 33250 && gross_income <= 33749.99)
            {
                sss_contribution = 1675.00 / 2;
                SSSContrib_textBox.Text = sss_contribution.ToString("n");
            }
            else if (gross_income >= 33750 && gross_income <= 34249.99)
            {
                sss_contribution = 1700.00 / 2;
                SSSContrib_textBox.Text = sss_contribution.ToString("n");
            }
            else if (gross_income >= 34250 && gross_income <= 34749.99)
            {
                sss_contribution = 1725.00 / 2;
                SSSContrib_textBox.Text = sss_contribution.ToString("n");
            }
            else
            {
                sss_contribution = 1750.00 / 2;
                SSSContrib_textBox.Text = sss_contribution.ToString("n"); 
            }

            //income tax contribution based from the gross income
            if (gross_income <= 250000)
            {
                income_tax_contribution = 0.00;
                incomeTaxCont_textBox.Text = income_tax_contribution.ToString("n");
            }
            else if (gross_income > 250000 && gross_income <= 400000)
            {
                income_tax_contribution = 0.15 * gross_income;
                incomeTaxCont_textBox.Text = income_tax_contribution.ToString("n");
            }
            else if (gross_income > 400000 && gross_income <= 800000)
            {
                income_tax_contribution = 22500 + (0.20 * gross_income);
                incomeTaxCont_textBox.Text = income_tax_contribution.ToString("n");
            }
            else if (gross_income > 800000 && gross_income <= 2000000)
            {
                income_tax_contribution = 102500 + (0.25 * gross_income);
                incomeTaxCont_textBox.Text = income_tax_contribution.ToString("n");
            }
            else if (gross_income > 2000000 && gross_income <= 8000000)
            {
                income_tax_contribution = 402500 + (0.30 * gross_income);
                incomeTaxCont_textBox.Text = income_tax_contribution.ToString("n");
            }
            else
            {
                income_tax_contribution = 2202500 + (0.35 * gross_income);
                incomeTaxCont_textBox.Text = income_tax_contribution.ToString("n");
            }

            //calculate total regular deductions
            total_regular_deductions = Convert.ToDouble(SSSContrib_textBox.Text) + Convert.ToDouble(philHealthCont_textBox.Text) + Convert.ToDouble(pagibigCont_textBox.Text) + income_tax_contribution;
        }

        private void netIncome_button_Click(object sender, EventArgs e)
        {
            //set variables needed for total deduction calculation
            double sss_loan, pagibig_loan, faculty_savings_dep, faculty_savings_loan, salary_loan, other_loans;
            double total_deductions, net_income;

            //get values from text boxes
            sss_loan = Convert.ToDouble(SSSLoan_textBox.Text);
            pagibig_loan = Convert.ToDouble(pagIbigLoan_textBox.Text);
            faculty_savings_dep = Convert.ToDouble(facultySavingsDep_textBox.Text);
            faculty_savings_loan = Convert.ToDouble(facultySavingsLoan_textBox.Text);
            salary_loan = Convert.ToDouble(salaryLoan_textBox.Text);
            other_loans = Convert.ToDouble(otherLoans_textBox.Text);

            //calculate total deductions
            total_deductions = sss_loan + pagibig_loan + faculty_savings_dep + faculty_savings_loan + salary_loan + other_loans + total_regular_deductions;
            totalDeduc_textBox.Text = total_deductions.ToString("n");

            //calculate net income
            net_income = gross_income - total_deductions;
            netInc_textBox.Text = net_income.ToString("n");
        }

        private void new_button_Click(object sender, EventArgs e)
        {
            empNum_textBox.Clear();
            Department_textBox.Clear();
            rateHour_textBox.Clear();
            numHours_textBox.Clear();
            income_textBox.Clear();
            rateHour_textBox2.Clear();
            numHours_textBox2.Clear();
            income_textBox2.Clear();
            rateHour_textBox3.Clear();
            numHours_textBox3.Clear();
            income_textBox3.Clear();

            grossInc_textBox.Clear();
            netInc_textBox.Clear();

            SSSContrib_textBox.Clear();
            philHealthCont_textBox.Clear();
            pagibigCont_textBox.Clear();
            incomeTaxCont_textBox.Clear();
            SSSLoan_textBox.Clear();
            pagIbigLoan_textBox.Clear();
            facultySavingsDep_textBox.Clear();
            facultySavingsLoan_textBox.Clear();
            salaryLoan_textBox.Clear();
            otherLoans_textBox.Clear();
            totalDeduc_textBox.Clear();

            firstname_textBox.Clear();
            middleName_textBox.Clear();
            surname_textBox.Clear();
            civilStatus_textBox.Clear();
            qualDepStat_textBox.Clear();
            paydate_textBox.Clear();
            empStat_textBox.Clear();
            designation_textBox.Clear();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            //code to open another form
            Prelim_Exam2_Lesson5Actvity_SaveForm print = new Prelim_Exam2_Lesson5Actvity_SaveForm();

            //pass values from textboxes to another form
            print.company_textBox.Text = "Lyceum of the Philippines University Cavite";
            print.empCode_textBox.Text = empNum_textBox.Text;
            print.empName_textBox.Text = firstname_textBox.Text + " " + middleName_textBox.Text + " " + surname_textBox.Text;
            print.department_textBox.Text = Department_textBox.Text;
            print.cuOff_textBox.Text = paydate_textBox.Text;
            print.payPeriod_textBox.Text = paydate_textBox.Text;

            print.basicPay_textBox.Text = income_textBox.Text;
            print.overtime_textBox.Text = income_textBox3.Text;
            print.honor_textBox.Text = income_textBox2.Text;

            print.sssContrib_textBox.Text = SSSContrib_textBox.Text;
            print.philHealth_textBox.Text = philHealthCont_textBox.Text;
            print.withholding_textBox.Text = incomeTaxCont_textBox.Text;

            print.earnings_textBox.Text = grossInc_textBox.Text;
            print.grossEarnings_textBox.Text = grossInc_textBox.Text;
            print.deductions_textBox.Text = totalDeduc_textBox.Text;
            print.deductions_textBox2.Text = totalDeduc_textBox.Text;
            print.netPay_textBox.Text = netInc_textBox.Text;

            print.hrs_textBox.Text = numHours_textBox.Text;
            print.hrs_textBox2.Text = numHours_textBox2.Text;
            print.hrs_textBox3.Text = numHours_textBox3.Text;
            
            print.Show();
        }

        private void CenterPanel()
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
        }

        private void Prelim_Exam2_Lesson5Activity_Load(object sender, EventArgs e)
        {
            CenterPanel();
            this.Resize += (s, ev) => CenterPanel();
            isloading = true;
        }
    }
}
