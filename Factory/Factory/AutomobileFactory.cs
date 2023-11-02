namespace Factory
{
    class AutomobileFactory : CarFactory
    {
        public override Car GetCar() => new Automobile();
    }
}