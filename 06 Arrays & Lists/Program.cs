using System;
using System.Collections.Generic;

namespace MyProgram
{
	class Program
	{
		static void Main(string[] args)
		{
			////Arrays
			//int[] numbers = new int[5] { 1,2,3,4,5};
			//numbers[2] = 10;
			//for (int i = 0; i < numbers.Length; i++)
			//{
			//	Console.WriteLine(numbers[i]);
			//}

			////Lists
			//List<string> names = new List<string>() { "Ali", "Zayed", "Ahmed"};
			//names.Add("Mohammed");
			//foreach (string name in names)
			//{
			//	Console.WriteLine(name);
			//}
			List<string> names = new List<string>() { "Ali", "Zayed", "Ahmed", "Mohammed" };
			Console.WriteLine("Write Names one by one (Write done when finshed):");
			string input;
			do
			{
				input = Console.ReadLine();
				if (input != "done")
				{
					names.Add(input);
				}
			} while (input != "done");

			names.Sort();
			Console.WriteLine("-------------------\nAfter Sorting:");
			foreach (string name in names)
			{
				Console.WriteLine(name);
			}

			names.Remove("Mohammed");
			names.RemoveAt(0);
			Console.WriteLine("-------------------");
			Console.WriteLine("After deletion:");
			foreach (string name in names)
			{
				Console.WriteLine(name);
			}

			//To prevent the program from exiting
			Console.BackgroundColor = ConsoleColor.Yellow;
			Console.ForegroundColor = ConsoleColor.Red;
			Console.Write("\n\nPress any key to exit...");
			Console.ReadKey();
		}
	}
}