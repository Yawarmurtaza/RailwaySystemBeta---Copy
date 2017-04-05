using System;
using System.Collections;
using System.Diagnostics;

namespace ServerWCF
{
    public class PasagerService : IPasagerService
    {
        public string MakeBooking(User u, Track t, string number)
        {
            using (var context = new RailwaySystemModelContainer())
            {
                Booking newBooking = new Booking();
                newBooking.Time = t.TimeToLeave;
                newBooking.Number = number;
                foreach (var track in context.Tracks)
                    foreach (var user in context.Users)
                        if (track.Name == t.Name && user.Username == u.Username && track.TimeToLeave == t.TimeToLeave)
                        {
                            newBooking.Track = track;
                            newBooking.Number = number;
                            newBooking.Price = (Convert.ToInt32(number)*Convert.ToInt32(track.Price)).
                            ToString();
                            newBooking.Passenger = (Passenger)user;
                        }
                try
                {
                    context.Bookings.Add(newBooking);
                    context.SaveChanges();
                    return newBooking.Price;
                }
                catch (Exception)
                {
                    return "fail";
                }
            }
        }

        public ArrayList LoadHours(Track track)
        {
            ArrayList hours = new ArrayList();
            using (var context = new RailwaySystemModelContainer())
            {
                foreach (var tr in context.Tracks)
                    if (tr.Name == track.Name)
                        hours.Add(tr.TimeToLeave);
                return hours;
            }
        }
    }
}
