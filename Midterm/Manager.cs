using System;
using System.Collections.Generic;
using System.Text;

namespace Midterm
{
    public class Manager : EnterpriseMembers
    {
        public Manager(string ID, string FirstName, string LastName, string DateCreated, EmployeeAccess employeeAccess, string email, string DepartmentID) : base(ID, FirstName, LastName, DateCreated, DepartmentID)
        {

        }
    }
}
