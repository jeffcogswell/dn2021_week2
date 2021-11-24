using System;
using System.Collections.Generic;

namespace DictionaryDemo2
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, int> temps = new Dictionary<string, int>();
			temps["Grand Rapids"] = 75;
			temps["Detroit"] = 75;
			temps["Columbus"] = 80;
			temps["Orlando"] = 95;

			foreach (var pair in temps)
			{
				Console.WriteLine($"{pair.Key} has temperature {pair.Value}");
			}

			Console.WriteLine("Grand Rapids:");
			Console.WriteLine(temps["Grand Rapids"]);

			Console.WriteLine("\nLet's get all the keys and loop through them");
			foreach (string key in temps.Keys)
			{
				Console.WriteLine($"This key is {key}");
				int theValue = temps[key];
				Console.WriteLine($"The temperature is {theValue}");
			}

			Console.Write("\nPlease enter a city: ");
			string entry = Console.ReadLine();
			if (temps.ContainsKey(entry))
			{
				Console.WriteLine($"The temperature at {entry} is {temps[entry]}");
			}
			else
			{
				Console.WriteLine("Sorry I don't know where that is.");
			}
		}
	}
}
