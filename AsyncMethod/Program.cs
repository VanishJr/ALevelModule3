using System;
using System.Collections.Generic;

namespace AsyncMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                numbers.Add(i);
            }
            foreach (int num in numbers)
            {
                Console.WriteLine(num + " ");
            }
            Console.WriteLine("\nAddRange");

            numbers.AddRange(numbers);
            foreach (int num in numbers)
            {
                Console.WriteLine(num + " ");
            }
            Console.WriteLine("\nRemove");
            numbers.Remove(2);

            foreach (int num in numbers)
            {
                Console.WriteLine(num + " ");
            }
            Console.WriteLine("\nRemoveAt");
            numbers.RemoveAt(1);
            foreach (int num in numbers)
            {
                Console.WriteLine(num + " ");
            }
            Console.WriteLine("\nSort");
            numbers.Sort();
            foreach (int num in numbers)
            {
                Console.WriteLine(num + " ");
            }
            Process obj = new Process();
            _ = obj.TwoMethods();
        }
    }
}
