using System.Collections.Generic;

namespace DataStructuresAndAlgorithms.DynamicProgramming
{
    class Fibonacci
    {
        private readonly Dictionary<int, long> dict = new Dictionary<int, long>();
        public long Solution(int num)
        {
            if (dict.ContainsKey(num))
                return dict[num];
            
            if (num == 1)
                return 1;

            if (num == 0)
                return 0;

            var solution = Solution(num - 1) + Solution(num - 2);
            dict.Add(num, solution);
            return solution;
        }
    }
}
