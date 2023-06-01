using System;

namespace MyProgram
{
	class Basics
	{
		static void Main(string[] args)
		{
			Console.Title = "My first program";
			Console.BackgroundColor = ConsoleColor.White;
			Console.ForegroundColor = ConsoleColor.Black;
			Console.Write("Hello!");
			Console.BackgroundColor = ConsoleColor.White;
			Console.ForegroundColor = ConsoleColor.Black;
			Console.WriteLine(" My name is Ahmed!");
			Console.WriteLine("What's your name?");
			Console.BackgroundColor = ConsoleColor.Black;
			Console.ForegroundColor = ConsoleColor.White;
			string username;
			username = Console.ReadLine();
			Console.BackgroundColor = ConsoleColor.White;
			Console.ForegroundColor = ConsoleColor.Black;
			Console.WriteLine("Hello, " + username + "! Nice to meet you.");
			Console.WriteLine("How old are you?");
			Console.BackgroundColor = ConsoleColor.Black;
			Console.ForegroundColor = ConsoleColor.White;
			string age = Console.ReadLine();
			Console.BackgroundColor = ConsoleColor.White;
			Console.ForegroundColor = ConsoleColor.Black;
			Console.WriteLine("I am 35 YO");

			//To prevent the program from exiting
			Console.BackgroundColor = ConsoleColor.Yellow;
			Console.ForegroundColor = ConsoleColor.Red;
			Console.Write("\n\n\nPress any key to exit...");
			Console.ReadKey();
		}
	}
}