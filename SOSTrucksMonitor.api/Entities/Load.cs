using System;
using System.Collections.Generic;

namespace SOSTrucksMonitor.api.Entities
{
    public partial class Load
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }
        public bool? Status { get; set; }
        public int? TrucksMonitorId { get; set; }

        public virtual TrucksMonitor TrucksMonitor { get; set; }
    }
}
