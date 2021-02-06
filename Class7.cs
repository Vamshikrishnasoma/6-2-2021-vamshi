using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fact
{
    class Class7
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number:");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            for(int i=1;i<num;i++)
            {
                if(num%i==0)
                {
                    sum = sum + i;
                }
            }
            if (num == sum)
            {
                Console.WriteLine("Perfect number");
            }
            else
            {
                Console.WriteLine("Not a perefct number");
            }
        }
    }
}
