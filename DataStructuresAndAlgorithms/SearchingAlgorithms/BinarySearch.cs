namespace DataStructuresAndAlgorithms.SearchingAlgorithms
{
    public class BinarySearch
    {
        public bool SearchByRecurrsion(int[] Array, int number)
        {
            return SearchByRecurrsion(Array, 0, Array.Length - 1, number);
        }
        private bool SearchByRecurrsion(int[] Array, int start, int end, int number)
        {
            if (start > end)
                return false;
            int mid = (start + end) / 2;

            if (Array[mid] == number)
                return true;
            if (Array[mid] < number)
                return SearchByRecurrsion(Array, mid + 1, end, number);
            if (Array[mid] > number)
                return SearchByRecurrsion(Array, start, mid - 1, number);

            return false;
        }
    }
}
