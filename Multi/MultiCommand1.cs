using Framework_Console;
using JetBrains.Annotations;

namespace Multi;

[Command]
public class MultiCommand
{
	public void AddBeaverCommand1(string beaverName)
	{
#if NET8_0
var beaver = MultiQuery.GetBeaver(beaverName);
		
#endif
		BeaversRepo.AddBeaver(null);
	}


	public void AddBeaverCommand1()
	{ }
}