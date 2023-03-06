using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoleStar_TraversalCoreProject.ViewComponents.Comment
{
    public class _CommentList:ViewComponent
    {
        CommentManager commentManager = new CommentManager(new EfCommentDal());
        public IViewComponentResult Invoke(int id)
        {
            ViewBag.v = commentManager.TGetListCommentWithDestinationAndUser(id).Count();
            var comment = commentManager.TGetListCommentWithDestinationAndUser(id);
            return View(comment);

           
        }
    }
}
