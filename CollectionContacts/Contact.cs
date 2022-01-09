using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactDictionary
{
    class Contact
    {
        public string FirstName;
        public string LastName;
        public int ID;
        public int Phone;
        public string Print()
        {
            return ID + ":  " + FirstName + " " + LastName + " " + Phone;
        }
    }
}