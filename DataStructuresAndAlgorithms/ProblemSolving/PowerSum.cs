using System;
using System.Text;

namespace DataStructuresAndAlgorithms.ProblemSolving
{
    public class PowerSum
    {
        public int PowerSumOutput(int x, int n)//x=100,n=2
        {
            int output = 0;
            int root = (int)Math.Pow(x, (1.0 / n));
            if (root == Math.Pow(x, (1.0 / n)))
                output++;

            for (int i = 1; i <= root; i++)
            {
                output+= re(0, root, x, n, i, 0);
            }
            Console.WriteLine(output);
            return 1;
        }
        private int re(int output, int root, int x, int n, int number, int result)
        {
            
            if (result == x)
            {
                return ++output;
            }

            result += (int)Math.Pow(number, n);
            for (int i = number+1; i <= root; i++)
            {
                if (result > x)
                {
                    return 0;
                }
                    
                output += re(output,root, x, n, i, result);
            }
            return output;
        }
    }
}
