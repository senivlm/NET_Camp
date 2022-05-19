using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Camp_Sigma_Software
{
    public class Product
    {
        private string price;
        private string name;
        private double weight;
       
        public string Name { get; set; }
        public double Weight { get; set; }
        public int Price { get; set; }
        public Product(): this(null, 0, 0.0) { }
        public Product(string name, int price, double weight)
        {
            Name = name;
            Weight = weight;
            Price = price;
        }
        public virtual int ChangePrice(int rate)
        {
            Price = (int)(Price * rate / 100.0);
            return Price;
        }
        public override string ToString()
        {
            return string.Format("Name: " + name, 
                " Price: " + price, " Weight: " + weight);
        }
    }
}
