using System.Collections;
using System.Collections.Generic;
using System.Drawing;

namespace DataStructuresAndAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            var z = new PriorityQueue();
            
            
            z.Enqueue(3);
            z.Enqueue(5);
            z.Enqueue(4);
            //z.Enqueue(1);
            //z.Enqueue(2);
            System.Console.WriteLine(z.Dequeue());
            System.Console.WriteLine(z.Dequeue());
            System.Console.WriteLine(z.Dequeue());
            //System.Console.WriteLine(z.Dequeue());
            z.Enqueue(13);
            z.Enqueue(25);
            z.Enqueue(04);
            z.Enqueue(10);


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
