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
    public partial class Lesson14_Activity9 : Form
    {
        useraccount_db_connection useraccount_db_connect = new useraccount_db_connection();

        private bool isloading = true;

        public Lesson14_Activity9()
        {
            useraccount_db_connect.useraccount_connString();
            InitializeComponent();
        }

        private void cleartextboxes()
        {
            empID_textBox.Clear();
            userID_textBox.Clear();
            firstName_textBox.Clear();
            middleName_textBox.Clear();
            surname_textBox.Clear();
            designation_textBox.Clear();
            picPath_textBox.Clear();
            username_textBox.Clear();
            password_textBox.Clear();
            confirmPass_textBox.Clear();
            status_comboBox.SelectedIndex = -1;
            accType_comboBox.SelectedIndex = -1;

            pictureBox1.Image = Properties.Resources.default_image;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Lesson14_Activity9_Load(object sender, EventArgs e)
        {
            firstName_textBox.Enabled = false;
            middleName_textBox.Enabled = false;
            surname_textBox.Enabled = false;
            designation_textBox.Enabled = false;
            picPath_textBox.Enabled = false;
            picPath_textBox.Hide();

            useraccount_db_connect.useraccount_sql = "SELECT pos_empRegTbl.emp_id, emp_fname, emp_mname, emp_surname, position, user_id, username, password, user_status, account_type FROM pos_empRegTbl INNER JOIN useraccountTbl ON pos_empRegTbl.emp_id = useraccountTbl.emp_id";

            useraccount_db_connect.useraccount_cmd();
            useraccount_db_connect.useraccount_sqladapterSelect();
            useraccount_db_connect.useraccount_sqldatasetSELECT();

            dataGridView1.DataSource = useraccount_db_connect.useraccount_sql_dataset.Tables[0];

            CenterPanel();
            this.Resize += (s, ev) => CenterPanel();
            isloading = true;

            pictureBox1.Image = Properties.Resources.default_image;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            useraccount_db_connect.useraccount_sql = "SELECT emp_id, emp_fname, emp_mname, emp_surname, position, picpath FROM pos_empRegTbl WHERE emp_id = '" + empID_textBox.Text + "'";
            useraccount_db_connect.useraccount_cmd();
            useraccount_db_connect.useraccount_sqladapterSelect();
            useraccount_db_connect.useraccount_sqldatasetSELECT();

            firstName_textBox.Text = useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows[0][1].ToString();
            middleName_textBox.Text = useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows[0][2].ToString();
            surname_textBox.Text = useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows[0][3].ToString();
            designation_textBox.Text = useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows[0][4].ToString();
            picPath_textBox.Text = useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows[0][5].ToString();
            pictureBox1.Image = Image.FromFile(picPath_textBox.Text);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void searchForUpd_button_Click(object sender, EventArgs e)
        {
            useraccount_db_connect.useraccount_sql = "SELECT pos_empRegTbl.emp_id, emp_fname, emp_mname, emp_surname, position, picpath, user_id, username, password, user_status, account_type FROM pos_empRegTbl INNER JOIN useraccountTbl ON pos_empRegTbl.emp_id = useraccountTbl.emp_id WHERE user_id = '" + userID_textBox.Text + "'";

            useraccount_db_connect.useraccount_cmd();
            useraccount_db_connect.useraccount_sqladapterSelect();
            useraccount_db_connect.useraccount_sqldatasetSELECT();

            dataGridView1.DataSource = useraccount_db_connect.useraccount_sql_dataset.Tables[0];

            firstName_textBox.Text = useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows[0][1].ToString();
            middleName_textBox.Text = useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows[0][2].ToString();
            surname_textBox.Text = useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows[0][3].ToString();
            designation_textBox.Text = useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows[0][4].ToString();
            picPath_textBox.Text = useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows[0][5].ToString();
            pictureBox1.Image = Image.FromFile(picPath_textBox.Text);
            username_textBox.Text = useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows[0][7].ToString();
            password_textBox.Text = useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows[0][8].ToString();
            status_comboBox.Text = useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows[0][9].ToString();
            accType_comboBox.Text = useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows[0][10].ToString();
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            useraccount_db_connect.useraccount_sql = "UPDATE useraccountTbl SET account_type = '" + accType_comboBox.Text + "', username = '" + username_textBox.Text + "', password = '" + password_textBox.Text + "', confirm_password = '" + confirmPass_textBox.Text + "', user_status = '" + status_comboBox.Text + "' WHERE user_id = '" + userID_textBox.Text + "'";
            useraccount_db_connect.useraccount_cmd();
            useraccount_db_connect.useraccount_sqladapterDelete();

            useraccount_db_connect.useraccount_sql = "SELECT pos_empRegTbl.emp_id, emp_fname, emp_mname, emp_surname, position, user_id, username, password, user_status, account_type FROM pos_empRegTbl INNER JOIN useraccountTbl ON pos_empRegTbl.emp_id = useraccountTbl.emp_id";
            useraccount_db_connect.useraccount_cmd();
            useraccount_db_connect.useraccount_sqladapterSelect();
            useraccount_db_connect.useraccount_sqldatasetSELECT();

            dataGridView1.DataSource = useraccount_db_connect.useraccount_sql_dataset.Tables[0];

            cleartextboxes();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            useraccount_db_connect.useraccount_sql = "DELETE FROM useraccountTbl WHERE user_id = '" + userID_textBox.Text + "'";
            useraccount_db_connect.useraccount_cmd();
            useraccount_db_connect.useraccount_sqladapterDelete();

            useraccount_db_connect.useraccount_sql = "SELECT pos_empRegTbl.emp_id, emp_fname, emp_mname, emp_surname, position, picpath, user_id, username, password, user_status, account_type FROM pos_empRegTbl INNER JOIN useraccountTbl ON pos_empRegTbl.emp_id = useraccountTbl.emp_id";
            useraccount_db_connect.useraccount_cmd();
            useraccount_db_connect.useraccount_sqladapterSelect();
            useraccount_db_connect.useraccount_sqldatasetSELECT();

            dataGridView1.DataSource = useraccount_db_connect.useraccount_sql_dataset.Tables[0];
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            useraccount_db_connect.useraccount_sql = "INSERT INTO useraccountTbl (user_id, account_type, username, password, confirm_password, user_status, emp_id) VALUES ('" + userID_textBox.Text + "', '" + accType_comboBox.Text + "', '" + username_textBox.Text + "', '" + password_textBox.Text + "', '" + confirmPass_textBox.Text + "', '" + status_comboBox.Text + "', '" + empID_textBox.Text + "')";
            useraccount_db_connect.useraccount_cmd();
            useraccount_db_connect.useraccount_sqladapterInsert();

            useraccount_db_connect.useraccount_sql = "SELECT pos_empRegTbl.emp_id, emp_fname, emp_mname, emp_surname, position, picpath, user_id, username, password, user_status, account_type FROM pos_empRegTbl INNER JOIN useraccountTbl ON pos_empRegTbl.emp_id = useraccountTbl.emp_id";
            useraccount_db_connect.useraccount_cmd();
            useraccount_db_connect.useraccount_sqladapterSelect();
            useraccount_db_connect.useraccount_sqldatasetSELECT();

            dataGridView1.DataSource = useraccount_db_connect.useraccount_sql_dataset.Tables[0];
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CenterPanel()
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            cleartextboxes();
        }
    }
}
