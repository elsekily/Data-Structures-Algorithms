namespace DataStructuresAndAlgorithms.Queues
{
    public class PriorityQueue
    {
        private int[] array;
        private int count;
        private int start;
        public PriorityQueue(int size=5)
        {
            array = new int[size];
        }
        public void Enqueue(int value)
        {
            int i = count;
            for (; i >= start + 1; i--) 
            {
                if (array[i - 1] > value)
                    array[i] = array[i - 1];
                else
                    break;
            }
            if (i < start)
                start = i;
            array[i] = value;
            count++;
        }
        public int Dequeue()
        {
            return array[start++];
        }
    }
}
