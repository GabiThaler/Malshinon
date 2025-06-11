using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Malshinon.DataBase
{
    public class MySqlData
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
            catch(Exception ex)
            {
                Console.WriteLine($"Error conacting to DATA BASE: {ex.Message}");
            }
        }

        public MySqlConnection GetConnect()
        {
            connection = new MySqlConnection(connictionString);
            try 
            {
                if (connection == null || connection.State==System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error conacting to database {ex.Message}");
            }
            return connection;
        }

        public void CloseConnect()
        {
            
            try
            {
                connection.Close();
                Console.WriteLine("the connection was closed succfuli");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"coonet close connection  {ex.Message}");
            }
        }
    }
}
