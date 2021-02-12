using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopstatements
{
    class ReverseNumber
    {

        public static int Reverse(int num)
        {
            int rev = 0;
            while (num > 0)
            {
                int digit = num % 10;
                rev = rev * 10 + digit;
                num = num / 10;
            }
            return rev;
        }
        public static int Sum(int num1, int num2) 
        {
            return num1 + num2;
        }
        static void Main(string[] args)
        {
            
            Console.WriteLine(Sum(9,6));
            Console.WriteLine(Reverse(736));
            Console.WriteLine(Reverse(456));
        }
    }
}
