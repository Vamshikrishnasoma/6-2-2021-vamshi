using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fact
{
    class Class2
    {
        static void Main(string[] args)
        {
            Console.Write("Enter range:");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine(i);
                sum = sum + i;
            }
            Console.WriteLine(sum);
        }
    }
}
