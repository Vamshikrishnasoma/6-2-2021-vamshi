using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopstatements
{
    class InvalidAgeException : Exception
    {
        public InvalidAgeException()
        {
            Console.WriteLine(this.GetType()+" : Invalid Age");
        }
    }
}
