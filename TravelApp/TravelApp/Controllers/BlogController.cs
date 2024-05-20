using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelApp.Models.Classes;

namespace TravelApp.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        Context c = new Context();
        BlogComments bc = new BlogComments();
        public ActionResult Index()
        {
            bc.Blogs = c.Blogs.ToList();
            bc.Comments = c.Comments.ToList();
            return View(bc);
        }

          
        public ActionResult BlogDetail(int id)
        {
            bc.Comments = c.Comments.Where(x => x.BlogId == id).ToList();
            bc.Blogs = c.Blogs.Where(x => x.id == id).ToList();
            return View(bc);
        }

        [HttpGet]
        public PartialViewResult AddComment(int id)
        {
            TempData["Data"] = id;
            TempData.Keep("Data");
            return PartialView();
        }


        [HttpPost]
        public PartialViewResult AddComment(Comment com) 
        {
            c.Comments.Add(com);
            c.SaveChanges();
            return PartialView();
        }
    }
}