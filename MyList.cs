using System;
using System.Collections;
using System.Linq;

namespace lecture1
{
    class MyList<T> : IEnumerable
    {
        private int n = 0;
        private T[] masiv = new T[] { };
        public int Count { get; private set; }

        public void Add(T value)
        {
            n++;
            Array.Resize<T>(ref masiv, n);
            masiv[Count] = value;
            Count++;
        }

        public void AddRange(T[] value)
        {
            n += value.Length;
            Array.Resize<T>(ref masiv, n);
            for (int i = 0; i < value.Length; i++)
            {
                masiv[Count] = value[i];
                Count++;
            }
        }
        public bool Remove(T value)
        {
            bool anyNull = masiv.Any(c => c.Equals(value));
            if (anyNull == true)
            {
                masiv = masiv.Where((source, index) => !source.Equals(value)).ToArray();
                n = masiv.Length;
                Count--;
                return true;
            }
            return false;
        }
        public void RemoveAt(int indexRemove)
        {
            if (masiv.Length > indexRemove)
            {
                masiv = masiv.Where((source, index) => index != indexRemove).ToArray();
                n = masiv.Length;
                Count--;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        public void Print()
        {
            foreach (var item in masiv)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public void Sort()
        {
            Array.Sort(masiv);
        }

        public IEnumerator GetEnumerator()
        {
            return new MyListEnum<T>(masiv);
        }
    }
}
