using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Web;
using System.Web.Mvc;
using MainProject.Core.Enums;
using MainProject.Framework.Models;

namespace MainProject.Framework.Helpers
{
	public static class ResourceHelper
	{
		public static string GetResource(this HtmlHelper helper, TempResourceKeyCollection resourceKey) => resourceKey.ToString();

		public static string GetResource(this HtmlHelper helper, ResourceKeyCollection resourceKey) => resourceKey.ToString();

		//public static string GetDay(this HtmlHelper helper, DateTime dateTime)
		//{
		//    var day = DateTime.Now.Subtract(dateTime);
		//    var daysOfYear = DateTime.IsLeapYear(DateTime.Now.Year) ? 366 : 365;

		//    if (day.TotalHours <= 24) // Same date
		//    {
		//        return string.Format("{0} {1}", day.TotalHours < 1 ? 1 : (int)day.TotalHours, GetResource(helper, TempTempResourceKeyCollection.Post_Hours)); // Show hours
		//    }
		//    else if (day.TotalDays <= DateTime.DaysInMonth(dateTime.Year, dateTime.Month)) // Same month
		//    {
		//        return string.Format("{0} {1}", (int)day.TotalDays, GetResource(helper, TempTempResourceKeyCollection.Post_Days)); // show days or 1 month
		//    }
		//    else if (day.TotalDays < daysOfYear) // Same year
		//    {
		//        return string.Format("{0} {1}", day.Days / (daysOfYear / 12), GetResource(helper, TempTempResourceKeyCollection.Post_Months)); // show months
		//    }

		//    return string.Format("{0} {1}", DateTime.Now.Year - dateTime.Year, GetResource(helper, TempTempResourceKeyCollection.Post_Years));
		//}

		#region Paging
		public static HtmlString RenderPaging(this HtmlHelper helper, PagingModel model, PagingStyleModel styleModel)
		{
			var strBuilder = new StringBuilder();
			if (model != null && model.HasPaging)
			{
				strBuilder.Append("<ul " + styleModel.DivContainerStyle + ">");

				// Check model has valid paging
				if (model.TotalPages > 1)
				{
					var distancePage = 1;
					if (model.CurrentPage == 1 || model.CurrentPage == model.TotalPages) distancePage = 2;

					// Binding dot
					var hasDot = false;
					// Check current page must larger than 1 and display button previous
					if (model.CurrentPage > 1)
					{
						strBuilder.Append("<li class=\"pagination__prev\"><a " + styleModel.LinkStyle + " " + BuildActionCode(model.ActionCode, model.CurrentPage - 1) + "><img class=\"svg\" src=\"/Content/resources/assets/icons/arrow_left_no_outline.svg\"/></a></li>");
					}
					// Get all page lower than current page
					for (var i = 1; i < model.CurrentPage; i++)
					{
						// Get 2 page lowest to current page
						if (i >= model.CurrentPage - distancePage)
						{
							strBuilder.Append("<li " + styleModel.ItemStyle + "><a " + styleModel.LinkStyle + " " + BuildActionCode(model.ActionCode, i) + ">" + i + "</a></li>");
						}
						// Check lower page must be lower than lowest page is 2
						else if (i <= 2)
						{
							strBuilder.Append("<li " + styleModel.ItemStyle + "><a " + styleModel.LinkStyle + " " + BuildActionCode(model.ActionCode, i) + ">" + i + "</a></li>");
						}
						else // These lower page has distance so far
						{
							if (!hasDot)
							{
								strBuilder.Append("<li class=\"pagination__dots\"><a " + styleModel.LinkStyle + ">...</span></li>");
								hasDot = true;
							}
						}
					}
					// Current active page
					strBuilder.Append("<li " + styleModel.CurrentItemStyle + "><a " + styleModel.LinkStyle + " href='javascript:void(0)'>" + model.CurrentPage + "</a></li>");

					hasDot = false;
					// Get all page larger than current page
					for (var i = (model.CurrentPage + 1); i <= model.TotalPages; i++)
					{
						// Get 2 page larger to current page
						if (i <= model.CurrentPage + distancePage)
						{
							strBuilder.Append("<li " + styleModel.ItemStyle + " ><a " + styleModel.LinkStyle + " " + BuildActionCode(model.ActionCode, i) + ">" + i + "</a></li>");
						}
						// Check larger page must be larger than largest page is 2
						else if (i > (model.TotalPages - 2))
						{
							strBuilder.Append("<li " + styleModel.ItemStyle + " ><a " + styleModel.LinkStyle + " " + BuildActionCode(model.ActionCode, i) + ">" + i + "</a></li>");
						}
						else // To many page from current page to largest page
						{
							if (!hasDot)
							{
								strBuilder.Append("<li class=\"pagination__dots\"><a " + styleModel.LinkStyle + ">...</span></li>");
								hasDot = true;
							}
						}
					}
					// Check current page must be lower than largest page to display next button
					if (model.CurrentPage < model.TotalPages)
					{
						strBuilder.Append("<li class=\"pagination__next\"><a " + styleModel.LinkStyle + " " + BuildActionCode(model.ActionCode, model.CurrentPage + 1) + "><img class=\"svg\" src=\"/Content/resources/assets/icons/arrow_right_no_outline.svg\"/></a></li>");
					}
				}
				strBuilder.Append("</ul>");
			}

			return new HtmlString(strBuilder.ToString());
		}

		private static string BuildActionCode(string strFormat, int pageIndex)
		{
			return string.Format(strFormat, pageIndex);
		}
		#endregion

		public static HtmlString GenerateBreadCrumb(this HtmlHelper helper, string seoStandardUrl)
		{
			// Bind breadcrumb
			string result = "";
			TextInfo myTI = new CultureInfo("en-US", false).TextInfo;
			while (!string.IsNullOrEmpty(seoStandardUrl))
			{
				string title = seoStandardUrl.Substring(seoStandardUrl.LastIndexOf("/") + 1);
				// Bind current url to breadcrumb
				if (string.IsNullOrEmpty(result))
				{
					result = string.Format("<li class=\"breadcrumb__item\"><a class=\"breadcrumb__link\" href='{0}'>{1}</a></li>", seoStandardUrl, myTI.ToTitleCase(title.ToLower()));
				}
				else
				{
					result = string.Format("<li class=\"breadcrumb__item\"><a class=\"breadcrumb__link\" href='{0}'>{1}</a></li>{2}", seoStandardUrl, myTI.ToTitleCase(title.ToLower()), result);
				}
				// Bind parent url to breadcrumb
				seoStandardUrl = seoStandardUrl.Substring(0, seoStandardUrl.LastIndexOf("/"));
			}

			return new HtmlString(string.Format("<ol class=\"breadcrumb__nav lst-n\"><li class=\"breadcrumb__item\"><a class=\"breadcrumb__link\" href='/'>{0}</a></li>{1}</ol>", "Home", result));
		}

		public static string ReadFile(string path) => File.ReadAllText(HttpContext.Current.Server.MapPath(path));
	}
}
