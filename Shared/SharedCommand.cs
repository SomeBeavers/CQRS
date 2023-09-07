namespace Framework_Console
{
	public static class SharedCommand
	{
		public static void AddBeaverCommand(string beaverName)
		{
			var beaver = SharedQuery.GetBeaver(beaverName);
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