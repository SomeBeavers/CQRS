using Framework_Console;

namespace Core_Lib.Commands;

public class BeaversQuery
{
	public Beaver GetBeaver(string name)
	{
		return BeaversRepo.GetBeaver(name);
	}
}