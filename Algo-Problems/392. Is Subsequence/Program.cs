using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _392.Is_Subsequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((new Program()).IsSubsequence("abc", "ahbgdc"));
            Console.WriteLine((new Program()).IsSubsequence("axc", "ahbgdc"));
            Console.ReadLine();
        }

        public bool IsSubsequence(string s, string t)
        {
            char[] target = s.ToArray();
            char[] source = t.ToArray();

            int sourceIdx=0, counter =0 , targetIdx=0;

            while (sourceIdx < source.Length && targetIdx < target.Length)
            {
                if (target[targetIdx] == source[sourceIdx++])
                {
                    counter++;
                    targetIdx++;
                }
            }

            return counter == target.Length;
        }

    }
}
