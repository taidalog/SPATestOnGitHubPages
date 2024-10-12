namespace SPATestOnGitHubPages

open Browser.Types
open Browser.Url

module Url =
    let mergePathname (url: URL) =
        let searchParams = url.searchParams

        match searchParams.get "pathname" with
        | None -> url
        | Some v ->
            let searchParams' = url.searchParams
            searchParams'.delete "pathname"

            if searchParams'.ToString() = "" then
                URL.Create(url.origin + v)
            else
                URL.Create(url.origin + v + "?" + searchParams'.ToString())
