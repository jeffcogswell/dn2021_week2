using System;
using System.Collections.Generic;

namespace ListMemory2
{
	class Program
	{
		// This is NOT by reference
		static void Modify(List<string> mylist)
		{
			mylist.Add("Frank");
			mylist.Clear();
			mylist.Add("All done");
		}

		static void TestInt(int n)
		{
			n++;
			Console.WriteLine(n);
		}


		static void Main(string[] args)
		{
			List<string> names = new List<string>();
			names.Add("Fred");
			names.Add("Sally");

			Modify(names);

			foreach (string name in names)
			{
				Console.WriteLine(name);
			}

			int x = 10;
			TestInt(x);
			Console.WriteLine(x);
		}
	}
}
