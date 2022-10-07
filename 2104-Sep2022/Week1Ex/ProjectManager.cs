using System;
using System.Collections.Generic;
using System.Text;

namespace _2104_Sep2022.Week1Quiz
{
    public class ProjectManager : Employee
    {
        public int Hours { get; set; }
        public int HourlyRate { get; set; }

        public ProjectManager(string id) : base(id)
        {
        }
    }
}
