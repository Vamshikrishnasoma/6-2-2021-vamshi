using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsprograms
{
    class Employee1
    {
        int EmpId;
        int Empsalary;
        string designation;
        public void ShowEmpDetails(int id,int salary,string designa)
        {
            EmpId = id;
            Empsalary = salary;
            designation = designa;
        }
        public void DisplayEmpDetails()
        {
            Console.WriteLine(EmpId);
            Console.WriteLine(Empsalary);
            Console.WriteLine(designation);
        }
    }
}
