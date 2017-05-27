using System;
using System.Collections.Generic;
using SOSTrucksMonitor.web.Models;

namespace SOSTrucksMonitor.web.ViewModels
{
    public class TrucksMonitorViewModel
    {
        public IEnumerable<TruckMonitorDTO> GetTrucks()
        {
            return GetTrucksFake();
        }



        private IEnumerable<TruckMonitorDTO> GetTrucksFake()
        {
             var trucksMonitor = new  List<TruckMonitorDTO>();
            
            var newTruck = new TruckMonitorDTO();
            newTruck.Load = 948;
            newTruck.Invoice = 948;
            newTruck.Driver = new DriverDTO();
            newTruck.Driver.Name = "Rosniel Macia";
            newTruck.Date = DateTime.Now;
            newTruck.TruckNumber = "1019";
            newTruck.TrailerNumber = "1642";
            newTruck.Customer = "Bussiness Transportation Solutions, LLC.";
            newTruck.CustomerReference = "Pending";
            newTruck.FileNumber = "104";
            newTruck.From = "West Memphis, AR";
            newTruck.To = "Miami, FL";
            newTruck.TruckOwner = "48 Xpress Inc";
            newTruck.EmptyMiles = 62;
            newTruck.RevenueMiles = 1050;
            newTruck.PickupDate = DateTime.Now;
            newTruck.DeliveryDate = DateTime.Now;

            trucksMonitor.Add(newTruck);

            var newTruck2 = new TruckMonitorDTO();
            newTruck2.Load = 9482;
            newTruck2.Invoice = 9482;
            newTruck2.Driver = new DriverDTO();
            newTruck2.Driver.Name = "Arnoldo Martinez";
            newTruck2.Date = DateTime.Now;
            newTruck2.TruckNumber = "1014A";
            newTruck2.TrailerNumber = "1641";
            newTruck2.Customer = "Bussiness Transportation Solutions, LLC.";
            newTruck2.CustomerReference = "J036638";
            newTruck.FileNumber = "107";
            newTruck2.From = "West Memphis, AR";
            newTruck2.To = "Miami, FL";
            newTruck2.TruckOwner = "48 Xpress Inc";
            newTruck2.EmptyMiles = 62;
            newTruck2.RevenueMiles = 1050;
            newTruck2.PickupDate = DateTime.Now;
            newTruck2.DeliveryDate = DateTime.Now;

            trucksMonitor.Add(newTruck2);

            return trucksMonitor;


        }
    }
}