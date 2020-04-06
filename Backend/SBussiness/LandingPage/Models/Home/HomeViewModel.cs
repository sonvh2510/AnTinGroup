﻿using MainProject.Core;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MainProject.Framework.Helpers;

namespace MainProject.SBussiness.LandingPage.Models.Home
{

    public class HeaderViewModel
    {
        public List<MenuItem> TopMenus { get; set; } = new List<MenuItem>
        {
            new MenuItem
            {
                Title = "Tuyển Dụng",
            },
            new MenuItem
            {
                Title = "Liên Hệ",
            },
        };

        public string Menu { get; set; } = ResourceHelper.ReadFile("/App_Data/Files/Header_Menu.txt");

        public string MainMenu { get; set; }

        public List<Banner> Banners { get; set; } = new List<Banner>
        {
            new Banner
            {
                Name = "Banner1",
                Path = "http://web4gsolutions.com/Content/layout/resources/images/logo.png"
            },
            new Banner
            {
                Name = "Banner1",
                Path = "http://web4gsolutions.com/Content/layout/resources/images/logo.png"
            }
        };
    }

    public class FooterViewModel
    {
        public string Menu { get; set; } = ResourceHelper.ReadFile("/App_Data/Files/FooterMenu.txt");

        public Branch Branch { get; set; } = new Branch
        {
            Address = "Tòa nhà H3, 384 Hoàng Diệu, Quận 4, TP.Hồ Chí Minh",
            Email = "info@antingroup.vn",
            Phone = "028. 38266766",
            Fax = "028. 38266766"
        };
    }

    public class SubscribeModel
    {
        [Required]
        public string Email { get; set; }
    }

    public class HomeViewModel
    {
        public Section Section1 { get; set; } = new Section
        {
            Content = "<p><b>Phụng sự khách hàng, phụng sự Tổ quốc </b>và gắn kết bạn bè thế giới, góp phần kiến tạo cộng đồng thịnh vượng, nâng cao các giá trị văn hóa Việt Nam, giao lưu với các nền văn hóa trên thế giới</p>",
            Title = "<h3>TS Nguyễn Đức Thọ</h3><p>Chủ tịch HĐQT - TGĐ</p>",
        };

        public List<Category> Invests { get; set; } = new List<Category>
        {
            new Category
                {
                    Order = 1,
                    Title = "Bất động sản",
                    ExternalUrl = "/Invest/InvestList",
                    ImageDefault = "/Content/resources/assets/invest/invest_index_1.jpg"
                },
                new Category
                {
                    Order = 2,
                    Title = "Giáo dục",
                    ExternalUrl = "/Invest/InvestList",
                    ImageDefault = "/Content/resources/assets/invest/invest_index_2.jpg"
                },
                new Category
                {
                    Order = 3,
                    Title = "hàng Không",
                    ExternalUrl = "/Invest/InvestList",
                    ImageDefault = "/Content/resources/assets/invest/invest_index_3.jpg"
                },
                new Category
                {
                    Order = 4,
                    Title = "Du lịch",
                    ExternalUrl = "/Invest/InvestList",
                    ImageDefault = "/Content/resources/assets/invest/invest_index_4.jpg"
                }
        };

        public List<Category> ProjectCategories { get; set; } = new List<Category>
        {
            new Category
            {
                Title = "Bất động sản",
                ExternalUrl = "/ProjectList",
                Id = 1,
            },
            new Category
            {
                Title = "Giáo dục",
                ExternalUrl = "/ProjectList",
                Id = 2,
            },
            new Category
            {
                Title = "hàng Không",
                ExternalUrl = "/ProjectList",
                Id = 3,
            },
            new Category
            {
                Title = "Du lịch",
                ExternalUrl = "/ProjectList",
                Id = 4,
            },
            new Category
            {
                Title = "Đầu tư",
                ExternalUrl = "/ProjectList",
                Id = 5,
            },
            new Category
            {
                Title = "Công nghệ",
                ExternalUrl = "/ProjectList",
                Id = 6,
            }
        };

        public List<Article> Projects { get; set; } = new List<Article>
        {
            new Article
            {
                Title = "1 Khu Du lịch nghỉ dưỡng và biệt thự sinh thái FLC Cù Lao Xanh, Quy Nhơn, Bình Định",
                ExternalUrl = "/Project/ProjectDetail",
                ImageDefault = "/Content/resources/assets/project/index_project_1.jpg"
            },
            new Article
            {
                Title = "2 Khu Du lịch nghỉ dưỡng và biệt thự sinh thái FLC Cù Lao Xanh, Quy Nhơn, Bình Định",
                ExternalUrl = "/Project/ProjectDetail",
                ImageDefault = "/Content/resources/assets/project/index_project_2.jpg"
            },
            new Article
            {
                Title = "3 Khu Du lịch nghỉ dưỡng và biệt thự sinh thái FLC Cù Lao Xanh, Quy Nhơn, Bình Định",
                ExternalUrl = "/Project/ProjectDetail",
                ImageDefault = "/Content/resources/assets/project/index_project_3.jpg"
            },
            new Article
            {
                Title = "4 Khu Du lịch nghỉ dưỡng và biệt thự sinh thái FLC Cù Lao Xanh, Quy Nhơn, Bình Định",
                ExternalUrl = "/Project/ProjectDetail",
                ImageDefault = "/Content/resources/assets/project/index_project_1.jpg"
            },
            new Article
            {
                Title = "5 Khu Du lịch nghỉ dưỡng và biệt thự sinh thái FLC Cù Lao Xanh, Quy Nhơn, Bình Định",
                ExternalUrl = "/Project/ProjectDetail",
                ImageDefault = "/Content/resources/assets/project/index_project_2.jpg"
            },
            new Article
            {
                Title = "6 Khu Du lịch nghỉ dưỡng và biệt thự sinh thái FLC Cù Lao Xanh, Quy Nhơn, Bình Định",
                ExternalUrl = "/Project/ProjectDetail",
                ImageDefault = "/Content/resources/assets/project/index_project_3.jpg"
            }
        };

        public Section Section2 { get; set; } = new Section
        {
            Title = "Tuyên ngôn chiến lược",
            Content = JsonHelper.Serialize(new List<Image>
            {
                new Image
                {
                    Order = 0,
                    Name = "1 Mục tiêu 2020",
                    Alt = "Độ nhận biết đầu tiên: 60% trong (nhóm khách hàng mục tiêu)"
                },
                new Image
                {
                    Order = 1,
                    Name = "1 Mục tiêu 2020",
                    Alt = "Độ nhận biết đầu tiên: 60% trong (nhóm khách hàng mục tiêu)"
                },
                new Image
                {
                    Order = 2,
                    Name = "1 Mục tiêu 2020",
                    Alt = "Độ nhận biết đầu tiên: 60% trong (nhóm khách hàng mục tiêu)"
                },
                new Image
                {
                    Order = 3,
                    Name = "1 Mục tiêu 2020",
                    Alt = "Độ nhận biết đầu tiên: 60% trong (nhóm khách hàng mục tiêu)"
                },
                new Image
                {
                    Order = 4,
                    Name = "1 Mục tiêu 2020",
                    Alt = "Độ nhận biết đầu tiên: 60% trong (nhóm khách hàng mục tiêu)"
                }
            })
        };

        public List<Category> NewsCategories { get; set; } = new List<Category>
        {
            new Category
            {
                Title = "Tin An Tín Group",
                ExternalUrl = "/NewsList",
                Id = 1,
            },
            new Category
            {
                Title = "Thông tin báo chí",
                ExternalUrl = "/NewsList",
                Id = 2,
            },
            new Category
            {
                Title = "Thông tin hợp tác",
                ExternalUrl = "/NewsList",
                Id = 3,
            },
        };

        public List<Article> News { get; set; } = new List<Article>
        {
            new Article
            {
                Title = "1 An Tín Ký Kết Hợp Tác Cùng Ủy Ban Thương Hiệu Xuất Sắc Châu Á Thái Bình Dương Và Vifolac",
                ExternalUrl = "/News/NewsDetail",
                ImageDefault = "/Content/resources/assets/news/news_1.jpg",
            },
            new Article
            {
                Title = "2 An Tín Ký Kết Hợp Tác Cùng Ủy Ban Thương Hiệu Xuất Sắc Châu Á Thái Bình Dương Và Vifolac",
                ExternalUrl = "/News/NewsDetail",
                ImageDefault = "/Content/resources/assets/news/news_2.jpg",
            },
            new Article
            {
                Title = "3 An Tín Ký Kết Hợp Tác Cùng Ủy Ban Thương Hiệu Xuất Sắc Châu Á Thái Bình Dương Và Vifolac",
                ExternalUrl = "/News/NewsDetail",
                ImageDefault = "/Content/resources/assets/news/news_3.jpg",
            },
            new Article
            {
                Title = "4 An Tín Ký Kết Hợp Tác Cùng Ủy Ban Thương Hiệu Xuất Sắc Châu Á Thái Bình Dương Và Vifolac",
                ExternalUrl = "/News/NewsDetail",
                ImageDefault = "/Content/resources/assets/news/news_4.jpg",
            },
        };

        public Section Partner { get; set; } = new Section
        {
            Image = JsonHelper.Serialize(new List<NewImage>() {
                new NewImage
                {
                    Link = "#",
                    Path = "/Content/resources/assets/partner/partner_1.png"
                },
                new NewImage
                {
                    Link = "#",
                    Path = "/Content/resources/assets/partner/partner_2.png"
                },
                new NewImage
                {
                    Link = "#",
                    Path = "/Content/resources/assets/partner/partner_3.png"
                },
                new NewImage
                {
                    Link = "#",
                    Path = "/Content/resources/assets/partner/partner_4.png"
                },
                new NewImage
                {
                    Link = "#",
                    Path = "/Content/resources/assets/partner/partner_5.png"
                },
                new NewImage
                {
                    Link = "#",
                    Path = "/Content/resources/assets/partner/partner_6.png"
                }
            })
        };
    }
}