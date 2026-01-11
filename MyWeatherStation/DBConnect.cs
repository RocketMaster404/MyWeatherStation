using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWeatherStation
{
    

    internal class DBConnect
    {
        private readonly string _connectionString =
        "Server=localhost\\MSSQLSERVER01;Database=PersonDB;Trusted_Connection=True;";

       public void ConnectDB()
        {
            using(SqlConnection connection = new(_connectionString))
            {
                connection.Open();
                Console.WriteLine("Nu är vi fkn live!");
            }
        }
    }
}
