using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsprograms
{
    class Doctor
    {
        string name;
        int consulationfee;
        string specilization;
        public void ShowDoctor(string DName,int fee,string Spl)
        {
            name =DName;
            consulationfee = fee;
            specilization= Spl ;
        }
        public void DisplayDoctor()
        {
            Console.WriteLine(name);
            Console.WriteLine(consulationfee);
            Console.WriteLine(specilization);
        }
    }
}
