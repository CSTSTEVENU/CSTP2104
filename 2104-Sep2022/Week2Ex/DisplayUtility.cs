using _2104_Sep2022.Week1Quiz;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2104_Sep2022.Week2Ex
{
    public static class DisplayUtility
    {
        public static void DisplayProperties(StandardEmployee employee)
        {
            Console.WriteLine(
                string.Format(
                    "Name:{0} - ID:{1} - VacationDays:{2}", 
                    employee.Name, 
                    employee.ID,
                    employee.GetVacationDays()));
        }
    }
}
