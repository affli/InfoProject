using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitBox
{
    class Product
    {
        public int Price { get; set; }
        public int height { get; set; }
        public int width { get; set; }
        public int depth { get; set; }
        public string orientation { get; set; }

        public void Setdepth(int value)
        {
            this.depth = value;
        }

        public string Getorientation()
        {
            return orientation;
        }

        public void Setheight(int value)
        {
            this.height = value;
        }

        public void Setwidth(int value)
        {
            this.width = value;
        }

        public int Getdepth()
        {
            return depth;
        }

        public int Getheight()
        {
            return height;
        }

        public int Getwidth()
        {
            return width;
        }
    }
}