using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiectDecorator
{
    internal class LaureateDecorator:CarDecorator
    {
        public LaureateDecorator(ICar decoratedCar) : base(decoratedCar)
        {
            this._decoratedCar.Type = ECarType.LAUREATE;
            SetAccesories();
        }

        public new void SetAccesories()
        {
            this._decoratedCar.Accesories += 1100;
        }
    }
}
