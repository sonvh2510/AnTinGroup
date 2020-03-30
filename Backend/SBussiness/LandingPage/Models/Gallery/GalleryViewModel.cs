using MainProject.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MainProject.SBussiness.LandingPage.Models.Gallery
{

	public class ImageItemViewModel
	{
		public string Name { get; set; }

		public string ResourcePath { get; set; }

		public List<Media> Images { get; set; } = new List<Media> { };
	}

	public class VideoItemViewModel
	{
		public string Name { get; set; }

		public string Image { get; set; }

		public string ResourcePath { get; set; }
	}

	public class GalleryViewModel
	{
		public List<ImageItemViewModel> ImageAlbums { get; set; } = new List<ImageItemViewModel>
		{
			new ImageItemViewModel
			{
				Name = "Album 1",
				ResourcePath = "/Content/resources/assets/gallery/gallery_img_thumb_1.jpg",
				Images = {
					new Media
					{
						ImageDefault = "/Content/resources/assets/gallery/gallery_img_thumb_1.jpg"
					},
					new Media
					{
						ImageDefault = "/Content/resources/assets/gallery/gallery_img_thumb_2.jpg"
					},
					new Media
					{
						ImageDefault = "/Content/resources/assets/gallery/gallery_img_thumb_3.jpg"
					}
				}
			},
			new ImageItemViewModel
			{
				Name = "Album 2",
				ResourcePath = "/Content/resources/assets/gallery/gallery_img_thumb_3.jpg",
				Images = {
					new Media
					{
						ImageDefault = "/Content/resources/assets/gallery/gallery_img_thumb_3.jpg"
					},
					new Media
					{
						ImageDefault = "/Content/resources/assets/gallery/gallery_img_thumb_2.jpg"
					},
					new Media
					{
						ImageDefault = "/Content/resources/assets/gallery/gallery_img_thumb_1.jpg"
					}
				}
			},
			new ImageItemViewModel
			{
				Name = "Album 3",
				ResourcePath = "/Content/resources/assets/gallery/gallery_img_thumb_2.jpg",
				Images = {
					new Media
					{
						ImageDefault = "/Content/resources/assets/gallery/gallery_img_thumb_2.jpg"
					},
					new Media
					{
						ImageDefault = "/Content/resources/assets/gallery/gallery_img_thumb_1.jpg"
					},
					new Media
					{
						ImageDefault = "/Content/resources/assets/gallery/gallery_img_thumb_3.jpg"
					}
				}
			},
			new ImageItemViewModel
			{
				Name = "Album 4",
				ResourcePath = "/Content/resources/assets/gallery/gallery_img_thumb_2.jpg",
				Images = {
					new Media
					{
						ImageDefault = "/Content/resources/assets/gallery/gallery_img_thumb_2.jpg"
					},
					new Media
					{
						ImageDefault = "/Content/resources/assets/gallery/gallery_img_thumb_3.jpg"
					},
					new Media
					{
						ImageDefault = "/Content/resources/assets/gallery/gallery_img_thumb_1.jpg"
					}
				}
			}
		};

		public List<VideoItemViewModel> VideoAlbums { get; set; } = new List<VideoItemViewModel>
		{
			new VideoItemViewModel
			{
				Name = "Maldives - Khám Phá Chốn Thiên Đường Nơi Hạ Giới 1",
				ResourcePath = "https://www.youtube.com/watch?v=R4em3LKQCAQ",
				Image = "/Content/resources/assets/gallery/gallery_vid_thumb_1.jpg"
			},
			new VideoItemViewModel
			{
				Name = "Maldives - Khám Phá Chốn Thiên Đường Nơi Hạ Giới 2",
				ResourcePath = "https://www.youtube.com/watch?v=R4em3LKQCAQ",
				Image = "/Content/resources/assets/gallery/gallery_vid_thumb_2.jpg"
			},
			new VideoItemViewModel
			{
				Name = "Maldives - Khám Phá Chốn Thiên Đường Nơi Hạ Giới 3",
				ResourcePath = "https://www.youtube.com/watch?v=R4em3LKQCAQ",
				Image = "/Content/resources/assets/gallery/gallery_vid_thumb_3.jpg"
			}
		};
	}
}