using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoleStar_TraversalCoreProject.ViewComponents.Comment
{
    public class _AddComment: ViewComponent
    {
        //CommentManager commentManager = new CommentManager(new EfCommentDal());
        
        public IViewComponentResult Invoke()
        {
            return View();
        }
        //[HttpPost]
        //public IViewComponentResult Invoke(EntityLayer.Concrete.Comment comment)
        //{
        //    comment.CommentDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
        //    comment.CommentState = true;
        //    commentManager.TAdd(comment);
        //    return View();
        //}
    }
}
