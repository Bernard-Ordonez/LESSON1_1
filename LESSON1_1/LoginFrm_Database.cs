using LESSON1_1;
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
    public partial class LoginFrm_Database : Form
    {
        private String username1, password1, user_level;
        employee_dbconnection emp_db_connect = new employee_dbconnection();
        loginDb_dbconnections login_db_connect = new loginDb_dbconnections();

        public LoginFrm_Database()
        {
            login_db_connect.login_connString();
            InitializeComponent();
        }

        private void cleartextboxes()
        {
            username_textBox.Clear();
            username_textBox.Focus();
            password_textBox.Clear();
        }

        private void LoginFrm_Database_Load(object sender, EventArgs e)
        {
            username_textBox.Focus();
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            try
            {
                login_db_connect.login_sql = "SELECT pos_empRegTbl.emp_id, emp_fname, emp_surname, username, password, account_type, pos_terminal_no FROM pos_empRegTbl INNER JOIN useraccountTbl ON pos_empRegTbl.emp_id = useraccountTbl.emp_id WHERE username = '" + username_textBox.Text + "' AND password = '" + password_textBox.Text + "'";
                login_db_connect.login_cmd();
                login_db_connect.login_sqladapterSelect();
                login_db_connect.login_sqldatasetSELECT();

                username1 = login_db_connect.login_sql_dataset.Tables[0].Rows[0][3].ToString();
                password1 = login_db_connect.login_sql_dataset.Tables[0].Rows[0][4].ToString();
                user_level = login_db_connect.login_sql_dataset.Tables[0].Rows[0][5].ToString();

                if ((username1 == username_textBox.Text) && (password1 == password_textBox.Text))
                {
                    if (user_level == "Administrator")
                    {
                        MessageBox.Show("Access granted");
                        AdminPage myform = new AdminPage();
                        myform.Show();
                        cleartextboxes();
                        this.Hide();
                    }
                    else if (user_level == "Cashier1")
                    {
                        MessageBox.Show("Access granted");
                        SQL_Cashier2 myform = new SQL_Cashier2();
                        cleartextboxes();
                        myform.Show();
                    }
                    else if (user_level == "Cashier2")
                    {
                        MessageBox.Show("Access granted");
                        SQL_Cashier1 myform = new SQL_Cashier1();
                        myform.pcTerminal_INPUT_label.Text = login_db_connect.login_sql_dataset.Tables[0].Rows[0][6].ToString();
                        myform.empIDINPUT_label.Text = login_db_connect.login_sql_dataset.Tables[0].Rows[0][0].ToString();
                        myform.empFNameINPUT_label.Text = login_db_connect.login_sql_dataset.Tables[0].Rows[0][1].ToString();
                        myform.empSNameINPUT_label.Text = login_db_connect.login_sql_dataset.Tables[0].Rows[0][2].ToString();
                        DateTime dateTime = DateTime.Now;
                        myform.dateINPUT_label.Text = dateTime.ToString("MMMM dd, yyyy");
                        cleartextboxes();
                        myform.Show();
                    }
                    else if (user_level == "HR Staff")
                    {
                        MessageBox.Show("Access granted");
                        employee_registration myform = new employee_registration();
                        myform.button5.Enabled = false;
                        cleartextboxes();
                        myform.Show();
                    }
                    else if (user_level == "Accounting Staff")
                    {
                        MessageBox.Show("Access granted");
                        Payrol_DatabaseApp myform = new Payrol_DatabaseApp();
                        myform.button10.Hide();
                        myform.button8.Hide();
                        myform.button9.Hide();
                        cleartextboxes();
                        myform.Show();
                    }
                    else if (user_level == "IT Staff")
                    {
                        MessageBox.Show("Access granted");
                        user_account myform = new user_account();
                        myform.button2.Hide();
                        myform.button4.Hide();
                        myform.button3.Hide();
                        cleartextboxes();
                        myform.Show();
                    }
                    else
                    {
                        MessageBox.Show("Access Denied");
                        cleartextboxes();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                }
            }
            catch
            {
                MessageBox.Show("Please contact your administrator!");
            }
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
