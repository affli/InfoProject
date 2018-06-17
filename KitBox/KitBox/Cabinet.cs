using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitBox
{
    public class Cabinet
    {
        int NbLocker;
        int Totalprice;
        List<Locker> Lockerlist = new List<Locker>();
        Support_Angle support = new Support_Angle();
        int width;
        int depth;
        int height;

        public void Setinfo(int width, int depth)
        {
            this.width = width;
            this.depth = depth;
        }

        public int Getdepth()
        {
            return depth;
        }

        public int Getwidth()
        {
            return width;
        }

        public int Getheight()
        {
            return height;
        }

        public Support_Angle Getsupport()
        {
            return support;
        }

        public void Setheight(int value)
        {
            this.height = value;
            this.support.Setheight(value);
        }

        public void AddLocker(Locker value)
        {
            Lockerlist.Add(value);
        }

        public void AddNbLocker()
        {
            NbLocker += 1;
        }

        public void DeleteNbLocker()
        {
            NbLocker -= 1;
        }
        /*
        public int GetSomme(Dictionary<Product, int> Elements)
        {
            return Totalprice;
        }
        */
        public int get_NbLocker()
        {
            return NbLocker;
        }

        public List<Locker> Getlocker()
        {
            return Lockerlist;
        }

        public void Empty()
        {
            Lockerlist.Clear();
        }
    }
}