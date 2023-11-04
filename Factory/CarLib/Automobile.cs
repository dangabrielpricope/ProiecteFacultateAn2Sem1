namespace Factory
{
    public class Automobile : Car
    {
        public Automobile(string brand, int price, string color)
            :base(brand, price, color)
        {
           
        }
        public Automobile() 
            :base()
            
        {
            
        }

    }
}