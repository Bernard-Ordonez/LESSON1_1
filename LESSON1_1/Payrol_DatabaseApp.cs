using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LESSON1_1
{
    public partial class Payrol_DatabaseApp : Form
    {
        payrol_dbconnection payrol_db_connect = new payrol_dbconnection();
        payrol_variables pay_variables = new payrol_variables();
        public Payrol_DatabaseApp()
        {
            payrol_db_connect.payroll_connString();
            InitializeComponent();
        }

        private void cleartexteboxes()
        {
            empNumberTxtBox.Clear(); firstnameTxtbox.Clear();
            MNameTxtbox.Clear(); surnameTxtBox.Clear();
            civilStatusTxtBox.Clear(); designationTxtBox.Clear();
            numDependentsTxtBox.Clear(); emp_statusTxtbox.Clear();
            departmentTxtBox.Clear(); basic_netincomeTxtbox.Clear();
            basic_numhrsTxtbox.Clear(); basic_rateTxtbox.Clear();
            hono_netincomeTxtbox.Clear(); hono_numhrsTxtbox.Clear();
            hono_rateTxtbox.Clear(); other_netincomeTxtbox.Clear();
            other_numhrsTxtbox.Clear(); other_rateTxtbox.Clear();
            net_incomeTxtbox.Clear(); gross_incomeTxtbox.Clear();
            sss_contribTxtbox.Clear(); pagibig_contribTxtbox.Clear();
            philhealth_contribTxtbox.Clear(); tax_contribTxtbox.Clear();
            sss_loanTxtbox.Clear(); pagibig_loanTxtbox.Clear();
            FSD_depositTxtbox.Clear(); FS_loanTxtbox.Clear();
            others_loanCombo.Text = "Select other loan";
            total_deducTxtbox.Clear(); sal_loanTxtbox.Clear();
            others_loanTxtbox.Clear(); payslip_viewListBox.Items.Clear();
            pictureBox1.Image = Image.FromFile("C:\\Users\\Bernard Ordonez\\source\\DSAL01E\\LESSON1_1\\LESSON1_1\\Resources\\images.jpg");
        }

        private void Payrol_DatabaseApp_Load(object sender, EventArgs e)
        {

        }

        // SAVE
        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                payrol_db_connect.payroll_sql = "INSERT INTO payroltbl (basic_rate_hr, " +
                "basic_no_of_hrs_cutoff, basic_income_per_cutoff, honorarium_rate_hr, " +
                "honorarium_no_of_hrs_cutoff, honorarium_income_per_cutoff, " +
                "other_rate_hr, other_no_of_hrs_cutoff, other_income_per_cutoff, " +
                "sss_contrib, philhealth_contrib, pagibig_contrib, tax_contrib, " +
                "sss_loan, pagibig_loan, fac_savings_deposit, fac_savings_loan, " +
                "salary_loan, other_loans, total_deductions, gross_income, " +
                "net_income, emp_id, pay_date) VALUES ('" + basic_rateTxtbox.Text + "','" +
                basic_numhrsTxtbox.Text + "','" + basic_netincomeTxtbox.Text + "','" +
                hono_rateTxtbox.Text + "','" + hono_numhrsTxtbox.Text + "','" +
                hono_netincomeTxtbox.Text + "','" + other_rateTxtbox.Text + "','" +
                other_numhrsTxtbox.Text + "','" + other_netincomeTxtbox.Text + "','" +
                sss_contribTxtbox.Text + "','" + philhealth_contribTxtbox.Text + "','" +
                pagibig_contribTxtbox.Text + "','" + tax_contribTxtbox.Text + "','" +
                sss_loanTxtbox.Text + "','" + pagibig_loanTxtbox.Text + "','" +
                FSD_depositTxtbox.Text + "','" + FS_loanTxtbox.Text + "','" +
                sal_loanTxtbox.Text + "','" + others_loanTxtbox.Text + "','" +
                total_deducTxtbox.Text + "','" + gross_incomeTxtbox.Text + "','" +
                net_incomeTxtbox.Text + "','" + empNumberTxtBox.Text + "','" +
                paydateDatePicker.Text + "')";

                payrol_db_connect.payroll_cmd();
                payrol_db_connect.payroll_sqldataadapterInsert();
                cleartexteboxes();
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }

        //EDIT
        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                payrol_db_connect.payroll_sql = "INSERT INTO payrolltbl (basic_rate_hr, " +
                "basic_no_of_hrs_cutoff, basic_income_per_cutoff, honorarium_rate_hr, " +
                "honorarium_no_of_hrs_cutoff, honorarium_income_per_cutoff, " +
                "other_rate_hr, other_no_of_hrs_cutoff, other_income_per_cutoff, " +
                "sss_contrib, philhealth_contrib, pagibig_contrib, tax_contrib, " +
                "sss_loan, pagibig_loan, fac_savings_deposit, fac_savings_loan, " +
                "salary_loan, other_loans, total_deductions, gross_income, " +
                "net_income, emp_id, pay_date) VALUES ('" + basic_rateTxtbox.Text + "','" +
                basic_numhrsTxtbox.Text + "','" + basic_netincomeTxtbox.Text + "','" +
                hono_rateTxtbox.Text + "','" + hono_numhrsTxtbox.Text + "','" +
                hono_netincomeTxtbox.Text + "','" + other_rateTxtbox.Text + "','" +
                other_numhrsTxtbox.Text + "','" + other_netincomeTxtbox.Text + "','" +
                sss_contribTxtbox.Text + "','" + philhealth_contribTxtbox.Text + "','" +
                pagibig_contribTxtbox.Text + "','" + tax_contribTxtbox.Text + "','" +
                sss_loanTxtbox.Text + "','" + pagibig_loanTxtbox.Text + "','" +
                FSD_depositTxtbox.Text + "','" + FS_loanTxtbox.Text + "','" +
                sal_loanTxtbox.Text + "','" + others_loanTxtbox.Text + "','" +
                total_deducTxtbox.Text + "','" + gross_incomeTxtbox.Text + "','" +
                net_incomeTxtbox.Text + "','" + empNumberTxtBox.Text + "','" +
                paydateDatePicker.Text + "')";

                payrol_db_connect.payroll_cmd();
                payrol_db_connect.payroll_sqldataadapterInsert();
                cleartexteboxes();
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }

        //DELETE
        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                payrol_db_connect.payroll_sql = "DELETE FROM payrolltbl WHERE payrolltbl.emp_id = '" + empNumberTxtBox.Text + "'";
                payrol_db_connect.payroll_cmd();
                payrol_db_connect.payroll_sqldataadapterDelete();
                cleartexteboxes();
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }

        //SEARCH
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                payrol_db_connect.payroll_sql = "SELECT emp_id, emp_fname, emp_mname, emp_surname, emp_status, position, emp_no_of_dependents, emp_work_status, emp_department, picpath FROM pos_empRegTbl WHERE emp_id = '" + empNumberTxtBox.Text + "'";
                payrol_db_connect.payroll_cmd();
                payrol_db_connect.payroll_sqldataadapterSelect();
                payrol_db_connect.payroll_sqldataadapterSELECT();
                firstnameTxtbox.Text = payrol_db_connect.payroll_sql_dataset.Tables[0].Rows[0][1].ToString();
                MNameTxtbox.Text = payrol_db_connect.payroll_sql_dataset.Tables[0].Rows[0][2].ToString();
                surnameTxtBox.Text = payrol_db_connect.payroll_sql_dataset.Tables[0].Rows[0][3].ToString();
                civilStatusTxtBox.Text = payrol_db_connect.payroll_sql_dataset.Tables[0].Rows[0][4].ToString();
                designationTxtBox.Text = payrol_db_connect.payroll_sql_dataset.Tables[0].Rows[0][5].ToString();
                numDependentsTxtBox.Text = payrol_db_connect.payroll_sql_dataset.Tables[0].Rows[0][6].ToString();
                emp_statusTxtbox.Text = payrol_db_connect.payroll_sql_dataset.Tables[0].Rows[0][7].ToString();
                departmentTxtBox.Text = payrol_db_connect.payroll_sql_dataset.Tables[0].Rows[0][8].ToString();
                picpathTxtbox.Text = payrol_db_connect.payroll_sql_dataset.Tables[0].Rows[0][9].ToString();
                pictureBox1.Image = Image.FromFile(picpathTxtbox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area, contact your administrator!");
            }
        }

        //SEARCH EDIT
        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                payrol_db_connect.payroll_sql = "SELECT pos_empRegTbl.emp_id, emp_fname, " +
                "emp_mname, emp_surname, emp_status, position, emp_no_of_dependents, " +
                "emp_work_status, emp_department, picpath, basic_rate_hr, " +
                "basic_no_of_hrs_cutoff, basic_income_per_cutoff, honorarium_rate_hr, " +
                "honorarium_no_of_hrs_cutoff, honorarium_income_per_cutoff, " +
                "other_rate_hr, other_no_of_hrs_cutoff, other_income_per_cutoff, " +
                "sss_contrib, philhealth_contrib, pagibig_contrib, tax_contrib, " +
                "sss_loan, pagibig_loan, fac_savings_deposit, fac_savings_loan, " +
                "salary_loan, other_loans, total_deductions, gross_income, " +
                "net_income, payrolTbl.emp_id, pay_date FROM pos_empRegTbl INNER " +
                "JOIN payrolTbl ON pos_empRegTbl.emp_id = payrolTbl.emp_id WHERE " +
                "(payrolTbl.emp_id = '" + empNumberTxtBox.Text + "' AND " +
                "payrolTbl.pay_date = '" + paydateDatePicker.Text + "')";
                payrol_db_connect.payroll_cmd();
                payrol_db_connect.payroll_sqldataadapterSelect();
                payrol_db_connect.payroll_sqldataadapterSELECT();
                firstnameTxtbox.Text =
                    payrol_db_connect.payroll_sql_dataset.Tables[0].Rows[0][1].ToString();
                MNameTxtbox.Text =
                    payrol_db_connect.payroll_sql_dataset.Tables[0].Rows[0][2].ToString();
                surnameTxtBox.Text =
                    payrol_db_connect.payroll_sql_dataset.Tables[0].Rows[0][3].ToString();
                civilStatusTxtBox.Text =
                    payrol_db_connect.payroll_sql_dataset.Tables[0].Rows[0][4].ToString();
                designationTxtBox.Text =
                    payrol_db_connect.payroll_sql_dataset.Tables[0].Rows[0][5].ToString();
                numDependentsTxtBox.Text =
                    payrol_db_connect.payroll_sql_dataset.Tables[0].Rows[0][6].ToString();
                emp_statusTxtbox.Text =
                    payrol_db_connect.payroll_sql_dataset.Tables[0].Rows[0][7].ToString();
                departmentTxtBox.Text =
                    payrol_db_connect.payroll_sql_dataset.Tables[0].Rows[0][8].ToString();
                picpathTxtbox.Text =
                    payrol_db_connect.payroll_sql_dataset.Tables[0].Rows[0][9].ToString();
                pictureBox1.Image = Image.FromFile(picpathTxtbox.Text);
                basic_rateTxtbox.Text =
                    payrol_db_connect.payroll_sql_dataset.Tables[0].Rows[0][10].ToString();
                basic_numhrsTxtbox.Text =
                    payrol_db_connect.payroll_sql_dataset.Tables[0].Rows[0][11].ToString();
                basic_netincomeTxtbox.Text =
                    payrol_db_connect.payroll_sql_dataset.Tables[0].Rows[0][12].ToString();
                hono_rateTxtbox.Text =
                    payrol_db_connect.payroll_sql_dataset.Tables[0].Rows[0][13].ToString();
                hono_numhrsTxtbox.Text =
                    payrol_db_connect.payroll_sql_dataset.Tables[0].Rows[0][14].ToString();
                hono_netincomeTxtbox.Text =
                    payrol_db_connect.payroll_sql_dataset.Tables[0].Rows[0][15].ToString();
                other_rateTxtbox.Text =
                    payrol_db_connect.payroll_sql_dataset.Tables[0].Rows[0][16].ToString();
                other_numhrsTxtbox.Text =
                    payrol_db_connect.payroll_sql_dataset.Tables[0].Rows[0][17].ToString();
                other_netincomeTxtbox.Text =
                    payrol_db_connect.payroll_sql_dataset.Tables[0].Rows[0][18].ToString();
                sss_contribTxtbox.Text =
                    payrol_db_connect.payroll_sql_dataset.Tables[0].Rows[0][19].ToString();
                philhealth_contribTxtbox.Text =
                    payrol_db_connect.payroll_sql_dataset.Tables[0].Rows[0][20].ToString();
                pagibig_contribTxtbox.Text =
                    payrol_db_connect.payroll_sql_dataset.Tables[0].Rows[0][21].ToString();
                tax_contribTxtbox.Text =
                    payrol_db_connect.payroll_sql_dataset.Tables[0].Rows[0][22].ToString();
                sss_loanTxtbox.Text =
                    payrol_db_connect.payroll_sql_dataset.Tables[0].Rows[0][23].ToString();
                pagibig_loanTxtbox.Text =
                    payrol_db_connect.payroll_sql_dataset.Tables[0].Rows[0][24].ToString();
                FSD_depositTxtbox.Text =
                    payrol_db_connect.payroll_sql_dataset.Tables[0].Rows[0][25].ToString();
                FS_loanTxtbox.Text =
                    payrol_db_connect.payroll_sql_dataset.Tables[0].Rows[0][26].ToString();
                sal_loanTxtbox.Text =
                    payrol_db_connect.payroll_sql_dataset.Tables[0].Rows[0][27].ToString();
                others_loanTxtbox.Text =
                    payrol_db_connect.payroll_sql_dataset.Tables[0].Rows[0][28].ToString();
                total_deducTxtbox.Text =
                    payrol_db_connect.payroll_sql_dataset.Tables[0].Rows[0][29].ToString();
                gross_incomeTxtbox.Text =   
                    payrol_db_connect.payroll_sql_dataset.Tables[0].Rows[0][30].ToString();
                net_incomeTxtbox.Text =
                    payrol_db_connect.payroll_sql_dataset.Tables[0].Rows[0][31].ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }
    }
}
