﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopstatements
{
    interface Mobile
        {
        void price();
        }
    class samsung : Mobile
    {
        public void price()
        {
            Console.WriteLine("samsung price is 21000");
        }
    }
        class nokia : Mobile
        {
            public void price()
            {
                Console.WriteLine("Nokia price is 12000A");
            }
        }
    class InterfaceProgram
    {
        static void Main(string[] args)
        {
            Mobile s = new samsung();
            s.price();
            Mobile n = new nokia();
            n.price();
        }
    }
}
