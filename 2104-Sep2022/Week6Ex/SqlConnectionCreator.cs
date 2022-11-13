using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2104_Sep2022.Assignment5
{
    public class SqlConnectionCreator
    {
        public string GetConnectionString()
        {
            var appConfigReader = new AppConfigReader();
            // appConfigReader.ReadConnectionStrings();

            var connString = appConfigReader.GetConnctionString("Project1Dev");
            if (string.IsNullOrWhiteSpace(connString))
            {
                Console.WriteLine("connection string was NOT FOUND");
            }

            return connString;
        }

        public void TestConnect()
        {
            SqlConnection connection = new SqlConnection(GetConnectionString());
            connection.Open();
            Console.WriteLine($"Connection.State after open={connection.State}");
            connection.Close();
            Console.WriteLine($"Connection.State after close={connection.State}");
        }
    }
}
