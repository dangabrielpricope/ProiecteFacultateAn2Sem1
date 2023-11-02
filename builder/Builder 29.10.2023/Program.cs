using Builder_29._10._2023;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Builder And Prototipe");

        ICarBuilder carBuilder = new CarBuilder();
        CarBuildDirector director = new CarBuildDirector(carBuilder);
        director.Construct();
        Car newCar = director.GetResult();
        Console.WriteLine(newCar.ToString());
        var clonedCar = newCar.Clone();
        Console.WriteLine(clonedCar.ToString());
        
    }
}