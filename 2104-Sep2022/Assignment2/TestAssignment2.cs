using _2104_Sep2022.Week1Quiz;
using _2104_Sep2022.Week2Ex;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2104_Sep2022.Assignment2
{
    public class TestAssignment2
    {
        public static void test2()
        {
            /*SalaryIndexer<string, string, Employee> salaryIndexer = new SalaryIndexer<string, string, Employee>();*/

            ISalaryCalculator salaryCalculator = new SalaryCalculator();

            Console.WriteLine(salaryCalculator.Calculate());
        }
    }
}
