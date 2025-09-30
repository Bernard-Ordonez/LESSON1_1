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
    public partial class Form5_Listbox_ : Form
    {
        public Form5_Listbox_()
        {
            InitializeComponent();
            printDisplaylistBox.Items.AddRange(printDisplaylistBox.Items);
        }

        private void Form5_Listbox__Load(object sender, EventArgs e)
        {

        }
    }
}
