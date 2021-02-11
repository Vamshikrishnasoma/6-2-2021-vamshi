using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsprograms
{
    class Customer2
    {
        string Name;
        string Network;
        int amount;
        public void ShowCustomerInfo(string Name, String Network, int Amount)
        {
            this.Name = Name;
            this.Network = Network;
            this.amount = amount;
        }
        public void DisplayCustomerInfo()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Network);
            Console.WriteLine(amount);
        }
    }
}
