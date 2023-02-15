using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParachuteTravel.Areas.Users.Controllers
{
    [Area("Users")]
    public class DashboardController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public DashboardController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var values = _userManager.FindByNameAsync(User.Identity.Name).Result;
            ViewBag.userName = values.Name +" "+values.Surname;
            ViewBag.userImage = values.ImageUrl;
            return View();
        }
    }
}
