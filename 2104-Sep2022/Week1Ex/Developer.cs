using _2104_Sep2022.Week2Ex;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2104_Sep2022.Week1Quiz
{
    public class Developer : StandardEmployee
    {
        public Developer(string id, StandardEmployeeType employeeType, int startYear) 
            : base(id, employeeType, startYear)
        {
            this.VacationDays = 15;
            this.SetSalary();
        }

        public override int GetVacationDays()
        {
            if (DateTime.Now.Year - this.startYear >= 5)
            {
                return this.VacationDays + 5;
            }

            return this.VacationDays;
        }

        // Override for the abstract function
        public override int StartYear => this.StartYear;
    }
}
