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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(new object[]
            {
            "Computer Engineering",
            "Mechanical Engineering",
            "Industrial Engineering",
            "Electronics Communications Engineering",
            "Civil Engineering"
            });

            textBox19.Enabled = false;
            textBox18.Enabled = false;
            textBox16.Enabled = false;
            textBox12.Enabled = false;
            textBox15.Enabled = false;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(ofd.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        
        private const decimal TuitionPerUnit = 1500;
        private decimal accumulatedTotalFee = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            {
                int unitLec = 0;
                if (int.TryParse(textBox8.Text, out int lecParsed))
                    unitLec = lecParsed;

                int unitLab = 0;
                if (int.TryParse(textBox9.Text, out int labParsed))
                    unitLab = labParsed;

                decimal labFee = 0;
                if (decimal.TryParse(textBox17.Text, out decimal labParsedFee))
                    labFee = labParsedFee;

                decimal compLabFee = 0;
                if (decimal.TryParse(textBox22.Text, out decimal compParsedFee))
                    compLabFee = compParsedFee;

                decimal ciscoFee = 0;
                if (decimal.TryParse(textBox23.Text, out decimal ciscoParsedFee))
                    ciscoFee = ciscoParsedFee;

                decimal examFee = 0;
                if (decimal.TryParse(textBox24.Text, out decimal examParsedFee))
                    examFee = examParsedFee;

                int creditUnits = unitLec + unitLab;
                decimal tuitionFee = creditUnits * TuitionPerUnit;
                decimal miscFee = labFee + compLabFee + ciscoFee + examFee;
                decimal totalFee = tuitionFee + miscFee;

                accumulatedTotalFee += totalFee;

                textBox19.Text = creditUnits.ToString();
                textBox18.Text = creditUnits.ToString();
                textBox16.Text = tuitionFee.ToString("N2");
                textBox15.Text = miscFee.ToString("N2");
                textBox12.Text = accumulatedTotalFee.ToString("N2");

                textBox20.Text = tuitionFee.ToString("N2");
                textBox21.Text = miscFee.ToString("N2");
                textBox26.Text = creditUnits.ToString();
                textBox27.Text = totalFee.ToString("N2");

                textBox20.Enabled = false;
                textBox21.Enabled = false;
                textBox26.Enabled = false;
                textBox25.Enabled = false;
                textBox27.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string courseCode = textBox5.Text;          
            string courseDesc = textBox7.Text;          
            string unitLec = textBox8.Text;            
            string unitLab = textBox9.Text;               
            string creditUnits = textBox19.Text;       
            string time = textBox10.Text;                     
            string day = textBox11.Text;                        

            int rowNumber = listBox1.Items.Count + 1;

            listBox1.Items.Add(rowNumber.ToString());   
            listBox2.Items.Add(courseCode);             
            listBox3.Items.Add(courseDesc);             
            listBox4.Items.Add(unitLec);               
            listBox5.Items.Add(unitLab);               
            listBox6.Items.Add(creditUnits);           
            listBox7.Items.Add(time);                   
            listBox8.Items.Add(day);                    
        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {
            textBox22.Text = textBox17.Text;
        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {
            textBox23.Text = textBox14.Text;
        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {
            textBox24.Text = textBox13.Text;
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            textBox22.Text = textBox17.Text;
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            textBox23.Text = textBox14.Text;
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            textBox24.Text = textBox13.Text;
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            textBox25.Text = textBox15.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox tb && tb != textBox12)
                {
                    tb.Clear();
                    tb.Enabled = true;
                }
            }

            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            listBox6.Items.Clear();
            listBox7.Items.Clear();
            listBox8.Items.Clear();

            comboBox1.SelectedIndex = -1;
            pictureBox1.Image = null;
        }
    }
}
