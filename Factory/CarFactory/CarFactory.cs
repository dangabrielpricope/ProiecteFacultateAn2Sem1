namespace Factory
{
    abstract class CarFactory
    {    
        protected abstract Car GetCar();
        private static Guid lastID;
        public Car BuildCar()
        {
            Car car = GetCar();
            lastID = car.Id;
            return car;
        }

        public static Guid LastID => lastID;

    }
}