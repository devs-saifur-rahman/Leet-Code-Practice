using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _228.Summary_Ranges
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 0, 1, 2, 4, 5, 7 };

            Program p = new Program();
            IList<string> list = p.SummaryRanges(nums);
            Console.ReadLine();

        }
        public IList<string> SummaryRanges(int[] nums)
        {
            List<string> ranges = new List<string>();
            int start = 0;
            int end = 0;
            if (nums.Length == 0)
            {
                return ranges;
            }
            else if (nums.Length == 1)
            {
                ranges.Add(nums[0].ToString());
            }
            else
            {
                start = 0;
                end = 1;
                int i = 1;
                while (end < nums.Length)
                {
                    if (nums[start] + i != nums[end]) // not sequential
                    {
                        if (start+1 == end)
                        {
                            ranges.Add(nums[start].ToString());
                        }
                        else
                        {
                            ranges.Add(nums[start].ToString() + "->" + nums[end - 1]);
                        }
                        start = end;
                        i = 0;
                    }
                    end++;
                    i++;
                    if (end == nums.Length)
                    {    //end of array
                        if (start+1 == end)
                        {
                            ranges.Add(nums[start].ToString());
                        }
                        else
                        {
                            ranges.Add(nums[start].ToString() + "->" + nums[end - 1]);
                        }
                    }
                }

            }
            return ranges;
        }
    }
}
