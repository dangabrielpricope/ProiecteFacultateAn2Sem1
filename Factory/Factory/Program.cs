using System.Reflection.Metadata.Ecma335;
using AbstractCarFactory;

namespace Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarFactoryExercise.Run();
            AbstractCarFactoryExercise.Run();

            // Wait for user
            Console.ReadKey();
        }
    }
}