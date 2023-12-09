namespace proiect_Bridge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Proiect Bridge!");

            IMessagingService messagingService = new Skype();

            IInstantMessanger instantMessanger = new InstantMessenger(messagingService);
            instantMessanger.SendMessanger("Salut de la Piatra Neamt!");
            instantMessanger.SendFile("fisierPiatraNeamt");

            IMessagingService newMessangerService = new WhatsApp();

            instantMessanger.MessagingService = newMessangerService;
            instantMessanger.SendMessanger("Salut din Podoleni-Neamt!");
            instantMessanger.SendFile("fisierPodoleniNeamt");
        }
    }
}