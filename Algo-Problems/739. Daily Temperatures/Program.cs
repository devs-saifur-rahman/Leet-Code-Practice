using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _739.Daily_Temperatures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            int[] a = p.DailyTemperatures(new int[] { 89, 62, 70, 58, 47, 47, 46, 76, 100, 70 });
            Console.WriteLine(String.Join(" , ", a ));
            Console.ReadLine();
        }

        public int[] DailyTemperatures(int[] temperatures)
        {
            Stack<Tuple<int, int>> highestTemp = new Stack<Tuple<int, int>>();
            int[] nextHighIdx = Enumerable.Repeat(-1, temperatures.Length).ToArray();
            int curTemp = 0;
            for (int i = temperatures.Length - 1; i >= 0; i--)
            {
                nextHighIdx[i] = i;
                curTemp = temperatures[i];
                if (highestTemp.Count == 0)
                {
                    highestTemp.Push(new Tuple<int, int>(i, curTemp));
                }
                else
                {
                    if (highestTemp.Peek().Item2 > curTemp)
                    {
                        nextHighIdx[i] = highestTemp.Peek().Item1;
                        highestTemp.Push(new Tuple<int, int>(i, curTemp));
                    }
                    else
                    {
                        while (highestTemp.Count > 0 && highestTemp.Peek().Item2 <= curTemp)
                        {
                            highestTemp.Pop();
                        }
                        if (highestTemp.Count > 0)
                        {
                            nextHighIdx[i] = highestTemp.Peek().Item1;
                        }
                        highestTemp.Push(new Tuple<int, int>(i, curTemp));
                    }
                }
            }
            return nextHighIdx.Select((val, idx) => val - idx).ToArray();

        }
    }
}
