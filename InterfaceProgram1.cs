﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopstatements
{
    class addition
    {
        public void add(int num1,int num2)
        {
            Console.WriteLine(num1+num2);
        }
    }
    interface substraction
    {
        void sub(int num1, int num2);
    }
    interface Multiplication
    {
        void mul(int num1, int num2);
     }
    class Impliment:addition,substraction,Multiplication
    {
        public void sub(int num1,int num2)
        {
            Console.WriteLine(num1-num2);
        }
        public void  mul(int num1,int num2)
        {
            Console.WriteLine(num1*num2);
        }
    }
    class InterfaceProgram1
    {
        static void Main(string[] args)
        {
            Impliment i = new Impliment();
            i.sub(9, 6);
            i.add(9, 6);
            i.mul(9, 6);
        }

    }
}
