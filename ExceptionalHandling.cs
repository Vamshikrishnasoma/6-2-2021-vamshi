using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopstatements
{
    class ExceptionalHandling
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter a Number:");
                    int num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter another Number:");
                    int num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine(num1 * num2);
                    Console.WriteLine(num1 / num2);
                }
                catch (FormatException fx)
                {
                    Console.WriteLine("Enter numbers only\n" + fx);
                }
                catch (DivideByZeroException dx)
                {
                    Console.WriteLine("Dont enter second number as zero\n" + dx);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
               
            }
        }
    }
}
