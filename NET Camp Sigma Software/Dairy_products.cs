﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Camp_Sigma_Software
{
    class Dairy_products : Product
    {
        public DateTime ExpirationDate { get; set; }
        public Dairy_products() : this(null, 0.0, default(DateTime), 0.0) { }
        public Dairy_products(string name, double weight, DateTime expirationDate, double price) 
            : base(name, weight, price)
        {
            ExpirationDate = expirationDate;
        }
       
        public override double ChangePrice(int rate)
        {
            Price = Price + (double)(Price * rate / 100.0);
            return Price;
        }
        public override string ToString()
        {
            return base.ToString() + " Date of expiration: " + ExpirationDate;
        }
        public override bool Equals(object obj)
        {
            return Equals(obj as Dairy_products);
        }
        public override void Parse(string str)
        {
            base.Parse(str);
            string dateString = null;
            DateTime.Parse(dateString);
        }

    }
}
