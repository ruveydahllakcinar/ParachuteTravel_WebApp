using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoleStar_TraversalCoreProject.ViewComponents.Home
{
    public class _TestimonialViewPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            TestimonialManager testimonialManager = new TestimonialManager(new EfTestimonialDal());
            var testimonial = testimonialManager.TGetList();
            return View(testimonial);
        }
    }
}
