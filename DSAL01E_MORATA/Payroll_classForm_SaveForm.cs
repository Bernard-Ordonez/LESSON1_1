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
    public partial class Payroll_classForm_SaveForm : Form
    {
        public Payroll_classForm_SaveForm()
        {
            InitializeComponent();

            //initialize variables to default values
            hrs_textBox4.Text = "0";
            hrs_textBox5.Text = "0";
            hrs_textBox6.Text = "0";

            honorAdj_textBox.Text = "0";
            substitution_textBox.Text = "0";
            tardy_textBox.Text = "0";
            HDMF_textBox.Text = "200.00";
            WISP_textBox.Text = "750.00";

            //disable some textboxes
            hrs_textBox.Enabled = false;
            hrs_textBox2.Enabled = false;
            hrs_textBox3.Enabled = false;
            hrs_textBox4.Enabled = false;
            hrs_textBox5.Enabled = false;
            hrs_textBox6.Enabled = false;

            company_textBox.Enabled = false;
            empCode_textBox.Enabled = false;
            empName_textBox.Enabled = false;
            department_textBox.Enabled = false;
            cuOff_textBox.Enabled = false;
            payPeriod_textBox.Enabled= false;

            basicPay_textBox.Enabled = false;
            overtime_textBox.Enabled = false;
            honor_textBox.Enabled = false;
            honorAdj_textBox.Enabled = false;
            substitution_textBox.Enabled = false;
            tardy_textBox.Enabled = false;

            withholding_textBox.Enabled = false;
            sssContrib_textBox.Enabled = false;
            HDMF_textBox.Enabled = false;
            philHealth_textBox.Enabled = false;
            WISP_textBox.Enabled = false;

            earnings_textBox.Enabled = false;
            grossEarnings_textBox.Enabled = false;
            deductions_textBox2.Enabled = false;
            deductions_textBox.Enabled = false;
            netPay_textBox.Enabled = false;
        }

        private void Lesson5Actvity_SaveForm_Load(object sender, EventArgs e)
        {

        }

        private void Lesson5Actvity_SaveForm_Load_1(object sender, EventArgs e)
        {

        }

        private void empName_textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
