﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParachuteTravel.Areas.Users.Controllers
{
    public class ChangePasswordController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
