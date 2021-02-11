using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsprograms
{
    class laptop2
    {
        int ram;
        int price;
        string brand;
        public void showlaptopdetails(int ram, int price, string brand)
        {
            this.ram = ram;
            this.price = price;
            this.brand = brand;
        }
        public void DisplaylapDetails()
        {
            Console.WriteLine(ram);
            Console.WriteLine(price);
            Console.WriteLine(brand);
        }
    }
}
