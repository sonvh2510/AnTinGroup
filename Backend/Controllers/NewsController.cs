using MainProject.SBussiness.LandingPage.Models.News;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MainProject.Framework.Helpers;
using MainProject.Core;

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
	public class ProjectController : Controller
	{
		// GET: Project
		public ActionResult Index()
		{
			return View(new NewsViewModel()
			{
				Category = ResourceHelper.ReadFile("/App_Data/Files/News_Category.txt"),
				NewsItems = new List<Article>
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
				}
			});
		}

		public ActionResult ProjectDetail()
		{
			return View("_Detail", new NewsDetailViewModel());
		}
	}
}