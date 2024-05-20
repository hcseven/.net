using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelApp.Models.Classes;

namespace TravelApp.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context context = new Context();
        [Authorize]
        public ActionResult Index()
        {
            var blogs = context.Blogs.ToList();
            return View(blogs);
        }
        [HttpGet]
        [Authorize]
        public ActionResult AddBlog() 
        {
            return View();
        }
        [HttpPost]
        [Authorize]
        public ActionResult AddBlog(Blog b)
        { 
            context.Blogs.Add(b);
            context.SaveChanges();
            return RedirectToAction("Index"); 
        }
        [Authorize]
        public ActionResult RemoveBlog(int id)
        {
            var b = context.Blogs.Find(id);
            context.Blogs.Remove(b);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult BringBlog(int id)
        {
            var blog = context.Blogs.Find(id);
            return View(blog);
        }
        public ActionResult UpdateBlog(Blog b) 
        {
            var blog = context.Blogs.Find(b.id);
            blog.Title = b.Title;
            blog.Explanation = b.Explanation;
            blog.Date = b.Date;
            blog.Image = b.Image;
            context.SaveChanges();
            return RedirectToAction("Index"); 
        }

        public ActionResult CommentList()
        {
            var com = context.Comments.ToList();
            return View(com);
        }

        public ActionResult CommentRemove(int id)
        {
            var c = context.Comments.Find(id);
            context.Comments.Remove(c);
            context.SaveChanges();
            return RedirectToAction("CommentList", "Admin");
        }

        public ActionResult BringComment(int id)
        {
            var comment = context.Comments.Find(id);
            return View(comment);
        }

        public ActionResult UpdateComment(Comment coms)
        {
            var com = context.Comments.Find(coms.Id);
            com.Username = coms.Username;
            com.Email = coms.Email;
            com.UserComment = coms.UserComment;
            context.SaveChanges();
            return RedirectToAction("CommentList");
        }
    }
}