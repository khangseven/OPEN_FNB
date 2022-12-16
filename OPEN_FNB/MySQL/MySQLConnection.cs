using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OPEN_FNB.MySQL
{
    internal class MySQLConnection
    {

        public static MySQLConnection conn { get; set; }

        public static MySqlConnection getMySQLConnection(string server, string port, string database, string uid, string pwd)
        {
            string connString = "server="+server+";port="+port+";database="+database+";uid="+uid+"; pwd="+pwd+ ";CharSet=utf8;";

            MySqlConnection conn = new MySqlConnection(connString);

            return conn;



        }
    }
}
