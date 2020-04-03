using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MainProject.Core;
using MainProject.Framework.Helpers;

namespace MainProject.SBussiness.LandingPage.Models.News
{
	public class AboutViewModel
	{
		public NewCategory Category { get; set; }

		public Introduction Section1 { get; set; }

		public Introduction Section2 { get; set; }
	}
}