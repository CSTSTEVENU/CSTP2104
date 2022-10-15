using System;
using System.Collections.Generic;
using System.Text;

namespace _2104_Sep2022.Assignment_3
{

    // Assignment 3 Part 1
    public class SalaryCalculator2
    {
        public delegate double SalaryDelegate(string ID, int Hours, double Rate, double Pay);

        public void Calculate()
        {
            SalaryDelegate salaryDelegate = CalculateSalary;

            var result = salaryDelegate("Mario", 200, 40, 80.2);

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

    }
    public class EmployeePayroll
    {
        private string v1;
        private double v2;
        private double v3;

        public EmployeePayroll(string v1, double v2, double v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        public string ID { get; set; }

        public int Hours { get; set; }

        public double Rate { get; set; }

        public double Pay { get; set; }

    }
}

