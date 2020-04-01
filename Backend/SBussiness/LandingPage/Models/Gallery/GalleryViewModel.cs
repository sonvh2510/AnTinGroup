using MainProject.Core;
using System.Collections.Generic;

namespace MainProject.SBussiness.LandingPage.Models.Gallery
{
	public class GalleryViewModel
	{
		public Category Category { get; set; }

		public List<ImageItemViewModel> ImageAlbums { get; set; } = new List<ImageItemViewModel>
		{
			new ImageItemViewModel
			{
				Name = "Album 1",
				Path = "/Content/resources/assets/gallery/gallery_img_thumb_1.jpg",
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
				Path = "/Content/resources/assets/gallery/gallery_img_thumb_3.jpg",
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
				Path = "/Content/resources/assets/gallery/gallery_img_thumb_2.jpg",
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
				Path = "/Content/resources/assets/gallery/gallery_img_thumb_2.jpg",
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
				Path = "https://www.youtube.com/watch?v=R4em3LKQCAQ",
				Image = "/Content/resources/assets/gallery/gallery_vid_thumb_1.jpg"
			},
			new VideoItemViewModel
			{
				Name = "Maldives - Khám Phá Chốn Thiên Đường Nơi Hạ Giới 2",
				Path = "https://www.youtube.com/watch?v=R4em3LKQCAQ",
				Image = "/Content/resources/assets/gallery/gallery_vid_thumb_2.jpg"
			},
			new VideoItemViewModel
			{
				Name = "Maldives - Khám Phá Chốn Thiên Đường Nơi Hạ Giới 3",
				Path = "https://www.youtube.com/watch?v=R4em3LKQCAQ",
				Image = "/Content/resources/assets/gallery/gallery_vid_thumb_3.jpg"
			}
		};
	}

	public class ImageItemViewModel
	{
		public string Name { get; set; }

		public string Path { get; set; }

		public List<Media> Images { get; set; } = new List<Media> { };
	}

	public class VideoItemViewModel
	{
		public string Name { get; set; }

		public string Image { get; set; }

		public string Path { get; set; }
	}

}