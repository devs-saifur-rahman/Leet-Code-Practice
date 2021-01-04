﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Richest_Customer_Wealth
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public int MaximumWealth(int[][] accounts)
        {
            int maxWealth = 0;
            for (int customer = 0; customer < accounts.Length;customer++)
            {
                int sumOfWealth =  accounts[customer].Sum();
                maxWealth = sumOfWealth > maxWealth ? sumOfWealth : maxWealth;
            }
            return maxWealth;

        }
    }
}
