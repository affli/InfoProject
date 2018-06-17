using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitBox
{
    class Client
    {
        string Name;
        string Email;
        string PhoneNumber;

        public Client(string Name, string Email, string PhoneNumber)
        {
            this.Name = Name;
            this.Email = Email;
            this.PhoneNumber = PhoneNumber;
        }
    }
}
