namespace Core_Console.Playground
{
	class Query
	{
		public void Test()
		{
		}
	}

	class Command
	{
		public void Test()
		{
			new Query().Test();
		}
	}
}