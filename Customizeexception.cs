using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopstatements
{
    class Customizeexception
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter age:");
                int age = int.Parse(Console.ReadLine());
                if (age < 0 || age > 150)
                {
                    throw new InvalidAgeException();
                }
            }
        }
    }
}
