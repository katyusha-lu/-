using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Демо
{
    class Class1
    {
            public static MySqlConnection GetConnection(string host, int port, string database, string user, string password)
            {
                String connString = "Server=" + host + ";port=" + port + ";database=" + database + ";user=" + user + ";password=" + password + ";";
                MySqlConnection conn = new MySqlConnection(connString);
                return conn;
            }
        
    }
}
