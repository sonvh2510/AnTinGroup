using MainProject.SBussiness.LandingPage.Models.Gallery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MainProject.Controllers
{
	public class GalleryController : Controller
	{
		// GET: Gallery
		public ActionResult Index()
		{
			return View(new GalleryViewModel());
		}

	}
}