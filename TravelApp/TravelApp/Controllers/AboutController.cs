using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelApp.Models.Classes;

namespace TravelApp.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        Context Context = new Context();
        public ActionResult Index()
        {
            var values = Context.Abouts.ToList();
            return View(values);
        }
    }
}