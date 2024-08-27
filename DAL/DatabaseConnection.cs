using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class DatabaseConnection
    {
        private readonly string connectionString;

        public DatabaseConnection()
        {
            //connectionString = "server=localhost;database=atmsystemdb;user=root;password=admin;"
            connectionString = "server=bo2g526zu8wewuxa0jf6-mysql.services.clever-cloud.com;database=bo2g526zu8wewuxa0jf6;user=uqwkrejrkwcrglho;password=9fCWuBTKA6ENC2EfqngG;";
        }

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
