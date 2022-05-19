using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Camp_Sigma_Software
{
    public class Meat : Product
    {
        public Category MeatCategory { get; set; }
        public Type MeatType { get; set; }
        public Meat() { }
        //public Meat(Category meatCategory, Type meatType) : base(name, price, weight)
        //{
        //    MeatCategory = meatCategory;
        //    MeatType = meatType;
        //}
        public override int ChangePrice(int rate)
        {
            Console.WriteLine("Enter your category");
            string category = Console.ReadLine();
            switch (category)
            {
                case "extra":
                    Price = Price + (Price * rate / 100) + (int)Category.extra;
                    break;
                case "sort1":
                    Price = Price + (Price * rate / 100) + (int)Category.sort1;
                    break;
                case "sort2":
                    Price = Price + (Price * rate / 100) + (int)Category.sort2;
                    break;
                default:
                    Console.WriteLine("Wrong enter!");
                    break;
            }
            return Price;
        }
        public override string ToString()
        {
            return base.ToString() + " Meat category: "; 
        }

    }
}
