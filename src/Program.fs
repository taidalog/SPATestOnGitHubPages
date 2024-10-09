namespace SPATestOnGitHubPages

open Fable.Core
open Fable.Core.JsInterop
open Browser.Dom
open Browser.Types

module Program =
    let pageinit (pathname: string) : unit =
        match pathname with
        | "/SPATestOnGitHubPages/" -> Home.f ()
        | "/SPATestOnGitHubPages/about/" -> About.f ()
        | "/SPATestOnGitHubPages/terms/" -> Terms.f ()
        | "/SPATestOnGitHubPages/404/" -> NotFound.f ()
        | _ -> NotFound.f ()

    let rec overwriteAnchor (x: HTMLAnchorElement) : unit =
        x.onclick <-
            fun (e: MouseEvent) ->
                e.preventDefault ()
                window.history.pushState (null, "", x.pathname)
                pageinit window.location.pathname
                printfn "%s" window.location.pathname

                document.body.getElementsByTagName "a"
                |> fun x -> JS.Constructors.Array?from(x)
                |> Array.iter overwriteAnchor

    window.addEventListener (
        "DOMContentLoaded",
        (fun _ ->
            let header = document.createElement "header"
            document.body.appendChild header |> ignore
            let main = document.createElement "main"
            document.body.appendChild main |> ignore
            let footer = document.createElement "footer"
            document.body.appendChild footer |> ignore

            let div = document.createElement "div"
            div.innerText <- "Happy coding with F# + Fable + Vite!"
            main.appendChild div |> ignore

            [ "/SPATestOnGitHubPages/", "home"
              "/SPATestOnGitHubPages/about/", "about"
              "/SPATestOnGitHubPages/terms/", "terms"
              "/SPATestOnGitHubPages/x/y/z/", "x/y/z" ]
            |> List.map (fun (x, y) ->
                let a = document.createElement "a" :?> HTMLAnchorElement
                a.href <- x
                a.innerText <- y
                a)
            |> List.iter (fun x -> main.appendChild x |> ignore)

            let output = document.createElement "output"
            main.appendChild output |> ignore

            document.body.getElementsByTagName "a"
            |> fun x -> JS.Constructors.Array?from(x)
            |> Array.iter overwriteAnchor)

    )

    window.addEventListener (
        "popstate",
        (fun _ ->
            pageinit window.location.pathname
            printfn "%s" window.location.pathname)
    )
