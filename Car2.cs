using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsprograms
{
    class Car2
    {
        long price;
        string model;
        int year;
        public void Showcar2(long price, string model, int year)
        {
            this.price = price;
            this.model = model;
            this.year = year;
        }
        public void DisplayCar2()
        {
            Console.WriteLine(price);
            Console.WriteLine(model);
            Console.WriteLine(year);
        }
    }
}
