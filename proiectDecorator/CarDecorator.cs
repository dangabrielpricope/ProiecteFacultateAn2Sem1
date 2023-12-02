using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiectDecorator
{
    internal class CarDecorator : ICar
    {
        protected ICar _decoratedCar;
        public CarDecorator(ICar decoratedCar)
        {
            _decoratedCar = decoratedCar;
        }

        public ECarType Type { get => _decoratedCar.Type; set => _decoratedCar.Type = value; }
        public string Color { get => _decoratedCar.Color; set => _decoratedCar.Color = value; }
        public string Motorization { get => _decoratedCar.Motorization; set => _decoratedCar.Motorization=value; }
        public int Accesories { get => _decoratedCar.Accesories; set => _decoratedCar.Accesories = value; }

        public void Assemble (string color, string motorization)
        {
            _decoratedCar.Assemble (color, motorization);

        }
        public void SetAccesories()
        {
            _decoratedCar.SetAccesories();
        }

        public override string ToString()
        {
            return _decoratedCar.ToString();
        }
    }
}
