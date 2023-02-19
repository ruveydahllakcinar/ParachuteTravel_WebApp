using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using ParachuteTravel.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ParachuteTravel.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GuideController : Controller
    {
        private readonly IGuideService _guideService;
        public GuideController(IGuideService guideService)
        {
            _guideService = guideService;
        }

        public IActionResult Index()
        {
            var guides = _guideService.TGetList();
            return View(guides);
        }

        [HttpGet]
        public IActionResult AddGuide()
        {

            return View();
        }
        [HttpPost]
        public IActionResult AddGuide(AddGuideViewModel addGuide)
        {
            Guide guide = new Guide();
            if (addGuide.Image != null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(addGuide.Image.FileName);
                var imagename = Guid.NewGuid() + extension;
                var savelocation = resource + "/wwwroot/GuideImage/" + imagename;
                var stream = new FileStream(savelocation, FileMode.Create);
                addGuide.Image.CopyToAsync(stream);
                guide.Image = imagename;
            }

            guide.Name = addGuide.Name;
            guide.Description = addGuide.Description;
            guide.Status = addGuide.Status;
            guide.InstagramUrl = addGuide.InstagramUrl;
            guide.TwitterUrl = addGuide.TwitterUrl;
            _guideService.TAdd(guide);
            return RedirectToAction("Index", "Guide");

        }

        [HttpGet]
        public IActionResult EditGuide(int id)
        {
            var guides = _guideService.TGetById(id);
            return View(guides);
        }
        [HttpPost]
        public IActionResult EditGuide(AddGuideViewModel addGuide)
        {
            var guide = _guideService.TGetById(addGuide.GuideId);
            if (addGuide.Image != null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(addGuide.Image.FileName);
                var imagename = Guid.NewGuid() + extension;
                var savelocation = resource + "/wwwroot/GuideImage/" + imagename;
                var stream = new FileStream(savelocation, FileMode.Create);
                addGuide.Image.CopyToAsync(stream);
                guide.Image = imagename;
            }
            guide.Name = addGuide.Name;
            guide.Description = addGuide.Description;
            guide.Status = addGuide.Status;
            guide.InstagramUrl = addGuide.InstagramUrl;
            guide.TwitterUrl = addGuide.TwitterUrl;
            _guideService.TUpdate(guide);
            return RedirectToAction("Index", "Guide", new { area = "Admin" });
        }

        public IActionResult ChangeTrue(int id)
        {
            return RedirectToAction("Index", "Guide");
        }


        public IActionResult ChangeFalse(int id)
        {
            return RedirectToAction("Index", "Guide");
        }
    }
}
