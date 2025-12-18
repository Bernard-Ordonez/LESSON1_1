using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//ADDED: Lesson 13 - Example 1
using System.Data.SqlClient;

namespace DSAL01E_MORATA
{
    public partial class Lesson13_Example1 : Form
    {
        private bool isloading = true;

        //ADDED: Lesson 13 - Example 1

        //declaration of variables used in the form programs for database connection
        String picpath; //a string variable used to hold the location of the image inside the table
        String connectionString = null; //a string variable with an initial value which is used to hold the SQL Connection Object

        SqlConnection connection; //a variable used to hold the SQL Connection Object
        SqlCommand command; //a variable used to hold the SQL Command or query
        DataSet dset; //a variable used to hold the mirror copy of the database contents reside inside the .NET Framework
        SqlDataAdapter adaptersql; //a variable used to hold the SQL DATA ADAPTER object

        string sql = null;

        public Lesson13_Example1()
        {
            InitializeComponent();

            picPath_pictureBox.Image = Properties.Resources.default_image;
            picPath_pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void CenterPanel()
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
        }

        private void Lesson13_Example1_Load(object sender, EventArgs e)
        {
            //codes in creating and establishing SQL Connection Object
            connectionString = @"Data Source=DESKTOP-4B2S90A\SQLEXPRESS;Initial Catalog=SampleDatabaseDb;Integrated Security=True;";
            connection = new SqlConnection(connectionString);

            CenterPanel();
            this.Resize += (s, ev) => CenterPanel();
            isloading = true;

            try
            {
                connection.Open();

                // Load data from studentTable
                string sql = "SELECT * FROM studentTable";
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataSet dset = new DataSet();
                adapter.Fill(dset, "studentTable");

                dataGridView1.DataSource = dset.Tables[0];
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dataGridView1.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void browsePic_button_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select an Image";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    picPath_pictureBox.Image = Image.FromFile(openFileDialog.FileName);
                    picPath_pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    picpath = openFileDialog.FileName;
                    picPath_textBox.Text = picpath;
                }
            }
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            // Open the connection
            connection.Open();

            //code to open the connection between c# and ms sql
            //ConnectionState.Open();
            //mssql query to insert or save data form GUI interface to the student table located inside the database
            sql = "INSERT INTO studentTable (student_id, student_name, department, picpath) VALUES ('" + studNum_textBox.Text + "', '" + studName_textBox.Text + "', '" + dept_textBox.Text + "', '" + picPath_textBox.Text + "')";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            //codes for meadiating the language or world of C# and MSSQL
            adaptersql = new SqlDataAdapter();
            adaptersql.InsertCommand = command;
            command.ExecuteNonQuery();

            //mssql query to display the contents of student table located inside the database
            sql = "SELECT * FROM studentTable";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            //codes for mediating the language or world of C# and MSSQL
            adaptersql = new SqlDataAdapter();
            adaptersql.SelectCommand = command;
            command.ExecuteNonQuery();

            //codes for mirroring the contents of the database inside the MSSQL going C# or Visual Studio
            dset = new DataSet();
            adaptersql.Fill(dset, "studentTable");

            //codes for displaying the contents of the student table inside the database to the datagridview
            dataGridView1.DataSource = dset.Tables[0];
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //clearing of textboxes after saving the data to the database.
            picPath_pictureBox.Image = Properties.Resources.default_image;
            studNum_textBox.Clear();
            studName_textBox.Clear();
            dept_textBox.Clear();
            picPath_textBox.Clear();

            connection.Close();
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            connection.Open();

            //mssql query to display the contents of student table located inside the database
            sql = "SELECT * FROM studentTable WHERE student_id = '" + studNum_textBox.Text + "'";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            //codes for mediating the language or world of C# and MSSQL
            adaptersql = new SqlDataAdapter();
            adaptersql.SelectCommand = command;
            command.ExecuteNonQuery();

            //codes for mirroring the contents of the database inside the MSSQL going C# or Visual Studio
            dset = new DataSet();
            adaptersql.Fill(dset, "studentTable");

            //codes for displaying the contents of the student table inside the database to the datagridview
            dataGridView1.DataSource = dset.Tables[0];
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //codes for diplaying the contents of the student table inside the database to the textboxes
            studName_textBox.Text = dset.Tables[0].Rows[0][1].ToString();
            dept_textBox.Text = dset.Tables[0].Rows[0][2].ToString();
            picPath_textBox.Text = dset.Tables[0].Rows[0][3].ToString();
            picPath_pictureBox.Image = Image.FromFile(picPath_textBox.Text);

            connection.Close();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            connection.Open();

            sql = "DELETE FROM studentTable WHERE student_id = '" + studNum_textBox.Text + "'";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            adaptersql = new SqlDataAdapter();
            adaptersql.DeleteCommand = command;
            command.ExecuteNonQuery();

            sql = "SELECT * FROM studentTable";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            adaptersql = new SqlDataAdapter();
            adaptersql.SelectCommand = command;
            command.ExecuteNonQuery();

            dset = new DataSet();
            adaptersql.Fill(dset, "studentTable");

            dataGridView1.DataSource = dset.Tables[0];
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            picPath_pictureBox.Image = Properties.Resources.default_image;

            studNum_textBox.Clear();
            studName_textBox.Clear();
            dept_textBox.Clear();
            picPath_textBox.Clear();
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            connection.Open();

            sql = "UPDATE studentTable SET student_name = '" + studName_textBox.Text + "', department = '" + dept_textBox.Text + "', picpath = '" + picPath_textBox.Text + "' WHERE student_id = '" + studNum_textBox.Text + "'";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            adaptersql = new SqlDataAdapter();
            adaptersql.UpdateCommand = command;
            command.ExecuteNonQuery();

            sql = "SELECT * FROM studentTable";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            adaptersql = new SqlDataAdapter();
            adaptersql.SelectCommand = command;
            command.ExecuteNonQuery();

            dset = new DataSet();
            adaptersql.Fill(dset, "studentTable");

            dataGridView1.DataSource = dset.Tables[0];
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            studNum_textBox.Clear();
            studName_textBox.Clear();
            dept_textBox.Clear();
            picPath_textBox.Clear();

            connection.Close();
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                // Load data from studentTable
                string sql = "SELECT * FROM studentTable";
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataSet dset = new DataSet();
                adapter.Fill(dset, "studentTable");

                dataGridView1.DataSource = dset.Tables[0];
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dataGridView1.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            picPath_pictureBox.Image = Properties.Resources.default_image;
            studNum_textBox.Clear();
            studName_textBox.Clear();
            dept_textBox.Clear();
            picPath_textBox.Clear();

        }
    }
}
