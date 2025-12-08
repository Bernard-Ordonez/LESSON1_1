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
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
        }

        // POS Cashier
        private void form1Cashier1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 newMDIChild = new Form1();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }
        private void cashier2Form4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 newMDIChild = new Form3();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void form21Cashier2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            POS1_functionfrm newMDIChild = new POS1_functionfrm();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // POS Administrator
        private void simplePOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 newMDIChild = new Form1();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }
        private void form1Cashier1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            POS1_functionfrm newMDIChild = new POS1_functionfrm();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void form21Cashier2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form3 newMDIChild = new Form3();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        // Payroll
        private void payrolApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Payroll_functionfrm newMDIChild = new Payroll_functionfrm();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        // Window
        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        // Bundle Promos
        private void userInfoPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 newMDIChild = new Form3();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void bundlePromo2Form5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            POS2_functionfrm newMDIChild = new POS2_functionfrm();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }
        
        // Accounting
        private void studentRegistrationPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 newMDIChild = new Form4();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        // Prelim
        private void prelimExamToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PrelimExam_Form5_ newMDIChild = new PrelimExam_Form5_();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void bundlePromoFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 newMDIChild = new Form3();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void bundlePromo2Form5ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            POS2_functionfrm newMDIChild = new POS2_functionfrm();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void payrolApplicationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            POS2_functionfrm newMDIChild = new POS2_functionfrm();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void studentRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 newMDIChild = new Form4();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to AdminPage", "Greeting", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
