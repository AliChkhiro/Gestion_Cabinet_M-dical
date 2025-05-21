using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management
{
    internal class DatabaseConnection
    {
        private MySqlConnection connection;
        public DatabaseConnection()
        {
            string connectionString = "Server=127.0.0.1;Database=HospitalDB;Uid=root;Pwd=€ali@068788/SEVEN97€";
            connection = new MySqlConnection(connectionString);
        }
        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }
}
