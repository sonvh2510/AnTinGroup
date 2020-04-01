using MainProject.SBussiness.LandingPage.Models.Home;
using MainProject.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MainProject.Controllers
{
	public class HomeController : Controller
	{
		// Return View() is used for the View need to render with _Layout.
		// Return PartialView() is used for the View only it's own.
		// If you don't put the name in View() or PartialView() it'll return View named of Action.
		public ActionResult Index()
		{
			ViewBag.ShowBreadCrumb = false;
			ViewBag.Banners = new Banner[] {
				new Banner
				{
					Link = "/#",
					ResourcePath = "/Content/resources/assets/banners/index_1.jpg"
				},
				new Banner
				{
					Link = "/#",
					ResourcePath = "/Content/resources/assets/banners/index_2.jpg"
				}
				
			};
			return View(new HomeViewModel());
		}

		public ActionResult ShowHeader()
		{
			return PartialView("_Header", new HeaderViewModel());
		}

		public ActionResult ShowFooter()
		{
			return PartialView("_Footer", new FooterViewModel());
		}
	}
}