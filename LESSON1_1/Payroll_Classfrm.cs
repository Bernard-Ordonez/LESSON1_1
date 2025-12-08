using System;
using System.Linq;
using System.Windows.Forms;

namespace LESSON1_1
{
    public partial class Payroll_Classfrm : Form
    {
        // Instance of your PayrollClass1 for computations
        private PayrollClass1 payroll = new PayrollClass1();

        public Payroll_Classfrm()
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

        // Helper to safely parse doubles from textboxes (keeps code DRY)
        private double ParseDouble(TextBox tb)
        {
            if (tb == null) return 0;
            if (double.TryParse(tb.Text, out double val)) return val;
            return 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ---------- Inputs ----------
            double rateBasic = ParseDouble(textBox3);
            double hoursBasic = ParseDouble(textBox4);
            double rateHonor = ParseDouble(textBox7);
            double hoursHonor = ParseDouble(textBox8);
            double rateOther = ParseDouble(textBox10);
            double hoursOther = ParseDouble(textBox11);

            // ---------- Monthly Incomes ----------
            double basicIncome = payroll.ComputeBasicIncome(rateBasic, hoursBasic);
            double honorariumIncome = payroll.ComputeBasicIncome(rateHonor, hoursHonor);
            double otherIncome = payroll.ComputeBasicIncome(rateOther, hoursOther);
            double grossIncome = payroll.ComputeGrossIncome(basicIncome, honorariumIncome, otherIncome);

            // ---------- Cutoff (semi-monthly) ----------
            double basicCutoff = payroll.ComputeCutoff(basicIncome);
            double honorariumCutoff = payroll.ComputeCutoff(honorariumIncome);
            double otherCutoff = payroll.ComputeCutoff(otherIncome);
            double grossCutoff = payroll.ComputeCutoff(grossIncome);

            // ---------- Contributions ----------
            double sss_contrib = payroll.GetSSSContribution(grossIncome);
            double philhealth_contrib = payroll.GetPhilHealthContribution(grossIncome);
            double pagibig_contrib = payroll.GetPagibigContribution();
            double tax_contrib = payroll.GetWithholdingTax(grossIncome);

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
            double sss = ParseDouble(textBox24);
            double philhealth = ParseDouble(textBox23);
            double pagibig = ParseDouble(textBox20);
            double tax = ParseDouble(textBox25);

            double sssLoan = ParseDouble(textBox29);
            double pagibigLoan = ParseDouble(textBox28);
            double facultySavingDeposit = ParseDouble(textBox27);
            double facultySavingsLoan = ParseDouble(textBox26);
            double salaryLoan = ParseDouble(textBox31);
            double otherLoans = ParseDouble(textBox30);

            double totalDeductions = payroll.ComputeTotalDeductions(
                sss, philhealth, pagibig, tax,
                sssLoan, pagibigLoan, facultySavingDeposit,
                facultySavingsLoan, salaryLoan, otherLoans
            );

            double grossCutoff = ParseDouble(textBox14);
            double netIncome = payroll.ComputeNetIncome(grossCutoff, totalDeductions);

            textBox32.Text = totalDeductions.ToString("N2");
            textBox13.Text = netIncome.ToString("N2");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox tb) tb.Clear();
            }
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
