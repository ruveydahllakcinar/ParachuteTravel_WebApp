﻿using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParachuteTravel.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly IAppUserService _appUserService;

        public UserController(IAppUserService appUserService)
        {
            _appUserService = appUserService;
        }

        public IActionResult Index()
        {
            var user = _appUserService.TGetList();
            return View(user);
        }

        public IActionResult DeleteUser(int id)
        {
            var user = _appUserService.TGetById(id);
            _appUserService.TDelete(user);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditUser(int id)
        {
            var user = _appUserService.TGetById(id);       
            return View(user);
        }

        [HttpPost]
        public IActionResult EditUser(AppUser appUser)
        {
            _appUserService.TUpdate(appUser);
            return RedirectToAction("Index");
        }

        public IActionResult CommentUser(int id)
        {
            _appUserService.TGetList();
            return View();
        }

    }
}
