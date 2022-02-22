using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture02
{
    class Class1
    {
        Class2 obj = new Class2();
        public delegate void Flag(bool some);

        public int pow(int a, int b)
        {
            return a * b;
        }
    }
}
