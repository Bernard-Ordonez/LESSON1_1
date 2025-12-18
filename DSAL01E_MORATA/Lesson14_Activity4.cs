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
    public partial class Lesson14_Activity4 : Form
    {
        string picpath;
        employee_dbconnection emp_db_connect = new employee_dbconnection();

        private bool isloading = true;

        public Lesson14_Activity4()
        {
            emp_db_connect.employee_connString();
            InitializeComponent();
        }

        private void cleartextboxes()
        {
            empNum_textBox.Clear();
            firstName_textBox.Clear();
            midName_textBox.Clear();
            surname_textBox.Clear();
            sssNum_textBox.Clear();
            TINnum_textBox.Clear();
            philHealthNum_textBox.Clear();
            pagibigNum_textBox.Clear();
            height_textBox.Clear();
            weight_textBox.Clear();
            yearsStay_textBox.Clear();
            houseNum_textBox.Clear();
            subdName_textBox.Clear();
            phaseNum_textBox.Clear();
            street_textBox.Clear();
            barangay_textBox.Clear();
            municipality_textBox.Clear();
            city_textBox.Clear();
            state_textBox.Clear();
            country_textBox.Clear();
            zipCode_textBox.Clear();
            elemSchool_textBox.Clear();
            elemAddress_textBox.Clear();
            elemAward_textBox.Clear();
            juniorHigh_textBox.Clear();
            juniorAddress_textBox.Clear();
            juniorAward_textBox.Clear();
            seniorHigh_textBox.Clear();
            seniorAddress_textBox.Clear();
            seniorAward_textBox.Clear();
            seniorTrack_textBox.Clear();
            collegeSchool_textBox.Clear();
            collegeAddress_textBox.Clear();
            collegeCourse_textBox.Clear();
            collegeAward_textBox.Clear();
            others_textBox.Clear();
            position_textBox.Clear();
            empStatus_textBox.Clear();
            dept_textBox.Clear();
            numDependents_textBox.Clear();

            age_textBox.Clear();
            dateHired_textBox.Clear();
            status_comboBox.SelectedIndex = -1;
            gender_comboBox.SelectedIndex = -1;
            elemYearGrad_textBox.Clear();
            juniorYearGrad_textBox.Clear();
            seniorYearGrad_textBox.Clear();
            collegeYearGrad_textBox.Clear();

            empPic_textBox.Clear();
            emp_pictureBox.Image = Properties.Resources.default_image;

            empNum_textBox.Focus();
        }

        private void Lesson14_Activity4_Load(object sender, EventArgs e)
        {
            empPic_textBox.Hide();
            emp_pictureBox.Image = Properties.Resources.default_image;
            emp_pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            
            emp_db_connect.employee_sql = "SELECT * FROM pos_empRegTbl";
            emp_db_connect.employee_cmd();
            emp_db_connect.employee_sqladapterSelect();
            emp_db_connect.employee_sqldatasetSELECT();

            dataGridView1.DataSource = emp_db_connect.employee_sql_dataset.Tables[0];

            CenterPanel();
            this.Resize += (s, ev) => CenterPanel();
            isloading = true;
        }

        private void empPic_browse_button_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select an Image";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    emp_pictureBox.Image = Image.FromFile(openFileDialog.FileName);
                    emp_pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    picpath = openFileDialog.FileName;
                    empPic_textBox.Text = picpath;
                }
            }
        }

        private void empID_Search_button_Click(object sender, EventArgs e)
        {
            emp_db_connect.employee_sql = "SELECT * FROM pos_empRegTbl WHERE emp_id = '" + empNum_textBox.Text + "'";
            emp_db_connect.employee_cmd();
            emp_db_connect.employee_sqladapterSelect();
            emp_db_connect.employee_sqldatasetSELECT();

            dataGridView1.DataSource = emp_db_connect.employee_sql_dataset.Tables[0];

            firstName_textBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][2].ToString();
            midName_textBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][3].ToString();
            surname_textBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][4].ToString();
            age_textBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][5].ToString();
            gender_comboBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][6].ToString();
            sssNum_textBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][7].ToString();
            TINnum_textBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][8].ToString();
            philHealthNum_textBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][9].ToString();
            pagibigNum_textBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][10].ToString();
            status_comboBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][11].ToString();
            height_textBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][12].ToString();
            weight_textBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][13].ToString();
            
            yearsStay_textBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][14].ToString();
            houseNum_textBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][15].ToString();
            subdName_textBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][16].ToString();
            phaseNum_textBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][17].ToString();
            street_textBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][18].ToString();
            barangay_textBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][19].ToString();
            municipality_textBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][20].ToString();
            city_textBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][21].ToString();
            state_textBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][22].ToString();
            country_textBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][23].ToString();
            zipCode_textBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][24].ToString();

            elemSchool_textBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][25].ToString();
            elemAddress_textBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][26].ToString();
            elemYearGrad_textBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][27].ToString();
            elemAward_textBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][28].ToString();

            juniorHigh_textBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][29].ToString();
            juniorAddress_textBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][30].ToString();
            juniorYearGrad_textBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][31].ToString();
            juniorAward_textBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][32].ToString();

            seniorHigh_textBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][33].ToString();
            seniorAddress_textBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][34].ToString();
            seniorYearGrad_textBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][35].ToString();
            seniorAward_textBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][36].ToString();
            seniorTrack_textBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][37].ToString();

            collegeSchool_textBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][38].ToString();
            collegeAddress_textBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][39].ToString();
            collegeCourse_textBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][40].ToString();
            collegeYearGrad_textBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][41].ToString();
            collegeAward_textBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][42].ToString();

            others_textBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][43].ToString();
            position_textBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][44].ToString();
            empStatus_textBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][45].ToString();
            dateHired_textBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][46].ToString();
            dept_textBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][47].ToString();
            numDependents_textBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][48].ToString();

            empPic_textBox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][49].ToString();
            emp_pictureBox.Image = Image.FromFile(empPic_textBox.Text);
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            emp_db_connect.employee_sql = "INSERT INTO pos_empRegTbl (emp_id, emp_fname, emp_mname, emp_surname, emp_age, emp_gender," +
            "emp_sss_no, emp_tin_no, emp_philhealth_no, emp_pagibig_no, emp_status, emp_height, emp_weight, add_yrs_stay, add_house_no," +
            "add_sub_name, add_phase_no, add_street, add_barangay, add_municipality, add_city, add_state_province, add_country, add_zipcode," +
            "elem_name, elem_address, elem_yr_grad, elem_award, junior_high_name, junior_high_address, junior_high_yr_grad, junior_high_award," +
            "senior_high_name, senior_high_address, senior_high_yr_grad, senior_high_award, track, college_school_name, college_address," +
            "college_yr_grad, college_award, college_course, others, position, emp_work_status, emp_date_hired, emp_department," +
            "emp_no_of_dependents, picpath) VALUES ('" + empNum_textBox.Text + "','" +
            firstName_textBox.Text + "','" + midName_textBox.Text + "','" + surname_textBox.Text + "','" +
            age_textBox.Text + "','" + gender_comboBox.Text + "','" + sssNum_textBox.Text + "','" +
            TINnum_textBox.Text + "','" + philHealthNum_textBox.Text + "','" + pagibigNum_textBox.Text + "','" +
            status_comboBox.Text + "','" + height_textBox.Text + "','" + weight_textBox.Text + "','" +
            yearsStay_textBox.Text + "','" + houseNum_textBox.Text + "','" + subdName_textBox.Text + '"' +
            "','" + phaseNum_textBox.Text + "','" + street_textBox.Text + '"' + "','" + barangay_textBox.Text + "','" +
            municipality_textBox.Text + "','" + city_textBox.Text + "','" + state_textBox.Text + "','" +
            country_textBox.Text + "','" + zipCode_textBox.Text + "','" + elemSchool_textBox.Text + "','" +
            elemAddress_textBox.Text + "','" + elemYearGrad_textBox.Text + "','" + elemAward_textBox.Text + "','" +
            juniorHigh_textBox.Text + "','" + juniorAddress_textBox.Text + "','" + juniorYearGrad_textBox.Text + '"' +
            "','" + juniorAward_textBox.Text + "','" + seniorHigh_textBox.Text + "','" + seniorAddress_textBox.Text + "','" +
            seniorYearGrad_textBox.Text + "','" + seniorAward_textBox.Text + "','" + seniorTrack_textBox.Text + '"' +
            "','" + collegeSchool_textBox.Text + "','" + collegeAddress_textBox.Text + "','" + collegeYearGrad_textBox.Text + "','" +
            collegeAward_textBox.Text + "','" + collegeCourse_textBox.Text + "','" + others_textBox.Text + "','" +
            position_textBox.Text + "','" + empStatus_textBox.Text + "','" + dateHired_textBox.Text + "','" +
            dept_textBox.Text + "','" + numDependents_textBox.Text + "','" + empPic_textBox.Text + "')";

            emp_db_connect.employee_cmd();
            emp_db_connect.employee_sqladapterInsert();

            emp_db_connect.employee_sql = "SELECT * FROM pos_empRegTbl";
            emp_db_connect.employee_cmd();
            emp_db_connect.employee_sqladapterSelect();
            emp_db_connect.employee_sqldatasetSELECT();

            dataGridView1.DataSource = emp_db_connect.employee_sql_dataset.Tables[0];
            cleartextboxes();
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            emp_db_connect.employee_sql = "UPDATE pos_empRegTbl SET " +
            "emp_fname = '" + firstName_textBox.Text + "', " +
            "emp_mname = '" + midName_textBox.Text + "', " +
            "emp_surname = '" + surname_textBox.Text + "', " +
            "emp_age = '" + age_textBox.Text + "', " +
            "emp_gender = '" + gender_comboBox.Text + "', " +
            "emp_sss_no = '" + sssNum_textBox.Text + "', " +
            "emp_tin_no = '" + TINnum_textBox.Text + "', " +
            "emp_philhealth_no = '" + philHealthNum_textBox.Text + "', " +
            "emp_pagibig_no = '" + pagibigNum_textBox.Text + "', " +
            "emp_status = '" + status_comboBox.Text + "', " +
            "emp_height = '" + height_textBox.Text + "', " +
            "emp_weight = '" + weight_textBox.Text + "', " +
            "add_yrs_stay = '" + yearsStay_textBox.Text + "', " +
            "add_house_no = '" + houseNum_textBox.Text + "', " +
            "add_sub_name = '" + subdName_textBox.Text + "', " +
            "add_phase_no = '" + phaseNum_textBox.Text + "', " +
            "add_street = '" + street_textBox.Text + "', " +
            "add_barangay = '" + barangay_textBox.Text + "', " +
            "add_municipality = '" + municipality_textBox.Text + "', " +
            "add_city = '" + city_textBox.Text + "', " +
            "add_state_province = '" + state_textBox.Text + "', " +
            "add_country = '" + country_textBox.Text + "', " +
            "add_zipcode = '" + zipCode_textBox.Text + "', " +
            "elem_name = '" + elemSchool_textBox.Text + "', " +
            "elem_address = '" + elemAddress_textBox.Text + "', " +
            "elem_yr_grad = '" + elemYearGrad_textBox.Text + "', " +
            "elem_award = '" + elemAward_textBox.Text + "', " +
            "junior_high_name = '" + juniorHigh_textBox.Text + "', " +
            "junior_high_address = '" + juniorAddress_textBox.Text + "', " +
            "junior_high_yr_grad = '" + juniorYearGrad_textBox.Text + "', " +
            "junior_high_award = '" + juniorAward_textBox.Text + "', " +
            "senior_high_name = '" + seniorHigh_textBox.Text + "', " +
            "senior_high_address = '" + seniorAddress_textBox.Text + "', " +
            "senior_high_yr_grad = '" + seniorYearGrad_textBox.Text + "', " +
            "senior_high_award = '" + seniorAward_textBox.Text + "', " +
            "track = '" + seniorTrack_textBox.Text + "', " +
            "college_school_name = '" + collegeSchool_textBox.Text + "', " +
            "college_address = '" + collegeAddress_textBox.Text + "', " +
            "college_yr_grad = '" + collegeCourse_textBox.Text + "', " +
            "college_award = '" + collegeYearGrad_textBox.Text + "', " +
            "college_course = '" + collegeAward_textBox.Text + "', " +
            "others = '" + others_textBox.Text + "', " +
            "position = '" + position_textBox.Text + "', " +
            "emp_work_status = '" + empStatus_textBox.Text + "', " +
            "emp_date_hired = '" + dateHired_textBox.Text + "', " +
            "emp_department = '" + dept_textBox.Text + "', " +
            "emp_no_of_dependents = '" + numDependents_textBox.Text + "', " +
            "picpath = '" + empPic_textBox.Text + "' " +
            "WHERE emp_id = '" + empNum_textBox.Text + "'";

            emp_db_connect.employee_cmd();
            emp_db_connect.employee_sqladapterInsert();
            emp_db_connect.employee_cmd();
            emp_db_connect.employee_sql = "SELECT * FROM pos_empRegTbl";
            emp_db_connect.employee_cmd();
            emp_db_connect.employee_sqladapterSelect();
            emp_db_connect.employee_sqldatasetSELECT();
            dataGridView1.DataSource = emp_db_connect.employee_sql_dataset.Tables[0];
            cleartextboxes();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            emp_db_connect.employee_sql = "DELETE FROM pos_empRegTbl WHERE emp_id = '" + empNum_textBox.Text + "'";
            emp_db_connect.employee_cmd();
            emp_db_connect.employee_sqladapterDelete();
            emp_db_connect.employee_sql = "SELECT * FROM pos_empRegTbl";
            emp_db_connect.employee_cmd();
            emp_db_connect.employee_sqladapterSelect();
            emp_db_connect.employee_sqldatasetSELECT();
            dataGridView1.DataSource = emp_db_connect.employee_sql_dataset.Tables[0];
            cleartextboxes();
        }

        private void new_button_Click(object sender, EventArgs e)
        {
            cleartextboxes();
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            cleartextboxes();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CenterPanel()
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
        }
    }
}
