using System;

namespace SOSTrucksMonitor.web.Models
{
    public class TruckMonitorDTO
    {
        public int Load { get; set; }
        public int Invoice {get;set;}
        public DateTime Date { get; set; }
        public string TruckNumber { get; set; }
        public string TrailerNumber { get; set; }
        public string Customer { get; set; }
        public string CustomerReference { get; set; }
        public string FileNumber { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string TruckOwner { get; set; }
        public int EmptyMiles { get; set; }
        public int RevenueMiles { get; set; }
        public DateTime PickupDate {get;set;}
        public DateTime DeliveryDate { get; set; }
        public string Dispatcher { get; set; }

        public DriverDTO Driver { get; set; }
        public BrokerDTO Broker { get; set; }
    }
}