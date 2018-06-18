using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitBox
{
    class Support_Angle
    {
        private string color;
        private int height;

        public void Setheight(int value)
        {
            this.height = value;
        }

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