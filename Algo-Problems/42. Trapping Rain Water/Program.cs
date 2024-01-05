using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42.Trapping_Rain_Water
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] height = { 0,1,0,2,1,0,1,3,2,1,2,1};
            int res = Trap(height);

            Console.ReadLine();
        }

        public static int Trap(int[] height)
        {
            int[] maxLeftHeight = new int[height.Length];
            int[] maxRightHight = new int[height.Length];
            int[] minOfLeftRightHeieght = new int[height.Length];
            maxLeftHeight[0] = 0;
            int current = 0;
            for (int i = 1; i < height.Length; i++)
            {
                current = height[i-1] > current ? height[i-1] : current;
                maxLeftHeight[i] = current;
            }

            maxRightHight[height.Length - 1] = 0;
            current = 0;
            for (int i = height.Length - 2; i >= 0; i--)
            {
                current = height[i +1 ] > current ? height[i+1] : current;
                maxRightHight[i] = current;
                minOfLeftRightHeieght[i] = Math.Min(maxRightHight[i], maxLeftHeight[i]);
            }

            minOfLeftRightHeieght[height.Length - 1] = Math.Min(maxRightHight[height.Length - 1], maxLeftHeight[height.Length - 1]);
            current = 0;
            int sum = 0;
            for (int i = 0; i < height.Length - 1; i++)
            {
                current = height[i] < minOfLeftRightHeieght[i] ?  minOfLeftRightHeieght[i] - height[i] : 0;
                sum += current;
            }
            return sum;
        }
    }
}
