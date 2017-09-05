# WpfNetStandardSample
Sample WPF application using new csproj format (for NetStandard). Targeting .NET Framework 4.6.2.

It works perfectly well with ReSharper.

Without ReSharper it's still can build without any errors, but auto-complete don't work properly: it doesn't work with WPF generated code (it seems intermediate C# files from obj folder are not included into the VS "project model"). It means you can reference another user controls, but Visual Studio will display bogus errors for all the generated code such as `InitializeComponent()` method calls.