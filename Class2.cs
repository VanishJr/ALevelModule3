using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture02
{
    class Class2
    {
        private int res;
        public delegate int GetPow(int a, int b);
        public bool Calc()
        {
            var obj = new Class1();
            int a = 2, b = 3;
            GetPow getint = obj.pow;
            res = getint.Invoke(a, b);
            Console.WriteLine(res);
            return true;

        }
        public bool Result(int c = 2)
        {
            Calc();
            if (res % c == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
