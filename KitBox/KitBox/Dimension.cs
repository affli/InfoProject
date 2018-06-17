using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitBox
{
    public interface Dimension
    {
        int height { get; set; }
        int width { get; set; }
        int depth { get; set; }
    }
}