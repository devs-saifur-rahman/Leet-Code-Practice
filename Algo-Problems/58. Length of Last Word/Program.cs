using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _58.Length_of_Last_Word
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.LengthOfLastWord("   fly me   to   the moon  ");
            Console.ReadLine(); 
        }

        public int LengthOfLastWord(string s)
        {
            int counter = 0;
            bool firstCharFound = false;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == ' ' & firstCharFound)
                {
                    break;
                }
                if (s[i] != ' ')
                {
                    firstCharFound = true;
                    counter++;
                }
            }
            return counter;
        }

        //works- faster - ?? !! 
        public int LengthOfLastWord_v1(string s)
        {
            string[] words = s.Split(' ').Where(x=>x.Length > 0).ToArray();
            return words[words.Length - 1].Length;
        }
    }
}
