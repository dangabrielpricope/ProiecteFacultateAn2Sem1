namespace proiectDecorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Laborator 4 - Decorator");

            ICar basicCar = new BasicCar();
            basicCar.Assemble("Green", "Hybrid");
            basicCar.SetAccesories();
            Console.WriteLine(basicCar);

            ICar accesDecorator = new AccessDecorator(basicCar);
            Console.WriteLine(accesDecorator.ToString());

            ICar ambianceDecorator = new AmbianceDecorator(accesDecorator);
            Console.WriteLine(ambianceDecorator);

            ICar laureateDecorator = new LaureateDecorator(ambianceDecorator);
            Console.Write(laureateDecorator.ToString());

        }
    }
}