using CSTP2104_Assignment1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSTP2104_Assignment1
{
    public interface ICustomer
    {
        string Name { get; set; }
        string Email { get; set; }
    }
}

public class Customer : ICustomer
{

    public string _email;
    public string _name;
    public string Email { get => _email; set => _email = value; }

    public string Name { get => _name; set => _name = value; }

}


