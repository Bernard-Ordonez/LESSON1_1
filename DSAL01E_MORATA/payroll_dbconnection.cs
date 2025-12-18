using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAL01E_MORATA
{
    public class payroll_dbconnection
    {
        public String payroll_connectionString = null;
        public SqlConnection payroll_sql_connection;
        public SqlCommand payroll_sql_command;
        public DataSet payroll_sql_dataset;
        public SqlDataAdapter payroll_sql_dataadapter;
        public string payroll_sql = null;

        public void payroll_connString()
        {
            payroll_sql_connection = new SqlConnection();
            //payroll_connectionString = @"Data Source = C203-24; Initial Catalog = POSDB; user id = SA; password = B1Admin123@";
            payroll_connectionString = @"Data Source=DESKTOP-4B2S90A\SQLEXPRESS;Initial Catalog=POSDB;Integrated Security=True;";
            payroll_sql_connection = new SqlConnection(payroll_connectionString);
            payroll_sql_connection.ConnectionString = payroll_connectionString;
            payroll_sql_connection.Open();
        }

        public void payroll_cmd()
        {
            payroll_sql_command = new SqlCommand(payroll_sql, payroll_sql_connection);
            payroll_sql_command.CommandType = CommandType.Text;
        }

        public void payroll_sqladapterSelect()
        {
            payroll_sql_dataadapter = new SqlDataAdapter();
            payroll_sql_dataadapter.SelectCommand = payroll_sql_command;
            payroll_sql_command.ExecuteNonQuery();
        }

        public void payroll_sqladapterInsert()
        {
            payroll_sql_dataadapter = new SqlDataAdapter();
            payroll_sql_dataadapter.InsertCommand = payroll_sql_command;
            payroll_sql_command.ExecuteNonQuery();
        }

        public void payroll_sqladapterDelete()
        {
            payroll_sql_dataadapter = new SqlDataAdapter();
            payroll_sql_dataadapter.DeleteCommand = payroll_sql_command;
            payroll_sql_command.ExecuteNonQuery();
        }

        public void payroll_sqladapterUpdate()
        {
            payroll_sql_dataadapter = new SqlDataAdapter();
            payroll_sql_dataadapter.UpdateCommand = payroll_sql_command;
            payroll_sql_command.ExecuteNonQuery();
        }

        public void payroll_sqldatasetSELECT()
        {
            payroll_sql_dataset = new DataSet();
            payroll_sql_dataadapter.Fill(payroll_sql_dataset, "pos_empRegTbl");
        }
    }
}
