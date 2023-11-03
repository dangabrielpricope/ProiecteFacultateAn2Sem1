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
        public abstract Automobile GetAutomobile();
        public abstract Truck GetTruck();

    }

    class MercedesCarFactory : AbstractCarFactory
    {
        public override Automobile GetAutomobile()
        {
            return new Automobile();
        }

        public override Truck GetTruck()
        {
            return new Truck();
        }
    }

    class VolvoCarFactory : AbstractCarFactory
    {
        public override Automobile GetAutomobile()
        {
            return new Automobile();
        }

        public override Truck GetTruck()
        {
            return new Truck();
        }
    }
}
