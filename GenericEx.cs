using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopstatements
{
    class Gen1<A1,A2>
    {
        public void show(A1 x,A2 y)
        {
            Console.WriteLine($"{x} \t {y}");
        }
    }
    class GenericEx
    {
        static void Main(string[] args)
        {
            Gen1<int, double> a = new Gen1<int, double>();
            a.show(12,98.21);
            Gen1<string, int> v = new Gen1<string, int>();
            v.show("Krishna", 87);
            Gen1<double, string> m = new Gen1<double, string>();
            m.show(76.12, "mani");
        }
    }
}
