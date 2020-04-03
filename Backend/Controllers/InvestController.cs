using MainProject.Core;
using MainProject.SBussiness.LandingPage.Models.News;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MainProject.Controllers
{
	public class InvestController : Controller
	{
		// GET: Invest
		public ActionResult Index()
		{
			return View(new NewsViewModel() { 
				Categories = new List<Category>
				{
					new Category
					{
						Order = 1,
						Title= "Bất động sản",
						ImageDefault = "/Content/resources/assets/invest/invest_1.jpg",
						ExternalUrl = "/Invest/InvestList",
						Description= "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt"
					},
					new Category
					{
						Order = 2,
						Title= "Bất động sản",
						ImageDefault = "/Content/resources/assets/invest/invest_1.jpg",
						ExternalUrl = "/Invest/InvestList",
						Description= "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt"
					},
					new Category
					{
						Order = 3,
						Title= "Bất động sản",
						ImageDefault = "/Content/resources/assets/invest/invest_1.jpg",
						ExternalUrl = "/Invest/InvestList",
						Description= "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt"
					},
					new Category
					{
						Order = 4,
						Title= "Bất động sản",
						ImageDefault = "/Content/resources/assets/invest/invest_1.jpg",
						ExternalUrl = "/Invest/InvestList",
						Description= "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt"
					}
				},
				Articles = null,
			});
		}
		public ActionResult InvestList()
		{
			return View("_List", new NewsViewModel() { 
				Categories = null,
				Articles = new List<Article>
				{
					new Article{
						ExternalUrl = "/Invest/InvestDetail",
						ImageDefault = "/Content/resources/assets/invest/invest_item_1.jpg",
						Title = "1 TGĐ An Tín Group: “ Dự án bất động sản An Tín Group ”",
						Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, Lorem ipsum dolor sit amet, and mad consectetur elit sed do eiusmod tempor incididunt ut labore et dolore magna..."
					},
					new Article{
						ExternalUrl = "/Invest/InvestDetail",
						ImageDefault = "/Content/resources/assets/invest/invest_item_2.jpg",
						Title = "2 TGĐ An Tín Group: “ Dự án bất động sản An Tín Group ”",
						Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, Lorem ipsum dolor sit amet, and mad consectetur elit sed do eiusmod tempor incididunt ut labore et dolore magna..."
					},
					new Article{
						ExternalUrl = "/Invest/InvestDetail",
						ImageDefault = "/Content/resources/assets/invest/invest_item_3.jpg",
						Title = "3 TGĐ An Tín Group: “ Dự án bất động sản An Tín Group ”",
						Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, Lorem ipsum dolor sit amet, and mad consectetur elit sed do eiusmod tempor incididunt ut labore et dolore magna..."
					},
					new Article{
						ExternalUrl = "/Invest/InvestDetail",
						ImageDefault = "/Content/resources/assets/invest/invest_item_4.jpg",
						Title = "4 TGĐ An Tín Group: “ Dự án bất động sản An Tín Group ”",
						Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, Lorem ipsum dolor sit amet, and mad consectetur elit sed do eiusmod tempor incididunt ut labore et dolore magna..."
					},
					new Article{
						ExternalUrl = "/Invest/InvestDetail",
						ImageDefault = "/Content/resources/assets/invest/invest_item_5.jpg",
						Title = "5 TGĐ An Tín Group: “ Dự án bất động sản An Tín Group ”",
						Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, Lorem ipsum dolor sit amet, and mad consectetur elit sed do eiusmod tempor incididunt ut labore et dolore magna..."
					}
				}
			});
		}
		public ActionResult InvestDetail()
		{
			return View("_Detail", new NewsDetailViewModel());
		}
	}
}