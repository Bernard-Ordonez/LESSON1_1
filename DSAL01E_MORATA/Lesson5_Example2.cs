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
    public partial class Lesson5_Example2 : Form
    {
        public Lesson5_Example2()
        {
            InitializeComponent();
        }

        private void compute_button_Click(object sender, EventArgs e)
        {
            double price, computed_discount;
            const double discount = 0.20D;

            try
            {
                price = Convert.ToDouble(productPrice_textBox.Text);
                if (price >= 2500)
                {
                    computed_discount = price * discount;
                    seniorCitizenDisc_textBox.Text = computed_discount.ToString("c");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Input data for price is invalid!");
                productPrice_textBox.Clear();
                productPrice_textBox.Focus();
            }
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void new_button_Click(object sender, EventArgs e)
        {
            productPrice_textBox.Clear();
            seniorCitizenDisc_textBox.Clear();
            productPrice_textBox.Focus();
        }
    }
}
