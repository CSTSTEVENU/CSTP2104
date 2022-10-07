using _2104_Sep2022.Week2Ex;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2104_Sep2022.Week1Quiz
{
    public abstract class StandardEmployee : Employee
    {
        public StandardEmployeeType EmployeeType { get; protected set; }
        protected int VacationDays;
        protected int startYear;
        protected double Salary;

        public StandardEmployee(string id) : base(id)
        {
        }

        public StandardEmployee(string id, StandardEmployeeType employeeType, int startYear) : base(id)
        {
            this.EmployeeType = employeeType;
            this.startYear = startYear;
        }

        public void Display()
        {
            Console.WriteLine(
                string.Format("Name:{0} - ID:{1}", this.Name, this.ID));
        }

        public virtual int GetVacationDays()
        {
            return this.VacationDays;
        }

        protected virtual void SetSalary()
        {
            if (StandardEmployeeType.Fulltime == this.EmployeeType)
            {
                this.Salary = SalaryConfiguration.DefaultFulltimeSalary;
            }
            else
            {
                this.Salary = SalaryConfiguration.DefaultParttimeSalary;
            }
        }

        public abstract int StartYear { get; }
    }
}
