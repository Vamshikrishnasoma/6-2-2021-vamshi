using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopstatements
{
    class parent
    {
        public void Display()
        {
            Console.WriteLine("Hello");
        }
        public virtual void Show()
        {
            Console.WriteLine("Hello .Net");
        }
    }
    class child:parent
    {
        public override void Show()
        {
            Console.WriteLine("child");
        }
    }
    class Moverriding
    {
        static void Main(string[] args)
        {
            parent p = new parent();
            p.Show();
            p=new child();
            p.Show();
        }
    }
}
