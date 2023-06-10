using System;

namespace MyProgram
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "My first program";
			string username = AskForInput("Hello, My name is Ahmed.\nWhat's your name?!");
			BotMessage("Hello, " + username + "! Nice to meet you.");
			string age = AskForInput("How old are you?");
			BotMessage("I am 35 YO!");

			//To prevent the program from exiting
			Console.BackgroundColor = ConsoleColor.Yellow;
			Console.ForegroundColor = ConsoleColor.Red;
			Console.Write("\n\n\nPress any key to exit...");
			Console.ReadKey();
		}
		static string AskForInput(string prompt)
		{
			BotMessage(prompt);
			Console.BackgroundColor = ConsoleColor.Black;
			Console.ForegroundColor = ConsoleColor.White;
			return Console.ReadLine();
		}
		static void BotMessage(string message)
		{
			Console.BackgroundColor = ConsoleColor.White;
			Console.ForegroundColor = ConsoleColor.Black;
			Console.WriteLine(message);
		}
	}
}