using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Singleton
{

    class LoadBalancer
    {
        private static LoadBalancer instance;
        private static readonly object syncRoot = new Object();
        private List<Server> servers = new List<Server>();

        public Boolean RandomAccess { get; set; }

        private LoadBalancer()
        {

            for (int i = 0; i < 10; i++)
            {
                servers.Add(new Server("Server " + i, "Ip " + 10 + 10 * i + 100 * i));
            }
        }

        public static LoadBalancer Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                        {
                            instance = new LoadBalancer();
                        }

                    }
                }
                return instance;
            }
        }

        public void ProcessRequest(int request)
        {
            if (RandomAccess)
            {
                Random rnd = new Random();
                int idxServer = rnd.Next(0, 9);
                servers[idxServer].ProcessRequest(request);
            }
            else
            {
                int min = servers[0].NumOfRequests;
                int idxChosenServer = 0;

                for (int i = 0; i < servers.Count; i++)
                {
                    if (servers[i].NumOfRequests <= min)
                    {
                        min = servers[i].NumOfRequests;
                        idxChosenServer = i;
                    }
                }
                servers[idxChosenServer].ProcessRequest(request);
            }
        }
        public void GenerateRapport()
        {
            foreach (Server s in servers)
            {
                Console.WriteLine(s.ToString());
            }
        }

    }
}