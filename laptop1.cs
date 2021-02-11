using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsprograms
{
    class laptop1
    {
        int ram;
        int price;
        string brand;
        public void showlaptopdetails(int lapram,int lapprice,string lapbrand)
        {
            ram = lapram;
            price = lapprice;
            brand = lapbrand;
        }
        public void DisplaylapDetails()
        {
            Console.WriteLine(ram);
            Console.WriteLine(price);
            Console.WriteLine(brand);
        }
    }
}
