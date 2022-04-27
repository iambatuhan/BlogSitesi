using BusinessLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProje.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        UserProfilManager UserProfil = new UserProfilManager();
        public ActionResult Index()
        {
         
            return View();
        }
        public PartialViewResult Partial1(string p)
        {
            var mail = (string)Session["Mail"];
            var profilvalues = UserProfil.GetAuthorByMail(mail);
            return PartialView(profilvalues);
        }
       
    }
}