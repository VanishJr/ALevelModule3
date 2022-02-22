using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture1
{
    class MyListEnum<T> : IEnumerator
    {
        private T[] _array;
        int position = -1;

        public MyListEnum(T[] array)
        {
            _array = array;
        }
        public T Current
        {
            get
            {
                try
                {
                    return _array[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public bool MoveNext()
        {
            position++;
            return (position < _array.Length);
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
