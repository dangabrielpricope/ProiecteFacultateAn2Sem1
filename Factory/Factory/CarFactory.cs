namespace Factory
{
    abstract class CarFactory
    {    
        public abstract Car GetCar();
        private static Guid LastID;

    }
}