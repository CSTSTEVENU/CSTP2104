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
    public class EmployeeRepository : IEmployeeRepository
    {
        public string GetConnectionString()
        {
            var appConfigReader = new AppConfigReader();
            appConfigReader.ReadConnectionStrings();

            var connString = appConfigReader.GetConnctionString("Project1Dev");
            if (string.IsNullOrWhiteSpace(connString))
            {
                Console.WriteLine("connection string was NOT FOUND");
            }

            return connString;
        }

        public List<Employee> Get(int Count = 10)
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

            List<Employee> employees = new List<Employee>();
            foreach (DataRow row in dataTable.Rows)
            {
                employees.Add((Employee)row["eID"]);
                employees.Add((Employee)row["eName"]);
                employees.Add((Employee)row["eAddress"]);
                employees.Add((Employee)row["PhoneNumber"]);
                employees.Add((Employee)row["eVacationDays"]);
                employees.Add((Employee)row["eStartYear"]);
                employees.Add((Employee)row["eSalary"]);
            }

            return employees;
            Console.WriteLine(employees);

            connection.Close();


        }
    }
}


