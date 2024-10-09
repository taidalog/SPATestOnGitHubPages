
export function f() {
    const div = document.createElement("div");
    div.innerText = "I\'m lost.";
    document.querySelector("main").querySelector("output").appendChild(div);
    const a = document.createElement("a");
    a.href = "/SPATestOnGitHubPages/somewhere/else/";
    a.innerText = "somewhere else";
    document.querySelector("main").querySelector("output").appendChild(a);
}

