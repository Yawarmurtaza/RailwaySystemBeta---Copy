//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Runtime.Serialization;

namespace ServerWCF
{
    using System;
    using System.Collections.Generic;
    
    [DataContract]
    public partial class Passenger : User
    {
        public Passenger()
        {
            this.Bookings = new HashSet<Booking>();
        }
        [DataMember]
        public int PassengerId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [DataMember]
        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
