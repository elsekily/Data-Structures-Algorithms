using System;

namespace DataStructuresAndAlgorithms
{
    public class SortedArray
    {
        public int[] SquaringSortedArray(int[] InputArray)
        {
            //O(N)
            int[] outputArray = new int[InputArray.Length];

            int headPointer = 0;
            int tailPointer = InputArray.Length - 1;

            for (int i = outputArray.Length - 1; i >= 0; i--)
            {
                outputArray[i] = Math.Abs(InputArray[headPointer]) >= Math.Abs(InputArray[tailPointer]) ?
                    (int)Math.Pow(InputArray[headPointer++], 2) : (int)Math.Pow(InputArray[tailPointer--], 2);
            }
            return outputArray;
        }
    }
}
