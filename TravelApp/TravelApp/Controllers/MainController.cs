using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelApp.Models.Classes;

namespace TravelApp.Controllers
{
    public class MainController : Controller
    {
        // GET: Main
        Context context = new Context();
        public ActionResult Index()
        {
            var blogs = context.Blogs.ToList();
            return View(blogs);
        }

        public PartialViewResult PartialViewResult()
        {
            var blogs = context.Blogs.OrderByDescending(x=>x.id).Take(2).ToList();
            return PartialView(blogs);
        }

        public PartialViewResult PartialViewResult2()
        {
            var blogs = context.Blogs.Where(x => x.id == 1).ToList();
            return PartialView(blogs);
        }

    }
}