using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Демо
{
    class Class2
    {

        public static MySqlConnection GetDBConnection()
        {
            string host = "localhost";
            int port = 3311;
            string database = "ll";
            string user = "user9";
            string password = "root";

            return Class1.GetConnection(host, port, database, user, password);


        }
    }
}