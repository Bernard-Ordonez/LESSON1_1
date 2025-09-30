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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            textBox5.Enabled = false; // Income|CutOff ; Basic Income
            textBox6.Enabled = false; // Income|CutOff ; Honorarium
            textBox9.Enabled = false; // Income|CutOff ; Other Income
            textBox13.Enabled = false; // Net Income
            textBox15.Enabled = true; // MiddleName
            textBox16.Enabled = true; // FirstName
            textBox12.Enabled = true; // Surname
            textBox19.Enabled = false; // Civil Status
            textBox21.Enabled = false; // Employee Status
            textBox22.Enabled = false; // Designation
            textBox20.Enabled = false; // Pagibig Contribution
            textBox23.Enabled = false; // PhilHealth Contribution
            textBox24.Enabled = false; // SSS Contribution
            textBox25.Enabled = false; // Income Tax Contribution
            textBox32.Enabled = false; // Total Deduction
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
            double basicCutoff = basicIncome / 2;
            double honorariumCutoff = honorariumIncome / 2;
            double otherCutoff = otherIncome / 2;
            double grossCutoff = grossIncome / 2;

            // ---------- SSS Contribution ----------
            double sss = 0;
            if (grossIncome >= 5250 && grossIncome <= 5749.99) sss = 275;
            else if (grossIncome <= 6249.99) sss = 300;
            else if (grossIncome <= 6749.99) sss = 325;
            else if (grossIncome <= 7249.99) sss = 350;
            else if (grossIncome <= 7749.99) sss = 375;
            else if (grossIncome <= 8249.99) sss = 400;
            else if (grossIncome <= 8749.99) sss = 425;
            else if (grossIncome <= 9249.99) sss = 450;
            else if (grossIncome <= 9749.99) sss = 475;
            else if (grossIncome <= 10249.99) sss = 500;
            else if (grossIncome <= 10749.99) sss = 525;
            else if (grossIncome <= 11249.99) sss = 550;
            else if (grossIncome <= 11749.99) sss = 575;
            else if (grossIncome <= 12249.99) sss = 600;
            else if (grossIncome <= 12749.99) sss = 625;
            else if (grossIncome <= 13249.99) sss = 650;
            else if (grossIncome <= 13749.99) sss = 675;
            else if (grossIncome <= 14249.99) sss = 700;
            else if (grossIncome <= 14749.99) sss = 725;
            else if (grossIncome <= 15249.99) sss = 750;
            else if (grossIncome <= 15749.99) sss = 775;
            else if (grossIncome <= 16249.99) sss = 800;
            else if (grossIncome <= 16749.99) sss = 825;
            else if (grossIncome <= 17249.99) sss = 850;
            else if (grossIncome <= 17749.99) sss = 875;
            else if (grossIncome <= 18249.99) sss = 900;
            else if (grossIncome <= 18749.99) sss = 925;
            else if (grossIncome <= 19249.99) sss = 950;
            else if (grossIncome <= 19749.99) sss = 975;
            else if (grossIncome <= 20249.99) sss = 1000;
            else if (grossIncome <= 20749.99) sss = 1025;
            else if (grossIncome <= 21249.99) sss = 1050;
            else if (grossIncome <= 21749.99) sss = 1075;
            else if (grossIncome <= 22249.99) sss = 1100;
            else if (grossIncome <= 22749.99) sss = 1125;
            else if (grossIncome <= 23249.99) sss = 1150;
            else if (grossIncome <= 23749.99) sss = 1175;
            else if (grossIncome <= 24249.99) sss = 1200;
            else if (grossIncome <= 24749.99) sss = 1225;
            else if (grossIncome >= 24750) sss = 1275;

            // ---------- PhilHealth ----------
            double philhealth = grossIncome * 0.05;
            if (philhealth < 500) philhealth = 500;
            if (philhealth > 5000) philhealth = 5000;
            philhealth /= 2; // employee share

            // ---------- Pagibig ----------
            double pagibig = 200;

            // ---------- Withholding Tax ----------
            double annualIncome = grossIncome * 24;
            double tax = 0;

            if (annualIncome <= 250000)
                tax = 0;
            else if (annualIncome <= 400000)
                tax = ((annualIncome - 250000) * 0.15) / 24;
            else if (annualIncome <= 800000)
                tax = (22500 + (annualIncome - 400000) * 0.20) / 24;
            else if (annualIncome <= 2000000)
                tax = (102500 + (annualIncome - 800000) * 0.25) / 24;
            else if (annualIncome <= 8000000)
                tax = (402500 + (annualIncome - 2000000) * 0.30) / 24;
            else
                tax = (2202500 + (annualIncome - 8000000) * 0.35) / 24;

            // ---------- Display ----------
            textBox5.Text = basicCutoff.ToString("N2");
            textBox6.Text = honorariumCutoff.ToString("N2");
            textBox9.Text = otherCutoff.ToString("N2");
            textBox14.Text = grossCutoff.ToString("N2");

            textBox24.Text = sss.ToString("N2");       // SSS
            textBox23.Text = philhealth.ToString("N2");// PhilHealth
            textBox20.Text = pagibig.ToString("N2");   // Pagibig
            textBox25.Text = tax.ToString("N2");       // Tax
        }


        private void button2_Click(object sender, EventArgs e) // Net Income
        {
            // ---------- Deductions from button1 ----------
            double sss = double.TryParse(textBox24.Text, out sss) ? sss : 0;
            double philhealth = double.TryParse(textBox23.Text, out philhealth) ? philhealth : 0;
            double pagibig = double.TryParse(textBox20.Text, out pagibig) ? pagibig : 0;
            double tax = double.TryParse(textBox25.Text, out tax) ? tax : 0;

            // ---------- Loan-related inputs ----------
            double sssLoan = double.TryParse(textBox29.Text, out sssLoan) ? sssLoan : 0;
            double pagibigLoan = double.TryParse(textBox28.Text, out pagibigLoan) ? pagibigLoan : 0;
            double facultySavingDeposit = double.TryParse(textBox27.Text, out facultySavingDeposit) ? facultySavingDeposit : 0;
            double facultySavingsLoan = double.TryParse(textBox26.Text, out facultySavingsLoan) ? facultySavingsLoan : 0;
            double salaryLoan = double.TryParse(textBox31.Text, out salaryLoan) ? salaryLoan : 0;
            double otherLoans = double.TryParse(textBox30.Text, out otherLoans) ? otherLoans : 0;

            // ---------- Total Deductions ----------
            double totalDeductions = 0;
            totalDeductions += sss;
            totalDeductions += philhealth;
            totalDeductions += pagibig;
            totalDeductions += tax;

            totalDeductions += sssLoan;
            totalDeductions += pagibigLoan;
            totalDeductions += facultySavingDeposit;
            totalDeductions += facultySavingsLoan;
            totalDeductions += salaryLoan;
            totalDeductions += otherLoans;

            // ---------- Gross Cutoff ----------
            double grossCutoff = double.TryParse(textBox14.Text, out grossCutoff) ? grossCutoff : 0;

            // ---------- Net Income ----------
            double netIncome = grossCutoff - totalDeductions;
            if (netIncome < 0) netIncome = 0; // safeguard 

            // ---------- Display ----------
            textBox32.Text = totalDeductions.ToString("N2"); // Total Deductions
            textBox13.Text = netIncome.ToString("N2");       // Net Income
        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox tb)
                    tb.Clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6_Payslip_ payslip = new Form6_Payslip_(
        "Lyceum of the Philippines University Cavite",   // Company (fixed text)
        textBox2.Text,                                   // Department
        textBox1.Text,                                   // Employee Code
        textBox16.Text + " " + textBox15.Text + " " + textBox12.Text, // Name (First Middle Last)
        dateTimePicker1.Value.ToString("MMM dd"),        // Cut Off
        dateTimePicker1.Value.ToString("MMM dd") + " to " +
        dateTimePicker1.Value.AddDays(15).ToString("MMM dd, yyyy"),// Pay Period (15 days range)

        // Earnings
        textBox5.Text,   // Basic Income
        textBox6.Text,   // Honorarium Income
        textBox9.Text,   // Other Income (Overtime)
        textBox14.Text,  // Gross Income

        // Deductions
        textBox24.Text,  // SSS
        textBox23.Text,  // PhilHealth
        textBox20.Text,  // Pagibig
        textBox25.Text,  // Income Tax

        // Totals
        textBox32.Text,  // Total Deduction
        textBox13.Text,   // Net Income

        //DayperHrs
        textBox5.Text, //Basic Pay per hour
        textBox6.Text // Honorarium
    );

            payslip.Show();
        }
    }
}
