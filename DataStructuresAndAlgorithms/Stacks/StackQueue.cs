using System.Collections.Generic;

namespace DataStructuresAndAlgorithms.Stacks
{
    public class StackQueue
    {
        private Stack<int> stack1;
        private Stack<int> stack2;
        public StackQueue()
        {
            stack1 = new Stack<int>();
            stack2 = new Stack<int>();
        }
        public void Enqueue(int value)
        {
            stack1.Push(value);
        }
        public int Dequeue()
        {
            if (stack2.Count != 0)
                return stack2.Pop();

            while (stack1.Count != 1)
                stack2.Push(stack1.Pop());

            return stack1.Pop();
        }
    }
}
