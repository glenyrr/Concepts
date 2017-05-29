using Microsoft.AspNetCore.Mvc;
using SOSTrucksMonitor.api.Features.TrucksMonitor;
using SOSTrucksMonitor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOSTrucksMonitor.api.Api.v1
{
    /// <summary>
    /// Trucks Monitor Controller
    /// </summary>
    [Route("api/v1/[controller]")]
    public class TrucksMonitorController: Controller
    {
        private TrucksMonitorAppService _trucksMonitorAppService;

        public TrucksMonitorController(TrucksMonitorAppService trucksMonitorAppService)
        {
            _trucksMonitorAppService = trucksMonitorAppService;
        }

        /// <summary>
        /// Get all the Trucks info stored in the monitor
        /// </summary>
        /// <returns>Lista de <see cref="TruckMonitorDTO"/></returns>
        [HttpGet]
        public async Task<List<TruckMonitorDTO>> GetAll()
        {
            return await _trucksMonitorAppService.GetAllIncluded();
        }
    }
}
