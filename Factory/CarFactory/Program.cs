namespace Factory
{
    public static class FactoryProgram
    {
        public static void Run()
        {
            CarFactory[] creators = new CarFactory[2];
            creators[0] = new AutomobileFactory();
            creators[1] = new TruckFactory();

            foreach (CarFactory creator in creators)
            {
                Car car = creator.Build();
                Console.WriteLine($"Created car of type {car.GetType()} with id {car.Id}");

                car = creator.Build();
                Console.WriteLine($"Created car of type {car.GetType()} with id {car.Id}");
            }

            Console.WriteLine($"Last car created is: {CarFactory.LastId}");

            Console.WriteLine("Factory Method!!!");
        }
    }
}