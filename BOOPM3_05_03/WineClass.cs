﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOPM3_05_03
{
    //Implementation of IWine as a class
    public class WineClass : IWine
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        override public string ToString() => $"{nameof(Name)}: {Name}, {nameof(Year)}: {Year}, {nameof(Price)}: {Price:N2}";

        public WineClass(string name, int year, decimal price)
        {
            (Name, Year, Price) = (name, year, price);
        }
    }
}
