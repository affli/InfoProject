using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitBox
{
    public class Panel : Product
    {
        string Orientation;
        string color;

        public Panel(string ori, string col)
        {
            this.Orientation = ori;
            this.color = col;
        }
    }
}