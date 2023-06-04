using System;

namespace MyProgram
{
	class Program
	{
		static void Main(string[] args)
		{
			//Console.Write("Enter a number: ");
			//int number = Convert.ToInt32(Console.ReadLine());
			//if(number > 10)
			//{
			//	//NUMBER is greater than 10
			//	Console.Write("Your number is greater than 10");
			//}else if(number < 5)
			//{
			//	//Number is not greater than 10 and it is less than 5
			//	Console.WriteLine("Your number is less than 5");
			//}else
			//{
			//	//Number is not greater than 10 and it is not less than 5
			//	Console.WriteLine("Your number is between 5 and 10");
			//}

			Console.Write("What is your grade in high school? ");
			double grade = Convert.ToDouble(Console.ReadLine());
			Console.Write("How old are you? ");
			int age = Convert.ToInt32(Console.ReadLine());
			if(grade >= 85 && age >= 18)
			{
				//grade is greater than or equal to 85, AND age is greater than or equal to 18
				Console.WriteLine("You are eligable to study engineering!");
			}
			else
			{
				Console.WriteLine("You are NOT eligable to study engineering!");
			}

			//To prevent the program from exiting
			Console.BackgroundColor = ConsoleColor.Yellow;
			Console.ForegroundColor = ConsoleColor.Red;
			Console.Write("\n\n\nPress any key to exit...");
			Console.ReadKey();
		}
	}
}