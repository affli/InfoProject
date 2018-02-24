using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitBox
{
    public interface Dimension
    {
        int Height { get; set; }
        int Width { get; set; }
        int Depth { get; set; }
    }
}