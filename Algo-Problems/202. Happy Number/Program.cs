using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202.Happy_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            bool k = p.IsHappy(19);
            Console.ReadLine();
        }
        public int[] NumbersIn(int value)
        {
            var numbers = new Stack<int>();

            for (; value > 0; value /= 10)
                numbers.Push(value % 10);

            return numbers.ToArray();
        }

        public bool isHappyRec(int n, ArrayList prevData)
        {

            int[] digits = NumbersIn(n);
            int newNumber = digits.Aggregate(0, (acc, x) => acc + x * x);


            if (n == 1)
            {
                return true;
            }
            else if (prevData.Contains(newNumber))
            {
                return false;
            }
            else
            {
                prevData.Add(newNumber);
                return isHappyRec(newNumber, prevData);
            }  
        }
        public bool IsHappy(int n)
        {
            ArrayList prevData = new ArrayList();
            prevData.Add(n);
            return isHappyRec(n, prevData);
        }
    }
}
