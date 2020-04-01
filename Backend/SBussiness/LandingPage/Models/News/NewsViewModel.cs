using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MainProject.Core;
using MainProject.Framework.Helpers;
using MainProject.Framework.Models;

namespace MainProject.SBussiness.LandingPage.Models.News
{
	public class NewsViewModel
	{
		public string Category { get; set; } = ResourceHelper.ReadFile("/App_Data/Files/News_Category.txt");

		public Introduction NewsCategoryTitle { get; set; } = new Introduction
		{
			Title = "Tin tức - sự kiện"
		};

		public List<Article> NewsItems { get; set; } = new List<Article>
		{
			new Article
			{
				Title = "1 An Tín Ký Kết Hợp Tác Cùng Ủy Ban Thương Hiệu Xuất Sắc Châu Á Thái Bình Dương Và Vifolac",
				ImageDefault = "/Content/resources/assets/news/news_1.jpg",
				Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua...",
				Order = new DateTime(2020,02,29),
				ExternalUrl = "/News/NewsDetail"
			},
			new Article
			{
				Title = "2 An Tín Ký Kết Hợp Tác Cùng Ủy Ban Thương Hiệu Xuất Sắc Châu Á Thái Bình Dương Và Vifolac",
				ImageDefault = "/Content/resources/assets/news/news_2.jpg",
				Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua...",
				Order = new DateTime(2020,03,01),
				ExternalUrl = "/News/NewsDetail"
			},
			new Article
			{
				Title = "3 An Tín Ký Kết Hợp Tác Cùng Ủy Ban Thương Hiệu Xuất Sắc Châu Á Thái Bình Dương Và Vifolac",
				ImageDefault = "/Content/resources/assets/news/news_3.jpg",
				Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua...",
				Order = new DateTime(2020,03,03),
				ExternalUrl = "/News/NewsDetail"
			},
			new Article
			{
				Title = "4 An Tín Ký Kết Hợp Tác Cùng Ủy Ban Thương Hiệu Xuất Sắc Châu Á Thái Bình Dương Và Vifolac",
				ImageDefault = "/Content/resources/assets/news/news_4.jpg",
				Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua...",
				Order = new DateTime(2020,03,05),
				ExternalUrl = "/News/NewsDetail"
			},
			new Article
			{
				Title = "5 An Tín Ký Kết Hợp Tác Cùng Ủy Ban Thương Hiệu Xuất Sắc Châu Á Thái Bình Dương Và Vifolac",
				ImageDefault = "/Content/resources/assets/news/news_5.jpg",
				Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua...",
				Order = new DateTime(2020,03,07),
				ExternalUrl = "/News/NewsDetail"
			},
			new Article
			{
				Title = "6 An Tín Ký Kết Hợp Tác Cùng Ủy Ban Thương Hiệu Xuất Sắc Châu Á Thái Bình Dương Và Vifolac",
				ImageDefault = "/Content/resources/assets/news/news_6.jpg",
				Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua...",
				Order = new DateTime(2020,03,09),
				ExternalUrl = "/News/NewsDetail"
			},
		};

		public List<Article> HotNewsItems { get; set; } = new List<Article>
		{
			new Article
			{
				Title = "1 An Tín Ký Kết Hợp Tác Cùng Ủy Ban Thương Hiệu Xuất Sắc Châu Á Thái Bình Dương Và Vifolac",
				ImageDefault = "/Content/resources/assets/news/news_1.jpg",
				//Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua...",
				//Order = new DateTime(2020,02,29),
				ExternalUrl = "/News/NewsDetail"
			},
			new Article
			{
				Title = "2 An Tín Ký Kết Hợp Tác Cùng Ủy Ban Thương Hiệu Xuất Sắc Châu Á Thái Bình Dương Và Vifolac",
				ImageDefault = "/Content/resources/assets/news/news_2.jpg",
				//Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua...",
				//Order = new DateTime(2020,02,29),
				ExternalUrl = "/News/NewsDetail"
			},
			new Article
			{
				Title = "3 An Tín Ký Kết Hợp Tác Cùng Ủy Ban Thương Hiệu Xuất Sắc Châu Á Thái Bình Dương Và Vifolac",
				ImageDefault = "/Content/resources/assets/news/news_3.jpg",
				//Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua...",
				//Order = new DateTime(2020,02,29),
				ExternalUrl = "/News/NewsDetail"
			},
			new Article
			{
				Title = "4 An Tín Ký Kết Hợp Tác Cùng Ủy Ban Thương Hiệu Xuất Sắc Châu Á Thái Bình Dương Và Vifolac",
				ImageDefault = "/Content/resources/assets/news/news_4.jpg",
				//Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua...",
				//Order = new DateTime(2020,02,29),
				ExternalUrl = "/News/NewsDetail"
			},
			new Article
			{
				Title = "5 An Tín Ký Kết Hợp Tác Cùng Ủy Ban Thương Hiệu Xuất Sắc Châu Á Thái Bình Dương Và Vifolac",
				ImageDefault = "/Content/resources/assets/news/news_5.jpg",
				//Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua...",
				//Order = new DateTime(2020,02,29),
				ExternalUrl = "/News/NewsDetail"
			},
		};

		public PagingModel Pagingation { get; set; } = new PagingModel(100, 6, 2, "href=''");
	}
}