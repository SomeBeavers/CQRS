#if NET8_0
using JetBrains.Annotations;
#endif

namespace Multi
{
#if NET8_0
		[Command]

	public class Multi1Query1Command
	{
		public void Multi1QueryMethod()
		{
		}
	}

	[Command]
	public class Multi1Query2Command
	{
		public void Multi1QueryMethod()
		{
			return;
		}
	}
#else
	public class Multi1Query
	{
		public void Multi1QueryMethod()
		{
		}
	}
#endif


#if NET8_0
	public class Multi1QueryCommand
	{
		public void Test()
		{
			new Multi1Query1Command().Multi1QueryMethod();
		}
	}
#else
	public class Multi1QueryCommand
	{
		public void Test()
		{
			new Multi1Query().Multi1QueryMethod();
		}
	}
#endif


}