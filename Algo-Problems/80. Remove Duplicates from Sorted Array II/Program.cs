using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _80.Remove_Duplicates_from_Sorted_Array_II
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 1, 1, 2, 3, 3, 4, 5, 5 };
            foreach (int n in nums)
            {
                Console.Write(n);
            }
            Program p = new  Program();
            Console.WriteLine("Remains : ${0}", p.removeDuplicates(nums));
                foreach (int n in nums)
            {
                Console.Write(n);
            }
            Console.ReadLine();

        }

        int removeDuplicates(int[] nums)
        {
            int i = 0;
            foreach (int n in nums)
            {
                if (i < 2 || n > nums[i - 2])
                    nums[i++] = n;
            }
            return i;
        }
    }
}
