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

        private void form21Cashier2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2_1 newMDIChild = new Form2_1();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
         
        // POS Administrator
        private void form1Cashier1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 newMDIChild = new Form1();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void form21Cashier2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2_1 newMDIChild = new Form2_1();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        // Payroll
        private void payrolApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 newMDIChild = new Form6();
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
            Form5 newMDIChild = new Form5();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void studentRegistrationPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 newMDIChild = new Form4();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }
    }
}
