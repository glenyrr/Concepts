using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace SOSTrucksMonitor.Models
{
    [DataContract]
    public class BrokerDTO
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }
        [DataMember(Name = "phoneNumber")]
        public string PhoneNumber { get; set; }
    }
}
