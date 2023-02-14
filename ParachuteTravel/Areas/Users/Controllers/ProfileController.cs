using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ParachuteTravel.Areas.Users.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ParachuteTravel.Areas.Users.Controllers
{
    [Area("Users")]
    [Route("Users/[controller]/[action]")]
    public class ProfileController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public ProfileController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var profile = _userManager.FindByNameAsync(User.Identity.Name).Result;
            UserEditViewModel userEditViewModel = new UserEditViewModel();
            userEditViewModel.Name = profile.Name;
            userEditViewModel.UserSurname = profile.Surname;
            userEditViewModel.UserMailAdress = profile.Email;
            userEditViewModel.UserPhoneNumber = profile.PhoneNumber;
            userEditViewModel.UserImageUrl = profile.ImageUrl;

            return View(userEditViewModel);
        }

        [HttpPost]

        public async Task<IActionResult> Index(UserEditViewModel userEditView)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (userEditView.Image!=null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(userEditView.Image.FileName);
                var imagename = Guid.NewGuid() + extension;
                var savelocation = resource + "/wwwroot/UserImages/" + imagename;
                var stream = new FileStream(savelocation, FileMode.Create);
                await userEditView.Image.CopyToAsync(stream);
                user.ImageUrl = imagename;
            }
            userEditView.Name = user.Name;
            userEditView.UserSurname = user.Surname;
            
            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Profile");
            }

            return View();
        }

    }
}
