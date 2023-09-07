using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework_Console
{
	internal class Program
	{
		static void Main(string[] args)
		{
		}
	}


	public class BeaverCommand
	{
		public void AddBeaverCommand(Beaver beaver)
		{
		}
	}
	public class BeaverQuery
	{
		public Beaver GetBeaver(Beaver beaver)
		{
			new BeaverCommand().AddBeaverCommand(beaver);
			return null;
		}
	}
}
