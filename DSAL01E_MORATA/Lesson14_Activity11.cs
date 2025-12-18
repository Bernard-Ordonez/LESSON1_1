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
    public partial class Lesson14_Activity11 : Form
    {
        private String username1, password1, user_level;
        employee_dbconnection emp_db_connect = new employee_dbconnection();
        loginDb_dbconnections login_db_connect = new loginDb_dbconnections();

        private bool isloading = true;

        private void CenterPanel()
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
        }

        public Lesson14_Activity11()
        {
            login_db_connect.login_connString();
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void cleartextboxes()
        {
            username_textBox.Clear();
            username_textBox.Focus();
            password_textBox.Clear();
        }

        private void Lesson14_Activity11_Load(object sender, EventArgs e)
        {
            username_textBox.Focus();

            this.BackgroundImage = Properties.Resources.GUI_BG; // Replace with your actual image name
            this.BackgroundImageLayout = ImageLayout.Stretch; // Makes the image fit the form size

            pictureBox1.Image = Properties.Resources.LAB_login;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            CenterPanel();
            this.Resize += (s, ev) => CenterPanel();
            isloading = true;
        }

        private void password_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_button_Click(object sender, EventArgs e)
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
                        Lesson6_MainForm myform = new Lesson6_MainForm();
                        myform.Show();
                        cleartextboxes();
                        this.Hide();
                    }
                    else if (user_level == "Cashier1")
                    {
                        MessageBox.Show("Access granted");
                        Lesson14_Activity3 myform = new Lesson14_Activity3();
                        cleartextboxes();
                        myform.Show();
                    }
                    else if (user_level == "Cashier2")
                    {
                        MessageBox.Show("Access granted");
                        Lesson14_Activity2 myform = new Lesson14_Activity2();
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
                        Lesson14_Activity4 myform = new Lesson14_Activity4();
                        myform.delete_button.Enabled = false;
                        cleartextboxes();
                        myform.Show();
                    }
                    else if (user_level == "Accounting Staff")
                    {
                        MessageBox.Show("Access granted");
                        Lesson14_Activity5 myform = new Lesson14_Activity5();
                        myform.search_edit_button.Hide();
                        myform.edit_button.Hide();
                        myform.delete_button.Hide();
                        cleartextboxes();
                        myform.Show();
                    }
                    else if (user_level == "IT Staff")
                    {
                        MessageBox.Show("Access granted");
                        Lesson14_Activity9 myform = new Lesson14_Activity9();
                        myform.searchForUpd_button.Hide();
                        myform.update_button.Hide();
                        myform.delete_button.Hide();
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
