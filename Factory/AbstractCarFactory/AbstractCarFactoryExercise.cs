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
            carFactories.Add(new VWCarFactory());
            carFactories.Add(new RenaultCarFactory());


            foreach (var creator in carFactories)
            {
                if (creator is MercedesCarFactory || creator is VWCarFactory || creator is RenaultCarFactory)
                {
                    Automobile carA = creator.GetAutomobile();

                    Console.WriteLine("Created {0} with ID {1} and brand {2}, price {3}, color {4}",
                      carA.GetType().Name, carA.Id, carA.Brand, carA.Price, carA.Color);
                }
                else if (creator is VolvoCarFactory) 
                {
                    Truck carB = creator.GetTruck();

                    Console.WriteLine("Created {0} with ID {1} and brand {2}, price {3}, color {4}",
                       carB.GetType().Name, carB.Id, carB.Brand, carB.Price, carB.Color);
                }

               

                
            }
            
        }

    }
}
