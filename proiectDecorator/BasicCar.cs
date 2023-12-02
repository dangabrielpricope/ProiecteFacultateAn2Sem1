using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiectDecorator
{
    internal class BasicCar : ICar
    {
        public ECarType Type { get; set; }
        public string Color { get; set; }
        public string Motorization { get; set; }
       public int Accesories { get; set; }
       
        public BasicCar() 
        {
            Type = ECarType.BASIC;
            SetAccesories();
        }

        public void SetAccesories()
        {
            Accesories = 7800;
        }

        public void Assemble (string color, string motorization)
        {
            Color = color;
            Motorization = motorization;
        }

        public override string ToString()
        {
            return new string ($" Type:{Type}\n Color={Color}\n Motorization={Motorization}\n Accesories {Accesories}\n");
        }
    }
}
