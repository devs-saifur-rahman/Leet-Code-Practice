using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _735.Asteroid_Collision
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            Program p = new Program();
            int[] a = p.AsteroidCollision(new int[] { -2, 1, 1, -2 });

            _ = Console.ReadLine();
        }

        public  int[] AsteroidCollision(int[] asteroids)
        {
            Stack<int> remainder = new Stack<int>();

            foreach (var currVal in asteroids)
            {
                if (remainder.Count == 0 // NOTHING
                    || currVal >= 0  // GOING RIGHT - POSITIVE FLOW
                    || (currVal < 0 && remainder.Peek() < 0)) //LEFT BUT NO POSITIVE FLOW EXISTS HENCE NO COLLISION
                {
                    remainder.Push(currVal);
                }
                else
                { // LEFT BUT POSITIVE FLOW TO RIGHT EXIST
                    bool isPrevPos = false;
                    bool shouldPush = false;
                    int valueToPush = currVal;
                    do
                    {
                        isPrevPos = false;
                        if (Math.Abs(currVal) < Math.Abs(remainder.Peek()))
                        {
                            shouldPush = false;
                            break;
                        }
                        else if (Math.Abs(currVal) == Math.Abs(remainder.Peek()))
                        {
                            remainder.Pop();
                            shouldPush = false;
                            break;
                        }
                        else
                        {
                            remainder.Pop();
                            isPrevPos = remainder.Count > 0 ? remainder.Peek() > 0 : false;
                            shouldPush = true;
                        }
                    } while (isPrevPos);
                    if (shouldPush)
                    {
                        remainder.Push(valueToPush);
                    }

                }
            }
            var res = remainder.ToArray();
            Array.Reverse(res);
            return res;

        }
    }
}
