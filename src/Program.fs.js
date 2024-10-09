import { g, f } from "./A.fs.js";
import { defaultOf } from "./fable_modules/fable-library-js.4.22.0/Util.js";
import { printf, toConsole } from "./fable_modules/fable-library-js.4.22.0/String.js";

f(undefined);

g(undefined);

window.addEventListener("DOMContentLoaded", (_arg) => {
    let array;
    const x = document.body.getElementsByTagName("a");
    array = (Array.from(x));
    array.forEach((x_1) => {
        x_1.onclick = ((e) => {
            e.preventDefault();
            window.history.pushState(defaultOf(), "", x_1.pathname);
        });
    });
});

window.addEventListener("popstate", (_arg) => {
    const arg = window.location.pathname;
    toConsole(printf("%s"))(arg);
});

