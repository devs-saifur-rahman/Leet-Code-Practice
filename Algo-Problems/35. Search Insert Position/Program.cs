using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35.Search_Insert_Position
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        public int SearchInsert(int[] nums, int target)
        {
            int min = 0;
            int max = nums.Length - 1;
            int possibleIdx = target < nums[min] ? 0 : nums.Length;
            int srcIdx;
            while (min <= max)
            {
                srcIdx = (int)Math.Floor((double)(min + max) / 2);
                if (nums[srcIdx] == target)
                {
                    possibleIdx = srcIdx;
                    break;
                }
                else if (min == max)
                {
                    possibleIdx = target < nums[min] ? min : max + 1;
                    break;
                }
                else if (target < nums[srcIdx])
                {
                    max = srcIdx - 1;
                    possibleIdx = srcIdx;
                }
                else
                {
                    min = srcIdx + 1;
                    possibleIdx = srcIdx;
                }
            }
            return possibleIdx;
        }
    }
}
