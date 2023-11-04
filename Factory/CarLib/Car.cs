using System.Drawing;

namespace Factory
{
    public abstract class Car
    {
        public Guid Id { get; } = Guid.NewGuid();
        public  decimal Price { get; }
        public  string Color { get; }
        public  string Brand { get; }
        protected Car(string brand, int price, string color)
        {
            Brand = brand;
            Price = price;
            Color = color;
        }
        protected Car()
        {
            
        }
    }
}