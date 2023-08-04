using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _290.Word_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = "abba", s = "dog cat cat dog";
            Program p = new Program();

            p.WordPattern(pattern, s);
        }

        public bool WordPattern(string pattern, string s)
        {
            
            Dictionary<string, int> dic = new Dictionary<string, int>();
            string[] words = s.Split(' ');
            string wordsPattern = "";
            for (int i=0; i< words.Length;i++)
            {
                if (!dic.ContainsKey(words[i])){
                    dic.Add(words[i], i); 
                }
                wordsPattern += dic[words[i]];
            }

            Dictionary<char, int> dic2 = new Dictionary<char, int>();
            string targetPatter = "";
            for (int i = 0; i < pattern.Length; i++)
            {
                if (!dic2.ContainsKey(pattern[i]))
                {
                    dic2.Add(pattern[i], i); // i=0=>a,i=1,b
                }
                targetPatter += dic2[pattern[i]];
            }


            return wordsPattern== targetPatter;
        }
    }
}
