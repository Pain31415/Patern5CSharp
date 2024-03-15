﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern5CSharp
{
    public class Investor : IObserver
    {
        private string name;

        public Investor(string name)
        {
            this.name = name;
        }

        public void Update(string stockSymbol, decimal stockPrice)
        {
            Console.WriteLine($"{name} received update: {stockSymbol} - {stockPrice}");
        }
    }
}
