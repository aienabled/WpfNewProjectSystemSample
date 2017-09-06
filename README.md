# WpfNetStandardSample
Sample WPF application using new csproj format (for NetStandard). Targeting .NET Framework 4.6.2.

It works perfectly well with VS IntelliSense with ReSharper.

It includes following workarounds:
* https://github.com/dotnet/sdk/issues/810#issuecomment-295642279 (LanguageTargets)
* https://github.com/Microsoft/VSProjectSystem/issues/169 (XAML Globbing with DependentUpon for .xaml.cs)
* https://github.com/dotnet/project-system/issues/2488 (VS IntelliSense)
* https://github.com/dotnet/project-system/blob/master/src/Microsoft.VisualStudio.ProjectSystem.Managed/ProjectSystem/Rules/ (XAML Page, ApplicationDefinition, ProjectItemsSchema)
* A workaround for ReSharper issue with including the WPF intermediate C# files into the project model (not yet reported issue). If you're not using ReSharper, you can safely remove this section from every .csproj file.
