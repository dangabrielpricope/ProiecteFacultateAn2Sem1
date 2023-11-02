using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_29._10._2023
{
    public  class CarBuildDirector
    {

        ICarBuilder _carBuilder;
        public CarBuildDirector(ICarBuilder carBuilder)
        {
            _carBuilder = carBuilder;
        }
        public void Construct()
        {
            _carBuilder.SetModel(ECarModel.ESedan);
            _carBuilder.SetColor("Green");
            _carBuilder.SetEngineType(EEngineType.EDiesel);
        }
        public Car GetResult()
        {
            return _carBuilder.GetCar();
        }
    }

    public enum ECarModel
    {
        ESedan,
        EHatchback,
        EPickup,
        ESUV,
        ECrossover
    }
    public enum EEngineType
    {
        EDiesel,
        EGas,
        EHybrid
    }

}
