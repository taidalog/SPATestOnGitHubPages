namespace SPATestOnGitHubPages

open Browser.Dom

module A =
    let f _ = printfn "Hello World From F#!"

    let g _ =
        let div = document.createElement "div"
        div.innerText <- "Happy coding with F# + Fable + Vite!"
        document.body.appendChild div |> ignore
