namespace Factory
{
    class AutomobileFactory : CarFactory
    {
        protected override Car GetCar() => new Automobile();
    }
}