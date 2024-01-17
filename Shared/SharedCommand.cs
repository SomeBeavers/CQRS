using Framework_Console;

namespace A
{
	public static class SharedCommand
	{
		public static void AddBeaverCommand(Beaver beaver)
		{
			//var beaver2 = SharedQuery.GetBeaver("beaverName");
			BeaversRepo.AddBeaver(beaver);
		} 
	}

	public static class SharedQuery
	{
		public static Beaver GetBeaver(string beaver)
		{
			return BeaversRepo.GetBeaver(beaver);


		}
	}
}