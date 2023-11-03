namespace Factory
{
    public static class CarFactoryExercise
    {
       public static void Run()
        {
            Console.WriteLine("Factory Method!!!");

            CarFactory[] creators = new CarFactory[2];
            creators[0] = new AutomobileFactory();
            creators[1] = new TruckFactory();


            foreach (CarFactory creator in creators)
            {
                Car carA = creator.BuildCar();

                Console.WriteLine("Created {0} with ID {1}",
                  carA.GetType().Name, carA.Id);
            }
            Console.WriteLine($"Id of the last car created is: {CarFactory.LastID} ");
        }

    }
}