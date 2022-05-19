using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Camp_Sigma_Software
{
    class Buy
    {
        private int boughtNumber;
        private int boughtPrice;
        private double boughtWeight;
        public Buy() : this(0, 0, 0.0) { }

        public Buy(int boughtNumber, int boughtPrice, double boughtWeight)
        {
            this.boughtNumber = boughtNumber;
            this.boughtPrice = boughtPrice;
            this.boughtWeight = boughtWeight;   
        }
        public int BoughtNumber
        {
            get { return boughtNumber; }
            set { boughtNumber = value; }
        }
        public int BoughtPrice
        {
            get { return boughtPrice; }
            set { boughtPrice = value; }
        }
        public double BoughtWeight
        {
            get { return boughtWeight; }
            set { boughtWeight = value; }
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
