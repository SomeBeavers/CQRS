using Framework_Console;
using JetBrains.Annotations;
using Nuget;

namespace Core_Console;

[NoCqrs]
public class UseNugetCommand 
{
	[NoCqrs]
	public void UseNugetCommandMethod()
	{
		new NugetCommand().NugetCommandMethod();
		new NugetQuery().NugetQueryMethod();
		
		SharedCommand.AddBeaverCommand(null!);
		SharedQuery.GetBeaver(null!);

		new UseNugetQuery().UseNugetQueryMethod();
	}
}
[NoCqrs]
public class UseNugetQuery
{
	public void UseNugetQueryMethod()
	{
		new NugetQuery().NugetQueryMethod();
	}
}