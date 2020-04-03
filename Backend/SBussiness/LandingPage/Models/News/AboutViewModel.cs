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

		public Introduction Section { get; set; }
	}

	public class AboutBoardOfExecutiveViewModel
	{
		public NewCategory Category { get; set; }
		public Introduction BoardOfExecutive1 { get; set; }
		public Introduction BoardOfExecutive2 { get; set; }
	}
}