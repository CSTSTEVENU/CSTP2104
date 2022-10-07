using _2104_Sep2022.Week2Ex;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2104_Sep2022.Week1Quiz
{
    public abstract class Employee : ISalaryCalculator
    {
        public string ID { get; private set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public Employee(string id)
        {
            this.ID = id;
        }

        public Employee(string id, string name, string address, string phoneNumber)
        {
            this.ID = id;
            this.Name = name;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
        }
    }
}
