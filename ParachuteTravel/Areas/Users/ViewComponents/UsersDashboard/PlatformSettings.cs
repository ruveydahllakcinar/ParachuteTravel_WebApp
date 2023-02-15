using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParachuteTravel.Areas.Users.ViewComponents.UsersDashboard
{
    public class PlatformSettings : ViewComponent
    {
        //DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());
        public IViewComponentResult Invoke()
        {
            //var values = destinationManager.TGetList().OrderByDescending(x => x.ShareDate).Take(5).ToList();
            return View();
        }
    }
 
}
