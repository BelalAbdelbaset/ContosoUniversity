using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContosoUniversity.Controllers
{
    public class HomeController : Controller
    {
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
        public ActionResult Students()
        {
            return View();
        }
        public ActionResult Courses()
        {
            return View();
        }
        public ActionResult Instructors()
        {
            return View();
        }
        public ActionResult Departments()
        {
            return View();
        }

    }
}