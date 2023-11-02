using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _66.Plus_One
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 1, 2, 3 };
            _ = (new Program()).PlusOne(n);
        }

        public int[] PlusOne(int[] digits)
        {
            bool hasCarryOver = false;
            int CarryValue = 0;
            int num = -1;
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (i == digits.Length - 1)
                {
                    num = digits[i] + 1 + CarryValue;
                }
                else
                {
                    num = digits[i] + CarryValue;
                }

                if (num >= 10)
                {
                    digits[i] = num % 10;
                    CarryValue = num / 10;
                    hasCarryOver = true;
                }
                else
                {
                    digits[i] = num;
                    hasCarryOver = false;
                    CarryValue = 0;
                    break;
                }
            }
            if (hasCarryOver)
            {
                List<int> list = new List<int>();
                list.AddRange(digits);
                return list.Prepend(CarryValue).ToArray();
            }
            return digits;
        }
    }
}
