using MainProject.Core;
using MainProject.Framework.Helpers;
using MainProject.SBussiness.LandingPage.Models.About;
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
                Category = new Core.NewCategory
                {
                    Content = ResourceHelper.ReadFile("/App_Data/Files/About_AnTin.txt")
                }
            });
        }

        public ActionResult ShowMenu()
        {
            return PartialView("_Menu", ResourceHelper.ReadFile("/App_Data/Files/About_Menu.txt"));
        }

        public ActionResult AboutMessage()
        {
            return View("Message", new AboutViewModel());
        }

        public ActionResult AboutBoardOfExecutive()
        {
            return View("BoardOfExecutive", new AboutViewModel());
        }

        public ActionResult AboutOrganizationChart()
        {
            return View("OrganizationChart", new AboutViewModel());
        }

        public ActionResult AboutDepartment()
        {
            return View("Department", new AboutViewModel()
            {
                Category = new Core.NewCategory
                {
                    Images = JsonHelper.Serialize(new List<NewImage>
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
                }
            });
        }

        public ActionResult AboutCustomer()
        {
            return View("Customer", new AboutViewModel());
        }

        public ActionResult AboutShareHolder()
        {
            return View("ShareHolder", new AboutViewModel());
        }
    }
}