using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _242.Valid_Anagram
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }


        public bool IsAnagram(string s, string t)
        {
            bool isAnagram = true;
            if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t) || s.Length != t.Length)
            {
                isAnagram = false;
            }
            else
            {

                Dictionary<char, int> dic = new Dictionary<char, int>();
                foreach (char c in s)
                {
                    if (dic.Keys.Contains(c))
                    {
                        dic[c]++;
                    }
                    else
                    {
                        dic.Add(c, 1);
                    }
                }
                foreach (char c in t)
                {
                    if (dic.ContainsKey(c) && dic[c] > 0)
                    {
                        dic[c]--;
                    }
                    else
                    {
                        isAnagram = false;
                        break;
                    }
                }
            }
            return isAnagram;



        }
    }
}
