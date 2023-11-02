namespace Factory
{
    abstract class CarFactory
    {    
        protected abstract Car GetCar();
        private static Guid lastId;

        public static Guid LastId => lastId;

        public Car Build()
        {
            var car = GetCar();
            lastId = car.Id;
            return car;
        }
    }
}