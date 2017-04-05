using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ServerWCF
{
    public class AdminService : IAdminService
    {
        public string AddTrain(Train newTrain)
        {
            using (var context = new RailwaySystemModelContainer())
            {
                try
                {
                    var tr = new Train();
                    tr.Model = newTrain.Model;
                    tr.Capacity = newTrain.Capacity;
                    tr.Type = newTrain.Type;
                    context.Trains.Add(tr);
                    context.SaveChanges();
                    return "success";
                }
                catch (Exception)
                {
                    return "fail";
                }
            }
        }

        public string AddStation(Station station)
        {
            using (var context = new RailwaySystemModelContainer())
            {
                try
                {
                    var st = new Station();
                    st.City = station.City;
                    st.Type = station.Type;
                    context.Stations.Add(st);
                    context.SaveChanges();
                    return "success";
                }
                catch (Exception)
                {
                    return "fail";
                }
            }
        }

        public string AddTrack(Track newTrack)
        {
            using (var context = new RailwaySystemModelContainer())
            {
                try
                {
                    var tr = new Track();
                    tr.FromStation = newTrack.FromStation;
                    tr.ToStation = newTrack.ToStation;
                    tr.TimeToLeave = newTrack.TimeToLeave;
                    tr.TimeToArrive = newTrack.TimeToArrive;
                    tr.Name = tr.FromStation + " - " + tr.ToStation;
                    tr.Price = newTrack.Price;
                    context.Tracks.Add(tr);
                    context.SaveChanges();
                    return "success";
                }
                catch (Exception)
                {
                    return "fail";
                }
            }
        }

        public string AddStationToTrack(Track myTrack, Station myStation)
        {
            using (var context = new RailwaySystemModelContainer())
            {
                foreach (var track in context.Tracks)
                    foreach (var station in context.Stations)
                        if (track.Name == myTrack.Name && station.City == myStation.City)
                        {
                            track.Stations.Add(station);
                            return "success";
                        }

                return "fail";


            }
        }

        public List<Station> LoadStations()
        {
            using (var context = new RailwaySystemModelContainer())
            {
                // return context.Stations.ToList();
                List<Station> allStations = new List<Station>()
                {
                    new Station(){City = "Karachi", StationId = 45, Tracks = new List<Track>(), Type = "Express"},
                    new Station(){City = "London", StationId = 46, Tracks = new List<Track>(), Type = "Super_Express"},
                    new Station(){City = "Lahore", StationId = 48, Tracks = new List<Track>(), Type = "Slow_Express"},
                };

                return allStations;

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
