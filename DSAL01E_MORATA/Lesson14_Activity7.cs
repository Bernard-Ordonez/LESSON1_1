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
    public partial class Lesson14_Activity7 : Form
    {
        payroll_dbconnection payroll_db_connect = new payroll_dbconnection();
        private bool isloading = true;

        private void CenterPanel()
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
        }

        private void payroll_select()
        { 
            payroll_db_connect.payroll_cmd();
            payroll_db_connect.payroll_sqladapterSelect();
            payroll_db_connect.payroll_sqldatasetSELECT();
            dataGridView1.DataSource = payroll_db_connect.payroll_sql_dataset.Tables[0];
        }

        private void cleartextboxes()
        {
            option_comboBox.Text = "";
            optionInput_textBox.Clear();
            option_comboBox.Focus();
        }

        private void cleartextboxes1()
        {
            option_comboBox.Text = "";
            optionInput_textBox.Clear();
        }

        public Lesson14_Activity7()
        {
            payroll_db_connect.payroll_connString();
            InitializeComponent();
        }

        private void Lesson14_Activity7_Load(object sender, EventArgs e)
        {
            payroll_db_connect.payroll_sql = @"
                    SELECT 
                        emp_fname, emp_mname, emp_surname,
                        basic_rate_hr, basic_no_of_hrs_cutOff, basic_income_per_cutOff,
                        honorarium_rate_hr, honorarium_no_of_hrs_cutOff, honorarium_income_per_cutOff,
                        other_rate_hr, other_no_of_hrs_cutOff, other_income_per_cutOff,
                        sss_contrib, philhealth_contrib, pagibig_contrib, tax_contrib,
                        sss_loan, pagibig_loan, fac_savings_deposit, fac_savings_loan,
                        salary_loan, other_loans, total_deductions,
                        gross_income, net_income, pay_date
                    FROM pos_empRegTbl
                    INNER JOIN payrollTbl ON pos_empRegTbl.emp_id = payrollTbl.emp_id";
            payroll_select();
            
            CenterPanel();
            this.Resize += (s, ev) => CenterPanel();
            isloading = true;
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (option_comboBox.Text == "employee_number")
                {
                    payroll_db_connect.payroll_sql = @"
                    SELECT emp_fname, emp_mname, emp_surname,
                           basic_rate_hr, basic_no_of_hrs_cutOff, basic_income_per_cutOff,
                           honorarium_rate_hr, honorarium_no_of_hrs_cutOff, honorarium_income_per_cutOff,
                           other_rate_hr, other_no_of_hrs_cutOff, other_income_per_cutOff,
                           sss_contrib, philhealth_contrib, pagibig_contrib, tax_contrib,
                           sss_loan, pagibig_loan, fac_savings_deposit, fac_savings_loan,
                           salary_loan, other_loans, total_deductions,
                           gross_income, net_income, pay_date
                    FROM pos_empRegTbl
                    INNER JOIN payrollTbl ON pos_empRegTbl.emp_id = payrollTbl.emp_id
                    WHERE pos_empRegTbl.emp_id = '" + optionInput_textBox.Text + "'";
                    payroll_select();
                    cleartextboxes1();
                }
                else if (option_comboBox.Text == "surname")
                {
                    payroll_db_connect.payroll_sql = @"
                    SELECT emp_fname, emp_mname, emp_surname,
                           basic_rate_hr, basic_no_of_hrs_cutOff, basic_income_per_cutOff,
                           honorarium_rate_hr, honorarium_no_of_hrs_cutOff, honorarium_income_per_cutOff,
                           other_rate_hr, other_no_of_hrs_cutOff, other_income_per_cutOff,
                           sss_contrib, philhealth_contrib, pagibig_contrib, tax_contrib,
                           sss_loan, pagibig_loan, fac_savings_deposit, fac_savings_loan,
                           salary_loan, other_loans, total_deductions,
                           gross_income, net_income, pay_date
                    FROM pos_empRegTbl
                    INNER JOIN payrollTbl ON pos_empRegTbl.emp_id = payrollTbl.emp_id
                    WHERE pos_empRegTbl.emp_surname = '" + optionInput_textBox.Text + "'";
                    payroll_select();
                    cleartextboxes1();
                }
                else if (option_comboBox.Text == "firstname")
                {
                    payroll_db_connect.payroll_sql = @"
                    SELECT emp_fname, emp_mname, emp_surname,
                           basic_rate_hr, basic_no_of_hrs_cutOff, basic_income_per_cutOff,
                           honorarium_rate_hr, honorarium_no_of_hrs_cutOff, honorarium_income_per_cutOff,
                           other_rate_hr, other_no_of_hrs_cutOff, other_income_per_cutOff,
                           sss_contrib, philhealth_contrib, pagibig_contrib, tax_contrib,
                           sss_loan, pagibig_loan, fac_savings_deposit, fac_savings_loan,
                           salary_loan, other_loans, total_deductions,
                           gross_income, net_income, pay_date
                    FROM pos_empRegTbl
                    INNER JOIN payrollTbl ON pos_empRegTbl.emp_id = payrollTbl.emp_id
                    WHERE pos_empRegTbl.emp_fname = '" + optionInput_textBox.Text + "'";
                    payroll_select();
                    cleartextboxes1();
                }
                else if (option_comboBox.Text == "gross_income")
                {
                    payroll_db_connect.payroll_sql = @"
                    SELECT emp_fname, emp_mname, emp_surname,
                           basic_rate_hr, basic_no_of_hrs_cutOff, basic_income_per_cutOff,
                           honorarium_rate_hr, honorarium_no_of_hrs_cutOff, honorarium_income_per_cutOff,
                           other_rate_hr, other_no_of_hrs_cutOff, other_income_per_cutOff,
                           sss_contrib, philhealth_contrib, pagibig_contrib, tax_contrib,
                           sss_loan, pagibig_loan, fac_savings_deposit, fac_savings_loan,
                           salary_loan, other_loans, total_deductions,
                           gross_income, net_income, pay_date
                    FROM pos_empRegTbl
                    INNER JOIN payrollTbl ON pos_empRegTbl.emp_id = payrollTbl.emp_id
                    WHERE payrollTbl.gross_income = '" + optionInput_textBox.Text + "'";
                    payroll_select();
                    cleartextboxes1();
                }
                else if (option_comboBox.Text == "net_income")
                {
                    payroll_db_connect.payroll_sql = @"
                    SELECT emp_fname, emp_mname, emp_surname,
                           basic_rate_hr, basic_no_of_hrs_cutOff, basic_income_per_cutOff,
                           honorarium_rate_hr, honorarium_no_of_hrs_cutOff, honorarium_income_per_cutOff,
                           other_rate_hr, other_no_of_hrs_cutOff, other_income_per_cutOff,
                           sss_contrib, philhealth_contrib, pagibig_contrib, tax_contrib,
                           sss_loan, pagibig_loan, fac_savings_deposit, fac_savings_loan,
                           salary_loan, other_loans, total_deductions,
                           gross_income, net_income, pay_date
                    FROM pos_empRegTbl
                    INNER JOIN payrollTbl ON pos_empRegTbl.emp_id = payrollTbl.emp_id
                    WHERE payrollTbl.net_income = '" + optionInput_textBox.Text + "'";
                    payroll_select();
                    cleartextboxes1();
                }
                else if (option_comboBox.Text == "pay_date")
                {
                    payroll_db_connect.payroll_sql = @"
                    SELECT emp_fname, emp_mname, emp_surname,
                           basic_rate_hr, basic_no_of_hrs_cutOff, basic_income_per_cutOff,
                           honorarium_rate_hr, honorarium_no_of_hrs_cutOff, honorarium_income_per_cutOff,
                           other_rate_hr, other_no_of_hrs_cutOff, other_income_per_cutOff,
                           sss_contrib, philhealth_contrib, pagibig_contrib, tax_contrib,
                           sss_loan, pagibig_loan, fac_savings_deposit, fac_savings_loan,
                           salary_loan, other_loans, total_deductions,
                           gross_income, net_income, pay_date
                    FROM pos_empRegTbl
                    INNER JOIN payrollTbl ON pos_empRegTbl.emp_id = payrollTbl.emp_id
                    WHERE payrollTbl.pay_date = '" + optionInput_textBox.Text + "'";
                    payroll_select();
                    cleartextboxes1();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void back_button_Click(object sender, EventArgs e)
        {
            payroll_db_connect.payroll_sql = @"
                SELECT emp_fname, emp_mname, emp_surname,
                       basic_rate_hr, basic_no_of_hrs_cutOff, basic_income_per_cutOff,
                       honorarium_rate_hr, honorarium_no_of_hrs_cutOff, honorarium_income_per_cutOff,
                       other_rate_hr, other_no_of_hrs_cutOff, other_income_per_cutOff,
                       sss_contrib, philhealth_contrib, pagibig_contrib, tax_contrib,
                       sss_loan, pagibig_loan, fac_savings_deposit, fac_savings_loan,
                       salary_loan, other_loans, total_deductions,
                       gross_income, net_income, pay_date
                FROM pos_empRegTbl
                INNER JOIN payrollTbl ON pos_empRegTbl.emp_id = payrollTbl.emp_id";
            payroll_select();
            cleartextboxes();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
