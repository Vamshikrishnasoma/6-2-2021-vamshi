using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopstatements
{
    class Product
    {
        int pId;
        string pName;
        Double pPrice;
    public Product()
        {
            pId = 0;
            pName = string.Empty;
            pPrice = 0;
        }
        public Product(string pName)
        {
            this.pName = pName;
        }
        public Product(int pId)
        {
            this.pId = pId;
        }
        public Product(int pId,String pName,Double pPrice)
        {
            this.pId = pId;
            this.pName = pName;
            this.pPrice = pPrice;
        }
        public Product(Product p)
        {
            this.pId = p.pId;
            this.pName = p.pName;
            this.pPrice = p.pPrice;
        }
        public void ShowValues()
        {
            Console.WriteLine($"{pId}\t{pName}\t{pPrice}");
        }
    }

    class Constructor
    {
        static void Main(string[] args)
        {
            Product p = new Product(543);
            p.ShowValues();
            Console.WriteLine("=====s object=======");
            Product q = new Product(573, "lenovo", 73632);
            q.ShowValues();
            Product s = new Product(q);
            s.ShowValues();

        }
    }
}
