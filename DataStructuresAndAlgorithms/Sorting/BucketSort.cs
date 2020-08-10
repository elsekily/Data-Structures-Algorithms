using System.Collections.Generic;

namespace DataStructuresAndAlgorithms.Sorting
{
    public class BucketSort
    {
        private List<int>[] bukets;

        public BucketSort(int n)
        {
            bukets = new List<int>[n];
            for (int i = 0; i < bukets.Length; i++)
            {
                bukets[i] = new List<int>();
            }
        }
        public void Sort(int[] Array)
        {
            foreach (var element in Array)
            {
                bukets[element / bukets.Length].Add(element);
            }
            for (int i = 0; i < bukets.Length; i++)
            {
                bukets[i].Sort();
            }
            int k = 0;
            for (int i = 0; i < bukets.Length; i++)
            {
                for (int j = 0; j < bukets[i].Count; j++)
                {
                    Array[k++] = bukets[i][j];
                }
            }
        }
    }
}
