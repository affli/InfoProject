using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitBox
{
    class Client
    {
        public string name { get; set; }
        public string email { get; set; }
        public string phonenumber { get; set; }

        public void Setname(string name)
        {
            this.name = name;
        }

        public void Setemail(string email)
        {
            this.email = email;
        }

        public void Setphonenumber(string phonenumber)
        {
            this.phonenumber = phonenumber;
        }

        public string Getname()
        {
            return name;
        }

        public string Getemail()
        {
            return email;
        }

        public string Getphonenumber()
        {
            return phonenumber;
        }
    }
}
