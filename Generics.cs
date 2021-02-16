using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopstatements
{
    class Gen<V>
    {
        public void Sum(V num1,V num2)
        {
            Console.WriteLine($"num1={num1} \t num2={num2}.");
        }
    }
    class Generics
    {
        static void Main(string[] args)
        {
            Gen<int> g = new Gen<int>();
            g.Sum(8, 7);
            Gen<float> h = new Gen<float>();
            h.Sum(8.85f, 7.735f);
            Gen<string> s = new Gen<string>();
            s.Sum("Vamshi","Krishna");

        }
    }
}
