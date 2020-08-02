namespace DataStructuresAndAlgorithms
{
    public class Sort
    {
        public void BubbleSort(int[] Array)
        {
            if (Array == null)
                return;
            for (int i = 0; i < Array.Length - 1; i++)
            {
                if (Array[i] > Array[i + 1])
                {
                    for (int j = 0; j < Array.Length - 1; j++)
                    {
                        if (Array[j] > Array[j + 1])
                            Swap(Array, j, j + 1);
                    }
                }
            }
        }
        public void CountSort(int[] Array, int max)
        {
            int[] counts = new int[max + 1];
            foreach (var element in Array)
            {
                counts[element]++;
            }


            int k = 0;
            for (int i = 0; i < Array.Length;)
            {
                for (int j = 0; j < counts[k]; j++)
                {
                    Array[i++] = k;
                }
                k++;
            }
        }
        public void InsertionSort(int[] Array)
        {
            for (int i = 1; i < Array.Length; i++)
            {
                var current = Array[i];
                int j = i - 1;
                while (j >= 0 && Array[j] > current)
                {
                    Array[j + 1] = Array[j];
                    j--;
                }
                Array[j + 1] = current;
            }
        }
        public void SortBySwap(int[] Array)
        {
            for (int i = 0; i < Array.Length; i++)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    if (Array[j] > Array[j + 1])
                        Swap(Array, j, j + 1);
                    else
                        break;
                }
            }
        }
        public void MergeSort(int[] Array)
        {
            Divide(Array, 0, Array.Length - 1);
        }
        private void Divide(int[] Array, int start, int end)
        {
            if (end == start)
                return;
            int mid = start + (end - start) / 2;
            Divide(Array, start, mid);
            Divide(Array, mid + 1, end);
            Merge(Array, start, mid, end);
        }
        private void Merge(int[] Array, int start, int mid, int end)
        {
            int[] left = new int[mid - start + 1];
            int[] right = new int[end - mid];

            for (int i = 0; i < left.Length; i++)
                left[i] = Array[start + i];

            for (int i = 0; i < right.Length; i++)
                right[i] = Array[mid + i + 1];

            int j = 0;
            int k = 0;
            for (int i = start; i <= end; i++)
            {
                if (j == left.Length)
                {
                    Array[i] = right[k++];
                    continue;
                }
                if (k == right.Length)
                {
                    Array[i] = left[j++];
                    continue;
                }

                if (left[j] < right[k])
                    Array[i] = left[j++];
                else
                    Array[i] = right[k++];
            }
        }
        public void QuickSort(int[] Array)
        {
            Partitioning(Array, 0, Array.Length - 1);
        }
        private void Partitioning(int[] Array, int start, int end)
        {
            if (end - start < 1)
                return;

            int pivot = end;
            int b = start - 1;
            for (int i = start; i < end; i++)
            {
                if (Array[i] < Array[pivot])
                    Swap(Array, i, ++b);
            }
            Swap(Array, pivot, b + 1);

            Partitioning(Array, 0, b);
            Partitioning(Array, b + 2, end);
        }
        public void SelectionSort(int[] Array)
        {
            for (int i = 0; i < Array.Length; i++)
            {
                var min = i;
                for (int j = i + 1; j < Array.Length; j++)
                {
                    if (Array[j] < Array[min])
                        min = j;

                }
                if (i != min)
                    Swap(Array, i, min);
            }
        }
        private void Swap(int[] Array, int i, int j)
        {
            var temp = Array[i];
            Array[i] = Array[j];
            Array[j] = temp;
        }
    }
}
