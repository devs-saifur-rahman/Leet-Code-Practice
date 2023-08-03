using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _88_Merge_Sorted_Array
{
    internal class Program
    {

        static void Main(string[] args)
        {

            Program p = new Program();

            //int[] nums1 = { 1, 2, 3, 0, 0, 0 };
            //int[] nums2 = { 2, 5, 6 };
            //int m = 1, , n = 0;


            ///**case1**/
            //int[] nums1 = { 1 };
            //int[] nums2 = { };
            //int m = 1, n = 0;
            ///**case1**/
            //int[] nums1 = { 2,0 };
            //int[] nums2 = { 1};
            //int m = 1, n = 1;
            /**case1**/
            int[] nums1 = { 1, 2, 4, 5, 6, 0 };
            int[] nums2 = { 3 };
            int m = 5, n = 1;


            foreach (var item in nums1)
            {
                Console.WriteLine(item);
            }

            p.Merge(nums1, m, nums2, n);


            foreach (var item in nums1)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

        }

        // Works
        //public void Merge(int[] nums1, int m, int[] nums2, int n)
        //{

        //    Array.Copy(nums2, 0, nums1, m, n);
        //    Array.Sort(nums1);
        //}

        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {

            int left = m - 1;   //end of nums1
            int secInd = n - 1;//end of nums2
            int right = m + n - 1; // end of nums1

            while (secInd >= 0)
            {
                if (left >= 0 && nums1[left] > nums2[secInd])
                {
                    nums1[right--] = nums1[left--];
                }
                else
                {
                    nums1[right--] = nums2[secInd--];
                }
            }

        }
    }
}
