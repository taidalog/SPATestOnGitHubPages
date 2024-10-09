namespace SPATestOnGitHubPages

open Fable.Core
open Fable.Core.JsInterop
open Browser.Dom
open Browser.Types

module Program =
    A.f ()
    A.g ()

    window.addEventListener (
        "DOMContentLoaded",
        (fun _ ->
            document.body.getElementsByTagName "a"
            |> (fun x -> JS.Constructors.Array?from(x))
            |> Array.iter (fun (x: HTMLAnchorElement) ->
                x.onclick <-
                    fun e ->
                        e.preventDefault ()
                        window.history.pushState (null, "", x.pathname)))
    )

    window.addEventListener ("popstate", (fun _ -> printfn "%s" window.location.pathname))
