using BusinessLayer.Concrate;
using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProje.Controllers
{
    public class CommentController : Controller
    {
        // GET: Comment
        CommentManager cm = new CommentManager();
        public PartialViewResult CommentList(int id)
        {
            var commentlist = cm.CommentBlogID(id);


            return PartialView(commentlist);
        }
        [HttpGet]
        public PartialViewResult LeaveComment(int id)
        {
            ViewBag.id = id;
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult LeaveComment(Comment c,int id)
        {

            ViewBag.id = id;
            cm.CommentAdd(c);
            return PartialView();

        }
        public ActionResult AdminCommentListTrue()
        {
            var commentlist = cm.CommentByStatusTrue();
            return View(commentlist);
        }
        public ActionResult CommentStatusChangeToFalse(int id)
        {
            cm.UpdateComment(id);
            return RedirectToAction("AdminCommentListTrue");
        }


    }
}