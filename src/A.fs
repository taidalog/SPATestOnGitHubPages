namespace SPATestOnGitHubPages

open Browser.Dom

module A =
    let f _ = printfn "Hello World From F#!"

    let g _ =
        let div = document.createElement "div"
        div.innerText <- "Happy Hapy F#!"
        document.body.appendChild div |> ignore
