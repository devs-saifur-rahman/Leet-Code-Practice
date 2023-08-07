using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _121.Best_Time_to_Buy_and_Sell_Stock
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        public int MaxProfit(int[] prices)
        {
            int maxProfit = 0;
            int minPrice = prices[0];
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] < minPrice)
                {
                    minPrice = prices[i];
                }
                if (prices[i]-minPrice > maxProfit)
                {
                    maxProfit = prices[i] - minPrice;
                }
            }
            return maxProfit;
        }


        //works but gets Time Limit Exceed
        //public int MaxProfit(int[] prices)
        //{
        //    int maxProfit = 0;
        //    for (int i = 0; i < prices.Length; i++)
        //    {
        //        for (int j = i + 1; j < prices.Length; j++)
        //        {
        //            int diff = prices[j] - prices[i];
        //            maxProfit = diff < maxProfit ? maxProfit : diff;
        //        }
        //    }
        //    return maxProfit;
        //}
    }
}
