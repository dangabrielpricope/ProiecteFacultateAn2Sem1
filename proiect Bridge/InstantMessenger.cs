using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect_Bridge
{
    internal class InstantMessenger : IInstantMessanger
    {
       

        public IMessagingService MessagingService { get; set; }

        public InstantMessenger(IMessagingService service)
        {

            MessagingService = service;
        }



        void IInstantMessanger.SendFile(string filePath)
        {
            MessagingService.SendFile(filePath);
        }
        void IInstantMessanger.SendMessanger(string message)
        {
            MessagingService.SendMessage(message);
        }
    }
}
