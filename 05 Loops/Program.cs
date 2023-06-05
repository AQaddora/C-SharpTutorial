using System;

namespace MyProgram
{
	class Program
	{
		static void Main(string[] args)
		{
			// x++ -> x = x + 1
			// x-- -> x = x -1
			// x += 2 - > x = x + 2

			//for(int x = 1; x <= 5; x++)
			//{
			//	Console.WriteLine(x);

			//	//x++
			//}

			//int i = 1;
			//while (i <= 5)
			//{
			//	Console.WriteLine(i);
			//	i++;
			//}

			//int x = 1;
			//do
			//{
			//	Console.WriteLine(x);
			//	x++;
			//} while (x < 0);

			do
			{
				Console.Write("Enter the number: ");
				int target = Convert.ToInt32(Console.ReadLine());

				int result = 0;
				for (int i = 0; i <= target; i++)
				{
					result += i;
				}
				Console.WriteLine("Result is: " + result);
				Console.WriteLine("Do you want to continue? YES/NO:");
			} while (Console.ReadLine() == "YES");
			

			//To prevent the program from exiting
			Console.BackgroundColor = ConsoleColor.Yellow;
			Console.ForegroundColor = ConsoleColor.Red;
			Console.Write("\n\nPress any key to exit...");
			Console.ReadKey();
		}
	}
}