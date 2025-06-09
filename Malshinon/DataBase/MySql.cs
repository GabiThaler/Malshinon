using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Malshinon.DataBase
{
    internal class MySqlData
    {
        static string connictionString = "server=localhost;DataBase=project1;user=root;Password='';Port=3306;";
        private MySqlConnection connection;

        public void connect()
        {
            var conn = new MySqlConnection(connictionString);
            connection = conn;

            try
            {
                conn.Open();
                Console.WriteLine("conneted to MySql database successfully.");
                conn.Close();

            }
            catch(MySqlException ex)
            {
                Console.WriteLine($"Error conacting to DATA BASE: {ex.Message}");
            }
        }
    }
}
