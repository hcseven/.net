using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TravelApp.Models.Classes;

namespace TravelApp.Controllers
{
    public class LoginController : Controller
    {

        Context c = new Context();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Admin ad) 
        {
            var inf = c.Admins.FirstOrDefault(x=> x.Name == ad.Name && x.Password == ad.Password);
            if (inf != null)
            {
                FormsAuthentication.SetAuthCookie(inf.Name, false);
                Session["user"]=inf.Name.ToString();

                return RedirectToAction("Index", "Admin");
            }
            return View();
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("/Login");
        }
    }

}