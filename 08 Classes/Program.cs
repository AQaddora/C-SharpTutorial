using System;

namespace MyProgram
{
    class Player
	{
        public static int Count;
        public string name;
        public int health = 100;
        private int maxPower = 30;
        public bool isDead = false;
        public Player()
		{
            Count++;
		}
        public Player(string name)
		{
            this.name = name;
            Count++;
		}
        public void Attack(Player otherPlayer)
		{
            int amount = new Random().Next(0, maxPower);
            otherPlayer.TakeDamage(amount);
            Console.WriteLine(name + " has attacked " + otherPlayer.name + " by: " + amount);
		}
        public void TakeDamage(int amount)
		{
            health -= amount;
            if(health <= 0)
			{
                isDead = true;
                health = 0;
			}
		}
        public void Print()
		{
            Console.WriteLine(name + ": " + health);
		}
	}
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome to the game
            Console.Title = "FIGHT GAME";
            Console.WriteLine("Welcome to the FIGHT");
            //First player
            Console.Write("First player - Enter your name: ");
            Player firstPlayer = new Player(Console.ReadLine());
            //Second player
            Console.Write("Second player - Enter your name: ");
            Player secondPlayer = new Player(Console.ReadLine());
            //Decide who starts
            Random random = new Random();
            Player current, next;
            if(random.Next(0,100) > 50)
			{
                current = firstPlayer;
                next = secondPlayer;
			}
			else
			{
                current = secondPlayer;
                next = firstPlayer;
            }
            Console.WriteLine(current.name + ": START THE FIGHT");
            //Loop fight
            while(!firstPlayer.isDead && !secondPlayer.isDead)
			{
                Console.WriteLine(current.name + ": Press any key to ATTACK " + next.name + "!");
                Console.ReadKey();
                current.Attack(next);
                Console.WriteLine(firstPlayer.name + " [" + firstPlayer.health + "] : " + secondPlayer.name + " [" + secondPlayer.health + "]");
                Player temp = current;
                current = next;
                next = temp;
			}
			//Declare the winner
			if (firstPlayer.isDead)
			{
                Console.WriteLine(secondPlayer.name + " HAS WON!");
			}
			else
			{
                Console.WriteLine(firstPlayer.name + " HAS WON!");
			}
            //To prevent the program from exiting
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}