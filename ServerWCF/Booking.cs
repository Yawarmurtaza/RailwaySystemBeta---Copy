//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Runtime.Serialization;
using System.ServiceModel;

namespace ServerWCF
{
    using System;
    using System.Collections.Generic;
    
    [DataContract]
    public partial class Booking
    {
        [DataMember]
        public int BookingId { get; set; }
        [DataMember]
        public string Time { get; set; }
        [DataMember]
        public int PassengerUserId { get; set; }
        [DataMember]
        public string Number { get; set; }
        [DataMember]
        public int TrackTrackId { get; set; }
        [DataMember]
        public string Price { get; set; }
        [DataMember]
        public virtual Passenger Passenger { get; set; }
        [DataMember]
        public virtual Track Track { get; set; }
    }
}
