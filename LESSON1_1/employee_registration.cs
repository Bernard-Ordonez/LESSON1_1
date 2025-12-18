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
    public partial class employee_registration : Form
    {
        string picpath;
        employee_dbconnection emp_db_connect = new employee_dbconnection();
        private bool isloading = true;
        public employee_registration()
        {
            emp_db_connect.employee_connString();
            InitializeComponent();
        }

        private void cleartextboxes()
        {
            emp_idTxtBox.Clear(); fnameTxtbox.Clear();
            mnameTxtbox.Clear(); surnameTxtbox.Clear();
            sssTxtbox.Clear(); tinTxtbox.Clear();
            philhealthTxtbox.Clear(); pagibigTxtbox.Clear();
            heightTxtbox.Clear(); weightTxtBox.Clear();
            current_yrsTxtbox.Clear(); current_ho_noTxtbox.Clear();
            currentSub_noTxtbox.Clear(); current_phaseTxtbox.Clear();
            current_streetTxtbox.Clear(); current_barangayTxtbox.Clear();
            current_municipalityTxtbox.Clear(); current_cityTxtbox.Clear();
            current_stateTxtBox.Clear(); current_countryTxtbox.Clear();
            current_ZipTxtbox.Clear(); elem_nameTxtbox.Clear();
            elem_addressTxtbox.Clear(); elem_awardTxtbox.Clear();
            junior_nameTxtbox.Clear(); junior_addressTxtbox.Clear();
            junior_awardTxtbox.Clear(); senior_nameTxtbox.Clear();
            senior_addressTxtbox.Clear(); senior_trackTxtbox.Clear();
            senior_awardTxtbox.Clear(); college_school_nameTxtbox.Clear();
            college_addressTxtbox.Clear(); college_courseTxtbox.Clear();
            college_awardTxtbox.Clear(); othersTxtBox.Clear();
            positionTxtbox.Clear(); employeeStatusTxtBox.Clear();
            departmentTxtBox.Clear(); emp_num_dependents.Clear();
            picturepathTxtBox.Clear();
            picbox.Image = Image.FromFile("C:\\Users\\Bernard Ordonez\\source\\DSAL01E\\LESSON1_1\\LESSON1_1\\Resources\\istockphoto-1182393436-612x612.jpg");
            emp_idTxtBox.Focus();

        }
        private void center_panel()
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
        }
        private void employee_registration_Load(object sender, EventArgs e)
        {
            center_panel();
            this.Resize += (s, ev) => center_panel();
            isloading = true;

            genderCombox.Items.AddRange(new object[]
            {
                "Male",
                "Female",
                "Undisclosed"
           
            });
            statusCombox.Items.AddRange(new object[]
            {
                "Single",
                "Married",
                "Widowed",
                "Divorced"
            });
            try
            {
                picturepathTxtBox.Hide();
                picbox.Image = Image.FromFile("C:\\Users\\Bernard Ordonez\\source\\DSAL01E\\LESSON1_1\\LESSON1_1\\Resources\\istockphoto-1182393436-612x612.jpg");

                emp_db_connect.employee_sql = "SELECT * FROM pos_empRegTbl";
                emp_db_connect.employee_cmd();
                emp_db_connect.employee_sqladapterSelect();
                emp_db_connect.employee_sqldatasetSELECT();
                dataGridView1.DataSource = emp_db_connect.employee_sql_dataset.Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!(1)");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //open_file_image();
                openFileDialog1.Filter = "Image File | *.gif; *.jpg; *.png; *.bmp";
                //filtering of image display using specific file extension
                openFileDialog1.ShowDialog(); //displaying the file dialogbox where the possible image located

                picbox.Image = Image.FromFile(openFileDialog1.FileName); //inserting of selected image to the picturebox shown in the GUI interface
                picpath = openFileDialog1.FileName; //storing the file location of the selected image inserted in picturebox to a variable
                picturepathTxtBox.Text = picpath; //displaying the file location of the image stored in a variable to the textbox
            }
            catch (Exception)
            {
                MessageBox.Show("No image selected!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
                // SQL command to select a specific employee record (from image_cf9c7e.jpg)
                emp_db_connect.employee_sql = "SELECT * FROM pos_empRegTbl WHERE emp_id = '" + emp_idTxtBox.Text + "'";

                // Execute the SQL command and retrieve data
                emp_db_connect.employee_cmd();
                emp_db_connect.employee_sqladapterSelect();
                emp_db_connect.employee_sqldatasetSELECT();

                // Bind the result table to a DataGridView
                dataGridView1.DataSource = emp_db_connect.employee_sql_dataset.Tables[0];
                fnameTxtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][2].ToString();
                mnameTxtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][3].ToString();
                surnameTxtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][4].ToString();
                ageComboBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][5].ToString();

                genderCombox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][6].ToString();   // emp_gender
                sssTxtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][7].ToString();      // emp_sss_no
                tinTxtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][8].ToString();
                philhealthTxtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][9].ToString();
                pagibigTxtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][10].ToString();

                statusCombox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][11].ToString();
                heightTxtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][12].ToString();
                weightTxtBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][13].ToString();

                current_yrsTxtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][14].ToString();
                current_ho_noTxtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][15].ToString();
                currentSub_noTxtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][16].ToString();
                current_phaseTxtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][17].ToString();
                current_streetTxtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][18].ToString();
                current_barangayTxtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][19].ToString();
                current_municipalityTxtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][20].ToString();
                current_cityTxtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][21].ToString();
                current_stateTxtBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][22].ToString();
                current_countryTxtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][23].ToString();
                current_ZipTxtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][24].ToString();

                elem_nameTxtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][25].ToString();
                elem_addressTxtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][26].ToString();
                elem_yr_gradTxtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][27].ToString();
                elem_awardTxtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][28].ToString();

                junior_nameTxtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][29].ToString();
                junior_addressTxtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][30].ToString();
                junior_yr_gradTxtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][31].ToString();
                junior_awardTxtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][32].ToString();

                senior_nameTxtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][33].ToString();
                senior_addressTxtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][34].ToString();
                senior_yr_gradTxtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][35].ToString();
                senior_awardTxtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][36].ToString();
                senior_trackTxtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][37].ToString(); // track

                college_school_nameTxtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][38].ToString();
                college_addressTxtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][39].ToString();
                college_yr_gradTxtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][40].ToString();
                college_awardTxtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][41].ToString();
                college_courseTxtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][42].ToString();
                othersTxtBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][43].ToString();

                positionTxtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][44].ToString();
                employeeStatusTxtBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][45].ToString();
                date_hiredTxtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][46].ToString();
                departmentTxtBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][47].ToString();
                emp_num_dependents.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][48].ToString();

                picturepathTxtBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][49].ToString();

                // Note: 'picbox.Image' is case-sensitive, matching the pattern of other control names.
                picbox.Image = Image.FromFile(picturepathTxtBox.Text);
        }

        // ADD
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Data saved successfully (POS_EmpRegTBL).",
                "Confirmation",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
            emp_db_connect.employee_sql = "INSERT INTO pos_empRegTbl (emp_id, " +
                    "emp_fname, emp_mname, emp_surname, emp_age, emp_gender, " +
                    "emp_sss_no, " + "emp_tin_no, " +
                    "emp_philhealth_no, " + "emp_pagibig_no," +
                    "emp_status, " + "emp_height, " +
                    "emp_weight, " + "add_yrs_stay, " +
                    "add_house_no, " + "add_sub_name, " +
                    "add_phase_no, " + "add_street, " +
                    "add_barangay, " + "add_municipality, " +
                    "add_city, " + "add_state_province, " +
                    "add_country, " + "add_zipcode, " +
                    "elem_name, " + "elem_address, " +
                    "elem_yr_grad, " + "elem_award, " +
                    "junior_high_name, " + "junior_high_address, " +
                    "junior_high_yr_grad, " + "junior_high_award, " +
                    "senior_high_name, " + "senior_high_address, " +
                    "senior_high_yr_grad, " + "senior_high_award, " +
                    "track, " + "college_school_name, " +
                    "college_address, " + "college_yr_grad, " +
                    "college_award, " + "college_course, " +
                    "others, " + "position, " +
                    "emp_work_status, " + "emp_date_hired, " +
                    "emp_department, " +
                    "emp_no_of_dependents, picpath) VALUES ('" + emp_idTxtBox.Text
                    + "', '" +
                    "" + fnameTxtbox.Text + "', '" +
                    "" + mnameTxtbox.Text + "', '" +
                    "" + surnameTxtbox.Text + "', '" +
                    "" + ageComboBox.Text + "', '" +
                    "" + genderCombox.Text + "', '" +
                    "" + sssTxtbox.Text + "', '" +
                    "" + tinTxtbox.Text + "', '" +
                    "" + philhealthTxtbox.Text + "', '" +
                    "" + pagibigTxtbox.Text + "', '" +
                    "" + statusCombox.Text + "', '" +
                    "" + heightTxtbox.Text + "', '" +
                    "" + weightTxtBox.Text + "', '" +
                    "" + current_yrsTxtbox.Text + "', '" +
                    "" + current_ho_noTxtbox.Text + "', '" +
                    "" + currentSub_noTxtbox.Text + "', '" +
                    "" + current_phaseTxtbox.Text + "', '" +
                    "" + current_streetTxtbox.Text + "', '" +
                    "" + current_barangayTxtbox.Text + "', '" +
                    "" + current_municipalityTxtbox.Text + "', '" +
                    "" + current_cityTxtbox.Text + "', '" +
                    "" + current_stateTxtBox.Text + "', '" +
                    "" + current_countryTxtbox.Text + "', '" +
                    "" + current_ZipTxtbox.Text + "', '" +
                    "" + elem_nameTxtbox.Text + "', '" +
                    "" + elem_addressTxtbox.Text + "', '" +
                    "" + elem_yr_gradTxtbox.Text + "', '" +
                    "" + elem_awardTxtbox.Text + "', '" +
                    "" + junior_nameTxtbox.Text + "', '" +
                    "" + junior_addressTxtbox.Text + "', '" +
                    "" + junior_yr_gradTxtbox.Text + "', '" +
                    "" + junior_awardTxtbox.Text + "', '" +
                    "" + senior_nameTxtbox.Text + "', '" +
                    "" + senior_addressTxtbox.Text + "', '" +
                    "" + senior_yr_gradTxtbox.Text + "', '" +
                    "" + senior_trackTxtbox.Text + "', '" +
                    "" + senior_awardTxtbox.Text + "', '" +
                    "" + college_school_nameTxtbox.Text + "', '" +
                    "" + college_addressTxtbox.Text + "', '" +
                    "" + college_courseTxtbox.Text + "', '" +
                    "" + college_yr_gradTxtbox.Text + "', '" +
                    "" + college_awardTxtbox.Text + "', '" +
                    "" + othersTxtBox.Text + "', '" +
                    "" + positionTxtbox.Text + "', '" +
                    "" + employeeStatusTxtBox.Text + "', '" +
                    "" + date_hiredTxtbox.Text + "', '" +
                    "" + departmentTxtBox.Text + "', '" +
                    "" + emp_num_dependents.Text + "', '" +
                    "" + picturepathTxtBox.Text + "')";

                emp_db_connect.employee_cmd();
                emp_db_connect.employee_sqladapterInsert();
                emp_db_connect.employee_sql = "SELECT * FROM pos_empRegTbl";
                emp_db_connect.employee_cmd();
                emp_db_connect.employee_sqladapterSelect();
                emp_db_connect.employee_sqldatasetSELECT();
                dataGridView1.DataSource = emp_db_connect.employee_sql_dataset.Tables[0];
                cleartextboxes();
        }

        private void button4_Click(object sender, EventArgs e)
        {
                emp_db_connect.employee_sql = "UPDATE pos_empRegTbl SET emp_fname = '" + fnameTxtbox.Text + "'," +
                "emp_mname = '" + mnameTxtbox.Text + "'," +
                "emp_surname = '" + surnameTxtbox.Text + "'," +
                "emp_age = '" + ageComboBox.Text + "'," +
                "emp_gender = '" + genderCombox.Text + "'," +
                "emp_sss_no = '" + sssTxtbox.Text + "'," +
                "emp_tin_no = '" + tinTxtbox.Text + "'," +
                "emp_philhealth_no = '" + philhealthTxtbox.Text + "'," +
                "emp_pagibig_no = '" + pagibigTxtbox.Text + "'," +
                "emp_status = '" + statusCombox.Text + "'," +
                "emp_height = '" + heightTxtbox.Text + "'," +
                "emp_weight = '" + weightTxtBox.Text + "'," +
                "add_yrs_stay = '" + current_yrsTxtbox.Text + "'," +
                "add_house_no = '" + current_ho_noTxtbox.Text + "'," +
                "add_sub_name = '" + currentSub_noTxtbox.Text + "'," +
                "add_phase_no = '" + current_phaseTxtbox.Text + "'," +
                "add_street = '" + current_streetTxtbox.Text + "'," +
                "add_barangay = '" + current_barangayTxtbox.Text + "'," +
                "add_municipality = '" + current_municipalityTxtbox.Text + "'," +
                "add_city = '" + current_cityTxtbox.Text + "'," +
                "add_state_province = '" + current_stateTxtBox.Text + "'," +
                "add_country = '" + current_countryTxtbox.Text + "'," +
                "add_zipcode = '" + current_ZipTxtbox.Text + "'," +
                "elem_name = '" + elem_nameTxtbox.Text + "'," +
                "elem_address = '" + elem_addressTxtbox.Text + "'," +
                "elem_yr_grad = '" + elem_yr_gradTxtbox.Text + "'," +
                "elem_award = '" + elem_awardTxtbox.Text + "'," +
                "junior_high_name = '" + junior_nameTxtbox.Text + "'," +
                "junior_high_address = '" + junior_addressTxtbox.Text + "'," +
                "junior_high_yr_grad = '" + junior_yr_gradTxtbox.Text + "'," +
                "junior_high_award = '" + junior_awardTxtbox.Text + "'," +
                "senior_high_name = '" + senior_nameTxtbox.Text + "'," +
                "senior_high_address = '" + senior_addressTxtbox.Text + "'," +
                "senior_high_yr_grad = '" + senior_yr_gradTxtbox.Text + "'," +
                "senior_high_award = '" + senior_trackTxtbox.Text + "'," +
                "track = '" + senior_awardTxtbox.Text + "'," +
                "college_school_name = '" + college_school_nameTxtbox.Text + "'," +
                "college_address = '" + college_addressTxtbox.Text + "'," +
                "college_yr_grad = '" + college_courseTxtbox.Text + "'," +
                "college_award = '" + college_yr_gradTxtbox.Text + "'," +
                "college_course = '" + college_awardTxtbox.Text + "'," +
                "others = '" + othersTxtBox.Text + "'," +
                "position = '" + positionTxtbox.Text + "'," +
                "emp_work_status = '" + employeeStatusTxtBox.Text + "'," +
                "emp_date_hired = '" + date_hiredTxtbox.Text + "'," +
                "emp_department = '" + departmentTxtBox.Text + "'," +
                "emp_no_of_dependents = '" + emp_num_dependents.Text + "'," +
                "picpath = '" + picturepathTxtBox.Text + "' " +
                "WHERE emp_id = '" + emp_idTxtBox.Text + "'";
                emp_db_connect.employee_cmd();
                emp_db_connect.employee_sqladapterInsert();
                emp_db_connect.employee_sql = "SELECT * FROM pos_empRegTbl";
                emp_db_connect.employee_cmd();
                emp_db_connect.employee_sqladapterSelect();
                emp_db_connect.employee_sqldatasetSELECT();
                dataGridView1.DataSource = emp_db_connect.employee_sql_dataset.Tables[0];
                cleartextboxes();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                emp_db_connect.employee_sql = "DELETE FROM pos_empRegTbl WHERE emp_id = '"
                + emp_idTxtBox.Text + "'";
                emp_db_connect.employee_cmd();
                emp_db_connect.employee_sqladapterDelete();
                emp_db_connect.employee_sql = "SELECT * FROM pos_empRegTbl";
                emp_db_connect.employee_cmd();
                emp_db_connect.employee_sqladapterSelect();
                emp_db_connect.employee_sqldatasetSELECT();
                dataGridView1.DataSource = emp_db_connect.employee_sql_dataset.Tables[0];
                cleartextboxes();
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!(5)");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cleartextboxes();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            cleartextboxes();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
