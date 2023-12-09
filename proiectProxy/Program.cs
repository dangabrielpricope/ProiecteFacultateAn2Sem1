namespace proiectProxy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Proiect Proxy");
        }
    }

    public interface IAccount
    {
        void Deposit(double amount);
        bool Withdraw(double amount);
        void DisplayBalance();
       
    }

    internal class AccountProtected : IAccount
    {
        private double balance = 0;

        public void Deposit(double amount)
        {
            balance += amount;
            Console.WriteLine($"Deposited: {amount}");
        }

        public bool Withdraw(double amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawn:{amount}");
                return true;
            }
            else
            {
                Console.WriteLine("Insufficient founds");
                    return false;
            }

        }

        public void DisplayBalance()
        {
            Console.WriteLine($"Balance:{balance}");
        }
    }


    internal class SafeAccountProxy : IAccount
    {



    }

 
}