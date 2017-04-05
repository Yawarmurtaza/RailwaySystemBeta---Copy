using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using ServerWCF;

namespace RailwayServiceConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {

            using (ServiceHost host = new ServiceHost(typeof(AdminService)))
            {
                PrintEndpoints(host.Description);
                host.Open();

                Console.WriteLine("Service(s) are up and running... Press Enter key to exit!");
                Console.ReadLine();
            }
        }

        static void PrintEndpoints(ServiceDescription desc)
        {
            Console.WriteLine(desc.Name);
            foreach (ServiceEndpoint nextEndpoint in desc.Endpoints)
            {
                Console.WriteLine();
                Console.WriteLine(nextEndpoint.Address);
            }
        }
    }
}
