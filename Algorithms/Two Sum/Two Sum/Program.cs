using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sl = new Solution();

            int[] nums = { 2, 7, 11, 15 };
            int target = 9;

            int[] result = sl.TwoSum(nums, target);
            Console.ReadLine();

        }
    }
}
