using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect_Bridge
{
    internal class WhatsApp : IMessagingService
    {
        public void SendFile(string filePath)
        {
            Console.WriteLine($"WhatsApp: SendFile: {filePath}");
        }

        public void SendMessage(string message)
        {
            Console.WriteLine($"WhatsApp: SendMesage: {message}");
        }

        public void VideoCall()
        {
            Console.WriteLine($"WhatsApp: VideoCall");
        }

        public void VoiceCall()
        {
            Console.WriteLine($"WhatsApp: VoiceCall");
        }
    }
}
