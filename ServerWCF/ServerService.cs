using System;
using System.Collections;
using System.Collections.Generic;
using System.ServiceModel;


namespace ServerWCF
{
    public class ServerService : IServerService
    {
        public List<Station> LoadStations()
        {
            var list = new List<Station>();
            using (var context = new RailwaySystemModelContainer())
            {
                foreach (var station in context.Stations)
                    list.Add(station);
                return list;
            }
        }

        public List<Track> GetTracks()
        {
            List<Track> list = new List<Track>();
            using (var context = new RailwaySystemModelContainer())
            {
                list.AddRange(context.Tracks);
                return list;
            }
        }
    }
}
