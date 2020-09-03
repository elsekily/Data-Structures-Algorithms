using System.Collections.Generic;

namespace DataStructuresAndAlgorithms.LeetCode
{
    class PowDoublexIntn
    {
        private Dictionary<int, double> memory = new Dictionary<int, double>();
        public double MyPow(double x, int n)
        {
            if (memory.ContainsKey(n))
                return memory[n];

            if (n < 0)
                return 1 / (x * MyPow(x, -n - 1));
            
            if (n == 0)
                return 1.0;
            
            else
            {
                if (n % 2 == 0)
                {
                    var result = MyPow(x, n / 2) * MyPow(x, n / 2);
                    memory.Add(n, result);
                    return result;
                }
                else
                {
                    var result = x * MyPow(x, n - 1);
                    memory.Add(n, result);
                    return result;
                }
            }
        }
    }
}
