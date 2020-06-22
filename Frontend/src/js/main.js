/* eslint-disable no-undef */
import Cookie from "./lib/Cookie";
import Loading from "./lib/Loading";
import GetSVG from "./lib/GetSVG";
import CommonController from './lib/CommonController';
// import CountNumber from "./lib/CountNumber";
// initialize
const header = document.querySelector("header");
const widgetSocial = document.querySelector(".header__widget-social");
const buttonToggleHeaderMenu = document.querySelector(".header__menu-toggle");
const headerMenu = document.querySelector(".header__menu");

const getScrollYPosition = () => window.scrollY;

const addClassBody = () => {
	const pageClassname = $('#js-page-verify').attr('class')
	$('body').addClass(pageClassname)
}

// SHOW BACK TO TOP
const showBackToTop = () => {
	$(window).scroll(function() {
		if ($(this).scrollTop() > 800) {
			$("#go-top").addClass("active");
		} else {
			$("#go-top").removeClass("active");
		}
	});

	$("#go-top").on("click", function(e) {
		e.preventDefault();
		$("html,body").animate({
			scrollTop: 0,
		});
	});
};

const getFormData = (Form) => {
	if (Form) {
		const Data = new FormData();
		Array.from(Form.querySelectorAll("[name]")).forEach((Field) => {
			const FieldName = Field.getAttribute("name");
			const FieldValue = Field.value;
			Data.append(FieldName, FieldValue);
		});
		return Data;
	}
	return;
};

const SubmitAjaxForm = () => {
	const FormSelector = ".form-ajax";
	const Forms = Array.from(document.querySelectorAll(FormSelector));
	Forms.forEach((Form) => {
		const ButtonSubmit = Form.querySelector(".form-ajax__submit");
		// $(Form).validate({
		// 	rules: {
		// 		Email: "required"
		// 	}
		// });
		ButtonSubmit.addEventListener("click", (e) => {
			e.preventDefault();
			const UrlRequest = ButtonSubmit.getAttribute("data-url");
			const Data = getFormData(Form);
			if ($(Form).valid()) {
				$.ajax({
					url: UrlRequest,
					data: Data,
					type: "POST",
					contentType: false,
					processData: false,
					beforeSend: function(res) {
						ButtonSubmit.setAttribute("disabled", "disabled");
					},
					success: function(res) {
						console.log(res);
					},
					complete: function(res) {
						ButtonSubmit.removeAttribute("disabled");
					},
				});
			}
		});
	});
};

const pageTitle = () => {
	const breadcrumb = document.querySelector(".page__breadcrumb");
	if (breadcrumb) {
		const breadcrumbItems = Array.from(
			breadcrumb.querySelectorAll(".breadcrumb__link")
		);
		const finalBreadcrumbItem = breadcrumbItems.pop();
		breadcrumb.querySelector(".page__title").innerHTML =
			finalBreadcrumbItem.textContent;
	}
};

const setSizeByRatio = () => {
	const items = Array.from(document.querySelectorAll("[data-ratio]"));
	items.forEach((item) => {
		const ratio = Number(item.getAttribute("data-ratio"));
		const width = item.clientWidth;
		item.style.height = `${width / ratio}px`;
	});
};

const setSizeFullScreen = (slides) => {
	const windowWidth = window.innerWidth;
	const windowHeight = window.innerHeight;
	slides.forEach((slide) => {
		slide.style.display = "block";
		slide.style.width = windowWidth + "px";
		if (window.innerWidth <= 1024) {
			slide.style.height = windowHeight - 60 + "px";
		} else {
			slide.style.height = windowHeight + "px";
		}
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
	(function() {
		// type code here
		const indexPage = document.querySelector('.index-page');
		if (indexPage) {
			indexPage.querySelector('.page__banner .swiper-container').classList.add('main__banner')
		}
		asyncCall()
	})()

	function asyncCall() {
		let banner = new Swiper(".page__banner .main__banner", {
			slidesPerView: 1,
			speed: 1600,
			loop: true,
			simulateTouch: true,
			autoplay: {
				disableOnInteraction: false,
				delay: 4000,
			},
			effect: "fade",
			fadeEffect: {
				crossFade: true,
			},
		});
	}
};

const addClassHeader = (currentScrollPosition) => {
	if (currentScrollPosition > 0 && window.innerWidth > 1025) {
		header.classList.add("scrolled");
	} else {
		header.classList.remove("scrolled");
	}
	if (widgetSocial && window.innerWidth > 1025) {
		if (currentScrollPosition > 0) {
			widgetSocial.classList.add("scrolled");
		} else {
			widgetSocial.classList.remove("scrolled");
		}
	}
};

const indexProjectNavAjax = () => {
	const items = Array.from(
		document.querySelectorAll(".index-project__nav .swiper-slide .nav-link")
	);
	items.forEach((item) => {
		item.addEventListener("click", (e) => {
			e.preventDefault();
			items.forEach((item) => {
				item.classList.remove("active");
			});
			item.classList.add("active");
			const urlRequest = item.getAttribute("href");
			const request = new XMLHttpRequest();
			request.open("GET", urlRequest, true);
			request.send();
			request.onload = (res) => {
				if (res.target.status === 200) {
					document.querySelector(
						".index-project .index-project-list"
					).innerHTML = res.target.response;
					indexProjectSlider();
				}
			};
			request.onerror = (err) => {
				console.log(err);
				indexProjectSlider();
			};
		});
	});
};

const indexProjectNavSlider = () => {
	indexProjectNavAjax();
	const sliderInstance = new Swiper(".index-project__nav .swiper-container", {
		slidesPerView: "auto",
		simulateTouch: false,
		navigation: {
			prevEl: ".index-project__nav .swiper-prev",
			nextEl: ".index-project__nav .swiper-next",
		},
		on: {
			init: function() {
				document
					.querySelector(".index-project__nav .swiper-slide .nav-link")
					.click();
			},
		},
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
			},
		},
	});
};

const indexBusinessInvestFieldsSlider = () => {
	return new Swiper(".bi__fields .swiper-container", {
		slidesPerView: 2,
		navigation: {
			prevEl: ".bi__fields .swiper-prev",
			nextEl: ".bi__fields .swiper-next",
		},
		breakpoints: {
			768: {
				slidesPerView: 3,
			},
			1025: {
				slidesPerView: 4,
			},
		},
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
			},
		},
	});
};

const indexPartnerSlider = () => {
	return new Swiper(".index-partner .swiper-container", {
		slidesPerView: 2,
		spaceBetween: 15,
		navigation: {
			prevEl: ".index-partner .swiper-prev",
			nextEl: ".index-partner .swiper-next",
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
		},
	});
};


const indexNewsNavAjax = () => {
	const items = Array.from(
		document.querySelectorAll(".index-news__nav .nav__link")
	);
	items.forEach((item) => {
		item.addEventListener("click", (e) => {
			e.preventDefault();
			items.forEach((item) => {
				item.classList.remove("active");
			});
			item.classList.add("active");
			const urlRequest = item.getAttribute("href");
			const request = new XMLHttpRequest();
			request.open("GET", urlRequest, true);
			request.send();
			request.onload = (res) => {
				if (res.target.status === 200) {
					document.querySelector(".index-news__list").innerHTML =
						res.target.response;
					indexNewsSlider();
				}
			};
			request.onerror = (err) => {
				indexNewsSlider();
			};
		});
	});
	if (items.length > 0) {
		items[0].click()
	}
};

const indexNewsSlider = () => {
	return new Swiper(".index-news__list .swiper-container", {
		slidesPerView: 1.5,
		spaceBetween: 15,
		loop: true,
		pagination: {
			el: ".index-news__list .swiper-pagination",
			type: "bullets",
			clickable: true,
		},
		breakpoints: {
			576: {
				slidesPerView: 2.7,
			},
			1025: {
				slidesPerView: 2.7,
			},
			1440: {
				slidesPerView: 3.7,
			},
		},
	});
};

const indexNewsNavSlider = () => {
	indexNewsNavAjax();
	if (window.innerWidth < 1025) {
		const slider = new Swiper(".index-news__nav .swiper-container", {
			slidesPerView: "auto",
			spaceBetween: 20,
			navigation: {
				prevEl: ".index-news__nav .swiper-prev",
				nextEl: ".index-news__nav .swiper-next",
			},
			on: {
				init: function() {
					document
						.querySelector(".index-news__nav .swiper-slide .nav__link")
						.click();
				},
			},
		});
	}
};

const aboutStaffsSlider = () => {
	$('.about__staffs-slider__wrapper .staff__item .item__description').each(
		function() {
			const oldHtml = $(this).html().split(' - ');
			const newHtml = `<h4>${oldHtml[0]}</h4><p>${oldHtml[1]}</p>`;
			$(this).html(newHtml);
		},
	);
	const staffsSlider = new Swiper(
		".about__staffs-slider__wrapper .swiper-container", {
			slidesPerView: 1,
			centeredSlides: true,
			spaceBetween: 20,
			loop: true,
			navigation: {
				prevEl: ".about__staffs-slider__wrapper .swiper__prev",
				nextEl: ".about__staffs-slider__wrapper .swiper__next",
			},
			breakpoints: {
				576: {
					slidesPerView: 2,
				},
				1025: {
					slidesPerView: 3,
				},
			},
		}
	);
	const ceoSlider = new Swiper(
		".about__ceos-slider__wrapper .swiper-container", {
			slidesPerView: 1,
			centeredSlides: true,
			spaceBetween: 20,
			loop: true,
			navigation: {
				prevEl: ".about__ceos-slider__wrapper .swiper__prev",
				nextEl: ".about__ceos-slider__wrapper .swiper__next",
			},
		}
	);
};

const setSizeAboutCompanyMemberItem = () => {
	const RATIO = 1.72;
	const items = Array.from(
		document.querySelectorAll(".about__company-member__item .item__img")
	);
	items.forEach((item) => {
		const width = item.clientWidth;
		item.style.height = width / RATIO + "px";
	});
};

const setSizeInvestItem = () => {
	const RATIO = 1.98;
	const items = Array.from(
		document.querySelectorAll(".invest__item .item__img")
	);
	items.forEach((item) => {
		const width = item.clientWidth;
		item.style.height = width / RATIO + "px";
	});
};

const setSizeProjectCategoryItem = () => {
	const RATIO = 2;
	const items = Array.from(
		document.querySelectorAll(".project-category__item .item__img")
	);
	items.forEach((item) => {
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
			},
		},
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
			},
		},
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
				axis: "y",
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
		desktop: 70,
	};
	if (newsHotElement) {
		let pageNavPaddingTop;

		if (window.innerWidth < 768) {
			pageNavPaddingTop =
				pageNavElement.clientHeight - breakpointPadding.mobile;
		}
		if (window.innerWidth < 1025) {
			pageNavPaddingTop = breakpointPadding.tablet;
		}
		if (window.innerWidth >= 1025) {
			pageNavPaddingTop =
				pageNavElement.clientHeight - breakpointPadding.desktop;
		}
		newsHotElement.style.paddingTop = pageNavPaddingTop + "px";
	}
};

const toggleHeaderMenuMobile = () => {
	if (buttonToggleHeaderMenu) {
		buttonToggleHeaderMenu.addEventListener("click", () => {
			if (headerMenu) {
				headerMenu.classList.toggle("active");
				if (headerMenu.classList.contains("active")) {
					document.body.style.overflow = "hidden";
					document.body.style.height = window.innerHeight + "px";
				} else {
					document.body.removeAttribute("style");
					const navItems = Array.from(
						document.querySelectorAll(".header__main-nav>.nav__item")
					);
					navItems.forEach((item) => {
						item.classList.remove("active");
					});
				}
			}
		});
	}
};

const pageNavToggle = () => {
	const pageNavElement1 = $(".page__nav");
	if (window.innerWidth <= 1024) {
		pageNavElement1.find("h2").on("click", function() {
			pageNavElement1.find(".nav__list").slideToggle();
		});
	}
	const pageNavElement2 = $(".page__nav-2");
	if (window.innerWidth <= 1024) {
		pageNavElement2.find("h2").on("click", function() {
			pageNavElement2.find(".nav__list").slideToggle();
		});
	}

	const pathname = document.location.pathname;
	$('.page__nav-2 .nav__list .nav__item').each(function() {
		const href = $(this).find('.nav__link').attr('href');
		if (href == pathname) {
			$(this).addClass('active');
		}
	});
	$('.page__nav-container .nav__list .nav__item').each(function() {
		const href = $(this).find('.nav__link').attr('href');
		if (href == pathname) {
			$(this).addClass('active');
		}
	});
};

const headerActiveSubmenu = () => {
	const navItems = Array.from(
		document.querySelectorAll(".header__main-nav>.nav__item")
	);
	navItems.forEach((item) => {
		item.addEventListener("click", () => {
			item.classList.toggle("active");
		});
	});
};

const animationWow = () => {
	var wow = new WOW({
		boxClass: "wow", // animated element css class (default is wow)
		animateClass: "animated", // animation css class (default is animated)
		offset: 100, // distance to the element when triggering the animation (default is 0)
		mobile: true, // trigger animations on mobile devices (default is true)
		live: true, // act on asynchronously loaded content (default is true)
		callback: function(box) {
			// the callback is fired every time an animation is started
			// the argument that is passed in is the DOM node being animated
		},
		scrollContainer: null, // optional scroll container selector, otherwise use window,
		resetAnimation: false, // reset animation on end (default is true)
	});
	wow.init();
};

const indexNewsBanner = () => {
	return new Swiper(".news-desc-banner .swiper-container", {
		slidesPerView: "auto",
		loopedSlides: 3,
		speed: 900,
		autoplay: {
			delay: 3000,
			disableOnInteraction: false,
		},
		loop: true,
	});
};

const BiFieldsTitleEdit = () => {
	if ($('.bi__fields .col-lg-20 .item__title').length > 0) {
		$('.bi__fields .col-lg-20 .item__title').html($('.bi__fields .col-lg-20 .item__title').html().replace(' - ', '<br>&nbsp;&nbsp;&nbsp;&nbsp;'))
	}
	if ($('.bi__fields .col-lg-20 .main-title').length > 0) {
		$('.bi__fields .col-lg-20 .main-title').html($('.bi__fields .col-lg-20 .main-title').html().replace(' - ', ' '))
	}

}

// Call functons in events
document.addEventListener("DOMContentLoaded", () => {
	Cookie();
	GetSVG();
	Loading();
	addClassBody();
	// Initialize Script
	BiFieldsTitleEdit();
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
	pageTitle();
	// Header
	toggleHeaderMenuMobile();
	addClassHeader(getScrollYPosition());
	headerActiveSubmenu();
	// PageNav
	pageNavToggle();
	// Banner
	pageBanner();
	// Slider
	indexProjectSlider();
	indexProjectNavSlider();
	indexBusinessInvestFieldsSlider();
	indexBrandPositioningSlider();
	indexNewsSlider();
	indexNewsNavSlider();
	indexPartnerSlider();
	aboutStaffsSlider();
	gallerySlider();
	// Ajax
	SubmitAjaxForm();
	// Other scripts
	// CountNumber({
	// 	duration: 1500,
	// 	offset: 75,
	// });
	animationWow();
	showBackToTop();
	indexNewsBanner();
	CommonController();
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