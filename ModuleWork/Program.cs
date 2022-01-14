using System;
using System.Collections.Generic;
using System.Linq;


namespace ModuleWork
{
    public delegate void MyDelegate();
    

    class Program
    {
        

        static void Main(string[] args)
        {
            MyDelegate myDelegate = Method1;
            myDelegate += Method2;
            myDelegate += Method3;
            myDelegate += Method4;

            myDelegate();
            Console.ReadLine();
        }

        static  void Method1()
        {

            List<int> numbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            Console.WriteLine("---let's show the initial data array---");


            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine();

        }

        public async static void Method2()
        {
            List<int> numbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            List<int> fourSixMultiples = numbers.Where(num => num % 3 == 0 || num % 5 == 0).ToList();

            Console.WriteLine("----multiples of 3 & 5-----");

            foreach (int num in fourSixMultiples)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine();
        }

        public async static void Method3()
        {
            List<int> numbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            List<int> takeThreeSymbols = numbers.Take(3).ToList();

            Console.WriteLine("---take first 3 symbols---");

            foreach (int num in takeThreeSymbols)
            {
                Console.WriteLine(num);
            }
        }

        public async static void Method4()
        {
            List<int> numbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            List<int> ascendingNumbers = numbers.OrderBy(n => n).ToList(); //default is ascending

            Console.WriteLine("----numbers in ascending order-----");

            foreach (int num in ascendingNumbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
