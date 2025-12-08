using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LESSON1_1
{
    internal class payrol_dbconnection
    {
        //declaration of variables for database connections and queries to access from one
        //form to another
        public String payroll_connectionString = null;
        public SqlConnection payroll_sql_connection;
        public SqlCommand payroll_sql_command;
        public DataSet payroll_sql_dataset;
        public SqlDataAdapter payroll_sql_dataadapter;
        public string payroll_sql = null;

        public void payroll_connString()
        {
            //codes to establish connection from C# forms to the SQL Server database
            payroll_sql_connection = new SqlConnection();
            payroll_connectionString = "Data Source=localhost\\SQLEXPRESS; Initial Catalog=POSDB; user id=Bernard; password=Ordonez23#";
            payroll_sql_connection = new SqlConnection(payroll_connectionString);
            payroll_sql_connection.ConnectionString = payroll_connectionString;
            payroll_sql_connection.Open();
        }
        public void payroll_cmd()//public function codes that support the MSSQL query
        {
            payroll_sql_command = new SqlCommand(payroll_sql, payroll_sql_connection);
            payroll_sql_command.CommandType = CommandType.Text;
        }
        public void payroll_sqldataadapterSelect()//public function codes for mediating between C# language and the MSSQL SELECT command
        {
            {
                payroll_sql_dataadapter = new SqlDataAdapter();
                payroll_sql_dataadapter.SelectCommand = payroll_sql_command;
                payroll_sql_command.ExecuteNonQuery();
            }
        }
        public void payroll_sqldataadapterInsert()//public function codes for mediating between C# language and the MSSQL INSERT command
        {
            {
                payroll_sql_dataadapter = new SqlDataAdapter();
                payroll_sql_dataadapter.InsertCommand = payroll_sql_command;
                payroll_sql_command.ExecuteNonQuery();
            }
        }
        public void payroll_sqldataadapterDelete()//public function codes for mediating between C# language and the MSSQL DELETE command
        {
            {
                payroll_sql_dataadapter = new SqlDataAdapter();
                payroll_sql_dataadapter.DeleteCommand = payroll_sql_command;
                payroll_sql_command.ExecuteNonQuery();
            }
        }
        public void payroll_sqldataadapterUpdate()//public function codes for mediating between C# language and the MSSQL UPDATE command
        {
            {
                payroll_sql_dataadapter = new SqlDataAdapter();
                payroll_sql_dataadapter.UpdateCommand = payroll_sql_command;
                payroll_sql_command.ExecuteNonQuery();
            }
        }
        public void payroll_sqldataadapterSELECT()//codes for mirroring the contents of the database inside the MSSQL going to C# or Visual Studio
        {
            {
                payroll_sql_dataset = new DataSet();
                payroll_sql_dataadapter.Fill(payroll_sql_dataset, "pos_empRegTbl");
            }
        }

    }
}
