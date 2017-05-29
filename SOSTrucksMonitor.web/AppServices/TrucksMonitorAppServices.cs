using Aspnet.Core.RestClient;
using SOSTrucksMonitor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOSTrucksMonitor.web.AppServices
{
    public class TrucksMonitorAppServices
    {
        private IHttpClientRequest _clientRequest;
        public TrucksMonitorAppServices(IHttpClientRequest clientRequest)
        {
            _clientRequest = clientRequest;
        }

        public async Task<IEnumerable<TruckMonitorDTO>> GetTrucksMonitor()
        {
            var uri = string.Format("http://localhost:59307/api/v1/trucksmonitor");
            var trucksMonitor = await _clientRequest.GetList<TruckMonitorDTO>(uri);
            if (trucksMonitor == null)
            {
                return new List<TruckMonitorDTO>();
            }

            return trucksMonitor;
        }

    }
}
