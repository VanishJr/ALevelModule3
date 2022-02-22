using System;

namespace lecture1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<Person> my = new MyList<Person>();
            my.Add(new Person { Name = "Alex", Age = 28 });
            my.Add(new Person { Name = "Vanya", Age = 33 });
            my.Add(new Person { Name = "John", Age = 29 });
            Console.WriteLine("MyList after metod Add:");
            my.Print();
            Person[] arr = { new Person { Name = "Roma", Age = 23 }, new Person { Name = "Igor", Age = 27 } };
            my.AddRange(arr);
            Console.WriteLine("MyList after metod AddRange:");
            my.Print();
            my.Remove(new Person { Name = "Roma", Age = 23 });
            Console.WriteLine("MyList after metod Remove:");
            my.Print();
            my.Add(new Person { Name = "Mark", Age = 24 });
            Console.WriteLine("MyList after metod Add:");
            my.Print();
            my.RemoveAt(1);
            Console.WriteLine("MyList after metod RemoveAt:");
            my.Print();
            my.Add(new Person { Name = "Sem", Age = 24 });
            Console.WriteLine("MyList after metod Add:");
            my.Print();
            my.Sort();
            Console.WriteLine("MyList after metod Sort:");
            my.Print();
        }
    }
}
