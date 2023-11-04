using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory;

namespace AbstractCarFactory
{

    abstract class AbstractCarFactory
    {
        protected abstract string Brand { get; }
        protected abstract int Price {  get; }
        protected abstract string Color { get; }
        public Automobile GetAutomobile() => new Automobile(Brand, Price, Color);
        public Truck GetTruck() => new Truck(Brand, Price, Color);

    }
}
