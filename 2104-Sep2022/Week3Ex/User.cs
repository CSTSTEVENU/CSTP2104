using System;
using System.Collections.Generic;
using System.Text;

namespace _2104_Sep2022.Week3Ex
{
    public class User
    {
        protected string UserID { get; }

        public string Name { get; }

        public string Email { get; }

        public User( string userID, string name, string email)
        {
            this.UserID = userID;
            this.Name = name;
            this.Email = email;
        }
    }
}
