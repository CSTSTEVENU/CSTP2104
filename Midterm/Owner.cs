using System;
using System.Collections.Generic;
using System.Text;

namespace Midterm
{
    public class Owner : EnterpriseMembers
    {
        public Owner(string ID, string FirstName, string LastName, string DateCreated, EmployeeAccess employeeAccess, string email, string DepartmentID) : base(ID, FirstName, LastName, DateCreated, DepartmentID)
        {

        }
    }
}
