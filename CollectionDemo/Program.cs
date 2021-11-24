using System;
using System.Collections.Generic;

namespace CollectionDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> names = new List<string>();
			names.Add("Fred");
			names.Add("Sally");

			Console.WriteLine(names[0]);
			Console.WriteLine(names[1]);

			names.Add("Julia");
			Console.WriteLine(names[2]);

			Console.WriteLine(names.Contains("Fred"));
			Console.WriteLine(names.Contains("Pizza"));

			Console.WriteLine("Now let's remove Fred");
			names.Remove("Fred");
			Console.WriteLine(names[0]);

			Console.WriteLine("Let's remove by index rather than names");
			names.RemoveAt(1); // Index 1 means the second one
			Console.WriteLine(names[0]);
			//Console.WriteLine(names[1]); // Can't do this one because it's gone!

			// Let's add a couple more things back in
			names.Add("Jack");
			names.Add("Allison");
			names.Add("Dylan");
			names.Add("Erica");

			Console.WriteLine("\nLet's loop through them using a for loop");
			for (int i=0; i<names.Count; i++)
			{
				Console.WriteLine($"We are inside the loop and our index is {i}.");
				Console.WriteLine($"{i} : {names[i]}");
			}

			Console.WriteLine("\nNow let's use a foreach loop");
			foreach (string item in names)
			{
				Console.WriteLine(item);
			}
		}
	}
}
