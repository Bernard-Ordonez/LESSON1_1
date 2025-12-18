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
    public partial class Lesson5_Example7_PrintForm : Form
    {
        public Lesson5_Example7_PrintForm()
        {
            InitializeComponent();
            //codes below is to display all the contents of the listbox in the main form
            printDisplayListBox.Items.AddRange(printDisplayListBox.Items);
        }

        private void Lesson5_Example7_PrintForm_Load(object sender, EventArgs e)
        {

        }
    }
}
