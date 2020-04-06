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

		public ActionResult ShowBanner()
		{
			return PartialView("_Banner", new List<Banner> {
				new Banner
				{
					Link = "/#",
					Path = "/Content/resources/assets/banners/index_1.jpg"
				},
				new Banner
				{
					Link = "/#",
					Path = "/Content/resources/assets/banners/index_2.jpg"
				}

			});
		}

		public ActionResult Search()
		{
			return View("Search", new List<Article>
			{
				new Article
				{
					Title = "Test",
					ImageDefault = "/Content/resources/assets/news/news_1.jpg",
					Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua...",
					Order = new DateTime(2020,02,29),
					ExternalUrl = "/Project/ProjectDetail"
				},
				new Article
				{
					Title = "2 An Tín Ký Kết Hợp Tác Cùng Ủy Ban Thương Hiệu Xuất Sắc Châu Á Thái Bình Dương Và Vifolac",
					ImageDefault = "/Content/resources/assets/news/news_2.jpg",
					Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua...",
					Order = new DateTime(2020,03,01),
					ExternalUrl = "/Project/ProjectDetail"
				},
				new Article
				{
					Title = "3 An Tín Ký Kết Hợp Tác Cùng Ủy Ban Thương Hiệu Xuất Sắc Châu Á Thái Bình Dương Và Vifolac",
					ImageDefault = "/Content/resources/assets/news/news_3.jpg",
					Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua...",
					Order = new DateTime(2020,03,03),
					ExternalUrl = "/Project/ProjectDetail"
				},
				new Article
				{
					Title = "4 An Tín Ký Kết Hợp Tác Cùng Ủy Ban Thương Hiệu Xuất Sắc Châu Á Thái Bình Dương Và Vifolac",
					ImageDefault = "/Content/resources/assets/news/news_4.jpg",
					Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua...",
					Order = new DateTime(2020,03,05),
					ExternalUrl = "/Project/ProjectDetail"
				},
				new Article
				{
					Title = "5 An Tín Ký Kết Hợp Tác Cùng Ủy Ban Thương Hiệu Xuất Sắc Châu Á Thái Bình Dương Và Vifolac",
					ImageDefault = "/Content/resources/assets/news/news_5.jpg",
					Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua...",
					Order = new DateTime(2020,03,07),
					ExternalUrl = "/Project/ProjectDetail"
				},
				new Article
				{
					Title = "6 An Tín Ký Kết Hợp Tác Cùng Ủy Ban Thương Hiệu Xuất Sắc Châu Á Thái Bình Dương Và Vifolac",
					ImageDefault = "/Content/resources/assets/news/news_6.jpg",
					Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua...",
					Order = new DateTime(2020,03,09),
					ExternalUrl = "/Project/ProjectDetail"
				},
			});
		}

		[Route("get-projects")]
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

		[Route("get-news")]
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