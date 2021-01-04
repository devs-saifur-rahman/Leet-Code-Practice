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
        public int[] Shuffle(int[] nums, int n)
        {

            var firstHalf = nums.Select((x, i) => new { val = x, index = i }).Where((c, j) => j < n);
            var secondHalf = nums.Select((x, i) => new { val = x, index = i - n }).Where((c, j) => j >= n);

            return firstHalf.Concat(secondHalf).OrderBy(x => x.index).Select(x => x.val).ToArray();
        }
    }
}
