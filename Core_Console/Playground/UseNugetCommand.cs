using A;
using JetBrains.Annotations;
using Nuget;

namespace Core_Console.Playground;


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
        new NotNugetCommand().NugetCommandMethod();
    }
}

public class NotNugetCommand
{
    public void NugetCommandMethod()
    {
        throw new NotImplementedException();
    }
}