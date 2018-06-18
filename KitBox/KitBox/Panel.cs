using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitBox
{
    class Panel : Product
    {
        private string color;

        public Panel(string ori, string col)
        {
            this.orientation = ori;
            this.color = col;
        }
    }
}