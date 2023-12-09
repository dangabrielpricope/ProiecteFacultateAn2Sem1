using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect_Bridge
{
    internal interface IInstantMessanger
    {
        public IMessagingService MessagingService { get; set; }
        void SendMessanger(string message);
        void SendFile(string filePath);



    }
}
