# Wpf sample application for new Project System
This is a sample WPF application using the [new csproj format](https://github.com/dotnet/project-system).
Targeting .NET Framework (4.6.2 or higher).
It could be used to for porting WPF applications to new csproj format until official support is implemented.
Please note that Microsoft is aware of the WPF porting problems and included WPF support of the new csproj format for the upcoming VS 16.0 release according the [official roadmap](https://github.com/dotnet/project-system/blob/master/docs/repo/roadmap.md).

It works perfectly well with VS IntelliSense and ReSharper.
XAML edit & continue also supported.
Basically, it should work in the same way as a regular WPF project, but based on the new Project System. However, there are some issues described below.

It includes following workarounds:
* https://github.com/dotnet/sdk/issues/810#issuecomment-295642279 (LanguageTargets)
* https://github.com/Microsoft/VSProjectSystem/issues/169 (XAML Globbing with DependentUpon for .xaml.cs)
* https://github.com/dotnet/project-system/issues/2488 (VS IntelliSense)
* https://github.com/dotnet/project-system/blob/master/src/Microsoft.VisualStudio.ProjectSystem.Managed/ProjectSystem/Rules/ (XAML Page, ApplicationDefinition, ProjectItemsSchema)
* Some new workarounds from my own experience to resolve issues such as https://github.com/Microsoft/VSProjectSystem/issues/261.

## Important issues
Please note that this solution doesn't use two-pass XAML building routine, so if you're referencing any elements by name from code-behind it will require you to compile the solution twice (so it will generate the required `.g.cs` files in intermediate (`obj`) folder during the first compilation).
The problem was discussed there with a known workaround (which is not incorporated into this repository yet)
https://github.com/dotnet/project-system/issues/1467#issuecomment-360985477
