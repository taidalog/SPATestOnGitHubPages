dotnet new console --language "F#" --name "App" --framework "net8.0" --output src
dotnet new globaljson --sdk-version "8.0.100" --roll-forward latestFeature
dotnet new nugetconfig
dotnet new tool-manifest
dotnet tool install fable
dotnet tool install fantomas
dotnet add .\src\App.fsproj package Fable.Core
dotnet add .\src\App.fsproj package Fable.Browser.Dom
# Saved workspace.
# Setup formatting.
npm init -y
npm i -D vite
New-Item -Name vite.config.ts -ItemType File
# edit vite.config.ts
# Add `base: '<REPO>',` to vite.config.ts.
New-Item -Name index.html -ItemType File
New-Item -Name style.css -ItemType File
# `dotnet fable` after cd .\src\