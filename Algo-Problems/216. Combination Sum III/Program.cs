using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _216.Combination_Sum_III
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Program p = new Program();
            // IList<IList<int>> a = new List<IList<int>>();
            //  var a = p.CombinationSum3(3, 7);
            var b = p.CombinationSum3(6, 36);

            Console.ReadLine();

        }
        public IList<IList<int>> CombinationSum3(int k, int n)
        {
            Tuple<bool, IList<IList<int>>> childRes = CombinationSum3(k, n, 0, n, 1);

            return childRes.Item2;
        }
        public Tuple<bool, IList<IList<int>>> CombinationSum3(int k, int target, int covered, int remains, int lowest)
        {
            IList<IList<int>> retList = new List<IList<int>>();
            bool isSuccess = false;

            if (k == 0 && remains == 0)
            {
                isSuccess = true;
                return new Tuple<bool, IList<IList<int>>>(isSuccess, retList);
            }

            if (target > 45 || target == 0 || (k <= 0 && remains > 0))
            {
                isSuccess = false;
                return new Tuple<bool, IList<IList<int>>>(isSuccess, retList);
            }

            int nextN;
            for (int i = lowest; i <= 9; i++)
            {
                nextN = remains - i;
                if (nextN<0) {
                    break;
                }
                Tuple<bool, IList<IList<int>>> childRes = CombinationSum3(k - 1, target, covered + i, nextN, i + 1);

                if (childRes.Item1)
                {
                    IList<int> ls = new List<int>();

                    if (childRes.Item2.Count == 0)
                    {
                        ls.Add(i);
                        retList.Add(ls);
                    }
                    else
                    {
                        foreach (var itm in childRes.Item2)
                        {
                            ls = itm;
                            ls.Add(i);
                            retList.Add(ls);
                        }
                    }

                    isSuccess = true;
                }
            }

            return new Tuple<bool, IList<IList<int>>>(isSuccess, retList);
        }
    }
}

/*
 Input: k = 3, n = 9
Output: [[1,2,6],[1,3,5],[2,3,4]]
Explanation:
1 + 2 + 6 = 9
1 + 3 + 5 = 9
2 + 3 + 4 = 9
 
 */
