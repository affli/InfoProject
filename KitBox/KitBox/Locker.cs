using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitBox
{
    public class Locker
    {
        int height;
        Dictionary<Product, int> Elements = new Dictionary<Product, int>();
        List<Door> doors = new List<Door>();
        string color;

        public void Addproduct(Product var, int quantity)
        {
            Elements.Add(var, quantity);
        }

        public void Setheight(int height)
        {
            this.height = height;
        }

        public void Setcolor(string color)
        {
            this.color = color;
        }

        public void Adddoors(Door door)
        {
            doors.Add(door);
        }

        public List<Door> Getdoors()
        {
            return doors;
        }

        public string Getcolor()
        {
            return color;
        }

        public int Getheight()
        {
            return height;
        }

        public Dictionary<Product, int> Getinfo()
        {
            return Elements;
        }
    }
}