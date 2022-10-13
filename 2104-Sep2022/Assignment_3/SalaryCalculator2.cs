using System;
using System.Collections.Generic;
using System.Text;
using static _2104_Sep2022.Assignment_3.SalaryCalculator2;

namespace _2104_Sep2022.Assignment_3
{

    // Assignment 3 Part 1
    public class SalaryCalculator2
    {
        public delegate double SalaryDelegate(string ID, int Hours, double Rate, double Pay);

        public void Calculate()
        {
            SalaryDelegate salaryDelegate = CalculateSalary;

            var result = salaryDelegate("Steven", 200, 40, 80.2);

            Console.WriteLine(result);
        }

        public double CalculateSalary(string ID, int Hours, double Rate, double Pay)
        {
            if (ID[0] == 'M')
            {
                return (Hours * Pay) + 500;
            }

            else
            {
                return (Hours + Pay);
            }
        }

        // Assignment 3 Part 2

        public void EmployeeList()
        {   
            List<EmployeePayroll> employeeList = new List<EmployeePayroll>();
        {
               var e1 = new EmployeePayroll { ID = "M001", Hours = 23, Rate = 50, Pay = 0 };
               var e2 = new EmployeePayroll { ID = "S001", Hours = 40, Rate = 40, Pay = 0 };
               var e3 = new EmployeePayroll { ID = "M002", Hours = 38, Rate = 52.50, Pay = 0 };
               var e4 = new EmployeePayroll { ID = "S011", Hours = 42, Rate = 43.50, Pay = 0 };
               var e5 = new EmployeePayroll { ID = "M023", Hours = 34, Rate = 42, Pay = 0 };


                employeeList.Add(e1);
                employeeList.Add(e2);
                employeeList.Add(e3);
                employeeList.Add(e4);
                employeeList.Add(e5);

                Console.WriteLine(employeeList);
     
            };
        }

        public class EmployeePayroll
        {
            public string ID { get; set; }
            public int Hours { get; set; }

            public double Rate { get; set; }

            public double Pay { get; set; }

        }

    }
}

