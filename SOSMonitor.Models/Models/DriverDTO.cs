using System;
using System.Runtime.Serialization;

namespace SOSTrucksMonitor.Models
{
    [DataContract]
    public class DriverDTO
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }
        [DataMember(Name = "phoneNumber")]
        public string PhoneNumber { get; set; }

    }
}