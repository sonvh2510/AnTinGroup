module.exports = () => {
	return new Promise((resolve, reject) => {
		let loading = document.getElementById("loading-container");
		if (loading) {
			let progressPercentage = loading.querySelector("#progress-percentage");
			let progressBar = loading.querySelector("#progress-bar");
			let images = document.images;
			let imagesLength = images.length;
			let counter = 0;

			const turnOffLoadingScreen = () => {
				loading.style.opacity = "0";
				setTimeout(function() {
					loading.parentNode.removeChild(loading);
					document.querySelector("body").classList.add("show-page");
					resolve();
				}, 1000);
			};

			const progressing = () => {
				let n = Math.round(100 / imagesLength * (counter += 1));
				if (progressBar) {
					progressBar.style.width = `${n}%`;
				}
				if (progressPercentage) {
					progressPercentage.innerHTML = `${n}`;
				}
				if (counter === imagesLength) {
					if (loading) {
						return turnOffLoadingScreen();
					}
				}
			};

			if (imagesLength === 0) {
				return turnOffLoadingScreen();
			} else {
				for (let i = 0; i < imagesLength; i++) {
					let img = new Image;
					img.onload = progressing;
					img.onerror = progressing;
					img.src = images[i].src;
				}
			}
		}
	});
};