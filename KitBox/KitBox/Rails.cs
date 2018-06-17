using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitBox
{
    class Rails : Product
    {
        string Orientation;
        bool slot;

        public void Setinfo(string ori, bool slot)
        {
            this.Orientation = ori;
            this.slot = slot;
        }      
    }
}