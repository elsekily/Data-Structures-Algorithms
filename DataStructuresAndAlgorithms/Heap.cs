using System;

namespace DataStructuresAndAlgorithms
{
    public class Heap
    {
        private int[] array;
        private int size;
        public Heap(int size)
        {
            array = new int[size];
        }
        public void Insert(int value)
        {
            if (IsFull())
                throw new Exception();

            array[size++] = value;
            BubbleUP();
        }
        private void BubbleUP()
        {
            int index = size - 1;
            while (index > 0 && array[index] > array[Parent(index)])
            {
                Swap(index, Parent(index));
                index = Parent(index);
            }
        }
        public void Remove()
        {
            size = size == array.Length ? size - 1 : size;
            Swap(0, size--);
            Heapify(0);
        }
        private void Heapify(int index)
        {
            int max = index;
            int left = index * 2 + 1;
            int right = index * 2 + 2;

            if (left < size && array[left] > array[index])
                max = left;

            if (right < size && array[right] > array[max])
                max = right;

            if (max != index)
            {
                Swap(max, index);
                Heapify(max);
            }
        }
        private int Parent(int index) => (index - 1) / 2;
        public bool IsFull() => size >= array.Length;
        private void Swap(int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
