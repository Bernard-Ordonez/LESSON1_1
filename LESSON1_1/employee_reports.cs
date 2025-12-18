using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LESSON1_1
{
    public partial class employee_reports : Form
    {
        payrol_dbconnection payrol_db_connect = new payrol_dbconnection();
        public employee_reports()
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
        private void employee_reports_Load(object sender, EventArgs e)
        {
            payrol_db_connect.payroll_sql = "SELECT * FROM pos_empRegTbl";
            payrol_select();
            optionCombo.Items.AddRange(new object[]
            {
                "employee_number",
                "surname",
                "firstname",
                "department",
                "designation",
                "zipcode",
                "province",
                "city"
            });

        }

        //SEARCH
        private void button1_Click(object sender, EventArgs e)
        {
            if (optionCombo.Text == "employee_number")
            {
                payrol_db_connect.payroll_sql = "SELECT * FROM pos_empRegTbl WHERE emp_id = '" + optionInputTxtbox.Text + "'";
                payrol_select();
                cleartextboxes1();
            }
            else if (optionCombo.Text == "surname")
            {
                payrol_db_connect.payroll_sql = "SELECT * FROM pos_empRegTbl WHERE emp_surname = '" + optionInputTxtbox.Text + "'";
                payrol_select();
                cleartextboxes1();
            }
            else if (optionCombo.Text == "Firstname")
            {
                payrol_db_connect.payroll_sql = "SELECT * FROM pos_empRegTbl WHERE emp_fname = '" + optionInputTxtbox.Text + "'";
                payrol_select();
                cleartextboxes1();
            }
            else if (optionCombo.Text == "department")
            {
                payrol_db_connect.payroll_sql = "SELECT * FROM pos_empRegTbl WHERE emp_department = '" + optionInputTxtbox.Text + "'";
                payrol_select();
                cleartextboxes1();
            }
            else if (optionCombo.Text == "designation")
            {
                payrol_db_connect.payroll_sql = "SELECT * FROM pos_empRegTbl WHERE position = '" + optionInputTxtbox.Text + "'";
                payrol_select();
                cleartextboxes1();
            }
            else if (optionCombo.Text == "zipcode")
            {
                payrol_db_connect.payroll_sql = "SELECT * FROM pos_empRegTbl WHERE add_zipcode = '" + optionInputTxtbox.Text + "'";
                payrol_select();
                cleartextboxes1();
            }
            else if (optionCombo.Text == "province")
            {
                payrol_db_connect.payroll_sql = "SELECT * FROM pos_empRegTbl WHERE add_state_province = '" + optionInputTxtbox.Text + "'";
                payrol_select();
                cleartextboxes1();
            }
            else if (optionCombo.Text == "city")
            {
                payrol_db_connect.payroll_sql = "SELECT * FROM pos_empRegTbl WHERE add_city = '" + optionInputTxtbox.Text + "'";
                payrol_select();
                cleartextboxes1();
            }
            else
            {
                MessageBox.Show("No Available Record Found!");
            }
        }

        //BACK
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                payrol_db_connect.payroll_sql = "SELECT * FROM pos_empRegTbl";
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
