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
    public partial class Lesson14_Activity6 : Form
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

        public Lesson14_Activity6()
        {

            payroll_db_connect.payroll_connString();

            InitializeComponent();
        }

        private void Lesson14_Activity6_Load(object sender, EventArgs e)
        {
            payroll_db_connect.payroll_sql = "SELECT * FROM pos_empRegTbl";
            payroll_select();

            CenterPanel();
            this.Resize += (s, ev) => CenterPanel();
            isloading = true;
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            if (option_comboBox.Text == "employee_number")
            {
                payroll_db_connect.payroll_sql = "SELECT * FROM pos_empRegTbl WHERE emp_id = '" + optionInput_textBox.Text + "'";
                payroll_select();
                cleartextboxes1();
            }
            else if (option_comboBox.Text == "surname")
            {
                payroll_db_connect.payroll_sql = "SELECT * FROM pos_empRegTbl WHERE emp_surname = '" + optionInput_textBox.Text + "'";
                payroll_select();
                cleartextboxes1();
            }
            else if (option_comboBox.Text == "firstname")
            {
                payroll_db_connect.payroll_sql = "SELECT * FROM pos_empRegTbl WHERE emp_fname = '" + optionInput_textBox.Text + "'";
                payroll_select();
                cleartextboxes1();
            }
            else if (option_comboBox.Text == "department")
            {
                payroll_db_connect.payroll_sql = "SELECT * FROM pos_empRegTbl WHERE emp_department = '" + optionInput_textBox.Text + "'";
                payroll_select();
                cleartextboxes1();
            }
            else if (option_comboBox.Text == "designation")
            {
                payroll_db_connect.payroll_sql = "SELECT * FROM pos_empRegTbl WHERE position = '" + optionInput_textBox.Text + "'";
                payroll_select();
                cleartextboxes1();
            }
            else if (option_comboBox.Text == "zipcode")
            {
                payroll_db_connect.payroll_sql = "SELECT * FROM pos_empRegTbl WHERE add_zipcode = '" + optionInput_textBox.Text + "'";
                payroll_select();
                cleartextboxes1();
            }
            else if (option_comboBox.Text == "province")
            {
                payroll_db_connect.payroll_sql = "SELECT * FROM pos_empRegTbl WHERE add_state_province = '" + optionInput_textBox.Text + "'";
                payroll_select();
                cleartextboxes1();
            }
            else if (option_comboBox.Text == "city")
            {
                payroll_db_connect.payroll_sql = "SELECT * FROM pos_empRegTbl WHERE add_city = '" + optionInput_textBox.Text + "'";
                payroll_select();
                cleartextboxes1();
            }
            else
            {
                MessageBox.Show("No Available Record Found!");
            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            payroll_db_connect.payroll_sql = "SELECT * FROM pos_empRegTbl";
            payroll_select();
            cleartextboxes();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
