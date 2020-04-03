using System;
using System.Collections.Generic;
using MainProject.Core;
using MainProject.Framework.Helpers;

namespace MainProject.SBussiness.LandingPage.Models.News
{
	public class NewsDetailViewModel
	{
		public Article Article { get; set; } = new Article
		{
			Title = "An Tín Ký Kết Hợp Tác Cùng Ủy Ban Thương Hiệu Xuất Sắc Châu Á Thái Bình Dương Và Vifolac",
			Order = new DateTime(2020, 02, 29),
			Body = ResourceHelper.ReadFile("/App_Data/Files/News_Detail.txt"),
			Category = new Category
			{
				Title = "Tin tức - sự kiện"
			}
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
	}
}