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
    public partial class Payroll_classForm : Form
    {
        private bool isloading = true;

        public Payroll_classForm()
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

        //creating function for philHealth calculation
        private double CalculatePhilHealth(double grossIncome)
        {
            return grossIncome < 100000 ? 0.025 * grossIncome : 5000;
        }

        //creating functon for SSS calculation
        private double CalculateSSS(double grossIncome)
        {
            var sssBrackets = new (double Min, double Max, double Contribution)[]
            {
        (0, 5249.99, 250), (5250, 5749.99, 275), (5750, 6249.99, 300),
        (6250, 6749.99, 325), (6750, 7249.99, 350), (7250, 7749.99, 375),
        (7750, 8249.99, 400), (8250, 8749.99, 425), (8750, 9249.99, 450),
        (9250, 9749.99, 475), (9750, 10249.99, 500), (10250, 10749.99, 525),
        (10750, 11249.99, 550), (11250, 11749.99, 575), (11750, 12749.99, 600),
        (12750, 13249.99, 625), (13250, 13749.99, 675), (13750, 14249.99, 700),
        (14250, 14749.99, 725), (14750, 15249.99, 750), (15250, 15749.99, 775),
        (15750, 16249.99, 800), (16250, 16749.99, 825), (16750, 17249.99, 850),
        (17250, 17749.99, 875), (17750, 18249.99, 900), (18250, 18749.99, 925),
        (18750, 19249.99, 950), (19250, 19749.99, 975), (19750, 20249.99, 1000),
        (20250, 20749.99, 1025), (20750, 21249.99, 1050), (21250, 21749.99, 1075),
        (21750, 22249.99, 1100), (22250, 22749.99, 1125), (22750, 23249.99, 1150),
        (23250, 23749.99, 1175), (23750, 24249.99, 1200), (24250, 24749.99, 1225),
        (24750, 25249.99, 1250), (25250, 25749.99, 1275), (25750, 26249.99, 1300),
        (26250, 26749.99, 1325), (26750, 27249.99, 1350), (27250, 27749.99, 1375),
        (27750, 28249.99, 1400), (28250, 28749.99, 1425), (28750, 29249.99, 1450),
        (29250, 29749.99, 1475), (29750, 30249.99, 1500), (30250, 30749.99, 1525),
        (30750, 31249.99, 1550), (31250, 31749.99, 1575), (31750, 32249.99, 1600),
        (32250, 32749.99, 1625), (32750, 33249.99, 1650), (33250, 33749.99, 1675),
        (33750, 34249.99, 1700), (34250, 34749.99, 1725)
            };

            foreach (var bracket in sssBrackets)
                if (grossIncome >= bracket.Min && grossIncome <= bracket.Max)
                    return bracket.Contribution / 2;

            return 1750 / 2; // Default max contribution
        }

        //creating function for income tax calculation
        private double CalculateIncomeTax(double grossIncome)
        {
            // Convert 15-day income to annual income for tax bracket comparison
            double annualIncome = grossIncome * 24;

            double annualTax;

            if (annualIncome <= 250000)
                annualTax = 0;
            else if (annualIncome <= 400000)
                annualTax = 0.15 * (annualIncome - 250000);
            else if (annualIncome <= 800000)
                annualTax = 22500 + (0.20 * (annualIncome - 400000));
            else if (annualIncome <= 2000000)
                annualTax = 102500 + (0.25 * (annualIncome - 800000));
            else if (annualIncome <= 8000000)
                annualTax = 402500 + (0.30 * (annualIncome - 2000000));
            else
                annualTax = 2202500 + (0.35 * (annualIncome - 8000000));

            // Convert annual tax back to 15-day equivalent
            return annualTax / 24;
        }

        //function to get double value from text box
        private double GetDoubleFromTextBox(TextBox box)
        {
            return double.TryParse(box.Text, out double value) ? value : 0;
        }


        //creating necessary global variables
        private double gross_income;
        private double total_regular_deductions;

        private void grossInc_button_Click(object sender, EventArgs e)
        {
            Income income = new Income
            {
                BasicRate = GetDoubleFromTextBox(rateHour_textBox),
                BasicHours = GetDoubleFromTextBox(numHours_textBox),
                HonorariumRate = GetDoubleFromTextBox(rateHour_textBox2),
                HonorariumHours = GetDoubleFromTextBox(numHours_textBox2),
                OtherRate = GetDoubleFromTextBox(rateHour_textBox3),
                OtherHours = GetDoubleFromTextBox(numHours_textBox3)
            };

            gross_income = income.GrossIncome;

            income_textBox.Text = income.BasicIncome.ToString("n");
            income_textBox2.Text = income.HonorariumIncome.ToString("n");
            income_textBox3.Text = income.OtherIncome.ToString("n");
            grossInc_textBox.Text = income.GrossIncome.ToString("n");

            double philHealth = CalculatePhilHealth(income.GrossIncome);
            double sss = CalculateSSS(income.GrossIncome);
            double tax = CalculateIncomeTax(income.GrossIncome);

            philHealthCont_textBox.Text = philHealth.ToString("n");
            SSSContrib_textBox.Text = sss.ToString("n");
            incomeTaxCont_textBox.Text = tax.ToString("n");
            pagibigCont_textBox.Text = "200.00";

            total_regular_deductions = sss + philHealth + 200 + tax;    
        }

        private void netIncome_button_Click(object sender, EventArgs e)
        {
            Deductions deductions = new Deductions
            {
                SSS = GetDoubleFromTextBox(SSSContrib_textBox),
                PhilHealth = GetDoubleFromTextBox(philHealthCont_textBox),
                IncomeTax = GetDoubleFromTextBox(incomeTaxCont_textBox),
                SSSLoan = GetDoubleFromTextBox(SSSLoan_textBox),
                PagibigLoan = GetDoubleFromTextBox(pagIbigLoan_textBox),
                FacultySavingsDep = GetDoubleFromTextBox(facultySavingsDep_textBox),
                FacultySavingsLoan = GetDoubleFromTextBox(facultySavingsLoan_textBox),
                SalaryLoan = GetDoubleFromTextBox(salaryLoan_textBox),
                OtherLoans = GetDoubleFromTextBox(otherLoans_textBox)
            };

            Income income = new Income
            {
                BasicRate = GetDoubleFromTextBox(rateHour_textBox),
                BasicHours = GetDoubleFromTextBox(numHours_textBox),
                HonorariumRate = GetDoubleFromTextBox(rateHour_textBox2),
                HonorariumHours = GetDoubleFromTextBox(numHours_textBox2),
                OtherRate = GetDoubleFromTextBox(rateHour_textBox3),
                OtherHours = GetDoubleFromTextBox(numHours_textBox3)
            };

            PayrollCalculator calculator = new PayrollCalculator
            {
                Income = income,
                Deductions = deductions
            };

            totalDeduc_textBox.Text = deductions.Total.ToString("n");
            netInc_textBox.Text = calculator.NetIncome.ToString("n");
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

            PayrollRecord record = new PayrollRecord
            {
                CompanyName = "Lyceum of the Philippines University Cavite",
                EmployeeCode = empNum_textBox.Text,
                EmployeeName = $"{firstname_textBox.Text} {middleName_textBox.Text} {surname_textBox.Text}",
                Department = Department_textBox.Text,
                CutoffDate = paydate_textBox.Text,
                PayPeriod = paydate_textBox.Text,
                BasicPay = income_textBox.Text,
                Honorarium = income_textBox2.Text,
                Overtime = income_textBox3.Text,
                SSSContribution = SSSContrib_textBox.Text,
                PhilHealth = philHealthCont_textBox.Text,
                WithholdingTax = incomeTaxCont_textBox.Text,
                Earnings = grossInc_textBox.Text,
                GrossEarnings = grossInc_textBox.Text,
                Deductions = totalDeduc_textBox.Text,
                Deductions2 = totalDeduc_textBox.Text,
                NetPay = netInc_textBox.Text,
                HoursBasic = numHours_textBox.Text,
                HoursHonorarium = numHours_textBox2.Text,
                HoursOther = numHours_textBox3.Text
            };

            Payroll_classForm_SaveForm print = new Payroll_classForm_SaveForm();

            // Assign values to the print form
            print.company_textBox.Text = record.CompanyName;
            print.empCode_textBox.Text = record.EmployeeCode;
            print.empName_textBox.Text = record.EmployeeName;
            print.department_textBox.Text = record.Department;
            print.cuOff_textBox.Text = record.CutoffDate;
            print.payPeriod_textBox.Text = record.PayPeriod;
            print.basicPay_textBox.Text = record.BasicPay;
            print.honor_textBox.Text = record.Honorarium;
            print.overtime_textBox.Text = record.Overtime;
            print.sssContrib_textBox.Text = record.SSSContribution;
            print.philHealth_textBox.Text = record.PhilHealth;
            print.withholding_textBox.Text = record.WithholdingTax;
            print.earnings_textBox.Text = record.Earnings;
            print.grossEarnings_textBox.Text = record.GrossEarnings;
            print.deductions_textBox.Text = record.Deductions;
            print.deductions_textBox2.Text = record.Deductions2;
            print.netPay_textBox.Text = record.NetPay;
            print.hrs_textBox.Text = record.HoursBasic;
            print.hrs_textBox2.Text = record.HoursHonorarium;
            print.hrs_textBox3.Text = record.HoursOther;

            print.Show();
        }

        private void Payroll_functionForm_Load(object sender, EventArgs e)
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
