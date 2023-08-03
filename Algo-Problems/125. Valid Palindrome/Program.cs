using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _125.Valid_Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((new Program()).IsPalindrome("race a car"));
            Console.WriteLine((new Program()).IsPalindrome("A man, a plan, a canal: Panama"));
            Console.ReadLine();
        }
        public bool IsPalindrome(string s)
        {
            bool IsPalindrome = true;
            char[] chars = s.ToLower().Where(Char.IsLetterOrDigit).ToArray();
            int left = 0;
            int right = chars.Length - 1;
            while (left <= right)
            {
                if (chars[left++] != chars[right--])
                {
                    IsPalindrome = false;
                }
            }
            return IsPalindrome;
        }
    }
}
