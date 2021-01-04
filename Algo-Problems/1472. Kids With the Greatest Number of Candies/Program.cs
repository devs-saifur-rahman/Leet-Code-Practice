using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1472.Kids_With_the_Greatest_Number_of_Candies
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        // 252 ms	31.3 MB
       /* public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            return candies.Select(x => (x + extraCandies) >= candies.Max()).ToList();
        }*/

        //236 ms	31.1 MB
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            int max = candies.Max();
            return candies.Select(x => (x + extraCandies) >= max).ToList();
        }
    }
}
