using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitBox
{
    public class Door : Product
    {
        string type;

        public Door(string value)
        {
            this.type = value;
        }

        public string Gettype()
        {
            return type;
        }
    }
}