using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq_operations
{
    class Program
    {
        static void Main(string[] args)
        {



            // Find the words in the collection that start with the letter 'L'
            List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

            List<string> LFruits = fruits.Where(fruit => fruit.StartsWith("L")).ToList();
            //where n.StartsWith("S") 

            Console.WriteLine("----fruits with L-----");

            foreach (string fruit in LFruits)
            {
                Console.WriteLine(fruit);
            }

            Console.WriteLine();

            // Which of the following numbers are multiples of 4 or 6
            List<int> numbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            List<int> fourSixMultiples = numbers.Where(num => num % 4 == 0 || num % 6 == 0).ToList(); //didn't work without the ToList()
            // var result = list.Where(i => i%2 == 0);

            Console.WriteLine("----multiples of 4 & 6-----");

            foreach (int num in fourSixMultiples)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("----student names alphabetically-----");

            // Order these student names alphabetically, in descending order (Z to A)
            List<string> names = new List<string>()
            {
                "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
                "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
                "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
                "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
                "Francisco", "Tre"
            };

            List<string> descendingNames = names.OrderByDescending(name => name).ToList(); //specify the identity function (x => x you compare to itself

            foreach (string name in descendingNames)
            {
                Console.WriteLine(name);
            }
            //other way to write
            // IEnumerable<Product> inexpensive = from product in shoppingCart
            // where product.Price < 100.00
            // orderby product.Price descending
            // select product;

            Console.WriteLine("----numbers in ascending order-----");

            // Build a collection of these numbers sorted in ascending order
            List<int> numbersToOrder = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            List<int> ascendingNumbers = numbersToOrder.OrderBy(n => n).ToList(); //default is ascending

            foreach (int num in ascendingNumbers)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("----how many nums in this list?-----");

            // Output how many numbers are in this list
            List<int> bunchOfNumbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            int numberCount = bunchOfNumbers.Count();
            Console.WriteLine(numberCount);

            Console.WriteLine("----we made the following amount-----");

            // How much money have we made?
            List<double> purchases = new List<double>()
            {
                2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
            };

            double totalCost = purchases.Sum();
            Console.WriteLine(totalCost);

            Console.WriteLine("----our most expensive item costs-----");

            // What is our most expensive product?
            List<double> prices = new List<double>()
            {
                879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
            };

            double highestCost = prices.Max();
            // int biggest = nums.Max();
            Console.WriteLine(highestCost);


            Console.WriteLine("----the list of numbers before the perfect square-----");
            /*
            Store each number in the following List until a perfect square
            is detected.

            Ref: https://msdn.microsoft.com/en-us/library/system.math.sqrt(v=vs.110).aspx
            */
            List<int> wheresSquaredo = new List<int>()
            {
                66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
            };

            //taking the number while we don't have a perfect square. predicate= function that returns true/false
            List<int> numbersBeforeSquare = wheresSquaredo.TakeWhile(num =>
            {
                //return true if num is NOT a perfect square
                double sqrt = Math.Sqrt(num);
                return sqrt % 1 != 0;
            }).ToList();

            foreach (int num in numbersBeforeSquare)
            {
                Console.WriteLine(num);
            }

            //doesn't print anything out

            // double result = Math.Sqrt(numberToCheck);
            // bool isSquare = result % 1 == 0;

            Console.WriteLine("----the list of millionaires-----");

            List<Bank> banks = new List<Bank>() {
            new Bank(){ Name="First Tennessee", Symbol="FTB"},
            new Bank(){ Name="Wells Fargo", Symbol="WF"},
            new Bank(){ Name="Bank of America", Symbol="BOA"},
            new Bank(){ Name="Citibank", Symbol="CITI"},
        };

            // Create some customers and store in a List
            List<Customer> customers = new List<Customer>() {
            new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
            new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
            new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
            new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
            new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
            new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
            new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
            new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
            new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
            new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}
        };

            var millionaireReportItem = customers
                .Where(c => c.Balance >= 1000000)
        .GroupBy(c => c.Bank)
        .Select(group =>
        {
            return new millionaireReportItem
            {
                BankName = group.Key,
                MillionaireCount = group.Count() //how many customers are in that group
            };
        });

            var reportItems = customers
           .Where(c => c.Balance >= 1000000)
           .Join(
               banks,
               customer => customer.Bank, //will match this key with the one below
               bank => bank.Symbol, //keys
               (customer, bank) =>  //callback function. will give us the ones that match together. full objects
               {
                   return new ReportItem
                   {
                       CustomerName = customer.Name,
                       BankName = bank.Name
                   };
               })
               .OrderBy(reportItem =>
               {
                   return reportItem.CustomerName.Split(" ").Last();
               });


        }


        /*
            TASK:
            As in the previous exercise, you're going to output the millionaires,
            but you will also display the full name of the bank. You also need
            to sort the millionaires' names, ascending by their LAST name.

            Example output:
                Tina Fey at Citibank
                Joe Landy at Wells Fargo
                Sarah Ng at First Tennessee
                Les Paul at Wells Fargo
                Peg Vale at Bank of America
        */
        public class ReportItem
        {
            public string CustomerName { get; set; }
            public string BankName { get; set; }
        }

        // Define a bank
        public class Bank
        {
            public string Symbol { get; set; }
            public string Name { get; set; }
        }

        // Define a customer
        public class Customer
        {
            public string Name { get; set; }
            public double Balance { get; set; }
            public string Bank { get; set; }
        }

        public class millionaireReportItem
        {
            public string BankName { get; set; }
            public int MillionaireCount { get; set; }
        }

        //get only the millionaires


        // Create some banks and store in a List


        /*
            You will need to use the `Where()`
            and `Select()` methods to generate
            instances of the following class.
        */


    }
}
