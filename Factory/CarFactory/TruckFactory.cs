namespace Factory
{
    class TruckFactory : CarFactory
    {
        protected override Car GetCar()
        {
           return new Truck();
        }
    }
}