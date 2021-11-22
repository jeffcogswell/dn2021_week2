using System;

namespace ArrayDemo1
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] numbers = new int[] { 5, 10, 15, 20, 25 };
			for (int i=0; i<5; i++)
			{
				Console.WriteLine(numbers[i]);
			}

			Console.WriteLine("Now let's make a string array");
			string[] names = new string[] { "Fred", "Sally", "Julia", "Sam" };
			Console.WriteLine(names[0]); // Print out the first one
			Console.WriteLine(names[2]); // Print out the third one

			Console.WriteLine("Change one and print them all out");
			// Let's suppose we need to change one
			// Let's change Sam to Samantha
			names[3] = "Samantha";
			for (int i=0; i < names.Length; i++)
			{
				Console.WriteLine(names[i]);
			}

			// Let's create an array but not initialize it. We do, however,
			// have to state the size when we create it.
			// We'll create an array with four slots, but intially they
			// are empty
			Console.WriteLine("Create an array without initializing it.");
			string[] words = new string[4];
			words[0] = "Apple";
			words[1] = "Banana";
			words[2] = "Orange";
			words[3] = "Watermelon";

			for (int i = 0; i < words.Length; i++)
			{
				Console.WriteLine(words[i]);
			}

		}
	}
}
