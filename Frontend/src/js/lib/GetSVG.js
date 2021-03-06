module.exports = (cb) => {
	const imgs = Array.from(document.querySelectorAll("img.svg"));
	imgs.forEach(img => {
		const url = img.getAttribute("src") || img.getAttribute("data-src");
		const getImageRequest = new XMLHttpRequest();
		getImageRequest.open("GET", url, true);
		getImageRequest.onload = function(e) {
			img.outerHTML = e.target.response;
			if (typeof(cb) == "function") {
				cb(img);
			}
		};
		getImageRequest.send();
	});
};