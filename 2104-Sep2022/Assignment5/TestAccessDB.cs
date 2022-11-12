using _2104_Sep2022.Week1Ex;
using _2104_Sep2022.Week1Quiz;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2104_Sep2022.Assignment5
{
    public class TestAccessDB
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

        public void TestSelect()
        {
            SqlConnection connection = new SqlConnection(GetConnectionString());
            connection.Open();
            string sqlCommandText = "SELECT TOP 10 * FROM EMPLOYEE";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommandText, connection);
            DataTable dataTable = new DataTable();

            dataAdapter.Fill(dataTable);

            foreach (DataRow row in dataTable.Rows)
            {
                Console.WriteLine($"Row: EmployeeID: {row["eID"]}, EmployeeName: {row["eName"]} EmployeeAddress: {row["eAddress"]} PhoneNumber: {row["PhoneNumber"]} VacationDays: {row["eVacationDays"]} StartYear: {row["eStartYear"]} EmployeeSalary: {row["eSalary"]}");
            }

            connection.Close();
        }

        public void TestGenericCollection()
        {
            var employeeDictionary = new Dictionary<string, Employee>();

            var dev1 = new Developer("Dev001", StandardEmployeeType.Fulltime, 1999);
            employeeDictionary.Add(dev1.ID, dev1);

            var proj1 = new ProjectManager("Proj001");
            employeeDictionary.Add(proj1.ID, proj1);

            var gm1 = new GroupManager("GM001", 20121007);
            employeeDictionary.Add(gm1.ID, gm1);

            var DOE1 = new DevOpsEngineer("DOE001", StandardEmployeeType.Fulltime, 2000);
            employeeDictionary.Add(DOE1.ID, DOE1);

            var prodM1 = new ProductManager("PRODM001", StandardEmployeeType.Parttime, 2005);
            employeeDictionary.Add(prodM1.ID, prodM1);

            foreach (var obj in employeeDictionary)
            {
                if (obj.Value is Developer) // type check
                {
                    var developer = (Developer)obj.Value;
                    Console.WriteLine($"developer: {developer.ID}");
                }
                else if (obj.Value is ProjectManager)
                {
                    var projectManager = (ProjectManager)obj.Value;
                    Console.WriteLine($"projectManager: {projectManager.ID}");
                }
                else if (obj.Value is GroupManager)
                {
                    var groupManager = (GroupManager)obj.Value;
                    Console.WriteLine($"groupManager: {groupManager.ID}");
                }
                else if (obj.Value is ProjectManager)
                {
                    var productManager = (ProductManager)obj.Value;
                    Console.WriteLine($"productManager: {productManager.ID}");
                }
                else if (obj.Value is DevOpsEngineer)
                {
                    var DevOpsEngineer = (DevOpsEngineer)obj.Value;
                    Console.WriteLine($"DevOpsEngineer: {DevOpsEngineer.ID}");
                }
            }
        }
    }
}
