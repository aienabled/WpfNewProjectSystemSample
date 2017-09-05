# WpfNetStandardSample
Sample WPF application using new csproj format (for NetStandard). Targeting .NET Framework 4.6.2.

It works perfectly well with ReSharper.

Without ReSharper it's still can build without any errors, but VS IntelliSense doesn't work properly: it doesn't work with WPF generated code (it seems intermediate C# files from obj folder are not included into the VS "project model"). Visual Studio will display bogus errors for all the WPF generated code such as `InitializeComponent()` method calls.


It includes some workarounds from https://github.com/dotnet/sdk/issues/810#issuecomment-295642279
and https://github.com/Microsoft/VSProjectSystem/issues/169
also it includes XAML Page and ApplicationDefinition from https://github.com/dotnet/project-system/blob/master/src/Microsoft.VisualStudio.ProjectSystem.Managed/ProjectSystem/Rules/
