namespace SPATestOnGitHubPages

open Browser.Dom

module A =
    let f (x: string) =
        ((document.querySelector "main").querySelector "output").innerHTML <- x
