namespace IntermediaryNuget;

using Nuget;
using System.Reflection;

public class IntermediaryNugetVersion
{
	public string Get()
	{
		string nugetVersion = new NugetVersion().Get();

		Version? version = Assembly.GetExecutingAssembly().GetName().Version;
        
		string myVersion = version?.ToString() ?? "0.0.0";

        return $"Nuget => {nugetVersion} - MyVersion => {myVersion}";
	}
}
