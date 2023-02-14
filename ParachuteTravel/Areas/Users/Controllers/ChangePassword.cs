using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ParachuteTravel.Areas.Users.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParachuteTravel.Areas.Users.Controllers
{
    [Area("Users")]
    [Route("Users/[controller]/[action]")]
    public class ChangePassword : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public ChangePassword(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserChangePasswordViewModel userChangePasswordView)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, userChangePasswordView.Password);
            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Profile");
            }
            return View();
        }
    }
}
