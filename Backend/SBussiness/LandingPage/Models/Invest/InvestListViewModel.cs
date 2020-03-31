using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MainProject.Core;

namespace MainProject.SBussiness.LandingPage.Models.Invest
{
	public class InvestListViewModel
	{
		public List<Article> InvestItems { get; set; } = new List<Article>
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
		};
	}
}