using System;

namespace MyProgram
{
	class Program
	{
		static void Main(string[] args)
		{
			PrintMessage();
			int z = Multiply(50, 5);
			Console.WriteLine("Z: " + z);
			//To prevent the program from exiting
			Console.BackgroundColor = ConsoleColor.Yellow;
			Console.ForegroundColor = ConsoleColor.Red;
			Console.Write("\n\nPress any key to exit...");
			Console.ReadKey();
		}

		static void PrintMessage()
		{
			Console.WriteLine("Hello, I am a Method");
		}

		static int Multiply(int x, int y)
		{
			return x * y;
		}
	}
}