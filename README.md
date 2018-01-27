# Wpf sample application for new Project System
Sample WPF application using the [new csproj format](https://github.com/dotnet/project-system).
Targeting .NET Framework (4.6.2 or higher).

It works perfectly well with VS IntelliSense and ReSharper.
XAML edit & continue also supported.
Basically, it should work in the same way as regular WPF project, but based on the new Project System.

It includes following workarounds:
* https://github.com/dotnet/sdk/issues/810#issuecomment-295642279 (LanguageTargets)
* https://github.com/Microsoft/VSProjectSystem/issues/169 (XAML Globbing with DependentUpon for .xaml.cs)
* https://github.com/dotnet/project-system/issues/2488 (VS IntelliSense)
* https://github.com/dotnet/project-system/blob/master/src/Microsoft.VisualStudio.ProjectSystem.Managed/ProjectSystem/Rules/ (XAML Page, ApplicationDefinition, ProjectItemsSchema)
* Some new workarounds from my own experience to resolve issues such as https://github.com/Microsoft/VSProjectSystem/issues/261.
