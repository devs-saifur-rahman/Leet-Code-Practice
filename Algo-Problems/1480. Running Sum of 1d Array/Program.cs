using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1480.Running_Sum_of_1d_Array
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        //236 ms	30.4 MB
        public int[] RunningSum(int[] nums)
        {
            int[] result = new int[nums.Length];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = nums[i] + (i - 1 >= 0 ? result[i - 1] : 0);
            }

            return result;
        }
    }
}
