using Aspnet.Core.Data;
using SOSTrucksMonitor.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using SOSTrucksMonitor.api.Entities;
using SOSTrucksMonitor.api.Repositories;
using System.Linq;
using System;

namespace SOSTrucksMonitor.api.Features.TrucksMonitor
{
    public class TrucksMonitorAppService
    {
        private ITruckMonitorRepository _repository;
        public TrucksMonitorAppService(ITruckMonitorRepository truckMonitorRepository)
        {
            _repository = truckMonitorRepository;
        }

        public async Task<List<TruckMonitorDTO>> GetAllIncluded()
        {
            var datos = await _repository.GetAllIncludedAsync();
            return  MappingTruckMonitor(datos);
        }

        public List<TruckMonitorDTO> MappingTruckMonitor(IEnumerable<TruckMonitor> trucksMonitor)
        {
            var trucksMonitorDTO = new List<TruckMonitorDTO>();

            foreach (var truck in trucksMonitor)
            {

                var newTruck = new TruckMonitorDTO()
                {
                    LoadNumber = truck.LoadNumber,
                    Invoice = truck.Invoice,
                    Date = truck.Date,
                    TruckNumber = truck.TruckNumber,
                    TrailerNumber = truck.TrailerNumber,
                    Customer = truck.Customer,
                    CustomerReference = truck.CustomerReference,
                    FileNumber = truck.FileNumber,
                    From = truck.From,
                    To = truck.To,
                    TruckOwner = truck.TruckOwner,
                    BaseCity = truck.BaseCity
                };

                if (truck.Driver != null)
                {
                    newTruck.Driver = new DriverDTO();
                    var truckDriver = truck.Driver.FirstOrDefault();
                    newTruck.Driver.Name = truckDriver.Name;
                    newTruck.Driver.PhoneNumber = truckDriver.PhoneNumber;
                }


                if (truck.PickUpAttributeStatus != null)
                {
                    newTruck.PickUp = new PickUpDTO()
                    {
                        Log = new List<string>()
                    };
                    foreach (var item in truck.PickUpAttributeStatus)
                    {
                        if (item.Type == "PICKUP_DATE")
                        {
                            newTruck.PickUp.Date = DateTime.Parse(item.Value);
                        }
                        else
                        {
                            newTruck.PickUp.Log.Add(item.Value);
                        }
                    }
                }


                if (truck.Broker != null)
                {
                    newTruck.Broker = new BrokerDTO();
                    var truckBroker = truck.Broker.FirstOrDefault();
                    newTruck.Broker.Name = truckBroker.Name;
                    newTruck.Broker.PhoneNumber = truckBroker.PhoneNumber;
                }


                if (truck.Load != null)
                {
                    newTruck.Load = new LoadDTO()
                    {
                        Loads = new List<string>()
                    };
                    foreach (var item in truck.Load)
                    {
                        if (item.Type == "FILE_NUMBER")
                        {
                            newTruck.Load.FileNumber = item.Value;
                        }
                        else
                        {
                            newTruck.Load.Loads.Add(item.Value);
                        }
                    }
                }

                if (truck.DeliveryAttributeStatus != null)
                {
                    newTruck.Delivery = new DeliveryDTO()
                    {
                        Log = new List<string>()
                    };
                    foreach (var item in truck.DeliveryAttributeStatus)
                    {
                        if (item.Type == "ETA")
                        {
                            newTruck.Delivery.Date = DateTime.Parse(item.Value);
                        }
                        else
                        {
                            newTruck.Delivery.Log.Add(item.Value);
                        }
                    }
                }

                trucksMonitorDTO.Add(newTruck);
            }

            return trucksMonitorDTO;
        }
    }
}
