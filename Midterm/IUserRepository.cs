using System;
using System.Collections.Generic;
using System.Text;

namespace Midterm
{
    public interface IUserRepository
    {
        void Add(UserRepository enterpriseMembers)
        {
            var userGenericStack = new UserGenericStack<UserRepository>(10);

            userGenericStack.Push(new StandardUser(enterpriseMembers.ID, enterpriseMembers.FirstName, enterpriseMembers.LastName, enterpriseMembers.DateCreated, enterpriseMembers.employeeAccess ,enterpriseMembers.Email, enterpriseMembers.DepartmentID));
            userGenericStack.Push(new Manager(enterpriseMembers.ID, enterpriseMembers.FirstName, enterpriseMembers.LastName, enterpriseMembers.DateCreated, enterpriseMembers.employeeAccess, enterpriseMembers.Email, enterpriseMembers.DepartmentID));
            userGenericStack.Push(new Owner(enterpriseMembers.ID, enterpriseMembers.FirstName, enterpriseMembers.LastName, enterpriseMembers.DateCreated, enterpriseMembers.employeeAccess, enterpriseMembers.Email, enterpriseMembers.DepartmentID));
            userGenericStack.Push(new Administrator(enterpriseMembers.ID, enterpriseMembers.FirstName, enterpriseMembers.LastName, enterpriseMembers.DateCreated, enterpriseMembers.employeeAccess, enterpriseMembers.Email, enterpriseMembers.DepartmentID));

        }

        void Update(UserRepository enterpriseMembers)
        {

        }

        void Delete(UserRepository enterpriseMembers)
        {
            var userGenericStack = new UserGenericStack<UserRepository>(10);

            userGenericStack.Pop(new StandardUser(enterpriseMembers.ID, enterpriseMembers.FirstName, enterpriseMembers.LastName, enterpriseMembers.DateCreated, enterpriseMembers.employeeAccess, enterpriseMembers.Email, enterpriseMembers.DepartmentID));
            userGenericStack.Pop(new Manager(enterpriseMembers.ID, enterpriseMembers.FirstName, enterpriseMembers.LastName, enterpriseMembers.DateCreated, enterpriseMembers.employeeAccess, enterpriseMembers.Email, enterpriseMembers.DepartmentID));
            userGenericStack.Pop(new Owner(enterpriseMembers.ID, enterpriseMembers.FirstName, enterpriseMembers.LastName, enterpriseMembers.DateCreated, enterpriseMembers.employeeAccess, enterpriseMembers.Email, enterpriseMembers.DepartmentID));
            userGenericStack.Pop(new Administrator(enterpriseMembers.ID, enterpriseMembers.FirstName, enterpriseMembers.LastName, enterpriseMembers.DateCreated, enterpriseMembers.employeeAccess, enterpriseMembers.Email, enterpriseMembers.DepartmentID));

        }

        void Get(string id)
        {
            
        }
    }
}
