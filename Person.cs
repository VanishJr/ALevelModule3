using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture1
{
    class Person : IComparable
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"Person: {Name} - {Age} years";
        }

        public override bool Equals(object value)
        {
            if (value == null)
            {
                return false;
            }

            Person person = value as Person;

            return (person != null)
                && (Name == person.Name)
                && (Age == person.Age);
        }
        public override int GetHashCode()
        {
            return Name.GetHashCode() ^ Age.GetHashCode();
        }

        public int CompareTo(object obj)
        {
            Person p = obj as Person;
            if (p != null)
                return this.Name.CompareTo(p.Name);
            else
                throw new Exception("Невозможно сравнить два объекта");
        }
    }

}

