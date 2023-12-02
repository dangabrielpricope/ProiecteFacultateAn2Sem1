using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_29._10._2023
{
    public class Car : ICarPrototype
    {
        public ECarModel Model { get; set; }
        public string Color { get; set; }
        public EEngineType EngineType { get; set; }
        public bool IsClone { get; private set; } = false;

      

        public Car() { }    
        public override string ToString()
        {
            string description = "" ;

            if (IsClone)
            {
                description += "Cloned Car:\n";
            }
            else
            {
                description += "Original Car:\n";
            }

            description = "Color " + Color + "\n";
            description += "Model " + Enum.GetName(typeof(ECarModel), Model) + "\n";
            description += "EngineType " + Enum.GetName(typeof(EEngineType), EngineType) + "\n";

            description += "IsClone " + (IsClone ? "true" : "false") + "\n";

            return description;
        }

        public Car Clone()
        {
            var clonedCar = (Car)this.MemberwiseClone();
            clonedCar.IsClone = true;
            clonedCar.Color = "Black";
            return clonedCar;
        }
    }


}
