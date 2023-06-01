using System;

namespace MyProgram
{
	class Program
	{
		static void Main(string[] args)
		{
			//string name = "Ahmed";
			//int age = 25;
			//double height = 175.5;
			//float gpa = 97.8f;
			//bool isMarried = true;

			//Console.WriteLine("name: " + name);
			//Console.WriteLine("age: " + age);
			//Console.WriteLine("height: " + height);
			//Console.WriteLine("gpa: " + gpa);
			//Console.WriteLine("isMarried: " + isMarried);

			double exam1, exam2, exam3;
			Console.Write("Enter first exam grade: ");
			exam1 = Convert.ToDouble(Console.ReadLine());

			Console.Write("Enter second exam grade: ");
			exam2 = Convert.ToDouble(Console.ReadLine());

			Console.Write("Enter third exam grade: ");
			exam3 = Convert.ToDouble(Console.ReadLine());

			double avg = (exam1 + exam2 + exam3) / 3;
			Console.WriteLine("Avarage: " + avg);

			//To prevent the program from exiting
			Console.BackgroundColor = ConsoleColor.Yellow;
			Console.ForegroundColor = ConsoleColor.Red;
			Console.Write("\n\n\nPress any key to exit...");
			Console.ReadKey();
		}
	}
}