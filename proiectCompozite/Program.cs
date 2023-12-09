namespace proiectCompozite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Proiect Compozite!!!");

            Vegetation tree = new Tree("My tree!");

            Vegetation leaf1 = new Leaf("leaf1");
            Vegetation leaf2 = new Leaf("leaf2");
            Vegetation leaf3 = new Leaf("leaf3");


            Vegetation branch1 = new Branch("branch1");
            branch1.Add(leaf1 );
            branch1.Add(leaf2 );
            branch1.Add(leaf3);

            Vegetation branch2 = new Branch("branch2");
            branch2.Add(leaf1);
            branch2.Add(leaf2);
            branch2.Add(leaf3);

            tree.Add(branch1);
            tree.Add(branch2);

            tree.Display(0);
        }
    }
}