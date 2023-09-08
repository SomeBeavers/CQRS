using Framework_Console;

namespace Multi;

public class MultiQuery
{
#if NET8_0
	public static Beaver GetBeaver(string beaver)
	{
		return BeaversRepo.GetBeaver(beaver);
	}
#else
#endif

}