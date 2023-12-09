using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiectCompozite
{
    internal class Tree : Branch
    {
        public Tree(string name) : base(name)
        {
            
        }
        public override void Display(int depth)
        {
            base.Display(depth+1);
        }
    }
}
