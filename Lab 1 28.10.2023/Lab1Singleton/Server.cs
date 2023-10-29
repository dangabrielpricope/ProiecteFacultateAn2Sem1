using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Singleton
{
    class Server
    {
        public string Name { get; private set; }
        public string IpAdress { get; private set; }
        public int NumOfRequests { get; private set; }
        public int MinTime { get; private set; }
        public int MaxTime { get; private set; }
        public int TotalTime { get; private set; }

        public Server(string name, string ipAdress)
        {
            this.Name = name;
            IpAdress = ipAdress;

            MinTime = int.MaxValue;
            MaxTime = int.MinValue;

            NumOfRequests = 0;
            TotalTime = 0;
        }
    
        public void ProcessRequest(int processingTime)
        {
            NumOfRequests++;
            TotalTime += processingTime;
            if (processingTime < MinTime)
            {
                MinTime = processingTime;
            }
            if (processingTime > MaxTime)
            {
                MaxTime = processingTime;
             }
        }
            public override string ToString()
            {
                string stringDescription = "Server name" + Name;
                stringDescription += "IpAdress" + IpAdress;
                stringDescription += "NumOfRequests" + NumOfRequests;
                stringDescription += "MinTime" + MinTime;
                stringDescription += "MaxTime" + MaxTime;
                stringDescription += "TotalTime" + TotalTime;
                return stringDescription;
             }
    }
}