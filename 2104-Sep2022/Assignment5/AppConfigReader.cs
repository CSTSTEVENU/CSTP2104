using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;


namespace _2104_Sep2022.Assignment5
{
    public class AppConfigReader
    {
        public void ReadConnectionStrings()
        {
            foreach (ConnectionStringSettings css in ConfigurationManager.ConnectionStrings)
            {
                Console.WriteLine(css.Name);
                Console.WriteLine(css.ProviderName);
                Console.WriteLine(css.ConnectionString);
            }
        }

        public string GetConnctionString(string name)
        {
            var connectionStringSetting = ConfigurationManager.ConnectionStrings[name];
            return connectionStringSetting.ConnectionString;

        }
    }
}
