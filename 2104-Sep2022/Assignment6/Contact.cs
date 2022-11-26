using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2104_Sep2022.Assignment6
{
    public class Contact
    {
        public string contactID { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }

        public string companyName { get; set; }

        public enum phoneNumber 
        {
            cell,
            home,
            work
        }

        public string personalEmail { get; set; }

        public string workEmail { get; set; }

        public string homeAddress { get; set; }

        public string workAddress { get; set; }

        public string contactUrl { get; set; }

        public string Notes { get; set; }

        public string sourceOfIntroduction { get; set; }

        public string linkedContacts { get; set; }


    }
}
