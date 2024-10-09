import { f } from "./Home.fs.js";
import { f as f_1 } from "./About.fs.js";
import { f as f_2 } from "./Terms.fs.js";
import { f as f_3 } from "./NotFound.fs.js";
import { defaultOf } from "./fable_modules/fable-library-js.4.22.0/Util.js";
import { printf, toConsole } from "./fable_modules/fable-library-js.4.22.0/String.js";
import { ofArray, map, iterate } from "./fable_modules/fable-library-js.4.22.0/List.js";

export function pageinit(pathname) {
    switch (pathname) {
        case "/SPATestOnGitHubPages/": {
            f();
            break;
        }
        case "/SPATestOnGitHubPages/about/": {
            f_1();
            break;
        }
        case "/SPATestOnGitHubPages/terms/": {
            f_2();
            break;
        }
        case "/SPATestOnGitHubPages/404/": {
            f_3();
            break;
        }
        default:
            f_3();
    }
}

export function overwriteAnchor(x) {
    x.onclick = ((e) => {
        e.preventDefault();
        window.history.pushState(defaultOf(), "", x.pathname);
        pageinit(window.location.pathname);
        const arg = window.location.pathname;
        toConsole(printf("%s"))(arg);
        let array;
        const x_1 = document.body.getElementsByTagName("a");
        array = (Array.from(x_1));
        array.forEach((x_2) => {
            overwriteAnchor(x_2);
        });
    });
}

window.addEventListener("DOMContentLoaded", (_arg) => {
    const header = document.createElement("header");
    document.body.appendChild(header);
    const main = document.createElement("main");
    document.body.appendChild(main);
    const footer = document.createElement("footer");
    document.body.appendChild(footer);
    const div = document.createElement("div");
    div.innerText = "Happy coding with F# + Fable + Vite!";
    main.appendChild(div);
    iterate((x_1) => {
        main.appendChild(x_1);
    }, map((tupledArg) => {
        const a = document.createElement("a");
        a.href = tupledArg[0];
        a.innerText = tupledArg[1];
        return a;
    }, ofArray([["/SPATestOnGitHubPages/", "home"], ["/SPATestOnGitHubPages/about/", "about"], ["/SPATestOnGitHubPages/terms/", "terms"], ["/SPATestOnGitHubPages/x/y/z/", "x/y/z"]])));
    const output = document.createElement("output");
    main.appendChild(output);
    let array;
    const x_2 = document.body.getElementsByTagName("a");
    array = (Array.from(x_2));
    array.forEach((x_3) => {
        overwriteAnchor(x_3);
    });
});

window.addEventListener("popstate", (_arg) => {
    pageinit(window.location.pathname);
    const arg = window.location.pathname;
    toConsole(printf("%s"))(arg);
});

