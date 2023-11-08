using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Letter_Combinations_of_a_Phone_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IList<string> vals = LetterCombinations("23");
            
            foreach (var item in vals)
            {
                Console.Write(item + " , ");
            }
            Console.ReadLine();
        }

        public void PrintContainer(Stack<Tuple<int, int, string>> container)
        {
            Console.WriteLine("-=-=-=-");
            foreach (var item in container)
            {
                Console.WriteLine(item.Item1 + " - " + item.Item2 + " - " + item.Item3);
            }
            Console.WriteLine("-=-=-=-");
        }
        public static IList<string> LetterCombinations(string digits)
        {
            IList<string> result;
            if (digits.Length == 0)
            {
                result = new List<string>();
            }
            else if (digits.Length == 1)
            {
                int val = digits[0] - '0';
                Dictionary<int, IList<string>> dict = new Dictionary<int, IList<string>>();
                dict.Add(2, new List<string> { "a", "b", "c" });
                dict.Add(3, new List<string> { "d", "e", "f" });
                dict.Add(4, new List<string> { "g", "h", "i" });
                dict.Add(5, new List<string> { "j", "k", "l" });
                dict.Add(6, new List<string> { "m", "n", "o" });
                dict.Add(7, new List<string> { "p", "q", "r", "s" });
                dict.Add(8, new List<string> { "t", "u", "v" });
                dict.Add(9, new List<string> { "w", "x", "y", "z" });
                result = dict[val];
            }
            else
            {
                IList<string> resultSecond = LetterCombinations(digits.Substring(1));
                IList<string> resultFirst = LetterCombinations(digits[0].ToString());
                result = (from x in resultFirst
                         from y in resultSecond
                         select x+ y).ToList();
            }

            return result;
        }
    }
}
