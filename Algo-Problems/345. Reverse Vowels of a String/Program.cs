using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _345.Reverse_Vowels_of_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseVowels("hello"));
            Console.ReadLine();
        }
        public static string ReverseVowels(string s)
        {
            char[] ss = s.ToCharArray();
            int fpIdx = 0, bpIdx = s.Length - 1;
            string vowels = "aeiou";
            for (int i = 0; i < ss.Length && i < bpIdx && fpIdx < bpIdx; i++)
            {
                if (vowels.Contains(Char.ToLower(ss[i])))
                {
                    fpIdx = i;
                    for (int j = bpIdx; fpIdx < bpIdx; j--)
                    {
                        if (vowels.Contains(Char.ToLower(ss[j])))
                        {
                            bpIdx = j - 1;
                            var temp = ss[j];
                            ss[j] = ss[fpIdx];
                            ss[fpIdx] = temp;
                            Console.WriteLine("Swapping");
                            break;
                        }
                    }
                }
            }
            return new string(ss);
        }
    }
}
