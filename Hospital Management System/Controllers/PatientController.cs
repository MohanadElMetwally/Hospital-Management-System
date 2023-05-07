using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hospital_Management_System.Controllers
{
    public class PatientController : Controller
    {
        // GET: Patient
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Reserve()
        {
            return View();
        }

        public ActionResult CancelAppointment()
        {
            return View();
        }

        public ActionResult ViewDoctors()
        {
            return View();
        }
    }
}