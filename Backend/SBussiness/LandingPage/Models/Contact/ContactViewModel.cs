using MainProject.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MainProject.SBussiness.LandingPage.Models.Contact
{
	public class ContactViewModel
	{
		public Category Category { get; set; }

		public Branch Branch { get; set; } = new Branch
		{
			AddressMap = "<iframe src='https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3919.664376207594!2d106.69690491526032!3d10.760328662431835!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x31752f133765f339%3A0x99f29a2fa8faa1c!2zQ2h1bmcgY8awIEgzLCAzODQgSG_DoG5nIERp4buHdSwgUGjGsOG7nW5nIDYsIFF14bqtbiA0LCBI4buTIENow60gTWluaCwgVmnhu4d0IE5hbQ!5e0!3m2!1svi!2s!4v1585018430920!5m2!1svi!2s' frameborder='0' style='border:0;' allowfullscreen='' aria-hidden='false' tabindex='0'></iframe>",
			Address = "Tòa nhà H3, 384 Hoàng Diệu, <br>Quận 4, TP.Hồ Chí Minh",
			Phone = "028.38266766 - 028.38266766",
			Email = "info@antingroup.vn"
		};
	}
}