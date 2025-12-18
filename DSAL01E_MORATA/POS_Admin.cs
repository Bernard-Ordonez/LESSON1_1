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
    public partial class POS_Admin : Form
    {
        private bool isloading = true;

        pos_dbconnection posdb_connect = new pos_dbconnection();
        private string picpath;
        private Image pic;
        

        OpenFileDialog openFileDialog1;

        public POS_Admin()
        {
            posdb_connect.pos_connString();
            InitializeComponent();
            openFileDialog1 = new OpenFileDialog();
        }

        private void CenterPanel()
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
        }

        private void Lesson14_Activity1_Load(object sender, EventArgs e)
        {
            CenterPanel();
            this.Resize += (s, ev) => CenterPanel();
            isloading = true;

            this.BackgroundImage = Properties.Resources.BG2; 
            this.BackgroundImageLayout = ImageLayout.Stretch;

            picpath_textBox1.Hide(); picpath_textBox2.Hide();
            picpath_textBox3.Hide(); picpath_textBox4.Hide();
            picpath_textBox5.Hide(); picpath_textBox6.Hide();
            picpath_textBox7.Hide(); picpath_textBox8.Hide();
            picpath_textBox9.Hide(); picpath_textBox10.Hide();
            picpath_textBox11.Hide(); picpath_textBox12.Hide();
            picpath_textBox13.Hide(); picpath_textBox14.Hide();
            picpath_textBox15.Hide(); picpath_textBox16.Hide();
            picpath_textBox17.Hide(); picpath_textBox18.Hide();
            picpath_textBox19.Hide(); picpath_textBox20.Hide();

            // accessing the pos_dbconnection.cs Class to connect the form to the database
            posdb_connect.pos_select();
            posdb_connect.pos_cmd();
            posdb_connect.pos_sqladapterSelect();
            posdb_connect.pos_sqldatasetSELECT();

            dataGridView1.DataSource = posdb_connect.pos_sql_dataset.Tables[0];
        }

        private void cleartextboxes()
        {
            
                pic = Properties.Resources.default_image;

                picpath_textBox1.Clear(); picpath_textBox2.Clear(); picpath_textBox3.Clear();
                picpath_textBox4.Clear(); picpath_textBox5.Clear(); picpath_textBox6.Clear();
                picpath_textBox7.Clear(); picpath_textBox8.Clear(); picpath_textBox9.Clear();
                picpath_textBox10.Clear(); picpath_textBox11.Clear(); picpath_textBox12.Clear();
                picpath_textBox13.Clear(); picpath_textBox14.Clear(); picpath_textBox15.Clear();
                picpath_textBox16.Clear(); picpath_textBox17.Clear(); picpath_textBox18.Clear();
                picpath_textBox19.Clear(); picpath_textBox20.Clear();

                pictureBox1.Image = pic; pictureBox2.Image = pic; pictureBox3.Image = pic;
                pictureBox4.Image = pic; pictureBox5.Image = pic; pictureBox6.Image = pic;
                pictureBox7.Image = pic; pictureBox8.Image = pic; pictureBox9.Image = pic;
                pictureBox10.Image = pic; pictureBox11.Image = pic; pictureBox12.Image = pic;
                pictureBox13.Image = pic; pictureBox14.Image = pic; pictureBox15.Image = pic;
                pictureBox16.Image = pic; pictureBox17.Image = pic; pictureBox18.Image = pic;
                pictureBox19.Image = pic; pictureBox20.Image = pic;

                price_textBox1.Clear(); price_textBox2.Clear(); price_textBox3.Clear();
                price_textBox4.Clear(); price_textBox5.Clear(); price_textBox6.Clear();
                price_textBox7.Clear(); price_textBox8.Clear(); price_textBox9.Clear();
                price_textBox10.Clear(); price_textBox11.Clear(); price_textBox12.Clear();
                price_textBox13.Clear(); price_textBox14.Clear(); price_textBox15.Clear();
                price_textBox16.Clear(); price_textBox17.Clear(); price_textBox18.Clear();
                price_textBox19.Clear(); price_textBox20.Clear();

                name_textBox1.Clear(); name_textBox2.Clear(); name_textBox3.Clear();
                name_textBox4.Clear(); name_textBox5.Clear(); name_textBox6.Clear();
                name_textBox7.Clear(); name_textBox8.Clear(); name_textBox9.Clear();
                name_textBox10.Clear(); name_textBox11.Clear(); name_textBox12.Clear();
                name_textBox13.Clear(); name_textBox14.Clear(); name_textBox15.Clear();
                name_textBox16.Clear(); name_textBox17.Clear(); name_textBox18.Clear();
                name_textBox19.Clear(); name_textBox20.Clear();
        }

        private void open_file_image()
        { 
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            openFileDialog1.ShowDialog();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            
            
                posdb_connect.pos_sql = "INSERT INTO pos_nameTbl (pos_id, name1, name2, name3, name4, name5, name6, name7, name8, name9, name10, name11, name12, name13, name14, name15, name16, name17, name18, name19, name20) VALUES ('"
                    + posIDNo_comboBox.Text + "','" + name_textBox1.Text + "', '" + name_textBox2.Text + "', '" + name_textBox3.Text + "', '" + name_textBox4.Text + "', '" + name_textBox5.Text + "', '" + name_textBox6.Text + "', '" + name_textBox7.Text + "', '"
                    + name_textBox8.Text + "', '" + name_textBox9.Text + "', '" + name_textBox10.Text + "', '" + name_textBox11.Text + "', '" + name_textBox12.Text + "', '" + name_textBox13.Text + "', '" + name_textBox14.Text + "', '" + name_textBox15.Text + "', '"
                    + name_textBox16.Text + "', '" + name_textBox17.Text + "', '" + name_textBox18.Text + "', '" + name_textBox19.Text + "', '" + name_textBox20.Text + "')";

                posdb_connect.pos_cmd();

                posdb_connect.pos_sqladapterInsert();

                posdb_connect.pos_sql = "INSERT INTO pos_priceTbl (price1, price2, price3, price4, price5, price6, price7, price8, price9, price10, price11, price12, price13, price14, price15, price16, price17, price18, price19, price20, pos_id) VALUES ('"
                    + price_textBox1.Text + "', '" + price_textBox2.Text + "', '" + price_textBox3.Text + "', '" + price_textBox4.Text + "', '" + price_textBox5.Text + "', '" + price_textBox6.Text + "', '" + price_textBox7.Text + "', '" + price_textBox8.Text + "', '"
                    + price_textBox9.Text + "', '" + price_textBox10.Text + "', '" + price_textBox11.Text + "', '" + price_textBox12.Text + "', '" + price_textBox13.Text + "', '" + price_textBox14.Text + "', '" + price_textBox15.Text + "', '" + price_textBox16.Text + "', '"
                    + price_textBox17.Text + "', '" + price_textBox18.Text + "', '" + price_textBox19.Text + "', '" + price_textBox20.Text + "', '" + posIDNo_comboBox.Text + "')";

                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterInsert();

                posdb_connect.pos_sql = "INSERT INTO pos_picTbl (pic1, pic2, pic3, pic4, pic5, pic6, pic7, pic8, pic9, pic10, pic11, pic12, pic13, pic14, pic15, pic16, pic17, pic18, pic19, pic20, pos_id) VALUES ('"
                    + picpath_textBox1.Text + "', '" + picpath_textBox2.Text + "', '" + picpath_textBox3.Text + "', '" + picpath_textBox4.Text + "', '" + picpath_textBox5.Text + "', '" + picpath_textBox6.Text + "', '" + picpath_textBox7.Text + "', '" + picpath_textBox8.Text + "', '"
                    + picpath_textBox9.Text + "', '" + picpath_textBox10.Text + "', '" + picpath_textBox11.Text + "', '" + picpath_textBox12.Text + "', '" + picpath_textBox13.Text + "', '" + picpath_textBox14.Text + "', '" + picpath_textBox15.Text + "', '" + picpath_textBox16.Text + "', '"
                    + picpath_textBox17.Text + "', '" + picpath_textBox18.Text + "', '" + picpath_textBox19.Text + "', '" + picpath_textBox20.Text + "', '" + posIDNo_comboBox.Text + "')";

                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterInsert();

                posdb_connect.pos_select();
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterSelect();
                posdb_connect.pos_sqldatasetSELECT();

                dataGridView1.DataSource = posdb_connect.pos_sql_dataset.Tables[0];
                cleartextboxes();
        }

        private void search_button_Click(object sender, EventArgs e)
        {
                posdb_connect.pos_sql = "SELECT * FROM pos_nameTbl INNER JOIN pos_picTbl ON pos_nameTbl.pos_id = pos_picTbl.pos_id INNER JOIN pos_priceTbl ON pos_picTbl.pos_id = pos_priceTbl.pos_id WHERE pos_nameTbl.pos_id = '" + posIDNo_comboBox.Text + "'";
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterSelect();

                posdb_connect.pos_sqldatasetSELECT();
                dataGridView1.DataSource = posdb_connect.pos_sql_dataset.Tables[0];

                name_textBox1.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][2].ToString();
                name_textBox2.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][3].ToString();
                name_textBox3.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][4].ToString();
                name_textBox4.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][5].ToString();
                name_textBox5.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][6].ToString();
                name_textBox6.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][7].ToString();
                name_textBox7.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][8].ToString();
                name_textBox8.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][9].ToString();
                name_textBox9.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][10].ToString();
                name_textBox10.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][11].ToString();
                name_textBox11.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][12].ToString();
                name_textBox12.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][13].ToString();
                name_textBox13.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][14].ToString();
                name_textBox14.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][15].ToString();
                name_textBox15.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][16].ToString();
                name_textBox16.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][17].ToString();
                name_textBox17.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][18].ToString();
                name_textBox18.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][19].ToString();
                name_textBox19.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][20].ToString();
                name_textBox20.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][21].ToString();

                picpath_textBox1.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][24].ToString();
                pictureBox1.Image = Image.FromFile(picpath_textBox1.Text);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                picpath_textBox2.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][25].ToString();
                pictureBox2.Image = Image.FromFile(picpath_textBox2.Text);
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

                picpath_textBox3.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][26].ToString();
                pictureBox3.Image = Image.FromFile(picpath_textBox3.Text);
                pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;

                picpath_textBox4.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][27].ToString();
                pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox4.Image = Image.FromFile(picpath_textBox4.Text);

                picpath_textBox5.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][28].ToString();
                pictureBox5.Image = Image.FromFile(picpath_textBox5.Text);
                pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;

                picpath_textBox6.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][29].ToString();
                pictureBox6.Image = Image.FromFile(picpath_textBox6.Text);
                pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;

                picpath_textBox7.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][30].ToString();
                pictureBox7.Image = Image.FromFile(picpath_textBox7.Text);
                pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;

                picpath_textBox8.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][31].ToString();
                pictureBox8.Image = Image.FromFile(picpath_textBox8.Text);
                pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;

                picpath_textBox9.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][32].ToString();
                pictureBox9.Image = Image.FromFile(picpath_textBox9.Text);
                pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;


                picpath_textBox10.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][33].ToString();
                pictureBox10.Image = Image.FromFile(picpath_textBox10.Text);
                pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;


                picpath_textBox11.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][34].ToString();
                pictureBox11.Image = Image.FromFile(picpath_textBox11.Text);
                pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;


                picpath_textBox12.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][35].ToString();
                pictureBox12.Image = Image.FromFile(picpath_textBox12.Text);
                pictureBox12.SizeMode = PictureBoxSizeMode.StretchImage;


                picpath_textBox13.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][36].ToString();
                pictureBox13.Image = Image.FromFile(picpath_textBox13.Text);
                pictureBox13.SizeMode = PictureBoxSizeMode.StretchImage;


                picpath_textBox14.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][37].ToString();
                pictureBox14.Image = Image.FromFile(picpath_textBox14.Text);
                pictureBox14.SizeMode = PictureBoxSizeMode.StretchImage;


                picpath_textBox15.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][38].ToString();
                pictureBox15.Image = Image.FromFile(picpath_textBox15.Text);
                pictureBox15.SizeMode = PictureBoxSizeMode.StretchImage;


                picpath_textBox16.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][39].ToString();
                pictureBox16.Image = Image.FromFile(picpath_textBox16.Text);
                pictureBox16.SizeMode = PictureBoxSizeMode.StretchImage;


                picpath_textBox17.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][40].ToString();
                pictureBox17.Image = Image.FromFile(picpath_textBox17.Text);
                pictureBox17.SizeMode = PictureBoxSizeMode.StretchImage;


                picpath_textBox18.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][41].ToString();
                pictureBox18.Image = Image.FromFile(picpath_textBox18.Text);
                pictureBox18.SizeMode = PictureBoxSizeMode.StretchImage;


                picpath_textBox19.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][42].ToString();
                pictureBox19.Image = Image.FromFile(picpath_textBox19.Text);
                pictureBox19.SizeMode = PictureBoxSizeMode.StretchImage;


                picpath_textBox20.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][43].ToString();
                pictureBox20.Image = Image.FromFile(picpath_textBox20.Text);
                pictureBox20.SizeMode = PictureBoxSizeMode.StretchImage;

                price_textBox1.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][46].ToString();
                price_textBox2.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][47].ToString();
                price_textBox3.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][48].ToString();
                price_textBox4.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][49].ToString();
                price_textBox5.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][50].ToString();
                price_textBox6.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][51].ToString();
                price_textBox7.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][52].ToString();
                price_textBox8.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][53].ToString();
                price_textBox9.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][54].ToString();
                price_textBox10.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][55].ToString();
                price_textBox11.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][56].ToString();
                price_textBox12.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][57].ToString();
                price_textBox13.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][58].ToString();
                price_textBox14.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][59].ToString();
                price_textBox15.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][60].ToString();
                price_textBox16.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][61].ToString();
                price_textBox17.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][62].ToString();
                price_textBox18.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][63].ToString();
                price_textBox19.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][64].ToString();
                price_textBox20.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][65].ToString();
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            posdb_connect.pos_sql = "UPDATE pos_nameTbl SET name1 = '" + name_textBox1.Text + "', name2 = '" + name_textBox2.Text + "', name3 = '" + name_textBox3.Text + "', name4 = '" + name_textBox4.Text + "', name5 = '" + name_textBox5.Text + "', name6 = '" + name_textBox6.Text + "', name7 = '" + name_textBox7.Text + "', name8 = '" + name_textBox8.Text + "', name9 = '" + name_textBox9.Text + "', name10 = '" + name_textBox10.Text + "', name11 = '" + name_textBox11.Text + "', name12 = '" + name_textBox12.Text + "', name13 = '" + name_textBox13.Text + "', name14 = '" + name_textBox14.Text + "', name15 = '" + name_textBox15.Text + "', name16 = '" + name_textBox16.Text + "', name17 = '" + name_textBox17.Text + "', name18 = '" + name_textBox18.Text + "', name19 = '" + name_textBox19.Text + "', name20 = '" + name_textBox20.Text + "' WHERE pos_id = '" + posIDNo_comboBox.Text + "'";
            posdb_connect.pos_cmd();
            posdb_connect.pos_sqladapterUpdate();

            posdb_connect.pos_sql = "UPDATE pos_picTbl SET " +
            "pic1 = '" + picpath_textBox1.Text + "', " +
            "pic2 = '" + picpath_textBox2.Text + "', " +
            "pic3 = '" + picpath_textBox3.Text + "', " +
            "pic4 = '" + picpath_textBox4.Text + "', " +
            "pic5 = '" + picpath_textBox5.Text + "', " +
            "pic6 = '" + picpath_textBox6.Text + "', " +
            "pic7 = '" + picpath_textBox7.Text + "', " +
            "pic8 = '" + picpath_textBox8.Text + "', " +
            "pic9 = '" + picpath_textBox9.Text + "', " +
            "pic10 = '" + picpath_textBox10.Text + "', " +
            "pic11 = '" + picpath_textBox11.Text + "', " +
            "pic12 = '" + picpath_textBox12.Text + "', " +
            "pic13 = '" + picpath_textBox13.Text + "', " +
            "pic14 = '" + picpath_textBox14.Text + "', " +
            "pic15 = '" + picpath_textBox15.Text + "', " +
            "pic16 = '" + picpath_textBox16.Text + "', " +
            "pic17 = '" + picpath_textBox17.Text + "', " +
            "pic18 = '" + picpath_textBox18.Text + "', " +
            "pic19 = '" + picpath_textBox19.Text + "', " +
            "pic20 = '" + picpath_textBox20.Text + "' " +
            "WHERE pos_id = '" + posIDNo_comboBox.Text + "'";
            posdb_connect.pos_cmd();
            posdb_connect.pos_sqladapterUpdate();

            posdb_connect.pos_sql = "UPDATE pos_priceTbl SET price1 = '" + price_textBox1.Text + "', price2 = '" + price_textBox2.Text + "', price3 = '" + price_textBox3.Text + "', price4 = '" + price_textBox4.Text + "', price5 = '" + price_textBox5.Text + "', price6 = '" + price_textBox6.Text + "', price7 = '" + price_textBox7.Text + "', price8 = '" + price_textBox8.Text + "', price9 = '" + price_textBox9.Text + "', price10 = '" + price_textBox10.Text + "', price11 = '" + price_textBox11.Text + "', price12 = '" + price_textBox12.Text + "', price13 = '" + price_textBox13.Text + "', price14 = '" + price_textBox14.Text + "', price15 = '" + price_textBox15.Text + "', price16 = '" + price_textBox16.Text + "', price17 = '" + price_textBox17.Text + "', price18 = '" + price_textBox18.Text + "', price19 = '" + price_textBox19.Text + "', price20 = '" + price_textBox20.Text + "' WHERE pos_id = '" + posIDNo_comboBox.Text + "'";
            posdb_connect.pos_cmd();
            posdb_connect.pos_sqladapterUpdate();

            posdb_connect.pos_select();
            posdb_connect.pos_cmd();
            posdb_connect.pos_sqladapterSelect();
            posdb_connect.pos_sqldatasetSELECT();

            dataGridView1.DataSource = posdb_connect.pos_sql_dataset.Tables[0];
            cleartextboxes();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            posdb_connect.pos_sql = "DELETE FROM pos_priceTbl WHERE pos_priceTbl.pos_id = '" + posIDNo_comboBox.Text + "'";
            posdb_connect.pos_cmd();
            posdb_connect.pos_sqladapterDelete();

            posdb_connect.pos_sql = "DELETE FROM pos_picTbl WHERE pos_picTbl.pos_id = '" + posIDNo_comboBox.Text + "'";
            posdb_connect.pos_cmd();
            posdb_connect.pos_sqladapterDelete();


            posdb_connect.pos_sql = "DELETE FROM pos_nameTbl WHERE pos_nameTbl.pos_id = '" + posIDNo_comboBox.Text + "'";
            posdb_connect.pos_cmd();
            posdb_connect.pos_sqladapterDelete();

            posdb_connect.pos_select();
            posdb_connect.pos_cmd();
            posdb_connect.pos_sqladapterSelect();
            posdb_connect.pos_sqldatasetSELECT();

            dataGridView1.DataSource = posdb_connect.pos_sql_dataset.Tables[0];
            cleartextboxes();
        }

        private void new_button_Click(object sender, EventArgs e)
        {
            cleartextboxes();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            open_file_image();
            pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            picpath = openFileDialog1.FileName;
            picpath_textBox1.Text = picpath;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            open_file_image();
            pictureBox2.Image = Image.FromFile(openFileDialog1.FileName);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            picpath = openFileDialog1.FileName;
            picpath_textBox2.Text = picpath;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            open_file_image();
            pictureBox3.Image = Image.FromFile(openFileDialog1.FileName);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            picpath = openFileDialog1.FileName;
            picpath_textBox3.Text = picpath;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            open_file_image();
            pictureBox4.Image = Image.FromFile(openFileDialog1.FileName);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            picpath = openFileDialog1.FileName;
            picpath_textBox4.Text = picpath;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            open_file_image();
            pictureBox5.Image = Image.FromFile(openFileDialog1.FileName);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            picpath = openFileDialog1.FileName;
            picpath_textBox5.Text = picpath;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            open_file_image();
            pictureBox6.Image = Image.FromFile(openFileDialog1.FileName);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            picpath = openFileDialog1.FileName;
            picpath_textBox6.Text = picpath;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            open_file_image();
            pictureBox7.Image = Image.FromFile(openFileDialog1.FileName);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            picpath = openFileDialog1.FileName;
            picpath_textBox7.Text = picpath;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            open_file_image();
            pictureBox8.Image = Image.FromFile(openFileDialog1.FileName);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            picpath = openFileDialog1.FileName;
            picpath_textBox8.Text = picpath;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            open_file_image();
            pictureBox9.Image = Image.FromFile(openFileDialog1.FileName);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            picpath = openFileDialog1.FileName;
            picpath_textBox9.Text = picpath;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            open_file_image();
            pictureBox10.Image = Image.FromFile(openFileDialog1.FileName);
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
            picpath = openFileDialog1.FileName;
            picpath_textBox10.Text = picpath;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            open_file_image();
            pictureBox11.Image = Image.FromFile(openFileDialog1.FileName);
            pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
            picpath = openFileDialog1.FileName;
            picpath_textBox11.Text = picpath;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            open_file_image();
            pictureBox12.Image = Image.FromFile(openFileDialog1.FileName);
            pictureBox12.SizeMode = PictureBoxSizeMode.StretchImage;
            picpath = openFileDialog1.FileName;
            picpath_textBox12.Text = picpath;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            open_file_image();
            pictureBox13.Image = Image.FromFile(openFileDialog1.FileName);
            pictureBox13.SizeMode = PictureBoxSizeMode.StretchImage;
            picpath = openFileDialog1.FileName;
            picpath_textBox13.Text = picpath;
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            open_file_image();
            pictureBox14.Image = Image.FromFile(openFileDialog1.FileName);
            pictureBox14.SizeMode = PictureBoxSizeMode.StretchImage;
            picpath = openFileDialog1.FileName;
            picpath_textBox14.Text = picpath;
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            open_file_image();
            pictureBox15.Image = Image.FromFile(openFileDialog1.FileName);
            pictureBox15.SizeMode = PictureBoxSizeMode.StretchImage;
            picpath = openFileDialog1.FileName;
            picpath_textBox15.Text = picpath;
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            open_file_image();
            pictureBox16.Image = Image.FromFile(openFileDialog1.FileName);
            pictureBox16.SizeMode = PictureBoxSizeMode.StretchImage;
            picpath = openFileDialog1.FileName;
            picpath_textBox16.Text = picpath;
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            open_file_image();
            pictureBox17.Image = Image.FromFile(openFileDialog1.FileName);
            pictureBox17.SizeMode = PictureBoxSizeMode.StretchImage;
            picpath = openFileDialog1.FileName;
            picpath_textBox17.Text = picpath;
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            open_file_image();
            pictureBox18.Image = Image.FromFile(openFileDialog1.FileName);
            pictureBox18.SizeMode = PictureBoxSizeMode.StretchImage;
            picpath = openFileDialog1.FileName;
            picpath_textBox18.Text = picpath;
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            open_file_image();
            pictureBox19.Image = Image.FromFile(openFileDialog1.FileName);
            pictureBox19.SizeMode = PictureBoxSizeMode.StretchImage;
            picpath = openFileDialog1.FileName;
            picpath_textBox19.Text = picpath;
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            open_file_image();
            pictureBox20.Image = Image.FromFile(openFileDialog1.FileName);
            pictureBox20.SizeMode = PictureBoxSizeMode.StretchImage;
            picpath = openFileDialog1.FileName;
            picpath_textBox20.Text = picpath;
        }
    }
}
