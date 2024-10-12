namespace SPATestOnGitHubPages

open Browser.Types
open Browser.Url

module Url =
    let mergeSource (url: URL) =
        let searchParams = url.searchParams

        match searchParams.get "source" with
        | None -> url
        | Some v ->
            let searchParams' = url.searchParams
            searchParams'.delete "source"

            if searchParams'.ToString() = "" then
                URL.Create(url.origin + url.pathname + v + searchParams'.ToString())
            else
                URL.Create(url.origin + url.pathname + v + "?" + searchParams'.ToString())
