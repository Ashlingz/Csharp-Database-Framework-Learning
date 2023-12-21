using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace SQLSERVER
{
    internal class ConnectionDB
    {

        public static SqlConnection Datacon { get; set; }
        public static void Connection(string ip,string dbName)
        {
            Datacon = new SqlConnection($"Server={ip};Database={dbName};Trusted_Connection=True;");
            Datacon.Open();
        }

        public static void Connection(string ip, string dbName,string user,string pass)
        {
            Datacon = new SqlConnection($"Server={ip};Database={dbName};User Id={user};Password={pass};");
            Datacon.Open();
        }
    }
}
