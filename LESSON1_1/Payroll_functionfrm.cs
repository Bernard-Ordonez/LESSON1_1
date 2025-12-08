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
    public partial class Payroll_functionfrm : Form
    {
        // ---- Contribution Tables ----

        // SSS contribution ranges and fixed amounts
        private readonly double[] sssRanges = { 0, 5250, 5750, 6250, 6750, 7250, 7750, 8250, 8750, 9250,
                                        9750, 10250, 10750, 11250, 11750, 12250, 12750, 13250, 13750, 14250,
                                        14750, 15250, 15750, 16250, 16750, 17250, 17750, 18250, 18750, 19250,
                                        19750, 20250, 20750, 21250, 21750, 22250, 22750, 23250, 23750, 24250,
                                        24750, 25250, 25750, 26250, 26750, 27250, 27750, 28250, 28750, 29250,
                                        29750, 30250, 30750, 31250, 31750, 32250, 32750, 33250, 33750, 34250, 34750 };
        private readonly double[] sssAmounts = { 250, 275, 300, 325, 350, 375, 400, 425, 450, 475,
                                          500, 525, 550, 575, 600, 625, 650, 675, 700, 725,
                                          750, 775, 800, 825, 850, 875, 900, 925, 950, 975,
                                          1000, 1025, 1050, 1075, 1100, 1125, 1150, 1175, 1200, 1225,
                                          1250, 1275, 1300, 1325, 1350, 1375, 1400, 1425, 1450, 1475,
                                          1500, 1525, 1550, 1575, 1600, 1625, 1650, 1675, 1700, 1725, 1750 };

        public Payroll_functionfrm()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox9.Enabled = false;
            textBox13.Enabled = false;
            textBox14.Enabled = false;
            textBox15.Enabled = true;
            textBox16.Enabled = true;
            textBox12.Enabled = true;
            textBox19.Enabled = false;
            textBox21.Enabled = false;
            textBox22.Enabled = false;
            textBox20.Enabled = false;
            textBox23.Enabled = false;
            textBox24.Enabled = false;
            textBox25.Enabled = false;
            textBox32.Enabled = false;
        }

        private double GetWithholdingTax(double income)
        {
            if (income <= 20832)
                return 0;
            else if (income <= 33333)
                return (income - 20833) * 0.20;
            else if (income <= 66667)
                return 2500 + (income - 33333) * 0.25;
            else if (income <= 166667)
                return 10833 + (income - 66667) * 0.30;
            else if (income <= 666667)
                return 40833 + (income - 166667) * 0.32;
            else
                return 200833 + (income - 666667) * 0.35;
        }
        private double GetSSSContribution(double income)
        {
            double contribution = sssAmounts.Last();
            for (int i = 0; i < sssRanges.Length; i++)
            {
                if (income <= sssRanges[i])
                {
                    contribution = sssAmounts[i];
                    break;
                }
            }
            return contribution;
        }
        private double GetPhilHealthContribution(double income)
        {
            double philhealth = income * 0.025;
            if (philhealth < 500) philhealth = 500;
            if (philhealth > 5000) philhealth = 5000;
            return philhealth;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ---------- Inputs ----------
            double rateBasic = double.TryParse(textBox3.Text, out rateBasic) ? rateBasic : 0;
            double hoursBasic = double.TryParse(textBox4.Text, out hoursBasic) ? hoursBasic : 0;
            double rateHonor = double.TryParse(textBox7.Text, out rateHonor) ? rateHonor : 0;
            double hoursHonor = double.TryParse(textBox8.Text, out hoursHonor) ? hoursHonor : 0;
            double rateOther = double.TryParse(textBox10.Text, out rateOther) ? rateOther : 0;
            double hoursOther = double.TryParse(textBox11.Text, out hoursOther) ? hoursOther : 0;

            // ---------- Monthly Incomes ----------
            double basicIncome = rateBasic * hoursBasic;
            double honorariumIncome = rateHonor * hoursHonor;
            double otherIncome = rateOther * hoursOther;
            double grossIncome = basicIncome + honorariumIncome + otherIncome;

            // ---------- Cutoff (semi-monthly) ----------
            double basicCutoff = basicIncome;
            double honorariumCutoff = honorariumIncome;
            double otherCutoff = otherIncome;
            double grossCutoff = grossIncome;

            // ---------- SSS Contribution ----------
            double sss_contrib = GetSSSContribution(grossIncome);

            // ---------- PhilHealth ----------
            double philhealth_contrib = GetPhilHealthContribution(grossIncome);

            // ---------- Pagibig ----------
            double pagibig_contrib = 200;
            double tax_contrib = GetWithholdingTax(grossIncome);


            // ---------- Display ----------
            textBox5.Text = basicCutoff.ToString("N2");
            textBox6.Text = honorariumCutoff.ToString("N2");
            textBox9.Text = otherCutoff.ToString("N2");
            textBox14.Text = grossCutoff.ToString("N2");

            textBox24.Text = sss_contrib.ToString("N2");
            textBox23.Text = philhealth_contrib.ToString("N2");
            textBox20.Text = pagibig_contrib.ToString("N2");
            textBox25.Text = tax_contrib.ToString("N2");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sss = double.TryParse(textBox24.Text, out sss) ? sss : 0;
            double philhealth = double.TryParse(textBox23.Text, out philhealth) ? philhealth : 0;
            double pagibig = double.TryParse(textBox20.Text, out pagibig) ? pagibig : 0;
            double tax = double.TryParse(textBox25.Text, out tax) ? tax : 0;

            double sssLoan = double.TryParse(textBox29.Text, out sssLoan) ? sssLoan : 0;
            double pagibigLoan = double.TryParse(textBox28.Text, out pagibigLoan) ? pagibigLoan : 0;
            double facultySavingDeposit = double.TryParse(textBox27.Text, out facultySavingDeposit) ? facultySavingDeposit : 0;
            double facultySavingsLoan = double.TryParse(textBox26.Text, out facultySavingsLoan) ? facultySavingsLoan : 0;
            double salaryLoan = double.TryParse(textBox31.Text, out salaryLoan) ? salaryLoan : 0;
            double otherLoans = double.TryParse(textBox30.Text, out otherLoans) ? otherLoans : 0;

            double totalDeductions = sss + philhealth + pagibig + tax +
                                     sssLoan + pagibigLoan + facultySavingDeposit +
                                     facultySavingsLoan + salaryLoan + otherLoans;

            double grossCutoff = double.TryParse(textBox14.Text, out grossCutoff) ? grossCutoff : 0;
            double netIncome = grossCutoff - totalDeductions;
            if (netIncome < 0) netIncome = 0;

            textBox32.Text = totalDeductions.ToString("N2");
            textBox13.Text = netIncome.ToString("N2");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
                if (c is TextBox tb)
                    tb.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6_Payslip_ payslip = new Form6_Payslip_(
                "Lyceum of the Philippines University Cavite",
                textBox2.Text,
                textBox1.Text,
                textBox16.Text + " " + textBox15.Text + " " + textBox12.Text,
                dateTimePicker1.Value.ToString("MMM dd"),
                dateTimePicker1.Value.ToString("MMM dd") + " to " + dateTimePicker1.Value.AddDays(15).ToString("MMM dd, yyyy"),
                textBox5.Text,
                textBox6.Text,
                textBox9.Text,
                textBox14.Text,
                textBox24.Text,
                textBox23.Text,
                textBox20.Text,
                textBox25.Text,
                textBox32.Text,
                textBox13.Text,
                textBox5.Text,
                textBox6.Text
            );

            payslip.Show();
        }
    }
}
