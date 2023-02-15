using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParachuteTravel.Areas.Users.ViewComponents.UsersDashboard
{
    [Area("Users")]
    public class ProfileInformations:ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;

        public ProfileInformations(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IViewComponentResult Invoke()
        {
            var values = _userManager.FindByNameAsync(User.Identity.Name).Result;
            ViewBag.name = values.Name + " "+ values.Surname;
            ViewBag.phonenumber = values.PhoneNumber;
            ViewBag.email = values.Email;
            ViewBag.city = "Türkiye";
            return View();
        }
    }
}
