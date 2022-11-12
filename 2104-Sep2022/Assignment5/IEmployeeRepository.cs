using _2104_Sep2022.Week1Quiz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2104_Sep2022.Assignment5
{
    public interface IEmployeeRepository
    {
            List<Employee> Get(int Count = 10);
    }
}

