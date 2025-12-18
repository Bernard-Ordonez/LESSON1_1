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
    public partial class Lesson6_MainForm : Form
    {
        public Lesson6_MainForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void jeePOSIncToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //codes for calling the form to be displayed once the submenu has been clicked
            Lesson14_Activity2 newMDIChild = new Lesson14_Activity2();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void jeePOSOrderingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //codes for calling the form to be displayed once the submenu has been clicked
            Lesson14_Activity3 newMDIChild = new Lesson14_Activity3();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void simplePOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //codes for calling the form to be displayed once the submenu has been clicked
            Lesson4_Example1 newMDIChild = new Lesson4_Example1();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void titleVerticalToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void payrollApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //codes for calling the form to be displayed once the submenu has been clicked
            Prelim_Exam2_Lesson5Activity newMDIChild = new Prelim_Exam2_Lesson5Activity();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void Lesson6_MainForm_Load(object sender, EventArgs e)
        {

        }

        private void pOSAdministratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //codes for calling the form to be displayed once the submenu has been clicked
            POS_Admin newMDIChild = new POS_Admin();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void userAccountPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //codes for calling the form to be displayed once the submenu has been clicked
            Lesson14_Activity9 newMDIChild = new Lesson14_Activity9();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void payrollToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //codes for calling the form to be displayed once the submenu has been clicked
            Lesson14_Activity5 newMDIChild = new Lesson14_Activity5();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void employeeInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //codes for calling the form to be displayed once the submenu has been clicked
            Lesson14_Activity9 newMDIChild = new Lesson14_Activity9();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void pOSAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //codes for calling the form to be displayed once the submenu has been clicked
            POS_Admin newMDIChild = new POS_Admin();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void userAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //codes for calling the form to be displayed once the submenu has been clicked
            Lesson14_Activity4 newMDIChild = new Lesson14_Activity4();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void employeeReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //codes for calling the form to be displayed once the submenu has been clicked
            Lesson14_Activity6 newMDIChild = new Lesson14_Activity6();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void payrollReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //codes for calling the form to be displayed once the submenu has been clicked
            Lesson14_Activity7 newMDIChild = new Lesson14_Activity7();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void pOSCashier1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //codes for calling the form to be displayed once the submenu has been clicked
            Lesson14_Activity8_Cashier2 newMDIChild = new Lesson14_Activity8_Cashier2();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void pOSCashier2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //codes for calling the form to be displayed once the submenu has been clicked
            Lesson14_Activity8_Cashier1 newMDIChild = new Lesson14_Activity8_Cashier1();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void userReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //codes for calling the form to be displayed once the submenu has been clicked
            Lesson14_Activity10 newMDIChild = new Lesson14_Activity10();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void pOS1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //codes for calling the form to be displayed once the submenu has been clicked
            POS1_functionForm newMDIChild = new POS1_functionForm();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void pOS2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //codes for calling the form to be displayed once the submenu has been clicked
            POS2_functionForm newMDIChild = new POS2_functionForm();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void payrollUsingIFELSEIFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //codes for calling the form to be displayed once the submenu has been clicked
            Prelim_Exam2_Lesson5Activity newMDIChild = new Prelim_Exam2_Lesson5Activity();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void payrollUsingCLASSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //codes for calling the form to be displayed once the submenu has been clicked
            Payroll_classForm newMDIChild = new Payroll_classForm();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void example3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //codes for calling the form to be displayed once the submenu has been clicked
            Lesson5_Example7 newMDIChild = new Lesson5_Example7();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void example4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //codes for calling the form to be displayed once the submenu has been clicked
            Lesson5_Example6 newMDIChild = new Lesson5_Example6();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void example2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //codes for calling the form to be displayed once the submenu has been clicked
            Lesson4_Example2 newMDIChild = new Lesson4_Example2();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void example1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //codes for calling the form to be displayed once the submenu has been clicked
            Lesson4_Example1 newMDIChild = new Lesson4_Example1();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void databaseLongMethodSampleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //codes for calling the form to be displayed once the submenu has been clicked
            Lesson13_Example1 newMDIChild = new Lesson13_Example1();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void pOSAdminToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //codes for calling the form to be displayed once the submenu has been clicked
            POS_Admin newMDIChild = new POS_Admin();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void pOS1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //codes for calling the form to be displayed once the submenu has been clicked
            Lesson14_Activity2 newMDIChild = new Lesson14_Activity2();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void pOS2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //codes for calling the form to be displayed once the submenu has been clicked
            Lesson14_Activity3 newMDIChild = new Lesson14_Activity3();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void payrollAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //codes for calling the form to be displayed once the submenu has been clicked
            Lesson14_Activity5 newMDIChild = new Lesson14_Activity5();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void employeeRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //codes for calling the form to be displayed once the submenu has been clicked
            Lesson14_Activity4 newMDIChild = new Lesson14_Activity4();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void userAccountRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //codes for calling the form to be displayed once the submenu has been clicked
            Lesson14_Activity9 newMDIChild = new Lesson14_Activity9();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }
    }
}
