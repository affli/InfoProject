using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitBox
{
    class Cabinet
    {
        private int NbLocker;
        private int Totalprice;
        private List<Product> Elements = new List<Product>();
    
        public void AddLocker(int NbLocker)
        {

        }
        public void DeleteLocker(int NbLocker)
        {

        }
        public int GetSomme(List<Product> Elements)
        {
            return Totalprice;
        }
    }
}
