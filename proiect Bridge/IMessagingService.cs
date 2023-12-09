using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect_Bridge
{
    internal interface IMessagingService
    {
        void SendMessage(string message);
        void SendFile(string filePath);
        void VoiceCall();
        void VideoCall();
    }
}
