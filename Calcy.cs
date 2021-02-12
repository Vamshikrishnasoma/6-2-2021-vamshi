using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopstatements
{
    class BasicCalcy
    {
        public void sum(int num1,int num2)
        {
            Console.WriteLine($"Sum is:{num1 + num2}");
        }
        public void Sub(int num1, int num2)
        {
            Console.WriteLine($"Sub is:{num1 - num2}");
        }
        public void Mul(int num1, int num2)
        {
            Console.WriteLine($"Mul is:{num1 * num2}");
        }

    }
    class scicalcy:BasicCalcy
    {
        public void sin(int num)
        {
            Console.WriteLine(Math.Sin(num));
        }
        public void cos(int num)
        {
            Console.WriteLine(Math.Cos(num));
        }
    }

    class Calcy
    {
        static void Main(string[] args)
        {
            scicalcy s1 = new scicalcy();
            s1.cos(0);
            s1.sin(90);
            s1.sum(26, 29);
            s1.Mul(6 , 9);
        }
    }
}
