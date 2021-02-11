using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsprograms
{
    class Car
    {

        long price;
        string model;
        int year;
        public void Showcar(long carprice,string carmodel,int caryear)
        {
            price = carprice;
            model = carmodel;
            year = caryear;
        }
        public void DisplayCar()
        {
            Console.WriteLine(price);
            Console.WriteLine(model);
            Console.WriteLine(year);
        }
    }
}
