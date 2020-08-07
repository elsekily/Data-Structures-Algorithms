using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms.Queues
{
    public class Utilities
    {
        static void QueueReverseUsingStacks(Queue<int> queue)
        {
            var stack = new Stack<int>();
            while (queue.Count != 0)
                stack.Push(queue.Dequeue());

            while (stack.Count != 0)
                queue.Enqueue(stack.Pop());
        }
    }
}
