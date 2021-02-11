using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsprograms
{
    class Oopsprogram
    {
        static void Main(string[] args)
        {
            Doctor d1 = new Doctor();
            d1.ShowDoctor("mani jyothi", 2000, "neuro");
            d1.DisplayDoctor();
            Console.WriteLine("------------------------------------");
            doctor1 d2 = new doctor1();
            d2.ShowDoc1(2500, "Aishwarya", 8364734641);
            d2.displaydoc1();
            Console.WriteLine("------------------------------------");
            Car c1 = new Car();
            c1.Showcar(2426299, "harrier", 2020);
            c1.DisplayCar();
            Console.WriteLine("------------------------------------");
            Car c2 = new Car();
            c2.Showcar(1226299, "altroz", 2019);
            c2.DisplayCar();
            Console.WriteLine("------------------------------------");
            Employee1 e1 = new Employee1();
            e1.ShowEmpDetails(17535, 50000, "Trainer");
            e1.DisplayEmpDetails();
            Console.WriteLine("------------------------------------");
            Employee1 e2 = new Employee1();
            e2.ShowEmpDetails(83635, 15000, "Trainee");
            e2.DisplayEmpDetails();
            Console.WriteLine("------------------------------------");
            customer1 cus1 = new customer1();
            cus1.ShowCustomerInfo("Maniteja", "Idea", 399);
            cus1.DisplayCustomerInfo();
            Console.WriteLine("------------------------------------");
            customer1 cus2 = new customer1();
            cus2.ShowCustomerInfo("Balu", "Airtel", 599);
            cus2.DisplayCustomerInfo();
            Console.WriteLine("------------------------------------");
            laptop1 l1 = new laptop1();
            l1.showlaptopdetails(8, 45000, "lenovo");
            l1.DisplaylapDetails();
            Console.WriteLine("------------------------------------");
            laptop1 l2 = new laptop1();
            l2.showlaptopdetails(4, 35500, "dell");
            l2.DisplaylapDetails();
        }
    }
}
