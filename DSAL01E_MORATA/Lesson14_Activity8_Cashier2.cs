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
    public partial class Lesson14_Activity8_Cashier2 : Form
    {
        pos_dbconnection posdb_connect = new pos_dbconnection();
        private bool isloading = true;

        private void CenterPanel()
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
        }

        private void pos_select()
        { 
            posdb_connect.pos_cmd();
            posdb_connect.pos_sqladapterSelect();
            posdb_connect.pos_sqldatasetSELECT();
            dataGridView1.DataSource = posdb_connect.pos_sql_dataset.Tables[0];
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

        public Lesson14_Activity8_Cashier2()
        {
            posdb_connect.pos_connString();
            InitializeComponent();
        }

        private void Lesson14_Activity8_Load(object sender, EventArgs e)
        {
            posdb_connect.pos_sql = "SELECT * FROM sales2Tbl";
            posdb_connect.pos_cmd();
            posdb_connect.pos_sqladapterSelect();
            posdb_connect.pos_sqldatasetSELECT();
            dataGridView1.DataSource = posdb_connect.pos_sql_dataset.Tables[0];

            CenterPanel();
            this.Resize += (s, ev) => CenterPanel();
            isloading = true;
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            if (option_comboBox.Text == "transaction2_id")
            {
                posdb_connect.pos_sql = "SELECT * FROM sales2Tbl WHERE transaction2_id = '" + optionInput_textBox.Text + "'";
                pos_select();
                cleartextboxes1();
            }
            else if (option_comboBox.Text == "food_order_choice")
            {
                posdb_connect.pos_sql = "SELECT * FROM sales2Tbl WHERE food_order_choice = '" + optionInput_textBox.Text + "'";
                pos_select();
                cleartextboxes1();
            }
            else if (option_comboBox.Text == "price")
            {
                posdb_connect.pos_sql = "SELECT * FROM sales2Tbl WHERE price = '" + optionInput_textBox.Text + "'";
                pos_select();
                cleartextboxes1();
            }
            else if (option_comboBox.Text == "discounted_amount")
            {
                posdb_connect.pos_sql = "SELECT * FROM sales2Tbl WHERE discounted_amount = '" + optionInput_textBox.Text + "'";
                pos_select();
                cleartextboxes1();
            }
            else if (option_comboBox.Text == "total_bills")
            {
                posdb_connect.pos_sql = "SELECT * FROM sales2Tbl WHERE total_bills = '" + optionInput_textBox.Text + "'";
                pos_select();
                cleartextboxes1();
            }
            else if (option_comboBox.Text == "total_quantity")
            {
                posdb_connect.pos_sql = "SELECT * FROM sales2Tbl WHERE total_quantity = '" + optionInput_textBox.Text + "'";
                pos_select();
                cleartextboxes1();
            }
            else
            {
                MessageBox.Show("No Available Record Found!");
            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            posdb_connect.pos_sql = "SELECT * FROM sales2Tbl";
            pos_select();
            cleartextboxes();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
