using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_29._10._2023
{
    public class CarBuilder:ICarBuilder
    {
        private Car _car;

        public void SetColor(string color)
        {
            _car.Color = color;
        }
        public void SetEngineType(EEngineType engineType)
        {
            _car.EngineType = engineType;
        }
        public void SetModel(ECarModel model)
        {
            _car.Model = model;
        }
        public CarBuilder()
        {
            _car = new Car();
        }

        public Car GetCar()
        {
            return _car;
        }
    }
}
