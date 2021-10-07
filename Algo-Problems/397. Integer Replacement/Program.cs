using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _397.longeger_Replacement
{
    class Program
    {
        static void Main(string[] args)
        {
            // based on CollatzConjecture with memonization
            Program p = new Program();
            Console.WriteLine(p.IntegerReplacement(2147483647));
            Console.ReadLine();

        }


        IDictionary<long, int> dictCycleLength;
        public int IntegerReplacement(int n)
        {
            dictCycleLength = new Dictionary<long, int>();
            dictCycleLength.Add(1, 0);
            return (int)RecursivelyCalculateCycleLength(n);
        }

        long RecursivelyCalculateCycleLength(long num)
        {
            if (!dictCycleLength.Keys.Contains(num))
            {
                int cycleLength;
                if (num % 2 == 0)
                {
                    cycleLength = (int)RecursivelyCalculateCycleLength(num / 2);
                }
                else
                {
                    cycleLength = (int)Math.Min(RecursivelyCalculateCycleLength(num + 1), RecursivelyCalculateCycleLength(num - 1));
                }

                cycleLength++;
                dictCycleLength.Add(num, cycleLength);
            }

            return dictCycleLength[num];
        }
    }
}
