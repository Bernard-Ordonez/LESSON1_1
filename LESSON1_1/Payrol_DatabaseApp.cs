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

        private Double basic_netincome = 0.00,
               basic_numhrs = 0.00,
               basic_rate = 0.00,
               hono_netincome = 0.00,
               hono_numhrs = 0.00,
               hono_rate = 0.00,
               other_netincome = 0.00,
               other_numhrs = 0.00,
               other_rate = 0.00;
        public Payrol_DatabaseApp()
        {
            payrol_db_connect.payroll_connString();
            InitializeComponent();
        }

        private void cleartextboxes()
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
            basic_netincomeTxtbox.Enabled = false;
            hono_netincomeTxtbox.Enabled = false;
            other_netincomeTxtbox.Enabled = false;
            gross_incomeTxtbox.Enabled = false;
            net_incomeTxtbox.Enabled = false;
            total_deducTxtbox.Enabled = false;

            sss_contribTxtbox.Text = "0.00";
            pagibig_contribTxtbox.Text = "0.00";
            philhealth_contribTxtbox.Text = "0.00";
            tax_contribTxtbox.Text = "0.00";

            sss_loanTxtbox.Text = "0.00";
            pagibig_loanTxtbox.Text = "0.00";
            FSD_depositTxtbox.Text = "0.00";
            FS_loanTxtbox.Text = "0.00";
            sal_loanTxtbox.Text = "0.00";
            others_loanTxtbox.Text = "0.00";

            others_loanCombo.Text = "Select other deduction";
            others_loanCombo.Items.AddRange(new object[]
            {
                "1",
                "2",
                "3",
                "4"
            });

            picpathTxtbox.Hide();
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
                cleartextboxes();
            }
            catch (Exception)
            {
                MessageBox.Show("Warning, check for correct int or double");
            }
        }


        //EDIT
        private void button8_Click(object sender, EventArgs e)
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
                cleartextboxes();
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
                payrol_db_connect.payroll_sql = "DELETE FROM payroltbl WHERE payroltbl.emp_id = '" + empNumberTxtBox.Text + "'";
                payrol_db_connect.payroll_cmd();
                payrol_db_connect.payroll_sqldataadapterDelete();
                cleartextboxes();
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
            payrol_db_connect.payroll_sql = "SELECT pos_empRegTbl.emp_id, emp_fname, emp_mname, emp_surname, emp_status, position, emp_no_of_dependents, emp_work_status, emp_department, picpath, basic_rate_hr, basic_no_of_hrs_cutOff, basic_income_per_cutOff, honorarium_rate_hr, honorarium_no_of_hrs_cutOff, honorarium_income_per_cutOff, other_rate_hr, other_no_of_hrs_cutOff, other_income_per_cutOff, sss_contrib, philhealth_contrib, pagibig_contrib, tax_contrib, sss_loan, pagibig_loan, fac_savings_deposit, fac_savings_loan, salary_loan, other_loans, total_deductions, gross_income, net_income, payroltbl.emp_id, pay_date FROM pos_empRegTbl INNER JOIN payrolTbl ON pos_empRegTbl.emp_id = payrolTbl.emp_id WHERE (payrolTbl.emp_id = '" + empNumberTxtBox.Text + "' AND payrolTbl.pay_date ='" + paydateDatePicker.Text + "')";

            payrol_db_connect.payroll_cmd();
            payrol_db_connect.payroll_sqldataadapterSelect();
            payrol_db_connect.payroll_sqldataadapterSELECT();

            firstnameTxtbox.Text = payrol_db_connect.payroll_sql_dataset.Tables[0].Rows[0][1].ToString();
            MNameTxtbox.Text = payrol_db_connect.payroll_sql_dataset.Tables[0].Rows[0][2].ToString();
            surnameTxtBox.Text = payrol_db_connect.payroll_sql_dataset.Tables[0].Rows[0][3].ToString();
            civilStatusTxtBox.Text = payrol_db_connect.payroll_sql_dataset.Tables[0].Rows[0][4].ToString();
            designationTxtBox.Text = payrol_db_connect.payroll_sql_dataset.Tables[0].Rows[0][5].ToString();
            departmentTxtBox.Text = payrol_db_connect.payroll_sql_dataset.Tables[0].Rows[0][6].ToString();
            emp_statusTxtbox.Text = payrol_db_connect.payroll_sql_dataset.Tables[0].Rows[0][7].ToString();
            departmentTxtBox.Text = payrol_db_connect.payroll_sql_dataset.Tables[0].Rows[0][8].ToString();
            picpathTxtbox.Text = payrol_db_connect.payroll_sql_dataset.Tables[0].Rows[0][9].ToString();
            pictureBox1.Image = Image.FromFile(picpathTxtbox.Text);

            basic_rateTxtbox.Text = payrol_db_connect.payroll_sql_dataset.Tables[0].Rows[0][10].ToString();
            basic_numhrsTxtbox.Text = payrol_db_connect.payroll_sql_dataset.Tables[0].Rows[0][11].ToString();
            basic_netincomeTxtbox.Text = payrol_db_connect.payroll_sql_dataset.Tables[0].Rows[0][12].ToString();

            hono_rateTxtbox.Text = payrol_db_connect.payroll_sql_dataset.Tables[0].Rows[0][13].ToString();
            hono_numhrsTxtbox.Text = payrol_db_connect.payroll_sql_dataset.Tables[0].Rows[0][14].ToString();
            hono_netincomeTxtbox.Text = payrol_db_connect.payroll_sql_dataset.Tables[0].Rows[0][15].ToString();

            other_rateTxtbox.Text = payrol_db_connect.payroll_sql_dataset.Tables[0].Rows[0][16].ToString();
            other_numhrsTxtbox.Text = payrol_db_connect.payroll_sql_dataset.Tables[0].Rows[0][17].ToString();
            other_netincomeTxtbox.Text = payrol_db_connect.payroll_sql_dataset.Tables[0].Rows[0][18].ToString();

            sss_contribTxtbox.Text = payrol_db_connect.payroll_sql_dataset.Tables[0].Rows[0][19].ToString();
            philhealth_contribTxtbox.Text = payrol_db_connect.payroll_sql_dataset.Tables[0].Rows[0][20].ToString(); pagibig_contribTxtbox.Text = payrol_db_connect.payroll_sql_dataset.Tables[0].Rows[0][21].ToString();
            tax_contribTxtbox.Text = payrol_db_connect.payroll_sql_dataset.Tables[0].Rows[0][22].ToString();

            sss_loanTxtbox.Text = payrol_db_connect.payroll_sql_dataset.Tables[0].Rows[0][23].ToString();
            pagibig_loanTxtbox.Text = payrol_db_connect.payroll_sql_dataset.Tables[0].Rows[0][24].ToString();
            FSD_depositTxtbox.Text = payrol_db_connect.payroll_sql_dataset.Tables[0].Rows[0][25].ToString();
            FS_loanTxtbox.Text = payrol_db_connect.payroll_sql_dataset.Tables[0].Rows[0][26].ToString();
            sal_loanTxtbox.Text = payrol_db_connect.payroll_sql_dataset.Tables[0].Rows[0][27].ToString();
            others_loanCombo.Text = payrol_db_connect.payroll_sql_dataset.Tables[0].Rows[0][28].ToString();
            total_deducTxtbox.Text = payrol_db_connect.payroll_sql_dataset.Tables[0].Rows[0][29].ToString();
            gross_incomeTxtbox.Text = payrol_db_connect.payroll_sql_dataset.Tables[0].Rows[0][30].ToString();
            net_incomeTxtbox.Text = payrol_db_connect.payroll_sql_dataset.Tables[0].Rows[0][31].ToString();
        }

        private void hono_numhrsTxtbox_Changed(object sender, EventArgs e)
        {
            try
            {
                hono_numhrs = Convert.ToDouble(hono_numhrsTxtbox.Text);
                hono_rate = Convert.ToDouble(hono_rateTxtbox.Text);
                hono_netincome = hono_numhrs * hono_rate;
                hono_netincomeTxtbox.Text = hono_netincome.ToString("n");
            }
            catch (Exception)
            {
                hono_rateTxtbox.Clear();
            }
        }

        private void other_numhrsTxtbox_TxtChanged(object sender, EventArgs e)
        {
            other_numhrs = Convert.ToDouble(other_numhrsTxtbox.Text);
            other_rate = Convert.ToDouble(other_rateTxtbox.Text);
            other_netincome = other_numhrs * other_rate;
            other_netincomeTxtbox.Text = other_netincome.ToString("n");
            grossincome = basic_netincome + hono_netincome + other_netincome;
            gross_incomeTxtbox.Text = grossincome.ToString("n");
            pagibig_contribTxtbox.Text = "100.00";
            
            if (grossincome <= 10000)
            {
                philhealth_contribTxtbox.Text = "137.50";
            }
            else if (grossincome > 10000 && grossincome <= 11000)
            {
                philhealth_contribTxtbox.Text = "151.25";
            }
            else if (grossincome > 11000 && grossincome <= 12000)
            {
                philhealth_contribTxtbox.Text = "165.00";
            }
            else if (grossincome > 12000 && grossincome <= 13000)
            {
                philhealth_contribTxtbox.Text = "178.75";
            }
            else if (grossincome > 13000 && grossincome <= 14000)
            {
                philhealth_contribTxtbox.Text = "192.50";
            }
            else if (grossincome > 14000 && grossincome <= 15000)
            {
                philhealth_contribTxtbox.Text = "206.25";
            }
            else if (grossincome > 15000 && grossincome <= 16000)
            {
                philhealth_contribTxtbox.Text = "220.00";
            }
            else if (grossincome > 16000 && grossincome <= 17000)
            {
                philhealth_contribTxtbox.Text = "233.75";
            }
            else if (grossincome > 17000 && grossincome <= 18000)
            {
                philhealth_contribTxtbox.Text = "247.50";
            }
            else if (grossincome > 18000 && grossincome <= 19000)
            {
                philhealth_contribTxtbox.Text = "261.25";
            }
            else if (grossincome > 19000 && grossincome <= 20000)
            {
                philhealth_contribTxtbox.Text = "275.00";
            }
            else if (grossincome > 20000 && grossincome <= 21000)
            {
                philhealth_contribTxtbox.Text = "288.75";
            }
            else if (grossincome > 21000 && grossincome <= 22000)
            {
                philhealth_contribTxtbox.Text = "302.50";
            }
            else if (grossincome > 22000 && grossincome <= 23000)
            {
                philhealth_contribTxtbox.Text = "316.25";
            }
            else if (grossincome > 23000 && grossincome <= 24000)
            {
                philhealth_contribTxtbox.Text = "330.00";
            }
            else if (grossincome > 24000 && grossincome <= 25000)
            {
                philhealth_contribTxtbox.Text = "343.75";
            }
            else if (grossincome > 25000 && grossincome <= 26000)
            {
                philhealth_contribTxtbox.Text = "357.50";
            }
            else if (grossincome > 26000 && grossincome <= 27000)
            {
                philhealth_contribTxtbox.Text = "371.25";
            }
            else if (grossincome > 27000 && grossincome <= 28000)
            {
                philhealth_contribTxtbox.Text = "385.00";
            }
            else if (grossincome > 28000 && grossincome <= 29000)
            {
                philhealth_contribTxtbox.Text = "398.75";
            }
            else if (grossincome > 29000 && grossincome <= 30000)
            {
                philhealth_contribTxtbox.Text = "412.50";
            }
            else if (grossincome > 30000 && grossincome <= 31000)
            {
                philhealth_contribTxtbox.Text = "426.25";
            }
            else if (grossincome > 31000 && grossincome <= 32000)
            {
                philhealth_contribTxtbox.Text = "440.00";
            }
            else if (grossincome > 32000 && grossincome <= 33000)
            {
                philhealth_contribTxtbox.Text = "453.75";
            }
            else if (grossincome > 33000 && grossincome <= 34000)
            {
                philhealth_contribTxtbox.Text = "467.50";
            }
            else if (grossincome > 34000 && grossincome <= 35000)
            {
                philhealth_contribTxtbox.Text = "481.25";
            }
            else if (grossincome > 35000 && grossincome <= 36000)
            {
                philhealth_contribTxtbox.Text = "495.00";
            }
            else if (grossincome > 36000 && grossincome <= 37000)
            {
                philhealth_contribTxtbox.Text = "508.75";
            }
            else if (grossincome > 37000 && grossincome <= 38000)
            {
                philhealth_contribTxtbox.Text = "522.50";
            }
            else if (grossincome > 38000 && grossincome <= 39000)
            {
                philhealth_contribTxtbox.Text = "536.25";
            }
            else if (grossincome > 39000 && grossincome <= 39999.99)
            {
                philhealth_contribTxtbox.Text = "543.13";
            }
            else
            {
                philhealth_contribTxtbox.Text = "550.00";
            }

            if (grossincome < 1000)
            {
                sss_contribTxtbox.Text = "0.00";
            }
            else if (grossincome >= 1000 && grossincome <= 1249.99)
            {
                sss_contribTxtbox.Text = "36.30";
            }
            else if (grossincome > 1250 && grossincome <= 1749.99)
            {
                sss_contribTxtbox.Text = "54.50";
            }
            else if (grossincome > 1750 && grossincome <= 2249.99)
            {
                sss_contribTxtbox.Text = "72.70";
            }
            else if (grossincome > 2250 && grossincome <= 2749.99)
            {
                sss_contribTxtbox.Text = "90.80";
            }
            else if (grossincome > 2750 && grossincome <= 3249.99)
            {
                sss_contribTxtbox.Text = "109.00";
            }
            else if (grossincome > 3250 && grossincome <= 3749.99)
            {
                sss_contribTxtbox.Text = "127.20";
            }
            else if (grossincome > 3750 && grossincome <= 4249.99)
            {
                sss_contribTxtbox.Text = "145.30";
            }
            else if (grossincome > 4250 && grossincome <= 4749.99)
            {
                sss_contribTxtbox.Text = "163.50";
            }
            else if (grossincome > 4750 && grossincome <= 5249.99)
            {
                sss_contribTxtbox.Text = "181.70";
            }
            else if (grossincome > 5250 && grossincome <= 5749.99)
            {
                sss_contribTxtbox.Text = "199.80";
            }
            else if (grossincome > 5750 && grossincome <= 6249.99)
            {
                sss_contribTxtbox.Text = "218.00";
            }
            else if (grossincome > 6250 && grossincome <= 6749.99)
            {
                sss_contribTxtbox.Text = "236.29";
            }
            else if (grossincome > 6750 && grossincome <= 7249.99)
            {
                sss_contribTxtbox.Text = "254.30";
            }
            else if (grossincome > 7250 && grossincome <= 7749.99)
            {
                sss_contribTxtbox.Text = "272.50";
            }
            else if (grossincome > 7750 && grossincome <= 8249.99)
            {
                sss_contribTxtbox.Text = "290.70";
            }
            else if (grossincome > 8250 && grossincome <= 8749.99)
            {
                sss_contribTxtbox.Text = "308.80";
            }
            else if (grossincome > 8750 && grossincome <= 9249.99)
            {
                sss_contribTxtbox.Text = "327.00";
            }
            else if (grossincome > 9250 && grossincome <= 9749.99)
            {
                sss_contribTxtbox.Text = "345.20";
            }
            else if (grossincome > 9750 && grossincome <= 10249.99)
            {
                sss_contribTxtbox.Text = "363.30";
            }
            else if (grossincome > 10250 && grossincome <= 10749.99)
            {
                sss_contribTxtbox.Text = "381.50";
            }
            else if (grossincome > 10750 && grossincome <= 11249.99)
            {
                sss_contribTxtbox.Text = "399.70";
            }
            else if (grossincome > 11250 && grossincome <= 11749.99)
            {
                sss_contribTxtbox.Text = "417.88";
            }
            else if (grossincome > 11750 && grossincome <= 12249.99)
            {
                sss_contribTxtbox.Text = "436.00";
            }
            else if (grossincome > 12250 && grossincome <= 12749.99)
            {
                sss_contribTxtbox.Text = "454.20";
            }
            else if (grossincome > 12750 && grossincome <= 13249.99)
            {
                sss_contribTxtbox.Text = "472.30";
            }
            else if (grossincome > 13250 && grossincome <= 13749.99)
            {
                sss_contribTxtbox.Text = "490.50";
            }
            else if (grossincome > 13750 && grossincome <= 14249.99)
            {
                sss_contribTxtbox.Text = "508.70";
            }
            else if (grossincome > 14250 && grossincome <= 14749.99)
            {
                sss_contribTxtbox.Text = "526.80";
            }
            else if (grossincome > 14750 && grossincome <= 15249.99)
            {
                sss_contribTxtbox.Text = "545.00";
            }
            else if (grossincome > 15250 && grossincome <= 15749.99)
            {
                sss_contribTxtbox.Text = "563.20";
            }
            else
            {
                sss_contribTxtbox.Text = "581.30";
            }

            //tax contribution per month on new table of TAX 2016
            if (grossincome < (250000 / 24))
            {
                tax_contribTxtbox.Text = "0.00";
            }
            else if (grossincome >= 10416.67 && grossincome <= 16666.67)
            {
                tax_contrib = ((((grossincome * 24) - 250000) * 0.20) / 24);
                tax_contribTxtbox.Text = tax_contrib.ToString("n");
            }
            else if (grossincome > 16666.67 && grossincome <= 33333.33)
            {
                tax_contrib = ((((grossincome * 24) - 400000) * 0.25) + 30000) / 24;
                tax_contribTxtbox.Text = tax_contrib.ToString("n");
            }
            else if (grossincome > 33333.33 && grossincome <= 83333.33)
            {
                tax_contrib = ((((grossincome * 24) - 800000) * 0.30) + 130000) / 24;
                tax_contribTxtbox.Text = tax_contrib.ToString("n");
            }
            else if (grossincome > 83333.33 && grossincome <= 333333.33)
            {
                tax_contrib = ((((grossincome * 24) - 2000000) * 0.32) + 490000) / 24;
                tax_contribTxtbox.Text = tax_contrib.ToString("n");
            }
            else
            {
                tax_contrib = ((((grossincome * 24) - 8000000) * 0.35) + 2410000) / 24;
                tax_contribTxtbox.Text = tax_contrib.ToString("n");
            }
        }

        private void Exit_Click_1(object sender, EventArgs e)
        {
          this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sss_contrib = Convert.ToDouble(sss_contribTxtbox.Text);
            pagibig_contrib = Convert.ToDouble(pagibig_contribTxtbox.Text);
            philhealth_contrib = Convert.ToDouble(philhealth_contribTxtbox.Text);
            tax_contrib = Convert.ToDouble(tax_contribTxtbox.Text);
            sss_loan = Convert.ToDouble(sss_loanTxtbox.Text);
            pagibig_loan = Convert.ToDouble(pagibig_loanTxtbox.Text);
            faculty_sav_loan = Convert.ToDouble(FSD_depositTxtbox.Text);
            salary_savings = Convert.ToDouble(FS_loanTxtbox.Text);
            other_deduction = Convert.ToDouble(others_loanTxtbox.Text);

            // formula to compute the desired data to be computed
            total_contrib = sss_contrib + pagibig_contrib + philhealth_contrib + tax_contrib;
            total_loan = sss_loan + pagibig_loan + salary_loan + faculty_sav_loan + salary_savings + other_deduction;
            total_deduction = total_contrib + total_loan;

            // codes for converting numeric data to string and displayed it inside the textboxes
            total_deducTxtbox.Text = total_deduction.ToString("n");
            netincome = grossincome - total_deduction;
            net_incomeTxtbox.Text = netincome.ToString("n");
        }

        private void PreviewPayslip_Click(object sender, EventArgs e)
        {
            payslip_viewListBox.Items.Add("------------------------------------------------------------");
            payslip_viewListBox.Items.Add("------------------------------------------------------------");
            payslip_viewListBox.Items.Add("EMPLOYEE NUMBER: " + " "
                + empNumberTxtBox.Text);
            payslip_viewListBox.Items.Add("FIRSTNAME: " + " "
                + firstnameTxtbox.Text);
            payslip_viewListBox.Items.Add("------------------------------------------------------------");
            payslip_viewListBox.Items.Add("------------------------------------------------------------");
            payslip_viewListBox.Items.Add("MIDDLENAME: " + " " + MNameTxtbox.Text);
            payslip_viewListBox.Items.Add("SURNAME: " + " " + surnameTxtBox.Text);
            payslip_viewListBox.Items.Add("DESIGNATION: " + " " + designationTxtBox.Text);
            payslip_viewListBox.Items.Add("EMPLOYEE STATUS: " + " " + emp_statusTxtbox.Text);
            payslip_viewListBox.Items.Add("DEPARTMENT: " + " " + departmentTxtBox.Text);
            payslip_viewListBox.Items.Add("PAYDATE: " + " " + paydateDatePicker.Text);
            payslip_viewListBox.Items.Add("------------------------------------------------------------");
            payslip_viewListBox.Items.Add("------------------------------------------------------------");
            payslip_viewListBox.Items.Add("BP Num. of Hrs.: " + " " + basic_numhrsTxtbox.Text);
            payslip_viewListBox.Items.Add("BP Rate / Hr.: " + " " + basic_rateTxtbox.Text);
            payslip_viewListBox.Items.Add("Basic Pay Income: " + " " + basic_netincomeTxtbox.Text);
            payslip_viewListBox.Items.Add("");
            payslip_viewListBox.Items.Add("------------------------------------------------------------");
            payslip_viewListBox.Items.Add("------------------------------------------------------------");
            payslip_viewListBox.Items.Add("HP Num. of Hrs.: " + " " + hono_numhrsTxtbox.Text);
            payslip_viewListBox.Items.Add("HP Rate / Hr.: " + " " + hono_rateTxtbox.Text);
            payslip_viewListBox.Items.Add("Honorarium Pay Income: " + " " + hono_netincomeTxtbox.Text);
            payslip_viewListBox.Items.Add("");
            payslip_viewListBox.Items.Add("------------------------------------------------------------");
            payslip_viewListBox.Items.Add("------------------------------------------------------------");
            payslip_viewListBox.Items.Add("OTI Num. of Hrs.: " + " " + other_numhrsTxtbox.Text);
            payslip_viewListBox.Items.Add("OTI Rate / Hr.: " + " " + other_rateTxtbox.Text);
            payslip_viewListBox.Items.Add("Other Income: " + " " + other_netincomeTxtbox.Text);
            payslip_viewListBox.Items.Add("------------------------------------------------------------");
            payslip_viewListBox.Items.Add("------------------------------------------------------------");
            payslip_viewListBox.Items.Add("SSS CONTRIBUTION: " + " " + sss_contribTxtbox.Text);
            payslip_viewListBox.Items.Add("PhilHealth CONTRIBUTION: " + " " + philhealth_contribTxtbox.Text);
            payslip_viewListBox.Items.Add("Pag-Ibig CONTRIBUTION: " + " " + pagibig_contribTxtbox.Text);
            payslip_viewListBox.Items.Add("Tax CONTRIBUTION: " + " " + tax_contribTxtbox.Text);
            payslip_viewListBox.Items.Add("------------------------------------------------------------");
            payslip_viewListBox.Items.Add("------------------------------------------------------------");
            payslip_viewListBox.Items.Add("SSS LOAN: " + " " + sss_loanTxtbox.Text);
            payslip_viewListBox.Items.Add("Pagibig LOAN: " + " " + pagibig_loanTxtbox.Text);
            payslip_viewListBox.Items.Add("Faculty Savings DEPOSIT: " + " " + FSD_depositTxtbox.Text);
            payslip_viewListBox.Items.Add("Faculty Savings LOAN: " + " " + FS_loanTxtbox.Text);
            payslip_viewListBox.Items.Add("Salary LOAN: " + " " + sal_loanTxtbox.Text);
            payslip_viewListBox.Items.Add("Other LOAN: " + " " + others_loanCombo.Text);
            payslip_viewListBox.Items.Add("------------------------------------------------------------");
            payslip_viewListBox.Items.Add("------------------------------------------------------------");
            payslip_viewListBox.Items.Add("------------------------------------------------------------");
            payslip_viewListBox.Items.Add("TOTAL DEDUCTIONS: " + " " + total_deducTxtbox.Text);
            payslip_viewListBox.Items.Add("GROSS INCOME: " + " " + gross_incomeTxtbox.Text);
            payslip_viewListBox.Items.Add("NET INCOME: " + " " + net_incomeTxtbox.Text);
            payslip_viewListBox.Items.Add("------------------------------------------------------------");
            payslip_viewListBox.Items.Add("------------------------------------------------------------");
        }

        private void print_Click(object sender, EventArgs e)
        {
            Form5_Listbox_ print1 = new Form5_Listbox_();
            print1.printDisplaylistBox.Items.AddRange(this.payslip_viewListBox.Items);
            print1.Show();
        }

        private void New_Click(object sender, EventArgs e)
        {
            cleartextboxes();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Double netincome = 0.00,
                grossincome = 0.00,
                sss_contrib = 0.00,
                pagibig_contrib = 0.00,
                philhealth_contrib = 0.00,
                tax_contrib = 0.00;

        private void basic_numhrs_TxtChange(object sender, EventArgs e)
        {

            try
            {
                basic_numhrs = Double.Parse(basic_numhrsTxtbox.Text);
                basic_rate = Convert.ToDouble(basic_rateTxtbox.Text);
                basic_netincome = basic_numhrs * basic_rate;
                basic_netincomeTxtbox.Text = basic_netincome.ToString("n");
            }
            catch (Exception)
            {
                basic_numhrsTxtbox.Clear();
            }
        }

        private Double sss_loan = 0.00,
               pagibig_loan = 0.00,
               salary_loan = 0.00,
               salary_savings = 0.00,
               faculty_sav_loan = 0.00,
               other_deduction = 0.00,
               total_deduction = 0.00,
               total_contrib = 0.00,
               total_loan = 0.00;
    }
}
