﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Camp_Sigma_Software
{
    class Check //this class doesn't have a Parse Method, because it need for check only
    {
        public string Name { get; set; }
        public int BoughtNumber { get; set; }
        public double BoughtWeight { get; set; }
        public double BoughtPrice { get; set; }
        public Check(): this(null,0,0.0,0.0) { }
        public Check(string name, int boughtNumber, double boughtWeight, double boughtPrice)
        {
            Name = name;
            BoughtNumber = boughtNumber;
            BoughtWeight = boughtWeight;
            BoughtPrice = boughtPrice;
        }
        public void ClientInform(string name, int boughtNumber, double boughtWeight, double boughtPrice)
        {
            Console.WriteLine("You bought a " + boughtNumber + " of " + name + "." + '\n' +
                "Weight of product is " + boughtWeight + ". Please, pay " + boughtPrice + ". Thank you!");
        }
        public override string ToString()
        {
            return string.Format("Name: " + Name + " Number: " + BoughtNumber +
                " Weight: " + BoughtWeight + " Price: " + BoughtPrice);
        }
        public override bool Equals(object obj)
        {
            return Equals(obj as Check);
        }
        
    }
}
