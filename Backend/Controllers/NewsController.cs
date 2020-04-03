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
		
        public ActionResult Detail()
        {
            return View(new NewsDetailViewModel());
        }
		
        public ActionResult ShowHotNews()
        {
            return PartialView("_HotNews", new List<Article>
            {
                new Article
                {
                    Title = "1 An Tín Ký Kết Hợp Tác Cùng Ủy Ban Thương Hiệu Xuất Sắc Châu Á Thái Bình Dương Và Vifolac",
                    ImageDefault = "/Content/resources/assets/news/news_1.jpg",
					//Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua...",
					//Order = new DateTime(2020,02,29),
					ExternalUrl = "/News/Detail"
                },
                new Article
                {
                    Title = "2 An Tín Ký Kết Hợp Tác Cùng Ủy Ban Thương Hiệu Xuất Sắc Châu Á Thái Bình Dương Và Vifolac",
                    ImageDefault = "/Content/resources/assets/news/news_2.jpg",
					//Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua...",
					//Order = new DateTime(2020,02,29),
					ExternalUrl = "/News/Detail"
                },
                new Article
                {
                    Title = "3 An Tín Ký Kết Hợp Tác Cùng Ủy Ban Thương Hiệu Xuất Sắc Châu Á Thái Bình Dương Và Vifolac",
                    ImageDefault = "/Content/resources/assets/news/news_3.jpg",
					//Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua...",
					//Order = new DateTime(2020,02,29),
					ExternalUrl = "/News/Detail"
                },
                new Article
                {
                    Title = "4 An Tín Ký Kết Hợp Tác Cùng Ủy Ban Thương Hiệu Xuất Sắc Châu Á Thái Bình Dương Và Vifolac",
                    ImageDefault = "/Content/resources/assets/news/news_4.jpg",
					//Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua...",
					//Order = new DateTime(2020,02,29),
					ExternalUrl = "/News/Detail"
                },
                new Article
                {
                    Title = "5 An Tín Ký Kết Hợp Tác Cùng Ủy Ban Thương Hiệu Xuất Sắc Châu Á Thái Bình Dương Và Vifolac",
                    ImageDefault = "/Content/resources/assets/news/news_5.jpg",
					//Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua...",
					//Order = new DateTime(2020,02,29),
					ExternalUrl = "/News/Detail"
                },
            });
        }

        // GET: Project
        public ActionResult Project()
        {
            return View(new NewsViewModel()
            {
                Category = new Category
                {
                    Title = "Dự án"
                },
                Categories = new List<Category>
                {
                    new Category
                    {
                        Title = "Du lịch"
                    },
                    new Category
                    {
                        Title = "Bất động sản"
                    },
                    new Category
                    {
                        Title = "Hàng không"
                    },
                },
                Articles = new List<Article>
                {
                    new Article
                    {
                        Title = "Test",
                        ImageDefault = "/Content/resources/assets/news/news_1.jpg",
                        Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua...",
                        Order = new DateTime(2020,02,29),
                        ExternalUrl = "/News/ProjectDetail"
                    },
                    new Article
                    {
                        Title = "2 An Tín Ký Kết Hợp Tác Cùng Ủy Ban Thương Hiệu Xuất Sắc Châu Á Thái Bình Dương Và Vifolac",
                        ImageDefault = "/Content/resources/assets/news/news_2.jpg",
                        Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua...",
                        Order = new DateTime(2020,03,01),
                        ExternalUrl = "/News/ProjectDetail"
                    },
                    new Article
                    {
                        Title = "3 An Tín Ký Kết Hợp Tác Cùng Ủy Ban Thương Hiệu Xuất Sắc Châu Á Thái Bình Dương Và Vifolac",
                        ImageDefault = "/Content/resources/assets/news/news_3.jpg",
                        Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua...",
                        Order = new DateTime(2020,03,03),
                        ExternalUrl = "/News/ProjectDetail"
                    },
                    new Article
                    {
                        Title = "4 An Tín Ký Kết Hợp Tác Cùng Ủy Ban Thương Hiệu Xuất Sắc Châu Á Thái Bình Dương Và Vifolac",
                        ImageDefault = "/Content/resources/assets/news/news_4.jpg",
                        Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua...",
                        Order = new DateTime(2020,03,05),
                        ExternalUrl = "/News/ProjectDetail"
                    },
                    new Article
                    {
                        Title = "5 An Tín Ký Kết Hợp Tác Cùng Ủy Ban Thương Hiệu Xuất Sắc Châu Á Thái Bình Dương Và Vifolac",
                        ImageDefault = "/Content/resources/assets/news/news_5.jpg",
                        Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua...",
                        Order = new DateTime(2020,03,07),
                        ExternalUrl = "/News/ProjectDetail"
                    },
                    new Article
                    {
                        Title = "6 An Tín Ký Kết Hợp Tác Cùng Ủy Ban Thương Hiệu Xuất Sắc Châu Á Thái Bình Dương Và Vifolac",
                        ImageDefault = "/Content/resources/assets/news/news_6.jpg",
                        Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua...",
                        Order = new DateTime(2020,03,09),
                        ExternalUrl = "/News/ProjectDetail"
                    },
                }
            });
        }

        public ActionResult ProjectDetail()
        {
            return View(new NewsDetailViewModel());
        }
    }
}