using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace LESSON1_1
{
    public partial class SQL_LongMethod_2 : Form
    {
        // --- Declaration of variables used in the form programs for database ---
        string picpath;                 // a string variable used to hold the location of the image
        string connectionstring;        // a string variable to hold the SQL connection string
        SqlConnection connection;       // variable to hold SQL connection object
        SqlCommand command;             // variable to hold SQL command/query
        DataSet dset;                   // variable to hold data from the SQL database
        SqlDataAdapter adaptersql;      // variable to hold SQL Data Adapter object
        string sql = null;              // variable to hold the SQL statement

        public SQL_LongMethod_2()
        {
            InitializeComponent();
            // --- Codes in creating and establishing SQL Connection Object ---
            connectionstring = "Data Source=localhost\\SQLEXPRESS; Initial Catalog=SampleDatabaseDb; user id=Bernard; password=Ordonez23#;";
            connection = new SqlConnection(connectionstring);
        }

        // ------------------------ SAVE BUTTON CODE ----------------------------
        private void Save_Button(object sender, EventArgs e)
        {
            // Code to open the connection between C# and MS SQL
            connection.Open();

            // MSSQL query to insert or save data from GUI interface 
            sql = "INSERT INTO studentTbl (student_id, student_name, department, picpath) VALUES ('"
                + richTextBox2.Text + "', '"
                + richTextBox3.Text + "', '"
                + richTextBox4.Text + "', '"
                + richTextBox1.Text + "')";

            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            // Codes for mediating the language or world of C# and MSSQL
            adaptersql = new SqlDataAdapter();
            adaptersql.InsertCommand = command;
            command.ExecuteNonQuery();

            // MSSQL query to display the contents of student table
            sql = "SELECT * FROM studentTbl";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            adaptersql = new SqlDataAdapter();
            adaptersql.SelectCommand = command;
            command.ExecuteNonQuery();

            // Codes for mirroring the contents of the database inside MSSQL going to C# or Visual Studio
            dset = new DataSet();
            adaptersql.Fill(dset, "studentTbl");

            // Codes for displaying the contents of student table inside of data grid view
            dataGridView1.DataSource = dset.Tables[0];

            // Clearing of textboxes after saving the data to the database
            pictureBox1.Image = Image.FromFile(@"C:\Users\Bernard Ordonez\source\DSAL01E\LESSON1_1\LESSON1_1\Resources\ashville Hot Chicken (fried chicken with a fiery cayenne-based paste).jpg");
            richTextBox2.Clear();
            richTextBox3.Clear();
            richTextBox4.Clear();
            richTextBox1.Clear();

            // Codes for closing the connection
            connection.Close();
        }

        // ----------------------- SEARCH BUTTON CODE ---------------------------
        private void Search_Button(object sender, EventArgs e)
        {
            // Code to open the connection between C# and MS SQL
            connection.Open();

            // MSSQL query to display the contents of student table based on ID
            sql = "SELECT * FROM studentTbl WHERE student_id = '" + richTextBox2.Text + "'";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            // Codes for mediating the language or world of C# and MSSQL
            adaptersql = new SqlDataAdapter();
            adaptersql.SelectCommand = command;
            command.ExecuteNonQuery();

            // Codes for mirroring the contents of the database inside MSSQL going to C# or Visual Studio
            dset = new DataSet();
            adaptersql.Fill(dset, "studentTbl");

            // Codes for displaying the contents of student table inside of data grid view
            dataGridView1.DataSource = dset.Tables[0];

            // Codes for displaying the contents of the student table to the textboxes
            richTextBox3.Text = dset.Tables[0].Rows[0][1].ToString();
            richTextBox4.Text = dset.Tables[0].Rows[0][2].ToString();
            richTextBox1.Text = dset.Tables[0].Rows[0][3].ToString();

            // Displaying the saved image using the file location to the PictureBox
            pictureBox1.Image = Image.FromFile(richTextBox1.Text);

            // Codes for closing the connection
            connection.Close();
        }

        // ----------------------- DELETE BUTTON CODE ---------------------------
        private void Delete_Button(object sender, EventArgs e)
        {
            connection.Open();

            //mssql query to modify the contents of student table located inside the database
            sql = "DELETE FROM studentTbl WHERE student_id = '" + richTextBox2.Text + "'";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            //codes for mediating the language or world of C# and MSSQL
            adaptersql = new SqlDataAdapter();
            adaptersql.DeleteCommand = command;
            command.ExecuteNonQuery();

            //mssql query to display the contents of student table located inside the database
            sql = "SELECT * FROM studentTbl ";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            //codes for mediating the language or world of C# and MSSQL
            adaptersql = new SqlDataAdapter();
            adaptersql.SelectCommand = command;
            command.ExecuteNonQuery();

            //codes for mirroring the contents of the database inside the MSSQL going to C# or Visual Studio
            dset = new DataSet();
            adaptersql.Fill(dset, "studentTbl");

            //codes for displaying the contents of student table to the inside of data grid view
            dataGridView1.DataSource = dset.Tables[0];
            pictureBox1.Image = Image.FromFile("C:\\Users\\Bernard Ordonez\\source\\DSAL01E\\LESSON1_1\\LESSON1_1\\Resources\\Bacon-Wrapped Pork Chop.jpg");
            connection.Close();
        }
        // ----------------------- EDIT BUTTON CODE ---------------------------
        private void Edit_Button(object sender, EventArgs e)
        {
            connection.Open();

            // Update record
            sql = "UPDATE studentTbl SET " +
                  "student_name = '" + richTextBox3.Text + "', " +
                  "department = '" + richTextBox4.Text + "', " +
                  "picpath = '" + richTextBox1.Text + "' " +
                  "WHERE student_id = '" + richTextBox2.Text + "';";

            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;
            command.ExecuteNonQuery();

            // Refresh table display
            sql = "SELECT * FROM studentTbl";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            adaptersql = new SqlDataAdapter(command);
            dset = new DataSet();
            adaptersql.Fill(dset, "studentTbl");

            dataGridView1.DataSource = dset.Tables[0];

            // Reset UI
            pictureBox1.Image = Image.FromFile("C:\\Users\\Bernard Ordonez\\source\\DSAL01E\\LESSON1_1\\LESSON1_1\\Resources\\User Face.jpg");
            richTextBox2.Clear();
            richTextBox3.Clear();
            richTextBox4.Clear();
            richTextBox1.Clear();

            connection.Close();
        }
        // ----------------------- CANCEL BUTTON CODE ---------------------------
        private void Cancel_Button(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\Bernard Ordonez\\source\\DSAL01E\\LESSON1_1\\LESSON1_1\\Resources\\User Face.jpg");
            richTextBox2.Clear();
            richTextBox3.Clear();
            richTextBox4.Clear();
            richTextBox1.Clear();
        }
        // ----------------------- CANCEL BUTTON CODE ---------------------------
        private void New_Button(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\Bernard Ordonez\\source\\DSAL01E\\LESSON1_1\\LESSON1_1\\Resources\\User Face.jpg");
            richTextBox2.Clear();
            richTextBox3.Clear();
            richTextBox4.Clear();
            richTextBox1.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //codes for inserting picture from the local file to the picturebox
            openFileDialog1.Filter = "Image File | *.gif; *.jpg; *.png; *.bmp";
            //filtering of image display using specific file extension
            openFileDialog1.ShowDialog(); //displaying the file dialogbox where the possible image located
            pictureBox1.Image = Image.FromFile(openFileDialog1.FileName); //inserting of selected image to the picturebox shown in the GUI interface
            picpath = openFileDialog1.FileName; //storing the file location of the selected image inserted in picturebox to a variable
            richTextBox1.Text = picpath;
        }
    }
}
