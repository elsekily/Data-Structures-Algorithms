using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms.LeetCode
{
    class ClimbingStairs
    {
        public int ClimbStairs(int n)
        {
            return ClimbRecursion(0, n);
        }
        private int ClimbRecursion(int i, int n)
        {
            if (i > n)
                return 0;
            if (i == n)
                return 1;

            return ClimbRecursion(i + 1, n) + ClimbRecursion(i + 2, n);
        }
    }
}
