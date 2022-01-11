using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBasket
{
    class Game
    {
        public void TheGame() 
        {
            int weight = new Random().Next(100) + 40, m;
            int attempts = 100;
            char c = '0';

            string nick1, nick2;

            Console.WriteLine("First player, enter your nickname");
            nick1 = Console.ReadLine();
            Console.WriteLine("Second player, enter your nickname");
            nick2 = Console.ReadLine();

            bool f = true;

        text: //introductory text for the user
            Console.WriteLine("Game \"Guess the basket size\".");
            Console.WriteLine("The computer \"conceived\"weight between 40 до 140.");
            Console.WriteLine("Guess it in 100 tries.");
            Console.WriteLine("Enter a number and press <Enter>");
            Console.WriteLine();
            
                while (weight > 0)
                {
                    Console.WriteLine("{0}, your move", f ? nick1: nick2);
                    Console.Write("-> ");
                    int input = int.Parse(Console.ReadLine());
                    if (input == weight)
                    {
                        Console.WriteLine();
                        Console.WriteLine("You guessed the number!");
                        Console.WriteLine();
                        Console.WriteLine("Thanks for playing!");
                        goto done;
                    }
                    if (input > weight)
                    {
                        Console.WriteLine("You have entered a larger number! Please enter a number from 40 to 140.");
                    }
                    if (input != weight && input < weight)
                    {
                        Console.WriteLine("You entered the number below the correct one! Please enter a number from 40 to 140.");
                    }
                    else
                    {
                        Random rand = new Random();
                        m = rand.Next(40, 140); 
                        Console.WriteLine(nick2 + " made a choice " + m);
                    }
                }
            
            while (attempts != 100);

            Console.WriteLine();
            Console.WriteLine("You failed! Try again!");
            Console.WriteLine();
            Console.WriteLine("Want to play again? (y/n)");
            c = Convert.ToChar(Console.ReadLine());
            if (c == 'y')
                goto text;

            done:
            Console.ReadKey();

        }
    }
}
