using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms.ProblemSolving
{
    class ConsolePatterns
    {
        public void UpsideDownNumberPyramid(int k)
        {
            for (int i = 1; i <= k; i++)
            {
                for (int j = k; j >= 1; j--)
                {
                    if (j >= i)
                        Console.Write(j);
                    else
                        Console.Write(' ');
                }
                for (int j = 2; j <= k; j++)
                {
                    if (j >= i)
                        Console.Write(j);
                    else
                        Console.Write(' ');
                }
                Console.WriteLine();
            }
        }
    }
}
