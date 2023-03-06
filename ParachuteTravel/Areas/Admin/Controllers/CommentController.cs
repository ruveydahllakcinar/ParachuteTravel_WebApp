using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParachuteTravel.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public IActionResult Index()
        {
            var comment = _commentService.TGetListCommentWithDestination();
            return View(comment);
        }

        public IActionResult DeleteComment(int id)
        {
            var comment = _commentService.TGetById(id);
            _commentService.TDelete(comment);
            return RedirectToAction("Index","Comment");
        }
    }
}
