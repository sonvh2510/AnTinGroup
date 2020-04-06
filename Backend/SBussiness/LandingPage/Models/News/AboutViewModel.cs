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

		public Section Section1 { get; set; }

		public Section Section2 { get; set; }
	}
}