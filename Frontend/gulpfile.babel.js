import {
	series,
	parallel
} from "gulp";

// Import tasks
import {
	server
} from "./.tasks/server";
import {
	jsTask,
	jsTask2
} from "./.tasks/script";
import {
	pugTask
} from "./.tasks/html";
import {
	cssTask
} from "./.tasks/css";
import {
	jsCore
} from "./.tasks/core-js";
import {
	cssCore
} from "./.tasks/core-css";
import {
	cleanDist
} from "./.tasks/clean";
import {
	copyFavicon,
	copyFonts,
	copyAssets
} from "./.tasks/copy";
import {
	copyAPIs
} from "./.tasks/api";


exports.default = series(
	cleanDist,
	parallel(
		copyFavicon,
		copyFonts,
		copyAssets,
		copyAPIs
	),
	parallel(
		jsCore,
		cssCore
	),
	parallel(
		cssTask,
		jsTask,
		jsTask2,
	),
	pugTask,
	server,
);