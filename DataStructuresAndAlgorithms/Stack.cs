using System;

namespace DataStructuresAndAlgorithms
{
    public class Stack
    {
        private int count;
        private int[] stack;

        public Stack(int depth)
        {
            stack = new int[depth];
            count = 0;
        }

        public void Push(int value)
        {
            if (count < stack.Length)
            {
                stack[count] = value;
                count++;
            }
            else
                throw new StackOverflowException();
        }
        public int Peek()
        {
            return stack[count];
        }
        public int Pop()
        {
            if (IsEmpty())
                return stack[--count];
            else
                throw new Exception();
        }
        public bool IsEmpty()
        {
            return count == 0;
        }
    }
}
