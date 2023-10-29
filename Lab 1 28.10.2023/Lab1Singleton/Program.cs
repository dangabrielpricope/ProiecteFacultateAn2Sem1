using Lab1Singleton;


class Program
{
    static void Main(string[] args)
    {
        LoadBalancer.Instance.RandomAccess = false;
        Console.WriteLine("Enter load balancing type: (true -> random, false -> balanced)");
        string randomAccesUserInput = Console.ReadLine();
        if (bool.TryParse(randomAccesUserInput, out bool randomAccesUserInputBool))
        {
            LoadBalancer.Instance.RandomAccess = randomAccesUserInputBool;
        }
        if (LoadBalancer.Instance.RandomAccess == true)
        {
            Console.WriteLine("Random balancing");
        }
        else
        {
            Console.WriteLine("Balanced loading");
        }

        Thread[] threads = new Thread[5];
        for (int i = 0; i < 5; i++)
        {
            Thread t = new Thread(WorkerThread.PostRequest);
            threads[i] = t;
        }
        for (int i = 0; i < 5; i++)
        {
            threads[i].Start();
            System.Threading.Thread.Sleep(2000);
        }
        for (int i = 0; i < 5; i++)
        {
            threads[i].Join();
            
        }

        Console.WriteLine("Raport final cu Threads");
        LoadBalancer.Instance.GenerateRapport();
    }
}