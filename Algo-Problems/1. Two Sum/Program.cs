using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Two_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        //480 ms	31.3 MB
        public int[] TwoSum(int[] nums, int target)
        {
            int[] result = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {
                int searchFor = target - nums[i];
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    if (nums[j] == searchFor)
                    {
                        result[0] = i;
                        result[1] = j;
                        break;
                    }
                }
            }

            return result;
        }
    }
}
