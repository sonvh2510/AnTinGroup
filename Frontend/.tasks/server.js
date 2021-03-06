import {
	watch,
	series,
	parallel
} from "gulp"
import bSync from "browser-sync";
import {
	jsCore
} from "./core-js"
import {
	jsTask,
	jsTask2
} from "./script"
import {
	pugTask
} from "./html"
import {
	cssCore
} from "./core-css"
import {
	cssTask
} from "./css"
import {
	copyAssets
} from "./copy";
import {
	cleanAssets
} from "./clean";
import {
	copyAPIs
} from "./api";

const server = () => {
	bSync.init({
		notify: true,
		server: {
			baseDir: "_dist",
		},
		port: 8000
	})

	watch([
		"src/api/**.json",
		"src/api/**.html",
	], series(copyAPIs))

	watch([
		"src/js/main.js",
		"src/js/lib/**.js"
	], series(jsTask));

	watch([
		"src/js/**.js",
		"!src/js/main.js"
	], series(jsTask2));

	watch([
		"src/**/**.pug"
	], series(pugTask));

	watch([
		"src/scss/**/**.scss"
	], series(cssTask));

	watch([
		"src/assets/**/**.{svg,png,jpg,jpeg,gif,mp4}"
	], series(cleanAssets, copyAssets));


	watch([
		"_vendors.json",
		"vendors/**/**.css",
		"vendors/**/**.js",
	], parallel(jsCore, cssCore));

	watch([
		"_dist"
	]).on("change", bSync.reload);
}

module.exports = {
	server
};