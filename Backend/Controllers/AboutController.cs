using MainProject.Core;
using MainProject.Framework.Helpers;
using MainProject.SBussiness.LandingPage.Models.News;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MainProject.Controllers
{
	public class AboutController : Controller
	{
		// GET: About
		public ActionResult Index()
		{
			return View(new AboutViewModel()
			{
				Category = new NewCategory
				{
					Content = ResourceHelper.ReadFile("/App_Data/Files/About_AnTin.txt")
				}
			});
		}

		public ActionResult ShowMenu()
		{
			return PartialView("_Menu", ResourceHelper.ReadFile("/App_Data/Files/About_Menu.txt"));
		}

		public ActionResult Message()
		{
			return View("Index", new AboutViewModel()
			{
				Category = new NewCategory
				{
					Content = ResourceHelper.ReadFile("/App_Data/Files/About_Message.txt")
				}
			});
		}

		public ActionResult BoardOfExecutive()
		{
			return View("BoardOfExecutive", new AboutBoardOfExecutiveViewModel()
			{
				Category = new NewCategory
				{
					Content = ResourceHelper.ReadFile("/App_Data/Files/About_BoardOfExecutive.txt"),
					Title = "<h2 class=\"main - title tagline\">TS Nguyễn Đức Thọ</h2><p>Chủ tịch HĐQT - TGĐ</p>",
					ImageDefault = "/Content/resources/assets/about/about_staff_1.png"
				},
				BoardOfExecutive1 = new Introduction
				{
					Title = "Thành viên hội đồng quản trị",
					Content = JsonHelper.Serialize(new List<Image>
					{
						new Image
						{
							Name = "<h4>1 Mr . Hoang Viet Hung</h4><p>Phó chủ tịch HĐQT</p>",
							ImageDefault = "/Content/resources/assets/about/about_staff_2.jpg"
						},
						new Image
						{
							Name = "<h4>2 Mr . Hoang Viet Hung</h4><p>Phó chủ tịch HĐQT</p>",
							ImageDefault = "/Content/resources/assets/about/about_staff_2.jpg"
						},
						new Image
						{
							Name = "<h4>3 Mr . Hoang Viet Hung</h4><p>Phó chủ tịch HĐQT</p>",
							ImageDefault = "/Content/resources/assets/about/about_staff_2.jpg"
						},
						new Image
						{
							Name = "<h4>4 Mr . Hoang Viet Hung</h4><p>Phó chủ tịch HĐQT</p>",
							ImageDefault = "/Content/resources/assets/about/about_staff_2.jpg"
						},
						new Image
						{
							Name = "<h4>5 Mr . Hoang Viet Hung</h4><p>Phó chủ tịch HĐQT</p>",
							ImageDefault = "/Content/resources/assets/about/about_staff_2.jpg"
						}
					})
				},
				BoardOfExecutive2 = new Introduction
				{
					Title = "Ban tổng giám đốc",
					Content = JsonHelper.Serialize(new List<Image>
					{
						new Image
						{
							Name = "<h4>1 Mr . Hoang Viet Hung</h4><p>Phó chủ tịch HĐQT</p>",
							ImageDefault = "/Content/resources/assets/about/about_staff_2.jpg"
						},
						new Image
						{
							Name = "<h4>2 Mr . Hoang Viet Hung</h4><p>Phó chủ tịch HĐQT</p>",
							ImageDefault = "/Content/resources/assets/about/about_staff_2.jpg"
						},
						new Image
						{
							Name = "<h4>3 Mr . Hoang Viet Hung</h4><p>Phó chủ tịch HĐQT</p>",
							ImageDefault = "/Content/resources/assets/about/about_staff_2.jpg"
						},
						new Image
						{
							Name = "<h4>4 Mr . Hoang Viet Hung</h4><p>Phó chủ tịch HĐQT</p>",
							ImageDefault = "/Content/resources/assets/about/about_staff_2.jpg"
						},
						new Image
						{
							Name = "<h4>5 Mr . Hoang Viet Hung</h4><p>Phó chủ tịch HĐQT</p>",
							ImageDefault = "/Content/resources/assets/about/about_staff_2.jpg"
						}
					})
				},
			});
		}

		public ActionResult OrganizationChart()
		{
			{
				return View("Index", new AboutViewModel()
				{
					Category = new NewCategory
					{
						Content = ResourceHelper.ReadFile("/App_Data/Files/About_Chart.txt")
					}
				});
			}
		}

		public ActionResult Member()
		{
			return View("Member", new AboutViewModel()
			{
				Category = new NewCategory
				{
					Images = JsonHelper.Serialize(new List<NewImage>
					{
						new NewImage
						{
							Name = "1 công ty cổ phần du lịch an tín travel",
							ImageDefault = "/Content/resources/assets/about/about_member_1.jpg",
							Link = "/#"
						},
						new NewImage
						{
							Name = "2 công ty cổ phần du lịch an tín travel",
							ImageDefault= "/Content/resources/assets/about/about_member_2.jpg",
							Link = "/#"
						},
						new NewImage
						{
							Name = "3 công ty cổ phần du lịch an tín travel",
							ImageDefault= "/Content/resources/assets/about/about_member_3.jpg",
							Link = "/#"
						},
						new NewImage
						{
							Name = "4 công ty cổ phần du lịch an tín travel",
							ImageDefault= "/Content/resources/assets/about/about_member_4.jpg",
							Link = "/#"
						},
						new NewImage
						{
							Name = "5 công ty cổ phần du lịch an tín travel",
							ImageDefault= "/Content/resources/assets/about/about_member_5.jpg",
							Link = "/#"
						},
						new NewImage
						{
							Name = "6 công ty cổ phần du lịch an tín travel",
							ImageDefault= "/Content/resources/assets/about/about_member_6.jpg",
							Link = "/#"
						},
					})
				}
			});
		}

		public ActionResult Customer()
		{
			return View("Customer", new AboutViewModel()
			{
				Category = new NewCategory
				{
					Content = JsonHelper.Serialize(new List<NewImage>
					{
						new NewImage
						{
							Link = "#",
							ImageDefault = "/Content/resources/assets/about/partners/cocacola.png"
						},
						new NewImage
						{
							Link = "#",
							ImageDefault = "/Content/resources/assets/about/partners/namesonholding.png"
						},
						new NewImage
						{
							Link = "#",
							ImageDefault = "/Content/resources/assets/about/partners/novaland.png"
						},
						new NewImage
						{
							Link = "#",
							ImageDefault = "/Content/resources/assets/about/partners/pvinvest.png"
						},
						new NewImage
						{
							Link = "#",
							ImageDefault = "/Content/resources/assets/about/partners/swancity.png"
						},
						new NewImage
						{
							Link = "#",
							ImageDefault = "/Content/resources/assets/about/partners/tanhoangminh.png"
						},
						new NewImage
						{
							Link = "#",
							ImageDefault = "/Content/resources/assets/about/partners/vinamilk.png"
						},
					})
				}
			});
		}

		public ActionResult ShareHolder()
		{
			return View("Customer", new AboutViewModel()
			{
				Category = new NewCategory
				{
					Content = JsonHelper.Serialize(new List<NewImage>
					{
						new NewImage
						{
							Link = "#",
							ImageDefault = "/Content/resources/assets/about/partners/pvinvest.png"
						},
						new NewImage
						{
							Link = "#",
							ImageDefault = "/Content/resources/assets/about/partners/swancity.png"
						},
						new NewImage
						{
							Link = "#",
							ImageDefault = "/Content/resources/assets/about/partners/tanhoangminh.png"
						},
						new NewImage
						{
							Link = "#",
							ImageDefault = "/Content/resources/assets/about/partners/vinamilk.png"
						},
						new NewImage
						{
							Link = "#",
							ImageDefault = "/Content/resources/assets/about/partners/cocacola.png"
						},
						new NewImage
						{
							Link = "#",
							ImageDefault = "/Content/resources/assets/about/partners/namesonholding.png"
						},
						new NewImage
						{
							Link = "#",
							ImageDefault = "/Content/resources/assets/about/partners/novaland.png"
						},
					})
				}
			});
		}
	}
}