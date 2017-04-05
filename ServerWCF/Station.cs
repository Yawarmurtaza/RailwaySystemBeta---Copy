
using System.Runtime.Serialization;

namespace ServerWCF
{
    using System;
    using System.Collections.Generic;
    [DataContract]
    public partial class Station
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Station()
        {
            this.Tracks = new HashSet<Track>();
        }
    
        [DataMember]
        public int StationId { get; set; }
        [DataMember]
        public string City { get; set; }
        [DataMember]
        public string Type { get; set; }
        [DataMember]
        public virtual ICollection<Track> Tracks { get; set; }
    }
}
