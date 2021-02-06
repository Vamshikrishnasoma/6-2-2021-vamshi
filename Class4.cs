using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fact
{
    class digits
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a number:");
            int num = int.Parse(Console.ReadLine());
            while (num != 0)
            {
                int digit = num % 10;
                num = num / 10;
                Console.WriteLine(digit);
            }
        }
    }
}
