using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiectCompozite
{
    internal abstract class Vegetation
    {
        public string Name { get; private set; }

        public string ParentName { get;  set; }

        public Vegetation(string name) 
        {
            Name = name;
           
        }

        public virtual void Add(Vegetation vegetation) { }
        public virtual bool Remove(Vegetation vegetation) { return false; }
        abstract public void Display(int depth);

        protected void DisplayInternal (int depth) 
        { 
            Console.Write($"Vegetation name {this.Name}");

            for (int i = 0; i< depth; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
