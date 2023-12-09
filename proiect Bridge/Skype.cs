using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect_Bridge
{
    internal class Skype : IMessagingService
    {
        public void SendFile(string filePath)
        {
            Console.WriteLine($"Skype:SendFile: {filePath}");
        }

        public void SendMessage(string message)
        {
            Console.WriteLine($"Skype:SendMessage: {message}");
        }

        public void VideoCall()
        {
            throw new NotImplementedException();
        }

        public void VoiceCall()
        {
            throw new NotImplementedException();
        }
    }
}
