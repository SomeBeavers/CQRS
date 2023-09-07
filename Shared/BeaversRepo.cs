﻿using System.Collections.Generic;

namespace Framework_Console
{
	public static class BeaversRepo
	{
		static List<Beaver> beavers = new List<Beaver>();

		public static void AddBeaver(Beaver beaver)
		{
			beavers.Add(beaver);
		}

		public static Beaver GetBeaver(string name)
		{
			return beavers.Find(b => b.Name == name);
		}

	}
}