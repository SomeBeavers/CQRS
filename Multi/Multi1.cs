using Framework_Console;
using JetBrains.Annotations;

namespace Multi;

public class MultiCommand1
{
	[Command]
	public void AddBeaverCommand1(string beaverName)
	{
		var beaver = MultiQuery.GetBeaver(beaverName);
		BeaversRepo.AddBeaver(beaver);
	} 
}

public class MultiQuery
{
	public static Beaver GetBeaver(string beaver)
	{
		return BeaversRepo.GetBeaver(beaver);
	}
}