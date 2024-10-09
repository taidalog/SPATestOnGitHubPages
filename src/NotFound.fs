namespace SPATestOnGitHubPages

open Browser.Dom
open Browser.Types

module NotFound =
    let f () =
        let div = document.createElement "div"
        div.innerText <- "I'm lost."

        ((document.querySelector "main").querySelector "output").appendChild div
        |> ignore

        let a = document.createElement "a" :?> HTMLAnchorElement
        a.href <- "/SPATestOnGitHubPages/somewhere/else/"
        a.innerText <- "somewhere else"
        ((document.querySelector "main").querySelector "output").appendChild a |> ignore
