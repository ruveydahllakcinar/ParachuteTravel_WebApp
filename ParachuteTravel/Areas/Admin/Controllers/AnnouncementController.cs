using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using ParachuteTravel.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParachuteTravel.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AnnouncementController : Controller
    {
        private readonly IAnnouncementService _announcementService;

        public AnnouncementController(IAnnouncementService announcementService)
        {
            _announcementService = announcementService;
        }

        public IActionResult Index()
        {
            List<Announcement> announcements = _announcementService.TGetList();
            List<AnnouncementViewModel> models = new();
            foreach (var announcement in announcements)
            {
                AnnouncementViewModel announcementViewModel = new();
                announcementViewModel.AnnouncementId = announcement.AnnouncementID;
                announcementViewModel.Title = announcement.Title;
                announcementViewModel.Content = announcement.Content;
                models.Add(announcementViewModel);
            }
            return View(models);
        }

        [HttpGet]
        public IActionResult AddAnnouncement()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult AddAnnouncement(string x)
        {

            return View();
        }
    }
}
