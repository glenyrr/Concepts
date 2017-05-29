using System;
using System.Collections.Generic;
using SOSTrucksMonitor.Models;

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
            newTruck.LoadNumber = 948;
            newTruck.Invoice = "948";
            newTruck.Date = DateTime.Now;
            newTruck.TruckNumber = "1019";
            newTruck.TrailerNumber = "1642";
            newTruck.Customer = "Bussiness Transportation Solutions, LLC.";
            newTruck.CustomerReference = "Pending";
            newTruck.FileNumber = "104";
            newTruck.From = "West Memphis, AR";
            newTruck.To = "Miami, FL";
            newTruck.TruckOwner = "48 Xpress Inc";
            newTruck.BaseCity = "Miami, FL";
            newTruck.EmptyMiles = 62;
            newTruck.RevenueMiles = 1050;
     
            newTruck.Driver = new DriverDTO();
            newTruck.Driver.Name = "Rosniel Macia";
            newTruck.Driver.PhoneNumber = "888-777-666";
            
            newTruck.PickUp = new PickUpDTO();
            newTruck.PickUp.Date = DateTime.Now;
            newTruck.PickUp.Log = new List<string>();
            newTruck.PickUp.Log.Add("Direction Done");
            newTruck.PickUp.Log.Add("App. Required");

            newTruck.Broker = new BrokerDTO();
            newTruck.Broker.Name = "Scott Logistic Corp";
            newTruck.Broker.PhoneNumber = "305-593-1533";

            newTruck.Load = new LoadDTO();
            newTruck.Load.FileNumber = "18";
             newTruck.Load.Loads = new List<string>();
            newTruck.Load.Loads.Add("16");   
            newTruck.Load.Loads.Add("18");   

            newTruck.Delivery = new DeliveryDTO();
            newTruck.Delivery.Date = DateTime.Now;
            newTruck.Delivery.Log = new List<string>();
            newTruck.Delivery.Log.Add("Direction Done");

           trucksMonitor.Add(newTruck);

            var newTruck2 = new TruckMonitorDTO();

           

            return trucksMonitor;


        }
    }
}