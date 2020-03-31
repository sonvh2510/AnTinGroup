using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MainProject.Core;
using MainProject.Framework.Helpers;

namespace MainProject.SBussiness.LandingPage.Models.About
{
	public class AboutViewModel
	{
		public string AboutMenu = ResourceHelper.ReadFile("/App_Data/Files/About_Menu.txt");

		public Introduction AboutAnTin { get; set; } = new Introduction
		{
			Content = ResourceHelper.ReadFile("/App_Data/Files/About_AnTin.txt")
		};

		public Introduction AboutMessage { get; set; } = new Introduction
		{
			Content = ResourceHelper.ReadFile("/App_Data/Files/About_Message.txt")
		};

		public Introduction AboutOrganizationChart { get; set; } = new Introduction
		{
			Content = ResourceHelper.ReadFile("/App_Data/Files/About_Chart.txt"),
		};

		public NewCategory AboutDepartment { get; set; } = new NewCategory
		{
			Images = JsonHelper.Serialize(new List<Image>
			{
				new NewImage
				{
					Name = "1 công ty cổ phần du lịch an tín travel",
					ImageDefault = "/Content/resources/assets/about/about_member_1.jpg",
					ExternalUrl = "#"
				},
				new NewImage
				{
					Name = "2 công ty cổ phần du lịch an tín travel",
					ImageDefault= "/Content/resources/assets/about/about_member_2.jpg",
					ExternalUrl = "#"
				},
				new NewImage
				{
					Name = "3 công ty cổ phần du lịch an tín travel",
					ImageDefault= "/Content/resources/assets/about/about_member_3.jpg",
					ExternalUrl = "#"
				},
				new NewImage
				{
					Name = "4 công ty cổ phần du lịch an tín travel",
					ImageDefault= "/Content/resources/assets/about/about_member_4.jpg",
					ExternalUrl = "#"
				},
				new NewImage
				{
					Name = "5 công ty cổ phần du lịch an tín travel",
					ImageDefault= "/Content/resources/assets/about/about_member_5.jpg",
					ExternalUrl = "#"
				},
				new NewImage
				{
					Name = "6 công ty cổ phần du lịch an tín travel",
					ImageDefault= "/Content/resources/assets/about/about_member_6.jpg",
					ExternalUrl = "#"
				},
			})
		};

		public Introduction AboutBoardOfExecutive { get; set; } = new Introduction
		{
			Content = "<p>…\"Lorem ipsum dolor sit amet sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam It has survived not only five centuries, but also the leap into.\"</p>",
			Title = "<h2 class=\"main - title tagline\">TS Nguyễn Đức Thọ</h2><p>Chủ tịch HĐQT - TGĐ</p>",
			Image = "/Content/resources/assets/about/about_staff_1.png"
		};

		public Introduction AboutBoardOfExecutiveBlock2 { get; set; } = new Introduction
		{
			Title = "THÀNH VIÊN HỘI ĐỒNG QUẢN TRỊ",
			Content = JsonHelper.Serialize(new List<Introduction>
			{
				new Introduction
				{
					Title = "<h4>1 Mr . Hoang Viet Hung</h4><p>Phó chủ tịch HĐQT</p>",
					Image = "/Content/resources/assets/about/about_staff_2.jpg"
				},
				new Introduction
				{
					Title = "<h4>2 Mr . Hoang Viet Hung</h4><p>Phó chủ tịch HĐQT</p>",
					Image = "/Content/resources/assets/about/about_staff_2.jpg"
				},
				new Introduction
				{
					Title = "<h4>3 Mr . Hoang Viet Hung</h4><p>Phó chủ tịch HĐQT</p>",
					Image = "/Content/resources/assets/about/about_staff_2.jpg"
				},
				new Introduction
				{
					Title = "<h4>4 Mr . Hoang Viet Hung</h4><p>Phó chủ tịch HĐQT</p>",
					Image = "/Content/resources/assets/about/about_staff_2.jpg"
				},
				new Introduction
				{
					Title = "<h4>5 Mr . Hoang Viet Hung</h4><p>Phó chủ tịch HĐQT</p>",
					Image = "/Content/resources/assets/about/about_staff_2.jpg"
				}
			})
		};

		public Introduction AboutBoardOfExecutiveBlock3 { get; set; } = new Introduction
		{
			Title = "BAN TỔNG GIÁM ĐỐC",
			Content = JsonHelper.Serialize(new List<Introduction>
			{
				new Introduction
				{
					Title = "<h4>1 Mr . Hoang Viet Hung</h4><p>Phó chủ tịch HĐQT</p>",
					Image = "/Content/resources/assets/about/about_staff_2.jpg"
				},
				new Introduction
				{
					Title = "<h4>2 Mr . Hoang Viet Hung</h4><p>Phó chủ tịch HĐQT</p>",
					Image = "/Content/resources/assets/about/about_staff_2.jpg"
				},
				new Introduction
				{
					Title = "<h4>3 Mr . Hoang Viet Hung</h4><p>Phó chủ tịch HĐQT</p>",
					Image = "/Content/resources/assets/about/about_staff_2.jpg"
				},
				new Introduction
				{
					Title = "<h4>4 Mr . Hoang Viet Hung</h4><p>Phó chủ tịch HĐQT</p>",
					Image = "/Content/resources/assets/about/about_staff_2.jpg"
				},
				new Introduction
				{
					Title = "<h4>5 Mr . Hoang Viet Hung</h4><p>Phó chủ tịch HĐQT</p>",
					Image = "/Content/resources/assets/about/about_staff_2.jpg"
				}
			})
		};

		public List<NewImage> Customers { get; set; } = new List<NewImage>
		{
			new NewImage
			{
				ExternalUrl = "#",
				ImageDefault = "/Content/resources/assets/about/partners/cocacola.png"
			},
			new NewImage
			{
				ExternalUrl = "#",
				ImageDefault = "/Content/resources/assets/about/partners/namesonholding.png"
			},
			new NewImage
			{
				ExternalUrl = "#",
				ImageDefault = "/Content/resources/assets/about/partners/novaland.png"
			},
			new NewImage
			{
				ExternalUrl = "#",
				ImageDefault = "/Content/resources/assets/about/partners/pvinvest.png"
			},
			new NewImage
			{
				ExternalUrl = "#",
				ImageDefault = "/Content/resources/assets/about/partners/swancity.png"
			},
			new NewImage
			{
				ExternalUrl = "#",
				ImageDefault = "/Content/resources/assets/about/partners/tanhoangminh.png"
			},
			new NewImage
			{
				ExternalUrl = "#",
				ImageDefault = "/Content/resources/assets/about/partners/vinamilk.png"
			},
		};

		public List<NewImage> ShareHolders { get; set; } = new List<NewImage>
		{
			new NewImage
			{
				ExternalUrl = "#",
				ImageDefault = "/Content/resources/assets/about/partners/cocacola.png"
			},
			new NewImage
			{
				ExternalUrl = "#",
				ImageDefault = "/Content/resources/assets/about/partners/namesonholding.png"
			},
			new NewImage
			{
				ExternalUrl = "#",
				ImageDefault = "/Content/resources/assets/about/partners/novaland.png"
			},
			new NewImage
			{
				ExternalUrl = "#",
				ImageDefault = "/Content/resources/assets/about/partners/pvinvest.png"
			},
			new NewImage
			{
				ExternalUrl = "#",
				ImageDefault = "/Content/resources/assets/about/partners/swancity.png"
			},
			new NewImage
			{
				ExternalUrl = "#",
				ImageDefault = "/Content/resources/assets/about/partners/tanhoangminh.png"
			},
			new NewImage
			{
				ExternalUrl = "#",
				ImageDefault = "/Content/resources/assets/about/partners/vinamilk.png"
			},
		};
	}
}