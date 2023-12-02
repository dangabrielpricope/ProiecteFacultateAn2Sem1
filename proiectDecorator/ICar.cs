using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiectDecorator
{
    public interface ICar
    {
        ECarType Type { get; set; }
        string Color { get; set; }
        string Motorization { get; set; }
        int Accesories {  get; set; }


        void Assemble(string color, string motorization);
        void SetAccesories();
        string ToString();


    }

    public enum ECarType
    {
        BASIC,
        ACCESS,
        AMBIANCE,
        LAUREATE
    }
}
