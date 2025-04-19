namespace Nuget;

using System.Reflection;

public class NugetVersion
{
	public string Get()
	{
		Version? version = Assembly.GetExecutingAssembly().GetName().Version;
        return version?.ToString() ?? "0.0.0";
	}
}
