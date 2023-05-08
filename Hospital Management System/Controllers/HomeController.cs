using Hospital_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hospital_Management_System.Controllers
{
    public class HomeController : Controller
    {
        Hospital_Management_SystemEntities db = new Hospital_Management_SystemEntities();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(Person p)
        {
            if (ModelState.IsValid)
            {
                db.People.Add(p);
                db.SaveChanges();
                return RedirectToAction("Index","Patient");

            }
            
            return View();
        }
    }
}