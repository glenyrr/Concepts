using System.Collections.Generic;

namespace SOSTrucksMonitor.web.Models
{
    public class LoadDTO
    {
        public string FileNumber { get; set; }
        public IList<string> Loads { get; set; }
    }
}