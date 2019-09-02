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
            if (n == 1)
            {
                return 1;
            }
            int first = 1;
            int second = 2;

            for (int i = 3; i <= n; i++)
            {
                int current = first + second;
                first = second;
                second = current;
            }

            return second;
        }
    }
}
