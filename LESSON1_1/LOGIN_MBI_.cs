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
    public partial class LOGIN_MBI_ : Form
    {
        public LOGIN_MBI_()
        {
            InitializeComponent();
        }
        private void LOGIN_MBI__Load(object sender, EventArgs e)
        {
            richTextBox1.Focus();
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Admin, AdminPass,
                Cashier1, Cashier1Pass,
                Cashier2, Cashier2Pass,
                Accounting, AccountingPass;

            Admin = "Admin";
            AdminPass = "AdminPass";

            Cashier1 = "Cashier1";
            Cashier1Pass = "Cashier1Pass";

            Cashier2 = "Cashier2";
            Cashier2Pass = "Cashier2Pass";

            Accounting = "Accounting";
            AccountingPass = "AccountingPass";

            if (richTextBox1.Text == Admin && richTextBox2.Text == AdminPass)
            {
                AdminPage newMDIChild = new AdminPage();
                newMDIChild.Show();
            }
            else if (richTextBox1.Text == Cashier1 && richTextBox2.Text == Cashier1Pass)
            {
                Form1 newMDIChild = new Form1();
                newMDIChild.Show();
            }
            else if (richTextBox1.Text == Cashier2 && richTextBox2.Text == Cashier2Pass)
            {
                Form2_1 newMDIChild = new Form2_1();
                newMDIChild.Show();
            }
            else if (richTextBox1.Text == Accounting && richTextBox2.Text == AccountingPass)
            {
                Form4 newMDIChild = new Form4();
                newMDIChild.Show();
            }
            else
            {
                MessageBox.Show("Wrong password or Username, try again",
                        "Login Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }
    }
}
