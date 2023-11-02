namespace Factory
{
    public static class AbstractFactoryProgram
    {
        public static void Run()
        {
            List<AbstractCarFactory> factories = new()
            {
                new MercedesCarFactory(),
                new VolvoCarFactory(),
                new RenaultCarFactory(),
                new VolkswagenCarFactory()
            };

            foreach (var factory in factories)
            {
                Car car = factory.GetAutomobile();
                Console.WriteLine($"Created car of type {car.GetType()}, brand: {car.Brand} and id {car.Id}.");

                car = factory.GetTruck();
                Console.WriteLine($"Created car of type {car.GetType()}, brand: {car.Brand} and id {car.Id}.");
            }

            Console.WriteLine("Abstract Factory Method!!!");
        }
    }
}