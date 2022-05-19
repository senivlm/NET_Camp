using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Camp_Sigma_Software
{
    class Storage
    {
        public int ProductsAmount { get; set; }
        public int TotalPrice { get; set; }
        public double TotalWeight { get; set; }
        public Product[] AllProducts { get; set; }
        public Storage()
        {
            ProductsAmount = 0;
            TotalPrice = 0;
            TotalWeight = 0.0;
            AllProducts = new Product[] { };
        }
        void UserDialogue()
        {
            Console.WriteLine("Enter your product");
            string product = Console.ReadLine();

        }
        void Initialization(string name, int price, double weight)
        {
            Product product = new Product(name, price, weight);
        }
        void Print(Product[] products)
        {
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine("Product: " + products[i].Name + '\n' +
                    "Price: " + products[i].Price + '\n' +
                    "Weight: " + products[i].Weight);
            }
        }
        void FindMeat(Product[] products)
        {
           
        }
        public void ChangePrice(Product[] products, int rate)
        {
            for (int i = 0; i < products.Length; i++)
            {
                products[i].Price = products[i].Price + (products[i].Price * rate / 100);
            }
        }
        //Product this[int index]
        //{
        //    get { return products[index]; }
        //    set { products[index] = value; }
        //}
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
