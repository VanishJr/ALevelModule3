using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Contact> EmployeeDictionary = new Dictionary<int, Contact>();

            EmployeeDictionary.Add(101, new Contact { ID = 101, FirstName = "Logutov", LastName = "Ivan", Phone = 0504783924 });
            EmployeeDictionary.Add(102, new Contact { ID = 102, FirstName = "Devil", LastName = "Morning Star", Phone = 0666666666 });
            EmployeeDictionary.Add(103, new Contact { ID = 103, FirstName = "Jesus", LastName = "Christ", Phone = 0777777777 });

            Console.WriteLine(EmployeeDictionary[101].Print());
            Console.WriteLine(EmployeeDictionary[102].Print());
            Console.WriteLine(EmployeeDictionary[103].Print());

            Console.ReadLine();
        }
    }
}