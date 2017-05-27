using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SOSTrucksMonitor.web.ViewModels;

namespace SOSTrucksMonitor.web.Controllers
{
    public class MonitorController : Controller
    {
        public IActionResult Index()
        {
            var viewModel = new TrucksMonitorViewModel();
            var model = viewModel.GetTrucks();


            return View(model);
        }

        public IActionResult Detail()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
