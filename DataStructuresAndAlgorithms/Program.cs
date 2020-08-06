using DataStructuresAndAlgorithms.HashTables;
using System.Collections.Generic;

namespace DataStructuresAndAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        static void PrintQueue(Queue<int> queue)
        {
            var array = queue.ToArray();
            foreach (var item in array)
            {
                System.Console.Write("{0}\t", item);
            }
            System.Console.WriteLine();
        }
        static void QueueReverse(Queue<int> queue)
        {
            var stack = new Stack<int>();
            while (queue.Count != 0)
                stack.Push(queue.Dequeue());

            while (stack.Count != 0)
                queue.Enqueue(stack.Pop());
        }
    }
}
