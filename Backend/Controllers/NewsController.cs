using MainProject.SBussiness.LandingPage.Models.News;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
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
            return View(new NewsDetailViewModel() { IsNews = true });
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
            return View("Detail", new NewsDetailViewModel());
        }

        public ActionResult Invest()
        {
            return View(new NewsViewModel()
            {
                Category = new Category
                {
                    Parent = new Category
                    {
                        IsSystem = true
                    }
                },
                Categories = new List<Category>
                {
                    new Category
                    {
                        Order = 1,
                        Title= "Bất động sản",
                        ImageDefault = "/Content/resources/assets/invest/invest_1.jpg",
                        ExternalUrl = "/News/InvestList",
                        Description= "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt"
                    },
                    new Category
                    {
                        Order = 2,
                        Title= "Bất động sản",
                        ImageDefault = "/Content/resources/assets/invest/invest_1.jpg",
                        ExternalUrl = "/News/InvestList",
                        Description= "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt"
                    },
                    new Category
                    {
                        Order = 3,
                        Title= "Bất động sản",
                        ImageDefault = "/Content/resources/assets/invest/invest_1.jpg",
                        ExternalUrl = "/News/InvestList",
                        Description= "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt"
                    },
                    new Category
                    {
                        Order = 4,
                        Title= "Bất động sản",
                        ImageDefault = "/Content/resources/assets/invest/invest_1.jpg",
                        ExternalUrl = "/News/InvestList",
                        Description= "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt"
                    }
                },
                Articles = null,
            });
        }

        public ActionResult InvestList()
        {
            return View("Invest", new NewsViewModel()
            {
                Category = new Category
                {
                    Parent = new Category
                    {

                    }
                },
                Categories = null,
                Articles = new List<Article>
                {
                    new Article{
                        ExternalUrl = "/News/InvestDetail",
                        ImageDefault = "/Content/resources/assets/invest/invest_item_1.jpg",
                        Title = "1 TGĐ An Tín Group: “ Dự án bất động sản An Tín Group ”",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, Lorem ipsum dolor sit amet, and mad consectetur elit sed do eiusmod tempor incididunt ut labore et dolore magna..."
                    },
                    new Article{
                        ExternalUrl = "/News/InvestDetail",
                        ImageDefault = "/Content/resources/assets/invest/invest_item_2.jpg",
                        Title = "2 TGĐ An Tín Group: “ Dự án bất động sản An Tín Group ”",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, Lorem ipsum dolor sit amet, and mad consectetur elit sed do eiusmod tempor incididunt ut labore et dolore magna..."
                    },
                    new Article{
                        ExternalUrl = "/News/InvestDetail",
                        ImageDefault = "/Content/resources/assets/invest/invest_item_3.jpg",
                        Title = "3 TGĐ An Tín Group: “ Dự án bất động sản An Tín Group ”",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, Lorem ipsum dolor sit amet, and mad consectetur elit sed do eiusmod tempor incididunt ut labore et dolore magna..."
                    },
                    new Article{
                        ExternalUrl = "/News/InvestDetail",
                        ImageDefault = "/Content/resources/assets/invest/invest_item_4.jpg",
                        Title = "4 TGĐ An Tín Group: “ Dự án bất động sản An Tín Group ”",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, Lorem ipsum dolor sit amet, and mad consectetur elit sed do eiusmod tempor incididunt ut labore et dolore magna..."
                    },
                    new Article{
                        ExternalUrl = "/News/InvestDetail",
                        ImageDefault = "/Content/resources/assets/invest/invest_item_5.jpg",
                        Title = "5 TGĐ An Tín Group: “ Dự án bất động sản An Tín Group ”",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, Lorem ipsum dolor sit amet, and mad consectetur elit sed do eiusmod tempor incididunt ut labore et dolore magna..."
                    }
                }
            });
        }

        public ActionResult InvestDetail()
        {
            return View("/Views/News/Detail.cshtml", new NewsDetailViewModel() { Categories = null });
        }
    }
}