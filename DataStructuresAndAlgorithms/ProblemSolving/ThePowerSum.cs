using System;

namespace DataStructuresAndAlgorithms.ProblemSolving
{
    class ThePowerSum
    {
        public int PowerSum(int x, int n)
        {
            return Recursion(x, n, 1, 0);
        }
        private int Recursion(int Target, int power, int i, int result)
        {
            var results = 0;

            int powerOfNum = (int)Math.Pow(i, power);

            while (powerOfNum + result < Target)
            {
                results += Recursion(Target, power, i + 1, result + powerOfNum);
                i++;
                powerOfNum = (int)Math.Pow(i, power);
            }
            
            if (Target == powerOfNum + result)
                results++;

            return results;
        }
    }
}