using Aspnet.Core.Data;
using SOSTrucksMonitor.api.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace SOSTrucksMonitor.api.Repositories
{
    public class TruckMonitorRepository: GenericRepository<TruckMonitor> , ITruckMonitorRepository
    {
        public TruckMonitorRepository(SOSMonitorContext context) : base(context)
        {

        }

        public async Task<IEnumerable<TruckMonitor>> GetAllIncludedAsync()
        {
            return await PlutoContext.TruckMonitor
                .Include("Broker")
                .Include("Driver")
                .Include("DeliveryAttributeStatus")
                .Include("Load")
                .Include("PickUpAttributeStatus")
                .ToListAsync();

        }

        public SOSMonitorContext PlutoContext
        {
            get { return _context as SOSMonitorContext; }
        }


    }
}
