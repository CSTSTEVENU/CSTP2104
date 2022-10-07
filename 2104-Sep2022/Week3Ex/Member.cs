using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace _2104_Sep2022.Week3Ex
{
    public class Member : User, IMember, IEquatable<Member>
    {
        public Member(string userID, string name, string email, string memberID) :
            base(userID, name, email)
        {
            this.MemberID = memberID;
        }

        public string MemberID { get; }

        public string[] Interests { get; set; }

        public bool Equals(Member other)
        {
            return this.MemberID == other.MemberID && this.UserID == other.UserID;
        }

        public string GetUserID()
        {
            return this.UserID;
        }
    }
}
