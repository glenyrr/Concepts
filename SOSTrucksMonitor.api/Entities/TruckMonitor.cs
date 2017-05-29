using System;
using System.Collections.Generic;

namespace SOSTrucksMonitor.api.Entities
{
    public partial class TruckMonitor
    {
        public TruckMonitor()
        {
            Broker = new HashSet<Broker>();
            DeliveryAttributeStatus = new HashSet<DeliveryAttributeStatus>();
            Driver = new HashSet<Driver>();
            Load = new HashSet<Load>();
            PickUpAttributeStatus = new HashSet<PickUpAttributeStatus>();
        }

        public int Id { get; set; }
        public int? LoadNumber { get; set; }
        public string Invoice { get; set; }
        public DateTime? Date { get; set; }
        public string TruckNumber { get; set; }
        public string TrailerNumber { get; set; }
        public string Customer { get; set; }
        public string CustomerReference { get; set; }
        public string BaseCity { get; set; }
        public string FileNumber { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string TruckOwner { get; set; }
        public string Dispatcher { get; set; }

        public virtual ICollection<Broker> Broker { get; set; }
        public virtual ICollection<DeliveryAttributeStatus> DeliveryAttributeStatus { get; set; }
        public virtual ICollection<Driver> Driver { get; set; }
        public virtual ICollection<Load> Load { get; set; }
        public virtual ICollection<PickUpAttributeStatus> PickUpAttributeStatus { get; set; }
    }
}
