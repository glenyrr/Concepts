using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SOSTrucksMonitor.Models
{
    [DataContract]
    public class LoadDTO
    {
        [DataMember(Name = "fileNumber")]
        public string FileNumber { get; set; }
        [DataMember(Name = "loads")]
        public IList<string> Loads { get; set; }
    }
}