using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Camp_Sigma_Software
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product("chupakabra", 100, 90.5);
            Buy buyer = new Buy(10, 1000, 905);
            Check check = new Check();
            check.ClientInform(product.Name, buyer.BoughtNumber, buyer.BoughtPrice, buyer.BoughtWeight);

            Console.ReadLine();
        }
    }
}
