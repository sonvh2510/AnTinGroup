using MainProject.SBussiness.LandingPage.Models.News;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MainProject.Controllers
{
	public class NewsController : Controller
	{
		// GET: News
		public ActionResult Index()
		{
			return View(new NewsViewModel());
		}

		public ActionResult NewsDetail()
		{
			return View("_Detail", new NewsDetailViewModel());
		}
	}
}