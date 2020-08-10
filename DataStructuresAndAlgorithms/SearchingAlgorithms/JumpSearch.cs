using System;

namespace DataStructuresAndAlgorithms.SearchingAlgorithms
{
    public class JumpSearch
    {
        public bool Search(int[] Array, int number)
        {
            int blockSize = (int)Math.Sqrt(Array.Length);
            int first = 0;


            int i;
            for (i = blockSize - 1; i < Math.Pow(blockSize, 2); i += blockSize)
            {
                if (number < Array[i])
                {
                    for (int j = first; j < i; j++)
                    {
                        if (number == Array[j])
                            return true;
                    }
                }
                first += blockSize;
            }

            for (i -= blockSize; i < Array.Length; i++)
            {
                if (number == Array[i])
                    return true;
            }

            return false;
        }
    }
}
