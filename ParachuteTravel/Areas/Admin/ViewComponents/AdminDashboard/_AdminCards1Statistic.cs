using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParachuteTravel.Areas.Admin.ViewComponents.AdminDashboard
{
    public class _AdminCards1Statistic: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Context context = new Context();
            ViewBag.v1 = context.Destinations.Count();
            ViewBag.v2 = context.Users.Count();
            return View();

        }
    }
}
