using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SOSTrucksMonitor.Models
{
    [DataContract]
    public class TruckMonitorDTO
    {
        public TruckMonitorDTO()
        {
            Driver = new DriverDTO();
            Broker = new BrokerDTO();
            PickUp = new PickUpDTO()
            {
                Log = new List<string>()
            };
            Load = new LoadDTO()
            {
                Loads = new List<string>()
            };

            Delivery = new DeliveryDTO()
            {
                Log = new List<string>()
            };

        }
        [DataMember(Name = "loadNumber")]
        public int? LoadNumber { get; set; }
        [DataMember(Name = "invoice")]
        public string Invoice { get; set; }
        [DataMember(Name = "date")]
        public DateTime? Date { get; set; }
        [DataMember(Name = "truckNumber")]
        public string TruckNumber { get; set; }
        [DataMember(Name = "trailerNumber")]
        public string TrailerNumber { get; set; }
        [DataMember(Name = "customer")]
        public string Customer { get; set; }
        [DataMember(Name = "customerReference")]
        public string CustomerReference { get; set; }
        [DataMember(Name = "baseCity")]
        public string BaseCity { get; set; }
        [DataMember(Name = "fileNumber")]
        public string FileNumber { get; set; }
        [DataMember(Name = "from")]
        public string From { get; set; }
        [DataMember(Name = "to")]
        public string To { get; set; }
        [DataMember(Name = "truckOwner")]
        public string TruckOwner { get; set; }
        [DataMember(Name = "emptyMiles")]
        public int EmptyMiles { get; set; }
        [DataMember(Name = "revenueMiles")]
        public int RevenueMiles { get; set; }
        [DataMember(Name = "dispatcher")]
        public string Dispatcher { get; set; }

        [DataMember(Name = "driver")]
        public DriverDTO Driver { get; set; }
        [DataMember(Name = "broker")]
        public BrokerDTO Broker { get; set; }
        [DataMember(Name = "pickUp")]
        public PickUpDTO PickUp { get; set; }
        [DataMember(Name = "load")]
        public LoadDTO Load { get; set; }
        [DataMember(Name = "delivery")]
        public DeliveryDTO Delivery { get; set; }
    }
}