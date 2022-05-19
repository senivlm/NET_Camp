using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Camp_Sigma_Software
{
    class Dairy_products : Product
    {
        int expirationDate;
        int expirationDateCoef;
        public Dairy_products():this(null, 0, 0.0) { }
        public Dairy_products(string name, int price, double weight) : base(name, price, weight) { }
        public int ExpirationDate
        {
            get { return expirationDate; }
            set { expirationDate = value; }
        }
        public override int ChangePrice(int rate)
        {
            Price = Price + (int)(Price * rate / 100.0) + expirationDateCoef;
            return Price;
        }
        public override string ToString()
        {
            return base.ToString() + " Date of expiration: " + expirationDate;
        }

    }
}
