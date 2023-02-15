using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParachuteTravel.Areas.Users.ViewComponents.UsersDashboard
{   
    [Area("Users")]
    public class CurrentTravelList:ViewComponent
    {
        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());
        [HttpPost]
        public IViewComponentResult Invoke(Destination destination)
        {
            var values = destinationManager.TGetList().OrderByDescending(x=>x.ShareDate).Take(5).ToList();
            return View(values);
            
        }
       
    }
}
