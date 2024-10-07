dotnet new console --language "F#" --name "App" --framework "net8.0" --output src
dotnet new globaljson --sdk-version "8.0.100" --roll-forward latestFeature
dotnet new nugetconfig
dotnet new tool-manifest
dotnet tool install fable
dotnet tool install fantomas