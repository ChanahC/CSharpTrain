using System;
using System.Data;
using System.Data.SqlClient;

namespace QuickSharp
{
    public class Program
    {
        private static void Main()
        {
            Console.WriteLine("Hello World!");
            SqlConnection conn = new SqlConnection("server=(local)\\SQLEXPRESS;database=MyDatabase;Integrated Security=SSPI;");
            /*
            YOu could also try doing this...
            String dbstring = "server=local\\*inset the other shits in here*";
            SlConnection conn = new SqlConnection(dbstring);
            */
            try {
                conn.Open();
                Console.WriteLine("Connection opened.");
            }
            catch (SqlException e) {
                Console.WriteLine("Error: " + e);
            }
            finally {
                conn.Close();
                Console.WriteLine("Connection closed.");
            }
        }
    }
}