using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fact
{
    class Countofdigit
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number:");
            int num = int.Parse(Console.ReadLine());
            int count = 0;
            while (num != 0)
            {
                int digit = num % 10;
                num = num / 10;
                count++;
            }
            Console.WriteLine($"Count of digits is:{count}");
        }
    }
}
