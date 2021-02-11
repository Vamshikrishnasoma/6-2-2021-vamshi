using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsprograms
{
    class customer1
    {
        string Name;
        string Network;
        int amount;
        public void ShowCustomerInfo(string CusName,String CusNetwork,int RechargeAmount)
        {
            Name = CusName;
            Network = CusNetwork;
            amount = RechargeAmount;
        }
        public void DisplayCustomerInfo()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Network);
            Console.WriteLine(amount);
        }
    }
}
