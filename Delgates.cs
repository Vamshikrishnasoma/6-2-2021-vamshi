using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopstatements
{
    public delegate void Delegate(int p, int q);
    class Example
    {
        public void sum(int num1,int num2)
        {
            Console.WriteLine(num1+num2);
        }
        public void sub(int num1, int num2)
        {
            Console.WriteLine(num1 - num2);
        }
        public void Mul(int num1, int num2)
        {
            Console.WriteLine(num1 * num2);
        }
    }

    class Delgates
    {
        static void Main(string[] args)
        {
            Delegate d = new Delegate(new Example().sum);

            Delegate p = new Delegate(new Example().sub);

            Delegate q = new Delegate(new Example().Mul);
            d(4, 6);
            p(9, 6);
            q(7, 6);
            Delegate v = d + p + q;
            v(4, 6);

        }
    }
}
