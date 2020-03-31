using MainProject.SBussiness.LandingPage.Models.About;
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
			return View(new AboutViewModel());
		}

		public ActionResult AboutMessage()
		{
			return View("Message", new AboutViewModel());
		}

		public ActionResult AboutBoardOfExecutive()
		{
			return View("BoardOfExecutive", new AboutViewModel());
		}

		public ActionResult AboutOrganizationChart()
		{
			return View("OrganizationChart", new AboutViewModel());
		}

		public ActionResult AboutDepartment()
		{
			return View("Department", new AboutViewModel());
		}

		public ActionResult AboutCustomer()
		{
			return View("Customer", new AboutViewModel());
		}

		public ActionResult AboutShareHolder()
		{
			return View("ShareHolder", new AboutViewModel());
		}
	}
}