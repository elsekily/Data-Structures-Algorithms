using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms.LeetCode
{
    class ClimbingStairs
    {
        private Dictionary<int, int> memory;
        public int ClimbStairs(int n)
        {
            memory = new Dictionary<int, int>();
            return ClimbRecursion(0, n);
        }
        private int ClimbRecursion(int i, int n)
        {
            if (memory.ContainsKey(i))
                return memory[i];

            if (i > n)
                return 0;
            if (i == n)
                return 1;

            var result = ClimbRecursion(i + 1, n) + ClimbRecursion(i + 2, n);
            memory.Add(i, result);
            return result;
        }
    }
}
