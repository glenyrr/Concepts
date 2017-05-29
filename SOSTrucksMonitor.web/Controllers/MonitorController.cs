using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SOSTrucksMonitor.web.ViewModels;
using SOSTrucksMonitor.web.AppServices;

namespace SOSTrucksMonitor.web.Controllers
{
    public class MonitorController : Controller
    {

        private TrucksMonitorAppServices _trucksMonitorAppServices;
        public MonitorController(TrucksMonitorAppServices trucksMonitorAppServices)
        {
            _trucksMonitorAppServices = trucksMonitorAppServices;
        }

        public async Task<IActionResult> Index()
        {

            var model = await _trucksMonitorAppServices.GetTrucksMonitor();

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
