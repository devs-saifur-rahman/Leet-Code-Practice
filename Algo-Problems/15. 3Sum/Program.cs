using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._3Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IList<IList<int>> res = ThreeSum(new int[] { -1,0,1,2,-1,-4});
            Console.ReadLine();
        }


        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            int start = 0;
            int left = 1;
            int right = nums.Length - 1;
            int target = 0;
            Array.Sort(nums);
            IList<IList<int>> threeSumList = new List<IList<int>>();
            while ( start < nums.Length - 2)
            {

                left = start + 1;
                right = nums.Length - 1;
                target = 0- nums[start];
                while (left < right)
                {
                    if (target < nums[left] + nums[right])
                    {
                        right--;
                    }
                    else if (target > nums[left] + nums[right])
                    {
                        left++;
                    }
                    else
                    {
                        List<int> currentSolution = new List<int> { nums[start], nums[left], nums[right] };
                        threeSumList.Add(currentSolution);
                        while (left < right && nums[left] == currentSolution[1])
                        {
                            left++;
                        }
                        while (left < right && nums[right] == currentSolution[2])
                        {
                            right--;
                        }
                    }
                   
                }
                int currentStartNumber = nums[start];
                while (start < nums.Length - 2 && nums[start] == currentStartNumber) { start++; }
            }
            return threeSumList;
        }
    }
}
