using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiectDecorator
{
    internal class AccessDecorator:CarDecorator
    {
        public AccessDecorator(ICar decoratedCar): base(decoratedCar)
        {
            this._decoratedCar.Type = ECarType.ACCESS;
            SetAccesories();
        }

        public new void SetAccesories()
        {
            this._decoratedCar.Accesories += 700;
        }
        
    }
}
