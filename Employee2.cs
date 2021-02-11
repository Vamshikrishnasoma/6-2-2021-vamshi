using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsprograms
{
    class Employee2
    {
        int Id;
        int salary;
        string designation;
        public void ShowEmpDetails(int id, int salary, string designation)
        {
            this.Id = id;
            this.salary = salary;
            this.designation = designation;
        }
        public void DisplayEmpDetails()
        {
            Console.WriteLine(Id);
            Console.WriteLine(salary);
            Console.WriteLine(designation);
        }
    }
}
