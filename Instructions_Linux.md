# MonoGame Setup for Linux

### Installing Visual Studio Code

To install Visual Studio Code, just install it using a Software package application from Flatpak.

### Installing the .NET framework

To code with MonoGame, the .NET software development kit should be installed.

First, the repository is updated:
```
sudo apt update
sudo apt upgrade
```

Installing the .NET SDK (Software Development Kit)

```
sudo apt install dotnet-sdk-8.0

dotnet --version
```

Installing the MonoGame templates

```
dotnet new install MonoGame.Templates.CSharp
dotnet new --list | grep MonoGame
```

Installing the MGCB Editor
```
dotnet tool install --global dotnet-mgcb-editor
export PATH="$PATH:$HOME/.dotnet/tools"

mgcb-editor Content/Content.mgcb   # Open the editor
```

Creating a project
```
dotnet new mgdesktopgl -n MyGame
cd MyGame

code .     # To go to Visual Studio Code
# C# and C# developer kit extensions are required in VSCode
```

Building and running the project
```
dotnet restore
dotnet build
dotnet run
```

If the error `/usr/lib/dotnet/sdk/8.0.122/Sdks/Microsoft.NET.Sdk/targets/Microsoft.NET.TargetFrameworkInference.targets(166,5): error NETSDK1045: The current .NET SDK does not support targeting .NET 9.0.  Either target .NET 8.0 or lower, or use a version of the .NET SDK that supports .NET 9.0. Download the .NET SDK from https://aka.ms/dotnet/download ` is obtained, replace `net9.0` with `net8.0` in `MyGame.csproj` file in the project.
