using System;

namespace Midterm
{
    class Program
    {
        static void Main(string[] args)
        {
            var userGenericStack = new UserGenericStack<UserRepository>(10);

            userGenericStack.Push(new StandardUser("SU102", "Steven", "Uhm", "January 10, 2002", EmployeeAccess.LimitedAccess, "SU102@tmail.com", "Delta"));
            userGenericStack.Push(new StandardUser("SU020", "Steven", "Uhm", "October 10, 1980", EmployeeAccess.FullAccess, "SU020@tmail.com", "Omega"));
            userGenericStack.Push(new StandardUser("SU300", "Jerry", "West", "October 07, 1969", EmployeeAccess.PartialAccess, "SU300@tmail.com", "Charlie"));
            userGenericStack.Push(new StandardUser("SU302", "Alex", "North", "May 07, 1999", EmployeeAccess.PartialAccess, "SU302@tmail.com", "Charlie"));
            userGenericStack.Push(new Manager("M005", "Michael", "Gunner", "June 09, 2001", EmployeeAccess.FullAccess, "M005@tmail.com", "Omega"));
            userGenericStack.Push(new Manager("M004", "Jessica", "Evans", "November 04, 1990", EmployeeAccess.FullAccess, "SU102@tmail.com", "Charlie"));
            userGenericStack.Push(new Owner("O001", "Brian", "Uhm", "March 20, 1981", EmployeeAccess.FullAccess, "Brian.uhm@tmail.com", "Operations"));
            userGenericStack.Push(new Administrator("A1101", "Jennifer", "Dipardo", "May 15, 1985", EmployeeAccess.NoAccess, "A1101@tmail.com", "Delta"));
            userGenericStack.Push(new Administrator("A1102", "Shane", "Garrison", "December 31, 1992", EmployeeAccess.FullAccess, "A1102@tmail.com", "Omega"));
            userGenericStack.Push(new Administrator("A1103", "Kira", "Yoon", "April 16, 2000", EmployeeAccess.FullAccess, "A1103@tmail.com", "Charlie"));
        }
    }
}
