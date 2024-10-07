import { printf, toConsole } from "./fable_modules/fable-library-js.4.22.0/String.js";

export function f(_arg) {
    toConsole(printf("Hello World From F#!"));
}

export function g(_arg) {
    const div = document.createElement("div");
    div.innerText = "Happy coding with F# + Fable + Vite!";
    document.body.appendChild(div);
}

