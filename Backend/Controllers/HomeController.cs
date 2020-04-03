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

		public ActionResult GetProjects(long id)
		{
			return PartialView("_Project", new List<Article> {
				new Article
				{
					Title = "Ajax 1 Khu Du lịch nghỉ dưỡng và biệt thự sinh thái FLC Cù Lao Xanh, Quy Nhơn, Bình Định",
					ExternalUrl = "/Project/ProjectDetail",
					ImageDefault = "/Content/resources/assets/project/index_project_1.jpg"
				},
				new Article
				{
					Title = "Ajax 2 Khu Du lịch nghỉ dưỡng và biệt thự sinh thái FLC Cù Lao Xanh, Quy Nhơn, Bình Định",
					ExternalUrl = "/Project/ProjectDetail",
					ImageDefault = "/Content/resources/assets/project/index_project_2.jpg"
				},
				new Article
				{
					Title = "Ajax 3 Khu Du lịch nghỉ dưỡng và biệt thự sinh thái FLC Cù Lao Xanh, Quy Nhơn, Bình Định",
					ExternalUrl = "/Project/ProjectDetail",
					ImageDefault = "/Content/resources/assets/project/index_project_3.jpg"
				},
				new Article
				{
					Title = "Ajax 4 Khu Du lịch nghỉ dưỡng và biệt thự sinh thái FLC Cù Lao Xanh, Quy Nhơn, Bình Định",
					ExternalUrl = "/Project/ProjectDetail",
					ImageDefault = "/Content/resources/assets/project/index_project_1.jpg"
				},
				new Article
				{
					Title = "5 Khu Du lịch nghỉ dưỡng và biệt thự sinh thái FLC Cù Lao Xanh, Quy Nhơn, Bình Định",
					ExternalUrl = "/Project/ProjectDetail",
					ImageDefault = "/Content/resources/assets/project/index_project_2.jpg"
				},
				new Article
				{
					Title = "6 Khu Du lịch nghỉ dưỡng và biệt thự sinh thái FLC Cù Lao Xanh, Quy Nhơn, Bình Định",
					ExternalUrl = "/Project/ProjectDetail",
					ImageDefault = "/Content/resources/assets/project/index_project_3.jpg"
				}
			});
		}

		public ActionResult GetNews(long id)
		{
			return PartialView("_Project", new List<Article> {
				new Article
				{
					Title = "Ajax 1 Khu Du lịch nghỉ dưỡng và biệt thự sinh thái FLC Cù Lao Xanh, Quy Nhơn, Bình Định",
					ExternalUrl = "/Project/ProjectDetail",
					ImageDefault = "/Content/resources/assets/news/news_1.jpg"
				},
				new Article
				{
					Title = "Ajax 2 Khu Du lịch nghỉ dưỡng và biệt thự sinh thái FLC Cù Lao Xanh, Quy Nhơn, Bình Định",
					ExternalUrl = "/Project/ProjectDetail",
					ImageDefault = "/Content/resources/assets/news/news_2.jpg"
				},
				new Article
				{
					Title = "Ajax 3 Khu Du lịch nghỉ dưỡng và biệt thự sinh thái FLC Cù Lao Xanh, Quy Nhơn, Bình Định",
					ExternalUrl = "/Project/ProjectDetail",
					ImageDefault = "/Content/resources/assets/news/news_3.jpg"
				},
				new Article
				{
					Title = "Ajax 4 Khu Du lịch nghỉ dưỡng và biệt thự sinh thái FLC Cù Lao Xanh, Quy Nhơn, Bình Định",
					ExternalUrl = "/Project/ProjectDetail",
					ImageDefault = "/Content/resources/assets/news/news_1.jpg"
				},
				new Article
				{
					Title = "5 Khu Du lịch nghỉ dưỡng và biệt thự sinh thái FLC Cù Lao Xanh, Quy Nhơn, Bình Định",
					ExternalUrl = "/Project/ProjectDetail",
					ImageDefault = "/Content/resources/assets/news/news_2.jpg"
				},
				new Article
				{
					Title = "6 Khu Du lịch nghỉ dưỡng và biệt thự sinh thái FLC Cù Lao Xanh, Quy Nhơn, Bình Định",
					ExternalUrl = "/Project/ProjectDetail",
					ImageDefault = "/Content/resources/assets/news/news_3.jpg"
				}
			});
		}
	}
}