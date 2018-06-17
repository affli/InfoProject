using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitBox
{
    public class Support_Angle : Product
    {
        string color;

        public void Setcolor(string color)
        {
            this.color = color;
        }

        public string Getcolor()
        {
            return color;
        }
    }
}