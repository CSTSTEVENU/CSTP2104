using System;
using System.Collections.Generic;
using System.Text;

namespace Midterm
{
    public class Administrator : UserRepository
    {
        public Administrator(string ID, string FirstName, string LastName, string DateCreated, EmployeeAccess employeeAccess, string email, string DepartmentID) : base(ID, FirstName, LastName, DateCreated, DepartmentID)
        {

        }
    }
}
