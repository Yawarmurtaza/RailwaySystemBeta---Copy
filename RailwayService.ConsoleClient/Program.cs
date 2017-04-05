using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using ServerWCF;

namespace RailwayService.ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            AdminServiceClient client = new AdminServiceClient();
            List<Station> allStations =  client.GetAllStations();

            foreach (Station nextStation in allStations)
            {
                Console.WriteLine(nextStation.City);
                Console.WriteLine(nextStation.StationId);
                Console.WriteLine(nextStation.Type);
                foreach (Track nextStationTrack in nextStation.Tracks)
                {
                    Console.WriteLine(nextStationTrack.Name);
                }

                Console.WriteLine("\n\n----------------------\n\n");
            }

            Console.ReadLine();

        }
    }

    public class AdminServiceClient : ClientBase<IAdminService>
    {
        public List<Station> GetAllStations()
        {
            return base.Channel.LoadStations();
        }
    }
}
