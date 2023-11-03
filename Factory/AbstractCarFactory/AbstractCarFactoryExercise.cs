using Factory;

namespace AbstractCarFactory
{
    public static class AbstractCarFactoryExercise
    {
        public static void Run()
        {
            Console.WriteLine(" Abstract Factory Method!!!");

           List<AbstractCarFactory> carFactories = new List<AbstractCarFactory>();
            carFactories.Add(new MercedesCarFactory());
            carFactories.Add(new VolvoCarFactory());    


            foreach (var creator in carFactories)
            {
                Automobile carA = creator.GetAutomobile();

                Console.WriteLine("Created {0} with ID {1} and brand {2}",
                  carA.GetType().Name, carA.Id, carA.Brand);

                Truck carB = creator.GetTruck();

                Console.WriteLine("Created {0} with ID {1} and brand {2}",
                   carB.GetType().Name, carB.Id, carB.Brand);
            }
            
        }

    }
}
