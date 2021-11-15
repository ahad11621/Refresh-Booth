using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ATM_System.Data
{
    class DataAccess
    {
        static MySqlConnection connection;
        static MySqlCommand command;

        public DataAccess()
        {
            connection = new MySqlConnection("datasource = localhost;username = root; password=; database = atm-system");
            connection.Open();
        }

        public MySqlDataReader GetData(string sql)
        {
            command = new MySqlCommand(sql, connection);
            return command.ExecuteReader();
        }

        public int ExecuteQuery(string sql)
        {
            command = new MySqlCommand(sql, connection);
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
