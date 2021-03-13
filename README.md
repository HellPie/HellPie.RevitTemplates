# Templates for Revit AddIns

Customizable templates for creating Revit AddIn Projects and Solutions using the [`dotnet new`](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-new) tooling.

## Available Templates

> **Note**: Pull Requests for new and improved Templates are very appreciated. This is a hobby project but it is used in production at the company I work for. I do hope more people will join in and turn this into a powerful Template Pack overtime.

### Solution template for Revit External Application AddIns

The `revit-app` template provides a preconfigured project for a Revit AddIn using a `IExternalApplication` implementation as the main point of entry.

It provides a Solution Tree structured as follows:
- Virtual folder for the main Revit project with:
    - C# AddIn Project with:
        - `.addin` file setup from template values
        - Minimal `IExternalApplication` class
        - Custom MSBuild Targets that either run the project in Revit for Debug builds or package it in a `.zip` file for Release builds
        - Easy to use Revit version switches to test and build the AddIn in multiple Revit environments
- Virtual folder for files not related to source code such as:
    - *Optional* Git files for VCS
    - *Optional* EditorConfig files for code style sharing
    - *Optional* README and LICENSE files
- *Optional* virtual folder for test with:
    - Minimal NUNit 3 Project for out-of-Revit Unit Tests
    - Minimal Project for in-Revit Unit Tests using NUnit

Multiple features can be configured, such as:
- Revit version which determines which SDK to rely on
- .NET Framework version, which offers documentation for which Revit version supports it
- `.addin` file values
- Inclusion or exclusion of optional elements in the aforementioned Solution Tree
- Namespace, versioning, Assembly configuration values and other parameters available through `dotnet new revit-app --help`

All Project files use the new SDK style projects and not the old and more verbose MSBuild style.

## Usage

> **Note**: Custom arguments are not supported in Visual Studio or Jetbrains Rider so the templates must be created using the CLI tools.

Run `dotnet new <template name>` to create a new Solution.
A list of arguments is provided by `dotnet new <template name> --help`. It lists parameter names, a human readable description, whether the parameter is optional as well as which values it may support and which value is used by default.

## Installation

> **Note**: Updates are performed by installing the most recent package. This will overwrite any existing old version.

### Download a Release

- Download the most recent NuGet Package `.nupkg` file from [Releases](https://github.com/HellPie/HellPie.RevitTemplates/releases).
- Install it with `dotnet new --install <path to .nupkg file>`.

### Built It Yourself

- Download or `git clone` the project source code.
- Run `dotnet pack` from within the repository root directory.
- Install it with `dotnet new --install .\bin\Debug\<.nupkg file name>`.

## Legal Disclaimer

This project is not affiliated with Autodesk or the Revit brand.

Trademarked referenced herein are property of their respective owners.

## Product license

This project, its sources, products and services are released under the [Apache 2.0 License](LICENSE).

```
Copyright 2020-2021 Diego Rossi (https://github.com/HellPie)

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

   http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
```

## Third party license

No license documentation is provided here at the moment.

Please check the dependencies used within the source code for additional information.
