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
    public partial class Form6_Payslip_ : Form
    {
        public Form6_Payslip_(
            string company,
            string department,
            string empCode,
            string empName,
            string cutoff,
            string payPeriod,
            string basicIncome,
            string honorIncome,
            string otherIncome,
            string grossIncome,
            string sss,
            string philhealth,
            string pagibig,
            string tax,
            string totalDeduction,
            string netIncome,
            string basicpayhrs,
            string honorariumhrs
            )
        {
            InitializeComponent();

            // Header info
            richTextBox1.Text = company;
            richTextBox2.Text = department;
            richTextBox4.Text = empCode;
            richTextBox6.Text = empName;
            richTextBox3.Text = cutoff;
            richTextBox5.Text = payPeriod;

            // Earnings
            textBox1.Text = basicIncome;
            textBox3.Text = honorIncome;
            textBox2.Text = otherIncome;
            textBox12.Text = grossIncome;

            textBox4.Text = "0.00";
            textBox5.Text = "0.00";
            textBox6.Text = "0.00";

            // Deductions
            textBox8.Text = sss;
            textBox10.Text = philhealth;
            textBox9.Text = pagibig;
            textBox7.Text = tax;
            textBox11.Text = "750.00"; // fixed

            // Totals
            textBox13.Text = totalDeduction;
            textBox14.Text = netIncome;

            textBox18.Text = grossIncome;
            textBox19.Text = totalDeduction;
            textBox20.Text = "0.00";
        }
    }
}
