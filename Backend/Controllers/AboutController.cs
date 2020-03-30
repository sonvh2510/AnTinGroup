using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MainProject.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ChairmainsLetter()
        {
            return View();
        }

        public ActionResult BoardOfExecutive()
        {
            return View();
        }

        public ActionResult OrganizationChart()
        {
            return View();
        }

        public ActionResult Department()
        {
            return View();
        }

        public ActionResult Customer()
        {
            return View();
        }

        public ActionResult ShareHolder()
        {
            return View();
        }
    }
}