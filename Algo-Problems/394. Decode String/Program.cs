using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _394.Decode_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
           // Console.WriteLine(program.DecodeString("2[ab3[c2[ef]]]2[gh]ij"));
            Console.WriteLine(program.DecodeString("3[z]2[2[y]pq4[2[jk]e1[f]]]ef"));
            Console.ReadLine();

        }
        public string DecodeString(string s)
        {
            string result = "";

            // making minimal changes to establish consistency
            s = "[" + s + "]";

            Stack<Tuple<int, int, string>> container = new Stack<Tuple<int, int, string>>();

            int currDepth = -1;
            int currMultp = 1;
            string currChar = "";
            bool isLastNonDigit = true;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '[')
                {
                    currDepth++;
                    isLastNonDigit = true;
                }
                else if (s[i] == ']')
                {
                    //container.Push(new Tuple<int, int, string>(currDepth, currMultp, currChar));

                    currMultp = 1;
                    currDepth--;
                    isLastNonDigit = true;
                }
                else if (Char.IsDigit(s[i]))
                {
                    if (!isLastNonDigit)
                    {
                        currMultp = 10 * currMultp + (s[i] - '0');
                    }
                    else
                    {
                        currMultp = s[i] - '0';
                    }

                    isLastNonDigit = false;
                }
                else
                {
                    container.Push(new Tuple<int, int, string>(currDepth, currMultp, s[i].ToString()));
                    isLastNonDigit = true;
                }

            }
            PrintContainer(container);
            while (container.Count > 0)
            {
                var item = container.Pop();
                if (container.Count <= 0)
                {
                    result = String.Concat(Enumerable.Repeat(item.Item3, item.Item2)) + result;
                    break;
                }
                if (item.Item1 == container.Peek().Item1 && item.Item2 == container.Peek().Item2)
                {
                    var itemTop = container.Pop();
                    container.Push(new Tuple<int, int, string>(itemTop.Item1, itemTop.Item2, itemTop.Item3 + item.Item3));
                }
                else
                {
                    if (item.Item1 - 1 <= 0) // final string
                    {
                        result = String.Concat(Enumerable.Repeat(item.Item3, item.Item2)) + result;
                    }
                    else
                    {
                        currChar = String.Concat(Enumerable.Repeat(item.Item3, item.Item2));
                        var itemTop = container.Pop();
                        container.Push(new Tuple<int, int, string>(itemTop.Item1, itemTop.Item2, itemTop.Item3 + currChar));
                    }
                }
            }
            return result;
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
    }
}
