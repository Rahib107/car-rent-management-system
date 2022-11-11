using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;


namespace Car_Rental_Management_System.Data
{
    class DataAccess
    {
        static SqlConnection connection;
        static SqlCommand command;

        public DataAccess()
        {
            connection = new SqlConnection(@"Data Source=WIN-SM53781DBFJ\SQLEXPRESS;Initial Catalog=CrmsDb;Integrated Security=True");
            connection.Open();
        }

        public SqlDataReader GetData(string sql)
        {
            command = new SqlCommand(sql, connection);
            return command.ExecuteReader();
        }

        public int ExecuteQuery(string sql)
        {
            command = new SqlCommand(sql, connection);
            return command.ExecuteNonQuery();
        }

        public void Dispose()
        {
            connection.Close();
        }
        ~DataAccess()
        {
            connection.Close();
        }
    }
}
