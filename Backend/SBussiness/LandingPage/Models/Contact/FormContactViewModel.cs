using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MainProject.SBussiness.LandingPage.Models.FormContactViewModel
{
	public class ContactFormManagement
	{
		[Required]
		public string Name { get; set; }
		[Required]
		public string Email { get; set; }
		[Required]
		public string Address { get; set; }
		[Required]
		public string Content { get; set; }
	}
}