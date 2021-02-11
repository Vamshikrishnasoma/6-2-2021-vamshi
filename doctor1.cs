using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsprograms
{
    class doctor1
    {
        int fee;
        string name;
        long contact;
        public void ShowDoc1(int fee, string name, long contact)
        {
            this.fee = fee;
            this.name = name;
            this.contact = contact;
        }
        public void displaydoc1()
        {
            Console.WriteLine($"Fee is:{fee}");
            Console.WriteLine(name);
            Console.WriteLine(contact);
        }
    }
}
