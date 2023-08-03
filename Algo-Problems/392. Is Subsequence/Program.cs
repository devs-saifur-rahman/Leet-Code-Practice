using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _392.Is_Subsequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
        }

        public int RemoveElement(int[] nums, int val)
        {
            int remainCounter = nums.Length;

            int start = 0, end = nums.Length - 1;

            while (start <= end)
            {
                if (nums[start] == val)
                {
                    int temp = nums[end];
                    nums[end] = nums[start];
                    nums[start] = temp;
                    remainCounter--;
                    end--;
                }
                else
                {
                    start++;
                }

            }
            return remainCounter;
        }

    }
}
