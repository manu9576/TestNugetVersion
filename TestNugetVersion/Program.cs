using Nuget;
using IntermediaryNuget;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

NugetVersion version  = new();

Console.WriteLine($"NugetVersion: {version.Get()}");

IntermediaryNugetVersion intermediaryVersion  = new();
Console.WriteLine($"IntermediaryNugetVersion: {intermediaryVersion.Get()}");