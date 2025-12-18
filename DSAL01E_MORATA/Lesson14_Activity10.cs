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
    public partial class Lesson14_Activity10 : Form
    {
        useraccount_db_connection useraccount_db_connect = new useraccount_db_connection();
        private bool isloading = true;

        private void CenterPanel()
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
        }

        private void useraccount_select()
        { 
            useraccount_db_connect.useraccount_cmd();
            useraccount_db_connect.useraccount_sqladapterSelect();
            useraccount_db_connect.useraccount_sqldatasetSELECT();
            dataGridView1.DataSource = useraccount_db_connect.useraccount_sql_dataset.Tables[0];
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

        public Lesson14_Activity10()
        {
            useraccount_db_connect.useraccount_connString();
            InitializeComponent();
        }

        private void Lesson14_Activity10_Load(object sender, EventArgs e)
        {
            useraccount_db_connect.useraccount_sql = "SELECT pos_empRegTbl.emp_id, emp_fname, emp_mname, emp_surname, emp_age, emp_gender, emp_department, position, user_id, username, password, user_status, account_type FROM pos_empRegTbl INNER JOIN useraccountTbl ON pos_empRegTbl.emp_id = useraccountTbl.emp_id";
            useraccount_select();

            CenterPanel();
            this.Resize += (s, ev) => CenterPanel();
            isloading = true;
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            if (option_comboBox.Text == "user_id")
            {
                useraccount_db_connect.useraccount_sql = "SELECT pos_empRegTbl.emp_id, emp_fname, emp_mname, emp_surname, emp_age, emp_gender, emp_department, position, user_id, username, password, user_status, account_type FROM pos_empRegTbl INNER JOIN useraccountTbl ON pos_empRegTbl.emp_id = useraccountTbl.emp_id WHERE user_id = '" + optionInput_textBox.Text + "'";
                useraccount_select();
                cleartextboxes1();
            }
            else if (option_comboBox.Text == "employee_number")
            {
                useraccount_db_connect.useraccount_sql = "SELECT pos_empRegTbl.emp_id, emp_fname, emp_mname, emp_surname, emp_age, emp_gender, emp_department, position, user_id, username, password, user_status, account_type FROM pos_empRegTbl INNER JOIN useraccountTbl ON pos_empRegTbl.emp_id = useraccountTbl.emp_id WHERE pos_empRegTbl.emp_id = '" + optionInput_textBox.Text + "'";
                useraccount_select();
                cleartextboxes1();
            }
            else if (option_comboBox.Text == "surname")
            {
                useraccount_db_connect.useraccount_sql = "SELECT pos_empRegTbl.emp_id, emp_fname, emp_mname, emp_surname, emp_age, emp_gender, emp_department, position, user_id, username, password, user_status, account_type FROM pos_empRegTbl INNER JOIN useraccountTbl ON pos_empRegTbl.emp_id = useraccountTbl.emp_id WHERE emp_surname = '" + optionInput_textBox.Text + "'";
                useraccount_select();
                cleartextboxes1();
            }
            else if (option_comboBox.Text == "firstname")
            {
                useraccount_db_connect.useraccount_sql = "SELECT pos_empRegTbl.emp_id, emp_fname, emp_mname, emp_surname, emp_age, emp_gender, emp_department, position, user_id, username, password, user_status, account_type FROM pos_empRegTbl INNER JOIN useraccountTbl ON pos_empRegTbl.emp_id = useraccountTbl.emp_id WHERE emp_fname = '" + optionInput_textBox.Text + "'";
                useraccount_select();
                cleartextboxes1();
            }
            else if (option_comboBox.Text == "active")
            {
                useraccount_db_connect.useraccount_sql = "SELECT pos_empRegTbl.emp_id, emp_fname, emp_mname, emp_surname, emp_age, emp_gender, emp_department, position, user_id, username, password, user_status, account_type FROM pos_empRegTbl INNER JOIN useraccountTbl ON pos_empRegTbl.emp_id = useraccountTbl.emp_id WHERE user_status = 'active'";
                useraccount_select();
                cleartextboxes1();
            }
            else if (option_comboBox.Text == "deactivate")
            {
                useraccount_db_connect.useraccount_sql = "SELECT pos_empRegTbl.emp_id, emp_fname, emp_mname, emp_surname, emp_age, emp_gender, emp_department, position, user_id, username, password, user_status, account_type FROM pos_empRegTbl INNER JOIN useraccountTbl ON pos_empRegTbl.emp_id = useraccountTbl.emp_id WHERE user_status = 'deactivate'";
                useraccount_select();
                cleartextboxes1();
            }
            else
            {
                MessageBox.Show("No Available Record Found!");
            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            useraccount_db_connect.useraccount_sql = "SELECT pos_empRegTbl.emp_id, emp_fname, emp_mname, emp_surname, emp_age, emp_gender, emp_department, position, user_id, username, password, user_status, account_type FROM pos_empRegTbl INNER JOIN useraccountTbl ON pos_empRegTbl.emp_id = useraccountTbl.emp_id";
            useraccount_select();
            cleartextboxes();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
