using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fact
{
    class avg
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number:");
            int num = int.Parse(Console.ReadLine());
            int count = 0;
            int sum = 0;
            while (num != 0)
            {
                int digit = num % 10;
                sum = sum + digit;
                num = num / 10;
                count++;
            }
            double avg = sum / count;
            Console.WriteLine($"average of digits is:{avg}");
        }
    }
}
