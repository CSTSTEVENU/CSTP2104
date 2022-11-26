using _2104_Sep2022.Week1Quiz;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2104_Sep2022.Assignment6
{
    public interface IContactRepository
    {
            
        string GetConnectionString();

        List<Contact> Get(int Count = 10);

        void Insert(Contact contact);


        void Delete(string contactID);

        void Update(Contact contact);

    }
}

