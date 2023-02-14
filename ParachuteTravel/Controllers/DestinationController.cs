using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParachuteTravel.Controllers
{
    public class DestinationController : Controller
    {
        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());
        public IActionResult Index()
        {
            var destination = destinationManager.TGetList();
            return View(destination);
        }

        [HttpGet]

        public IActionResult DestinationDetails(int id)
        {
            ViewBag.i = id;
            var destination = destinationManager.TGetById(id);
            return View(destination);
        }

        [HttpPost]

        public IActionResult DestinationDetails(Destination destination)
        {
            return View();
        }
    }
}
