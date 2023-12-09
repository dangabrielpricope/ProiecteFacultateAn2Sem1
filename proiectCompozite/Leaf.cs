using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiectCompozite
{
    internal class Leaf : Vegetation
    {
        public Leaf(string name):base(name) { }

        public override void Display(int depth)
        {
           DisplayInternal(depth);

        }
    }
}
