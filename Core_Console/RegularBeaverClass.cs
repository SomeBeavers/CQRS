using Framework_Console;

namespace Core_Console;

public class RegularBeaverClass
{
	public void RegularBeaverMethod(Beaver beaver)
	{
		SharedCommand.AddBeaverCommand(beaver);
		SharedQuery.GetBeaver(beaver.Name);
	}
}