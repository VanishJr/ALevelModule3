using System;

namespace lecture02
{
    class Program
    {
        static void Main()
        {
            var obj = new Program();
            obj.Show();
        }


        public int Show()
        {
            Class2 obj = new Class2();
            Console.WriteLine(obj.Result(3));
            return 0;
        }
    }
}
