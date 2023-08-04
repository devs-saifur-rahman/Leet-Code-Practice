using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _205.Isomorphic_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // (new Program()).IsIsomorphic("abcdefghijklmnopqrstuvwxyzva", "abcdefghijklmnopqrstuvwxyzck");
            (new Program()).IsIsomorphic("paper", "title");
        }

        public bool IsIsomorphic(string s, string t)
        {
            Dictionary<char, char> dic = new Dictionary<char, char>();
            Dictionary<char, char> dic2 = new Dictionary<char, char>();

            bool IsIsomorphic = true;

            for (int i = 0; i < s.Length; i++)
            {
                if (!dic.ContainsKey(s[i]))
                {
                    dic.Add(s[i], t[i]);
                }

                if (!dic2.ContainsKey(t[i]))
                {
                    dic2.Add(t[i], s[i]);
                }

                if (dic[s[i]] != t[i] || dic2[t[i]] != s[i])
                {

                    IsIsomorphic = false;
                    break;
                }
            }
            return IsIsomorphic;
        }

        public bool IsIsomorphic_v1(string s, string t)
        {

            Dictionary<char, int> dic = new Dictionary<char, int>();
            string wordsPattern = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (!dic.ContainsKey(s[i]))
                {
                    dic.Add(s[i], i);
                }
                wordsPattern = wordsPattern + "-" + dic[s[i]];
            }

            Console.WriteLine(wordsPattern);
            Dictionary<char, int> dic2 = new Dictionary<char, int>();
            string targetPatter = "";
            for (int i = 0; i < t.Length; i++)
            {
                if (!dic2.ContainsKey(t[i]))
                {
                    dic2.Add(t[i], i); // i=0=>a,i=1,b
                }
                targetPatter = targetPatter + "-" + dic2[t[i]];
            }

            Console.WriteLine(targetPatter);
            return wordsPattern == targetPatter;
        }

    }
}
