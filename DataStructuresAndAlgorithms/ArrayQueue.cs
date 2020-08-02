using System;
using System.Text;

namespace DataStructuresAndAlgorithms
{
    public class ArrayQueue
    {
        private int[] array;
        private int count;
        private int front;
        private int rear;
        public ArrayQueue(int size)
        {   
            array = new int[size];
        }
        public void Enqueue(int value)
        {
            if (IsFull())
                throw new InvalidProgramException();
           
            array[rear % array.Length] = value;
            rear++;
            count++;
        }
        public int Dequeue()
        {
            if(IsEmpty())
                throw new InvalidProgramException();
            var f = front % array.Length;
            var temp = array[f];
            array[f] = 0;
            count--;
            front++;
            return temp;
        }
        public int Peek()
        {
            if (IsEmpty())
                throw new InvalidProgramException();

            return array[front % array.Length];
        }

        public bool IsEmpty()
        {
            return count == 0;
        }

        public bool IsFull()
        {
            return count == array.Length;
        }
        public override string ToString()
        {
            var output = new StringBuilder();
            output.Append("\n");
            foreach (var item in array)
            {
                output.Append(item);
                output.Append("\t");
            }
            output.Append("\n");
            return output.ToString();
        }
    }
}
