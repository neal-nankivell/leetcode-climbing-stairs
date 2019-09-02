using System;
using System.Collections.Generic;
using System.Linq;

namespace Answer
{
    /*
    You are climbing a stair case. It takes n steps to
    reach to the top.

    Each time you can either climb 1 or 2 steps.
    In how many distinct ways can you climb to the top?

    Note: Given n will be a positive integer.
     */
    public class Solution
    {
        public int ClimbStairs(int n)
        {
            Dictionary<int, int> stairsMap = new Dictionary<int, int>();

            foreach (var step in Enumerable.Range(1, n))
            {
                if (step == 1)
                {
                    stairsMap[step] = 1;
                }
                else if (step == 2)
                {
                    stairsMap[step] = 2;
                }
                else
                {
                    stairsMap[step] =
                        stairsMap[step - 1] +
                        stairsMap[step - 2];
                }
            }

            return stairsMap[n];
        }
    }
}
