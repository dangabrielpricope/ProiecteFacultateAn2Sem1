using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiectDecorator
{
    internal class AmbianceDecorator : CarDecorator
    {
        public AmbianceDecorator(ICar decoratedCar) : base(decoratedCar)
        {
            this._decoratedCar.Type = ECarType.AMBIANCE;
            SetAccesories();
        }

        public new void SetAccesories()
        {
            this._decoratedCar.Accesories += 900;
        }
    }
}
