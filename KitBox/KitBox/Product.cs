using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitBox
{
    public class Product : Dimension
    {
        public int Price { get; set; }
        public int height { get; set; }
        public int width { get; set; }
        public int depth { get; set; }

        public void Setdepth(int value)
        {
            this.depth = value;
        }

        public void Setheight(int value)
        {
            this.height = value;
        }

        public void Setwidth(int value)
        {
            this.width = value;
        }
    }
}