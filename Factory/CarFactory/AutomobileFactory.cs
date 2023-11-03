namespace Factory
{
    class AutomobileFactory : CarFactory
    {
        protected override Car GetCar()
        {
            
            return new Automobile();
        }
    }
}