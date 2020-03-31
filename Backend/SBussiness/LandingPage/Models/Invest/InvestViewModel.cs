using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MainProject.Core;
using MainProject.Framework.Helpers;

namespace MainProject.SBussiness.LandingPage.Models.Invest
{
	public class InvestViewModel
	{
		public List<Category> Categories { get; set; } = new List<Category>
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
		};
	}
}