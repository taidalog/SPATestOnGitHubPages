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