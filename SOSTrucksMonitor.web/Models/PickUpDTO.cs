using System;
using System.Collections.Generic;

namespace SOSTrucksMonitor.web.Models
{
    public class PickUpDTO
    {
        public DateTime Date { get; set; }
        public IList<string> Log { get; set; }
    }
}