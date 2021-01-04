using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1470.Shuffle_the_Array
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        //252 ms	33.6 MB
        /*public int[] Shuffle(int[] nums, int n)
        {

            var firstHalf = nums.Select((x, i) => new { val = x, index = i }).Where((c, j) => j < n);
            var secondHalf = nums.Select((x, i) => new { val = x, index = i - n }).Where((c, j) => j >= n);

            return firstHalf.Concat(secondHalf).OrderBy(x => x.index).Select(x => x.val).ToArray();
        }*/

        //240 ms	33.1 MB
        public int[] Shuffle(int[] nums, int n)
        {
            int[] shuffledNums = new int[2 * n];

            for (int i = 0; i < n; i++)
            {
                shuffledNums[i * 2] = nums[i];
                shuffledNums[i * 2 + 1] = nums[i + n];
            }

            return shuffledNums;

        }
    }
}
