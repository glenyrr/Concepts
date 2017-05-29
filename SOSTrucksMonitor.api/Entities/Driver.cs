using System;
using System.Collections.Generic;

namespace SOSTrucksMonitor.api.Entities
{
    public partial class Driver
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public int? TrucksMonitorId { get; set; }

        public virtual TruckMonitor TruckMonitor { get; set; }
    }
}
