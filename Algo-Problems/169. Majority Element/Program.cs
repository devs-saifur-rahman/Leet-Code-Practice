using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _169.Majority_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        public int MajorityElement(int[] nums)
        {
            int maxElem = nums[0];
            int maxCount = -1;

            Dictionary<int,int> counterMap = new Dictionary<int,int>();

            for(int idx =0; idx < nums.Length; idx++)
            {
                if (counterMap.ContainsKey(nums[idx]))
                {
                    counterMap[nums[idx]]++;
                    if(nums.Length/2 <= counterMap[nums[idx]] && maxCount <= counterMap[nums[idx]])
                    {
                        maxElem = nums[idx];
                        maxCount= counterMap[nums[idx]]; ;
                    }
                }
                else
                {
                    counterMap.Add(nums[idx], 1);
                }

            }
            
            

            return maxElem;

        }
    }
}
