using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NOSTRA_IoT_Platform.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.markdashboard = "active";
            return View();
        }

        public ActionResult Timeline()
        {
            ViewBag.Message = "Your application description page.";
            ViewBag.marktimeline = "active";
            return View();
        }

        public ActionResult Sensor()
        {
            ViewBag.Message = "Your contact page.";
            ViewBag.marksensor = "active";
            return View();
        }

        public ActionResult Analysis()
        {
            ViewBag.Message = "Your contact page.";
            ViewBag.markanalysis = "active";
            return View();
        }
    }
}