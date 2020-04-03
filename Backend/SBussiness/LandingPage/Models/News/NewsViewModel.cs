using System;
using System.Collections.Generic;
using MainProject.Core;
using MainProject.Framework.Models;

namespace MainProject.SBussiness.LandingPage.Models.News
{
	public class NewsViewModel
	{
		public Category Category { get; set; } = new Category
		{
			Title = "Tin tức - sự kiện"
		};

		public List<Category> Categories { get; set; } = new List<Category>
		{
			new Category
			{
				Title = "Tin An Tín Group"
			},
			new Category
			{
				Title = "Thông tin báo chí"
			},
			new Category
			{
				Title = "Thôn tin hợp tác"
			},
		};

		public List<Article> Articles { get; set; } = new List<Article>
		{
			new Article
			{
				Title = "1 An Tín Ký Kết Hợp Tác Cùng Ủy Ban Thương Hiệu Xuất Sắc Châu Á Thái Bình Dương Và Vifolac",
				ImageDefault = "/Content/resources/assets/news/news_1.jpg",
				Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua...",
				Order = new DateTime(2020,02,29),
				ExternalUrl = "/News/Detail"
			},
			new Article
			{
				Title = "2 An Tín Ký Kết Hợp Tác Cùng Ủy Ban Thương Hiệu Xuất Sắc Châu Á Thái Bình Dương Và Vifolac",
				ImageDefault = "/Content/resources/assets/news/news_2.jpg",
				Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua...",
				Order = new DateTime(2020,03,01),
				ExternalUrl = "/News/Detail"
			},
			new Article
			{
				Title = "3 An Tín Ký Kết Hợp Tác Cùng Ủy Ban Thương Hiệu Xuất Sắc Châu Á Thái Bình Dương Và Vifolac",
				ImageDefault = "/Content/resources/assets/news/news_3.jpg",
				Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua...",
				Order = new DateTime(2020,03,03),
				ExternalUrl = "/News/Detail"
			},
			new Article
			{
				Title = "4 An Tín Ký Kết Hợp Tác Cùng Ủy Ban Thương Hiệu Xuất Sắc Châu Á Thái Bình Dương Và Vifolac",
				ImageDefault = "/Content/resources/assets/news/news_4.jpg",
				Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua...",
				Order = new DateTime(2020,03,05),
				ExternalUrl = "/News/Detail"
			},
			new Article
			{
				Title = "5 An Tín Ký Kết Hợp Tác Cùng Ủy Ban Thương Hiệu Xuất Sắc Châu Á Thái Bình Dương Và Vifolac",
				ImageDefault = "/Content/resources/assets/news/news_5.jpg",
				Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua...",
				Order = new DateTime(2020,03,07),
				ExternalUrl = "/News/Detail"
			},
			new Article
			{
				Title = "6 An Tín Ký Kết Hợp Tác Cùng Ủy Ban Thương Hiệu Xuất Sắc Châu Á Thái Bình Dương Và Vifolac",
				ImageDefault = "/Content/resources/assets/news/news_6.jpg",
				Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua...",
				Order = new DateTime(2020,03,09),
				ExternalUrl = "/News/Detail"
			},
		};

		public PagingModel Pagingation { get; set; } = new PagingModel(100, 6, 2, "href=''");
	}
}