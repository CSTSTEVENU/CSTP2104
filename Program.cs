using System;

namespace Exercise1_CSTP2104
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public class Organization
        {
            // data members 
            private string name;
            private string jobTitle;
            private int daysWorked;
            private int salary;

            public string Name { get; set; }
            public string JobTitle { get; set; }

            public int DaysWorked { get; set; }
            public int Salary { get; set; }

            public Organization(string name, string jobTitle, int daysWorked, int salary)
            {
                this.name = name;
                this.jobTitle = jobTitle;
                this.daysWorked = daysWorked;
                this.salary = salary; 
            }

        }

        public class projectManger : Organization
        {
            public projectManger(string name, string jobTitle, int daysWorked, int salary) : base( name, jobTitle, daysWorked, salary)
            {

            }
        }

        public class developer : Organization
        {
            public developer(string name, string jobTitle, int daysWorked, int salary) : base(name, jobTitle, daysWorked, salary)
            {

            }
        }
    }
}
