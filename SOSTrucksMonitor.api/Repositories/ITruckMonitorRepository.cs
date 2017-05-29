using Aspnet.Core.Data;
using SOSTrucksMonitor.api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOSTrucksMonitor.api.Repositories
{
   public interface ITruckMonitorRepository : IGenericRepository<TruckMonitor>
    {

        Task<IEnumerable<TruckMonitor>> GetAllIncludedAsync();
    }
}
