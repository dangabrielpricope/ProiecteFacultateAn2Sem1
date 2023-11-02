namespace Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarFactory[] creators = new CarFactory[2];
            creators[0] = new AutomobileFactory();
            creators[1] = new TruckFactory();

            foreach (CarFactory creator in creators)
            {
                Car car = creator.GetCar();
                Console.WriteLine($"Created car of type {car.GetType()} with id {car.Id}");
            }

            Console.WriteLine("Factory Method!!!");

            // Wait for user
            Console.ReadKey();
        }
    }
}