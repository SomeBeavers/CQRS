namespace Nuget;

public class NugetQuery
{
	public void NugetQueryMethod()
	{
		new NugetCommand().NugetCommandMethod();
		Console.WriteLine(nameof(NugetQueryMethod));
	}
}