const getOffset = (item) => {
	let offset = {};
	if (item) {
		const offsetTop = item.getBoundingClientRect().top;
		const offsetLeft = item.getBoundingClientRect().left;
		offset.top = offsetTop;
		offset.left = offsetLeft;
		return offset;
	}
};

module.exports = opts => {
	let options = {
		duration: 2000,
		offset: 0,
		once: true,
	};

	if (typeof(opts) == "object") {
		Object.assign(options, opts);
	}

	const execute = () => {
		const countItems = Array.from(document.querySelectorAll("[data-count]"));
		countItems.forEach(item => {
			const itemOffset = getOffset(item);
			if (!item.classList.contains("counted")) {
				if (itemOffset.top <= window.innerHeight - options.offset && itemOffset.top > 0) {
					let valueStart = 0;
					const valueEnd = Number(item.getAttribute("data-count"));
					const run = setInterval(function() {
						valueStart += 1;
						item.innerHTML = `${valueStart} `;
						if (valueStart >= valueEnd) {
							clearInterval(run);
						}
					}, options.duration / valueEnd);
					item.classList.add("counted");
				}
			} else {
				if (options.once === false) {
					if (itemOffset.top > window.innerHeight || itemOffset.top < 0) {
						item.innerHTML = "0 ";
						item.classList.remove("counted");
					}
				}
			}
		});
	};

	const countItems = Array.from(document.querySelectorAll("[data-count]"));
	countItems.forEach(item => {
		if (!item.classList.contains("counted")) {
			item.innerHTML = "0 ";
		}
	});

	execute();

	window.addEventListener("scroll", () => {
		execute();
	});
}