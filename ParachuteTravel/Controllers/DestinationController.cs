using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParachuteTravel.Controllers
{   
    [AllowAnonymous]
    public class DestinationController : Controller
    {
        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());
        private readonly UserManager<AppUser> _userManager;

        public DestinationController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var destination = destinationManager.TGetList();
            return View(destination);
        }

        [HttpGet]

        public async Task<IActionResult>DestinationDetails(int id)
        {
            ViewBag.i = id;
            ViewBag.DestId = id;
            var value = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.userId = value.Id;
            var destination = destinationManager.TGetDestinationWithGuide(id);
            return View(destination);
        }

        [HttpPost]

        public IActionResult DestinationDetails(Destination destination)
        {
            return View();
        }
    }
}
