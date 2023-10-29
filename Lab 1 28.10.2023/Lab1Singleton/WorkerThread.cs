using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Singleton
{
    class WorkerThread
    {
        public static void PostRequest()
        {
            Random rnd = new Random();
            for (int i = 0; i < 20; i++)
            {
                int timeProcessing = rnd.Next(500, 1000);
                LoadBalancer.Instance.ProcessRequest(timeProcessing);
            }
        }
    }

}
