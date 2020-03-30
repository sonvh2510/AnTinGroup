using MainProject.Core;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MainProject.Framework.Helpers;

namespace MainProject.SBussiness.LandingPage.Models.Home
{
	public class HomeViewModel
	{
		public Category Category { get; set; } = new Category
		{

		};


		public Introduction Section1 { get; set; } = new Introduction
		{
			Content = "<div class='bi__sentences'><p class='fs-i'><b>Phụng sự khách hàng, phụng sự Tổ quốc</b> và gắn kết bạn bè thế giới, góp phần kiến tạo cộng đồng thịnh vượng, nâng cao các giá trị văn hóa Việt Nam, giao lưu với các nền văn hóa trên thế giới</p></div><div class='bi__author'><h3><span>TS Nguyễn Đức Thọ</span></h3><p><b>CHỦ TỊCH HĐQT - TGĐ</b></p></div>",
		};

		public Introduction Section2 { get; set; } = new Introduction
		{
			Image = JsonHelper.Serialize(new List<Image> {
				new Image {
					// Define Property is here
				},
			})
		};

		public List<Category> InvestmentFields { get; set; } = new List<Category>
		{

			new Category {
				Order= 1,
				ImageDefault= "/Content/resources/assets/invest/invest_index_1.jpg",
				Title= "Bất động sản",
				ExternalUrl = "/invest-danhsach.html"
			},
			new Category {
				Order= 2,
				ImageDefault= "/Content/resources/assets/invest/invest_index_2.jpg",
				Title= "Giáo dục",
				ExternalUrl = "/invest-danhsach.html"
			},
			new Category {
				Order= 3,
				ImageDefault= "/Content/resources/assets/invest/invest_index_3.jpg",
				Title= "Hàng không",
				ExternalUrl = "/invest-danhsach.html"
			},
			new Category {
				Order= 4,
				ImageDefault= "/Content/resources/assets/invest/invest_index_4.jpg",
				Title= "Du lịch",
				ExternalUrl = "/invest-danhsach.html"
			}
		};
	}

	public class HeaderViewModel
	{
		public string Menu { get; set; } = ResourceHelper.ReadFile("/App_Data/Files/HeaderMenu.txt");

		public string MainMenu { get; set; }

		public List<Banner> Banners { get; set; } = new List<Banner>
		{
			new Banner
			{
				Name = "Banner1",
				ResourcePath = "http://web4gsolutions.com/Content/layout/resources/images/logo.png"
			},
			new Banner
			{
				Name = "Banner1",
				ResourcePath = "http://web4gsolutions.com/Content/layout/resources/images/logo.png"
			}
		};
	}

	public class FooterViewModel
	{
		public string MainMenu { get; set; }
		public Branch Branch { get; set; } = new Branch
		{
			OfficeName = "Văn phòng chính",
			Address = "192/68 Nguyễn Oanh, ....",
			AddressMap = "iframe or some format text show on map"
		};
	}

	public class SubscribeModel
	{
		[Required]
		public string Email { get; set; }
	}
}