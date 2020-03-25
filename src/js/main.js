/* eslint-disable no-undef */
import Cookie from "./lib/Cookie";
import Loading from "./lib/Loading";
import GetSVG from "./lib/GetSVG";
import Swiper from "swiper";
// import CountNumber from "./lib/CountNumber";
// initialize
const header = document.querySelector("header");
const widgetSocial = document.querySelector(".widget__social");
const buttonToggleHeaderMenu = document.querySelector(".header__menu-toggle");
const headerMenu = document.querySelector(".header__menu");

const getScrollYPosition = () => window.scrollY;

const setSizeByRatio = () => {
	const items = Array.from(document.querySelectorAll("[data-ratio]"));
	items.forEach(item => {
		const ratio = Number(item.getAttribute("data-ratio"));
		const width = item.clientWidth;
		item.style.height = `${width / ratio}px`;
	});
};

const setSizeFullScreen = (slides) => {
	const windowWidth = window.innerWidth;
	const windowHeight = window.innerWidth > 1024 ? window.innerHeight : window.innerHeight / 2;
	slides.forEach(slide => {
		slide.style.display = "block";
		slide.style.width = windowWidth + "px";
		slide.style.height = windowHeight + "px";
	});
};

const setSize = (opts) => {
	const about1Image = document.querySelector(opts.src);
	if (about1Image) {
		const about1Content = document.querySelector(opts.target);
		const about1ImageHeight = about1Image.clientHeight;
		if (window.innerWidth >= opts.breakpoint) {
			about1Content.style.height = `${about1ImageHeight}px`;
			about1Content.style.maxHeight = `${about1ImageHeight}px`;
		}
		if (window.innerWidth < opts.breakpoint) {
			about1Content.removeAttribute("style");
		}
	}
};

const pageBanner = () => {
	const banner1 = document.querySelector(".index__banner");
	if (banner1) {
		return new Swiper(".index__banner .swiper-container", {
			slidesPerView: 1,
			speed: 1100,
			effect: "fade",
			loop: true,
			fadeEffect: {
				crossFade: true,
			},
			on: {
				init: function() {
					const slides = Array.from(document.querySelectorAll(".index__banner .swiper-slide a"));
					setSizeFullScreen(slides);
				},
				resize: function() {
					const slides = Array.from(document.querySelectorAll(".index__banner .swiper-slide a"));
					setSizeFullScreen(slides);
				}
			}
		});
	}
};

const addClassHeader = currentScrollPosition => {
	if (currentScrollPosition > 0) {
		header.classList.add("scrolled");
	} else {
		header.classList.remove("scrolled");
	}
	if (widgetSocial && currentScrollPosition > 0) {
		widgetSocial.classList.add("scrolled");
	} else {
		widgetSocial.classList.remove("scrolled");
	}
};

const indexProjectNavAjax = () => {
	const items = Array.from(document.querySelectorAll(".index-project-nav .swiper-slide .nav-link"));
	items.forEach(item => {
		item.addEventListener("click", (e) => {
			items.forEach(item => {
				item.classList.remove("active");
			});
			item.classList.add("active");
			e.preventDefault();
			const urlRequest = item.getAttribute("href");
			const request = new XMLHttpRequest();
			request.open("GET", urlRequest, true);
			request.send();
			request.onload = res => {
				if (res.target.status === 200) {
					document.querySelector(".index-project .index-project-list").innerHTML = res.target.response;
					indexProjectSlider();
				}
				if (res.target.status === 404) {
					console.log(res.target.status);
				}
			};
			request.onerror = (err) => {
				console.log(err);
			};
		});
	});
};

const indexProjectNavSlider = () => {
	indexProjectNavAjax();
	const sliderInstance = new Swiper(".index-project-nav .swiper-container", {
		slidesPerView: "auto",
		simulateTouch: false,
		navigation: {
			prevEl: ".index-project-nav .swiper-prev",
			nextEl: ".index-project-nav .swiper-next"
		},
		on: {
			init: function() {
				document.querySelector(".index-project-nav .swiper-slide .nav-link").click();
			}
		}
	});
};

const indexProjectSlider = () => {
	return new Swiper(".index-project-list .swiper-container", {
		slidesPerView: 1.2,
		spaceBetween: -10,
		centeredSlides: true,
		loop: true,
		pagination: {
			el: ".index-project-list .swiper-pagination",
			type: "bullets",
			clickable: true,
		},
		breakpoints: {
			576: {
				spaceBetween: 0,
				slidesPerView: 1.5,
			},
			768: {
				slidesPerView: 1.8,
			},
			1025: {

				spaceBetween: 10,
				slidesPerView: 3,
			}
		}
	});
}

const indexBusinessInvestFieldsSlider = () => {
	return new Swiper(".bi__fields .swiper-container", {
		slidesPerView: 2,
		navigation: {
			prevEl: ".bi__fields .swiper-prev",
			nextEl: ".bi__fields .swiper-next"
		},
		breakpoints: {
			768: {
				slidesPerView: 3,
			},
			1025: {
				slidesPerView: 4,
			}
		}
	});
};

const indexBrandPositioningSlider = () => {
	return new Swiper(".index-brand-positioning .swiper-container", {
		slidesPerView: 2,
		spaceBetween: 20,
		pagination: {
			el: ".index-brand-positioning .swiper-pagination",
			type: "bullets",
			clickable: true,
		},
		breakpoints: {
			576: {
				slidesPerView: 3,
			},
			1025: {
				slidesPerView: 4,
			}
		}
	});
};

const indexPartnerSlider = () => {
	return new Swiper(".index-partner .swiper-container", {
		slidesPerView: 2,
		spaceBetween: 15,
		navigation: {
			prevEl: ".index-partner .swiper-prev",
			nextEl: ".index-partner .swiper-next"
		},
		breakpoints: {
			576: {
				slidesPerView: 3,
			},
			768: {
				slidesPerView: 5,
			},
			1025: {
				slidesPerView: 6,
			},
			1200: {
				slidesPerView: 7,
			},
		}
	});
};

const indexNewsSlider = () => {
	return new Swiper(".index-news .swiper-container", {
		slidesPerView: 1.5,
		spaceBetween: 15,
		loop: true,
		pagination: {
			el: ".index-news .swiper-pagination",
			type: "bullets",
			clickable: true,
		},
		breakpoints: {
			576: {
				slidesPerView: 1.7,
			},
			1025: {
				slidesPerView: 2.5,
			},
		}
	});
};
const indexChangeNewsNavToSlider = () => {
	const indexNewsNav = document.querySelector(".index-news__nav");
	if (window.innerWidth < 1025 && indexNewsNav) {
		Array.from(indexNewsNav.querySelectorAll(".nav__item")).forEach(item => {
			item.classList.remove("nav__item");
			item.classList.add("swiper-slide");
		});
		const swiperSlidesHTML = indexNewsNav.innerHTML;
		indexNewsNav.innerHTML = "<div class='swiper-container'><div class='swiper-wrapper'></div></div>";
		indexNewsNav.querySelector(".swiper-wrapper").innerHTML = swiperSlidesHTML;
		const swiperPrev = document.createElement("div");
		const swiperNext = document.createElement("div");
		swiperPrev.classList.add("swiper-prev");
		swiperPrev.innerHTML = "<img class='svg' src='./assets/icons/swiper_prev_1.svg'>";
		swiperNext.classList.add("swiper-next");
		swiperNext.innerHTML = "<img class='svg' src='./assets/icons/swiper_next_1.svg'>";
		indexNewsNav.appendChild(swiperPrev);
		indexNewsNav.appendChild(swiperNext);
		return new Swiper(".index-news__nav .swiper-container", {
			slidesPerView: "auto",
			spaceBetween: 20,
			navigation: {
				prevEl: ".index-news__nav .swiper-prev",
				nextEl: ".index-news__nav .swiper-next"
			}
		});
	}
};

const aboutStaffsSlider = () => {
	const staffsSlider = new Swiper(".about__staffs-slider__wrapper .swiper-container", {
		slidesPerView: 1,
		centeredSlides: true,
		spaceBetween: 20,
		loop: true,
		navigation: {
			prevEl: ".about__staffs-slider__wrapper .swiper__prev",
			nextEl: ".about__staffs-slider__wrapper .swiper__next"
		},
		breakpoints: {
			576: {
				slidesPerView: 2,
			},
			1025: {
				slidesPerView: 3,
			}
		}
	});
	const ceoSlider = new Swiper(".about__ceos-slider__wrapper .swiper-container", {
		slidesPerView: 1,
		centeredSlides: true,
		spaceBetween: 20,
		loop: true,
		navigation: {
			prevEl: ".about__ceos-slider__wrapper .swiper__prev",
			nextEl: ".about__ceos-slider__wrapper .swiper__next"
		}
	});
};

const setSizeAboutCompanyMemberItem = () => {
	const RATIO = 1.72;
	const items = Array.from(document.querySelectorAll(".about__company-member__item .item__img"));
	items.forEach(item => {
		const width = item.clientWidth;
		item.style.height = width / RATIO + "px";
	});
};

const setSizeInvestItem = () => {
	const RATIO = 1.98;
	const items = Array.from(document.querySelectorAll(".invest__item .item__img"));
	items.forEach(item => {
		const width = item.clientWidth;
		item.style.height = width / RATIO + "px";
	});
};

const setSizeProjectCategoryItem = () => {
	const RATIO = 2;
	const items = Array.from(document.querySelectorAll(".project-category__item .item__img"));
	items.forEach(item => {
		const width = item.clientWidth;
		item.style.height = width / RATIO + "px";
	});
};

const gallerySlider = () => {
	const imageSlider = new Swiper(".gallery-images__slider .swiper-container", {
		slidesPerView: 1,
		spaceBetween: 0,
		loop: true,
		centeredSlides: true,
		navigation: {
			prevEl: ".gallery-images__slider .swiper__prev",
			nextEl: ".gallery-images__slider .swiper__next",
		},
		breakpoints: {
			768: {
				slidesPerView: 1.8,
			},
			1200: {
				slidesPerView: 2.8,
			}
		}
	});

	const videoSlider = new Swiper(".gallery-videos__slider .swiper-container", {
		slidesPerView: 1,
		loop: true,
		centeredSlides: true,
		navigation: {
			prevEl: ".gallery-videos__slider .swiper__prev",
			nextEl: ".gallery-videos__slider .swiper__next",
		},
		breakpoints: {
			768: {
				slidesPerView: 1.8,
				spaceBetween: -20,
			},
			1200: {
				slidesPerView: 2.8,
				spaceBetween: -25,
			}
		}
	});

	const autoStart = () => window.innerWidth >= 768;

	$(".gallery-images__slider .swiper-slide").each(function(index) {
		const _this = $(this);
		_this.find(".item__list a").each(function() {
			$(this).attr("data-fancybox", "image-" + index);
		});
		_this.find("a").fancybox({
			hash: false,
			thumbs: {
				autoStart: autoStart(),
				hideOnClose: true,
				parentEl: ".fancybox-container",
				axis: "y"
			},
		});
	});
	$(".gallery-videos__slider .swiper-slide").each(function(index) {
		const _this = $(this);
		_this.find(".item__link").each(function() {
			$(this).attr("data-fancybox", "video-" + index);
		});
	});

	$(".swiper-slide").on("click", function() {
		$(this).find(".item__list a").eq(0).triggerHandler("click");
	});
};

const setPaddingTopNewsNav = () => {
	const newsHotElement = document.querySelector(".news-hot__col");
	const pageNavElement = document.querySelector(".page__nav");
	const breakpointPadding = {
		mobile: 30,
		tablet: 50,
		desktop: 70
	};
	if (newsHotElement) {
		let pageNavPaddingTop;

		if (window.innerWidth < 768) {
			pageNavPaddingTop = pageNavElement.clientHeight - breakpointPadding.mobile;

		}
		if (window.innerWidth < 1025) {
			pageNavPaddingTop = breakpointPadding.tablet;
		}
		if (window.innerWidth >= 1025) {
			pageNavPaddingTop = pageNavElement.clientHeight - breakpointPadding.desktop;
		}
		newsHotElement.style.paddingTop = pageNavPaddingTop + "px";
	}
};

const toggleHeaderMenuMobile = () => {
	if (buttonToggleHeaderMenu) {
		buttonToggleHeaderMenu.addEventListener("click", () => {
			if (headerMenu) {
				headerMenu.classList.toggle("active");
			}
		});
	}
};

// Call functons in events
document.addEventListener("DOMContentLoaded", () => {
	Cookie();
	GetSVG();
	Loading();
	// Initialize Script
	toggleHeaderMenuMobile();
	// Set size 
	setSizeByRatio();
	setSize({
		src: ".about__1 .block__img img",
		target: ".about__1 .block__content",
		breakpoint: 768,
	});
	setSize({
		src: ".am__block-1 .am__img img",
		target: ".am__block-1 .am__content",
		breakpoint: 1025,
	});
	setSizeAboutCompanyMemberItem();
	setSizeInvestItem();
	setSizeProjectCategoryItem();
	setPaddingTopNewsNav();
	// Header
	addClassHeader(getScrollYPosition());
	// Banner
	pageBanner();
	// Slider
	indexProjectNavSlider();
	indexBusinessInvestFieldsSlider();
	indexBrandPositioningSlider();
	indexNewsSlider();
	indexPartnerSlider();
	aboutStaffsSlider();
	indexChangeNewsNavToSlider();
	gallerySlider();
	// Ajax
	// Other scripts
	// CountNumber({
	// 	duration: 1500,
	// 	offset: 75,
	// });
});

// Call functions after images were lazyloaded
$(document).on("lazyloaded", function(e) {
	//use width of parent node instead of the image width itself
	setSizeByRatio();
	setSize({
		src: ".about__1 .block__img img",
		target: ".about__1 .block__content",
		breakpoint: 768,
	});
	setSize({
		src: ".am__block-1 .am__img img",
		target: ".am__block-1 .am__content",
		breakpoint: 1025,
	});
});

// Call functions when screen was resized
window.addEventListener("resize", () => {
	setSizeByRatio();
	setSize({
		src: ".about__1 .block__img img",
		target: ".about__1 .block__content",
		breakpoint: 768,
	});
	setSize({
		src: ".am__block-1 .am__img img",
		target: ".am__block-1 .am__content",
		breakpoint: 1025,
	});
	setSizeAboutCompanyMemberItem();
	setSizeInvestItem();
	setSizeProjectCategoryItem();
	setPaddingTopNewsNav();
});

window.addEventListener("scroll", () => {
	addClassHeader(getScrollYPosition());
});