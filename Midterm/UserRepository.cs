using System;
using System.Collections.Generic;
using System.Text;

namespace Midterm
{
    public class EnterpriseMembers
    {

        public EmployeeAccess employeeAccess { get; protected set; }
        public EnterpriseMembers(string iD, string firstName, string lastName, string dateCreated, string departmentID)
        {
            this.ID = iD;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateCreated = dateCreated;
            this.DepartmentID = departmentID;
        }

        public EnterpriseMembers(string id)
        {
            this.ID = id;
        }

        public string ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string DateCreated { get; set; }

        public string Email { get; set; }

        public string DepartmentID { get; set; }
    }
}
