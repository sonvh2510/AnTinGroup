using MainProject.SBussiness.LandingPage.Models.Invest;
using MainProject.SBussiness.LandingPage.Models.News;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MainProject.Controllers
{
	public class InvestController : Controller
	{
		// GET: Invest
		public ActionResult Index()
		{
			return View(new InvestViewModel());
		}
		public ActionResult InvestList()
		{
			return View("_List", new InvestListViewModel());
		}
		public ActionResult InvestDetail()
		{
			return View("_Detail", new NewsDetailViewModel());
		}
	}
}