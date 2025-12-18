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
    public partial class payrol_report : Form
    {
        payrol_dbconnection payrol_db_connect = new payrol_dbconnection();
        public payrol_report()
        {
            payrol_db_connect.payroll_connString();
            InitializeComponent();
        }
        private void payrol_select()
        {
            payrol_db_connect.payroll_cmd();
            payrol_db_connect.payroll_sqldataadapterSelect();
            payrol_db_connect.payroll_sqldataadapterSELECT();
            dataGridView1.DataSource = payrol_db_connect.payroll_sql_dataset.Tables[0];
        }
        private void cleartextboxes()
        {
            optionCombo.Text = "";
            optionInputTxtbox.Clear();
            optionCombo.Focus();
        }
        private void cleartextboxes1()
        {
            optionInputTxtbox.Clear();
            optionInputTxtbox.Focus();
        }

        private void payrol_report_Load(object sender, EventArgs e)
        {

            optionCombo.Items.AddRange(new object[]
            {
                "employee_number",
                "surname",
                "firstname",
                "gross_income",
                "net_income",
                "pay_date"

            });
            try
            {
                payrol_db_connect.payroll_sql = "SELECT emp_fname, emp_mname, emp_surname, basic_rate_hr, basic_no_of_hrs_cutOff, basic_income_per_cutOff, honorarium_rate_hr, honorarium_no_of_hrs_cutOff, honorarium_income_per_cutOff, other_rate_hr, other_no_of_hrs_cutOff, other_income_per_cutOff, sss_contrib, philhealth_contrib, pagibig_contrib, tax_contrib, sss_loan, pagibig_loan, fac_savings_deposit, fac_savings_loan, salary_loan, other_loans, total_deductions, gross_income, net_income, pay_date FROM pos_empRegTbl INNER JOIN payrolTbl ON pos_empRegTbl.emp_id = payrolTbl.emp_id";
                payrol_select();
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (optionCombo.Text == "employee_number")
                {
                    payrol_db_connect.payroll_sql = "SELECT emp_fname, emp_mname, emp_surname, basic_rate_hr, basic_no_of_hrs_cutOff, basic_income_per_cutOff, honorarium_rate_hr, honorarium_no_of_hrs_cutOff, honorarium_income_per_cutOff, other_rate_hr, other_no_of_hrs_cutOff, other_income_per_cutOff, sss_contrib, philhealth_contrib, pagibig_contrib, tax_contrib, sss_loan, pagibig_loan, fac_savings_deposit, fac_savings_loan, salary_loan, other_loans, total_deductions, gross_income, net_income, pay_date FROM pos_empRegTbl INNER JOIN payrolTbl ON pos_empRegTbl.emp_id = payrolTbl.emp_id WHERE pos_empRegTbl.emp_id = '" + optionInputTxtbox.Text + "'";
                    payrol_select();
                    cleartextboxes1();
                }
                else if (optionCombo.Text == "surname")
                {
                    payrol_db_connect.payroll_sql = "SELECT emp_fname, emp_mname, emp_surname, basic_rate_hr, basic_no_of_hrs_cutOff, basic_income_per_cutOff, honorarium_rate_hr, honorarium_no_of_hrs_cutOff, honorarium_income_per_cutOff, other_rate_hr, other_no_of_hrs_cutOff, other_income_per_cutOff, sss_contrib, philhealth_contrib, pagibig_contrib, tax_contrib, sss_loan, pagibig_loan, fac_savings_deposit, fac_savings_loan, salary_loan, other_loans, total_deductions, gross_income, net_income, pay_date FROM pos_empRegTbl INNER JOIN payrolTbl ON pos_empRegTbl.emp_id = payrolTbl.emp_id WHERE pos_empRegTbl.emp_surname = '" + optionInputTxtbox.Text + "'";
                    payrol_select();
                    cleartextboxes1();
                }
                else if (optionCombo.Text == "firstname")
                {
                    payrol_db_connect.payroll_sql = "SELECT emp_fname, emp_mname, emp_surname, basic_rate_hr, basic_no_of_hrs_cutOff, basic_income_per_cutOff, honorarium_rate_hr, honorarium_no_of_hrs_cutOff, honorarium_income_per_cutOff, other_rate_hr, other_no_of_hrs_cutOff, other_income_per_cutOff, sss_contrib, philhealth_contrib, pagibig_contrib, tax_contrib, sss_loan, pagibig_loan, fac_savings_deposit, fac_savings_loan, salary_loan, other_loans, total_deductions, gross_income, net_income, pay_date FROM pos_empRegTbl INNER JOIN payrolTbl ON pos_empRegTbl.emp_id = payrolTbl.emp_id WHERE pos_empRegTbl.emp_fname = '" + optionInputTxtbox.Text + "'";
                    payrol_select();
                    cleartextboxes1();
                }
                else if (optionCombo.Text == "gross_income")
                {
                    payrol_db_connect.payroll_sql = "SELECT emp_fname, emp_mname, emp_surname, basic_rate_hr, basic_no_of_hrs_cutOff, basic_income_per_cutOff, honorarium_rate_hr, honorarium_no_of_hrs_cutOff, honorarium_income_per_cutOff, other_rate_hr, other_no_of_hrs_cutOff, other_income_per_cutOff, sss_contrib, philhealth_contrib, pagibig_contrib, tax_contrib, sss_loan, pagibig_loan, fac_savings_deposit, fac_savings_loan, salary_loan, other_loans, total_deductions, gross_income, net_income, pay_date FROM pos_empRegTbl INNER JOIN payrolTbl ON pos_empRegTbl.emp_id = payrolTbl.emp_id WHERE payrolTbl.gross_income = '" + optionInputTxtbox.Text + "'";
                    payrol_select();
                    cleartextboxes1();
                }
                else if (optionCombo.Text == "net_income")
                {
                    payrol_db_connect.payroll_sql = "SELECT emp_fname, emp_mname, emp_surname, basic_rate_hr, basic_no_of_hrs_cutOff, basic_income_per_cutOff, honorarium_rate_hr, honorarium_no_of_hrs_cutOff, honorarium_income_per_cutOff, other_rate_hr, other_no_of_hrs_cutOff, other_income_per_cutOff, sss_contrib, philhealth_contrib, pagibig_contrib, tax_contrib, sss_loan, pagibig_loan, fac_savings_deposit, fac_savings_loan, salary_loan, other_loans, total_deductions, gross_income, net_income, pay_date FROM pos_empRegTbl INNER JOIN payrolTbl ON pos_empRegTbl.emp_id = payrolTbl.emp_id WHERE payrolTbl.net_income = '" + optionInputTxtbox.Text + "'";
                    payrol_select();
                    cleartextboxes1();
                }
                else if (optionCombo.Text == "pay_date")
                {
                    payrol_db_connect.payroll_sql = "SELECT emp_fname, emp_mname, emp_surname, basic_rate_hr, basic_no_of_hrs_cutOff, basic_income_per_cutOff, honorarium_rate_hr, honorarium_no_of_hrs_cutOff, honorarium_income_per_cutOff, other_rate_hr, other_no_of_hrs_cutOff, other_income_per_cutOff, sss_contrib, philhealth_contrib, pagibig_contrib, tax_contrib, sss_loan, pagibig_loan, fac_savings_deposit, fac_savings_loan, salary_loan, other_loans, total_deductions, gross_income, net_income, pay_date FROM pos_empRegTbl INNER JOIN payrolTbl ON pos_empRegTbl.emp_id = payrolTbl.emp_id WHERE pos_empRegTbl.emp_fname = '\" + optionInputTxtbox.Text + \"'\"";
                    payrol_select();
                    cleartextboxes1();
                }
                else if (optionCombo.Text == "gross_income")
                {
                    payrol_db_connect.payroll_sql = "SELECT emp_fname, emp_mname, emp_surname, basic_rate_hr, basic_no_of_hrs_cutOff, basic_income_per_cutOff, honorarium_rate_hr, honorarium_no_of_hrs_cutOff, honorarium_income_per_cutOff, other_rate_hr, other_no_of_hrs_cutOff, other_income_per_cutOff, sss_contrib, philhealth_contrib, pagibig_contrib, tax_contrib, sss_loan, pagibig_loan, fac_savings_deposit, fac_savings_loan, salary_loan, other_loans, total_deductions, gross_income, net_income, pay_date FROM pos_empRegTbl INNER JOIN payrolTbl ON pos_empRegTbl.emp_id = payrolTbl.emp_id WHERE payrolTbl.gross_income = '" + optionInputTxtbox.Text + "'";
                    payrol_select();
                    cleartextboxes1();
                }
                else if (optionCombo.Text == "net_income")
                {
                    payrol_db_connect.payroll_sql = "SELECT emp_fname, emp_mname, emp_surname, basic_rate_hr, basic_no_of_hrs_cutOff, basic_income_per_cutOff, honorarium_rate_hr, honorarium_no_of_hrs_cutOff, honorarium_income_per_cutOff, other_rate_hr, other_no_of_hrs_cutOff, other_income_per_cutOff, sss_contrib, philhealth_contrib, pagibig_contrib, tax_contrib, sss_loan, pagibig_loan, fac_savings_deposit, fac_savings_loan, salary_loan, other_loans, total_deductions, gross_income, net_income, pay_date FROM pos_empRegTbl INNER JOIN payrolTbl ON pos_empRegTbl.emp_id = payrolTbl.emp_id WHERE payrolTbl.net_income = '" + optionInputTxtbox.Text + "'";
                    payrol_select();
                    cleartextboxes1();
                }
                else if (optionCombo.Text == "pay_date")
                {
                    payrol_db_connect.payroll_sql = "SELECT emp_fname, emp_mname, emp_surname, basic_rate_hr, basic_no_of_hrs_cutOff, basic_income_per_cutOff, honorarium_rate_hr, honorarium_no_of_hrs_cutOff, honorarium_income_per_cutOff, other_rate_hr, other_no_of_hrs_cutOff, other_income_per_cutOff, sss_contrib, philhealth_contrib, pagibig_contrib, tax_contrib, sss_loan, pagibig_loan, fac_savings_deposit, fac_savings_loan, salary_loan, other_loans, total_deductions, gross_income, net_income, pay_date FROM pos_empRegTbl INNER JOIN payrolTbl ON pos_empRegTbl.emp_id = payrolTbl.emp_id WHERE payrolTbl.pay_date = '\" + optionInputTxtbox.Text + \"'\"";
                    payrol_select();
                    cleartextboxes1();
                }
                else
                {
                    MessageBox.Show("No Available Record Found!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                payrol_db_connect.payroll_sql = "SELECT emp_fname, emp_mname, emp_surname, basic_rate_hr, basic_no_of_hrs_cutOff, basic_income_per_cutOff, honorarium_rate_hr, honorarium_no_of_hrs_cutOff, honorarium_income_per_cutOff, other_rate_hr, other_no_of_hrs_cutOff, other_income_per_cutOff, sss_contrib, philhealth_contrib, pagibig_contrib, tax_contrib, sss_loan, pagibig_loan, fac_savings_deposit, fac_savings_loan, salary_loan, other_loans, total_deductions, gross_income, net_income, pay_date FROM pos_empRegTbl INNER JOIN payrolTbl ON pos_empRegTbl.emp_id = payrolTbl.emp_id";
                payrol_select();
                cleartextboxes();
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }
    }
}
