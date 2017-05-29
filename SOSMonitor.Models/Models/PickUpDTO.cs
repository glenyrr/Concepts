using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SOSTrucksMonitor.Models
{
    [DataContract]
    public class PickUpDTO
    {
        [DataMember(Name = "date")]
        public DateTime Date { get; set; }
        [DataMember(Name = "log")]
        public IList<string> Log { get; set; }
    }
}