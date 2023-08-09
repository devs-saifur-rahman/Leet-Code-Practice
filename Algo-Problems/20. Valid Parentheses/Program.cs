using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.Valid_Parentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(p.IsValid("()[]{}"));
        }
        public bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            int i = 0;
            bool isValid = true;
            while (i < s.Length)
            {
                if (s[i] == '(' || s[i] == '{' || s[i] == '[')
                {
                    stack.Push(s[i]);
                    i++;
                    continue;
                }
                try
                {

                    if (s[i] == ')')
                    {
                        char c = stack.Pop();
                        if (c != '(')
                        {
                            isValid = false;
                            break;
                        }
                    }
                    if (s[i] == '}')
                    {
                        char c = stack.Pop();
                        if (c != '{')
                        {
                            isValid = false;
                            break;
                        }
                    }
                    if (s[i] == ']')
                    {
                        char c = stack.Pop();
                        if (c != '[')
                        {
                            isValid = false;
                            break;
                        }
                    }
                }
                catch (Exception e)
                {
                    isValid = false;
                }
                i++;
            }
            return isValid && stack.Count() == 0;
        }
    }
}
