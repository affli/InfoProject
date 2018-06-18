using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitBox
{
    class Rails : Product
    {
        private bool groove;

        public void Setinfo(string ori, bool slot)
        {
            this.orientation = ori;
            this.groove = slot;
        }
    }
}