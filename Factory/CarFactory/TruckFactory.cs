namespace Factory
{
    class TruckFactory : CarFactory
    {
        protected override Car GetCar() => new Truck();
    }
}