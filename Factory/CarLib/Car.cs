using System.Drawing;

namespace Factory
{
    public abstract class Car
    {
        public Guid Id { get; } = Guid.NewGuid();
        public  decimal Price { get; }
        public  Color Color { get; }
        public  string Brand { get; }

        protected Car()
        {
            
        }

        protected Car(string brand)
            : this()
        {
            this.Brand = brand;
        }
    }
}