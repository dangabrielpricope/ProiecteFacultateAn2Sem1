using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_29._10._2023
{
    public interface ICarBuilder
    {
        void SetColor (string color);
        void SetModel (ECarModel model);
        void SetEngineType (EEngineType engineType);

        Car GetCar();
    }
}
