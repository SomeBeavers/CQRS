using JetBrains.Annotations;
using Nuget;

namespace Core_Console;

public class UseNugetCommand
{
	public void UseNugetCommandMethod()
	{
		new NugetCommand().NugetCommandMethod();
		new NugetQuery().NugetQueryMethod();
	}
}

public class UseNugetQuery
{
	public void UseNugetQueryMethod()
	{
		new NugetQuery().NugetQueryMethod();
	}
}