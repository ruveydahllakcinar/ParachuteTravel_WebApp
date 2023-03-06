using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntityLayer.Concrete;
using FluentValidation.Results;
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
    [Route("Admin/[controller]/[action]/{id?}")]
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
            GuideValidator validationRules = new();
            var validatorResult = validationRules.Validate(guide);

            if (!validatorResult.IsValid)
            {
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
                guide.LinkedinUrl = addGuide.LinkedinUrl;

                _guideService.TAdd(guide);
                return RedirectToAction("Index", "Guide", new { area = "Admin" });
            }
            else
            {
                foreach (var item in validatorResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }

            }
            return View();

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
            guide.LinkedinUrl = addGuide.LinkedinUrl;
            _guideService.TUpdate(guide);
            return RedirectToAction("Index", "Guide", new { area = "Admin" });
        }

        public IActionResult ChangeToTrue(int id)
        {
            _guideService.TChangeToTrueByGuide(id);
            return RedirectToAction("Index", "Guide", new { area = "Admin" });
        }


        public IActionResult ChangeToFalse(int id)
        {
            _guideService.TChangeToFalseByGuide(id);
            return RedirectToAction("Index", "Guide", new { area = "Admin" });
        }
    }
}
