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
        public  Automobile GetAutomobile() => new Automobile(Brand);
        public  Truck GetTruck() => new Truck(Brand);

    }
}
