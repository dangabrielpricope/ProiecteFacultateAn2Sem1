using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiectCompozite
{
    internal class Branch : Vegetation
    {
        private List<Vegetation> _children;
        public Branch(string name) : base(name)
        {
            _children = new List<Vegetation>();
        }
        public override void Add(Vegetation vegetation)
        {
            _children.Add(vegetation);
            vegetation.ParentName = this.Name;
        }

        public override bool Remove(Vegetation vegetation)
        {
           return _children.Remove(vegetation);
        }
        public override void Display(int depth)
        {
            DisplayInternal(depth);
            depth++;
            foreach (var child in _children)
            {
                child.Display(depth); 

            }
        }

       

       
    }
}
