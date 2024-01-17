using A;
using Nuget;

namespace Core_Console;


public class UseNugetCommand
{
	public void UseNugetCommandMethod()
	{
		new NugetCommand().NugetCommandMethod();
		new NugetQuery().NugetQueryMethod();

		//SharedCommand.AddBeaverCommand(null!);
		//SharedQuery.GetBeaver(null!);

		//new UseNugetQuery().UseNugetQueryMethod();
	}
}

public class UseNugetQuery
{
	public void UseNugetQueryMethod()
	{
		new NugetCommand().NugetCommandMethod();
	}
}