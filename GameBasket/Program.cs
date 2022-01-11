using System;

namespace GameBasket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Game!\n" +
                "by Ivan Logutov\n" +
                "_________________");

            var game = new Game();

            var menu = true;

            while (menu)
            {
                Console.WriteLine("\nPlease choose what do you want to do:\n" +
                    "1. Play Game;\n" +
                    "2. Exit;\n");
                Console.Write("Enter number of your choice:");

                var choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        game.TheGame();
                        break;
                    case 2:
                        Console.WriteLine("Good Buy!");
                        menu = false;
                        break;
                }
            }

        }
    }
}
