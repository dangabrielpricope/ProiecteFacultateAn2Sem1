namespace Factory
{
    abstract class AbstractCarFactory
    {
        public abstract string Brand { get; }
        public Car GetAutomobile() => new Automobile(Brand);
        public Car GetTruck() => new Truck(Brand);
    }
}