using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Container_With_Most_Water
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int k = MaxArea(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7});
            int k = MaxArea(new int[] { 1, 2, 1 });
            Console.WriteLine(k);
        }
        public static int MaxArea(int[] height)
        {
            int left = 0, right = height.Length - 1;
            int current = 0, max = 0;
            while (left < right)
            {
                current = (right - left) * Math.Min(height[left], height[right]);
                if (current > max)
                {
                    max = current;
                }

                if (height[left] <= height[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
            return max;

        }
    }
}
