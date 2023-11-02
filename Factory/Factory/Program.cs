namespace Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factory Method!!!");
        }
    }

     abstract class CarFactory
    {    
        public abstract Car GetCar();
        private static Guid LastID;

    }

    class AutomobileFactory : CarFactory
    {

    }

    class TruckFactory : CarFactory
    {

    }
}