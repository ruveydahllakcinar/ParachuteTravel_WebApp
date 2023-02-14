using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoleStar_TraversalCoreProject.ViewComponents.Home
{
    public class _FeatureLargeCardsViewPartial:ViewComponent
    {
        FeatureLargeCardManager featureLargeCardManager = new FeatureLargeCardManager(new EfFeatureLargeCardDal());
        public IViewComponentResult Invoke()
        {
            var values = featureLargeCardManager.TGetList();
            return View(values);
        }
    }
}
