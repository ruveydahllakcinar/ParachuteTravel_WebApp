using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParachuteTravel.Areas.Users.Controllers
{
    [Area("Users")]
    public class ReservationController : Controller
    {
        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());
        ReservationManager reservationManager = new ReservationManager(new EfReservationDal());

        private readonly UserManager<AppUser> _userManager;

        public ReservationController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult MyActiveReservation()
        {
            var values = _userManager.FindByNameAsync(User.Identity.Name).Result;
            var valuesList = reservationManager.GetListWithReservationByActive(values.Id);
            return View(valuesList);
        }

        public IActionResult MyPastReservation()
        {
            var values = _userManager.FindByNameAsync(User.Identity.Name).Result;
            var valuesList = reservationManager.GetListWithReservationByPast(values.Id);
            return View(valuesList);
        }

        public IActionResult MyApprovalWaitReservation()
        {
            var values = _userManager.FindByNameAsync(User.Identity.Name).Result;
            var valuesList = reservationManager.GetListWithReservationByWaitApproval(values.Id);
            return View(valuesList);
        }

        [HttpGet]
        public IActionResult NewReservation()
        {
            List<SelectListItem> values = (from x in destinationManager.TGetList()
                                           select new SelectListItem { 
                                                                        Text =x.CityName,
                                                                        Value = x.DestinationId.ToString()
                                                                      }).ToList();
            ViewBag.v = values;
            return View();
        }

        [HttpPost]
        public IActionResult NewReservation(Reservation reservation)
        {
            reservation.AppUserId=4;
            reservation.Status = "Waiting for approval";
            reservationManager.TAdd(reservation);
            return RedirectToAction("MyApprovalReservation");
        }
    }
}
