using BusinessLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProje.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        CategoryManager cm = new CategoryManager();
        public ActionResult Index()
        {
            var categoryvalue = cm.GetAll();
            return View(categoryvalue);
        }
        public PartialViewResult BlogDetayCategory()
        {
            var categoryvalue = cm.GetAll();
            return PartialView(categoryvalue);
        }
      
  
    }
}