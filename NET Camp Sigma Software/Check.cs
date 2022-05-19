using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Camp_Sigma_Software
{
    class Check
    {
        public Check() { }
        public void ClientInform(string name, int boughtNumber, int boughtPrice, double boughtWeight)
        {
            Console.WriteLine("You bought a " + boughtNumber + " of " + name + "." + '\n' +
                "Weight of product is " + boughtWeight + ". Please, pay " + boughtPrice + ". Thank you!");
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
