using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Roman_to_Integer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();

            int k = p.RomanToInt("MCMXCIV");

            Console.ReadLine();

        }
        public int RomanToInt(string s)
        {
            int number = 0;
            Dictionary<char, int> numerals = new Dictionary<char, int>();
            numerals.Add('I', 1);
            numerals.Add('V', 5);
            numerals.Add('X', 10);
            numerals.Add('L', 50);
            numerals.Add('C', 100);
            numerals.Add('D', 500);
            numerals.Add('M', 1000);
            for (int i = s.Length - 1; i >= 0; i--)
            {
                int curNum = numerals[s[i]];
                if (i < s.Length - 1 && s[i] == 'I' && (s[i + 1] == 'V' || s[i + 1] == 'X'))
                {
                    number--;
                }
                else if (i < s.Length - 1 && s[i]=='X' && (s[i + 1] == 'L' || s[i + 1] == 'C'))
                {
                    number -= 10;
                }

                else if (i < s.Length - 1 && s[i] == 'C' && (s[i + 1] == 'D' || s[i + 1] == 'M'))
                {
                    number -= 100;
                }
                else
                {
                    number = number + curNum;
                }
            }
            return number;
        }
    }
}
