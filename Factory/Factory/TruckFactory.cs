namespace Factory
{
    class TruckFactory : CarFactory
    {
        public override Car GetCar() => new Truck();
    }
}