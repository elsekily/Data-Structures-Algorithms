using System;

namespace DataStructuresAndAlgorithms
{
    public class CircularLinkedList
    {
        class Node
        {
            public int Value { get; set; }
            public Node Next { get; set; }
            public Node Previous { get; set; }


            public Node(int value)
            {
                this.Value = value;
            }
        }
        public int Count { get; set; }
        private Node First { get; set; }
        private Node Last { get; set; }
        public void AddFirst(int value)
        {
            var node = new Node(value);
            if (First == null)
            {
                First = Last = node;
                First.Previous = Last;
                First.Next = Last;
            }
            else
            {
                node.Next = First;
                First.Previous = node;
                node.Previous = Last;
                Last.Next = node;
                First = node;
            }
            Count++;
        }
        public void AddLast(int value)
        {
            var node = new Node(value);
            if (Last == null)
            {
                First = Last = node;
                First.Previous = Last;
                First.Next = Last;
            }
            else
            {
                node.Next = First;
                First.Previous = node;
                node.Previous = Last;
                Last.Next = node;
                Last = node;
            }
            Count++;
        }
        public int IndexOf(int index)
        {
            var node = First;
            for (int i = 1; i <= Count; i++)
            {
                if (node.Value == index)
                {
                    return i - 1;
                }
                node = node.Next;
            }
            return -1;
        }
        public bool Contains(int index)
        {
            return IndexOf(index) != -1;
        }
        public void RemoveFirst()
        {
            if (First == null)
            {
                throw new Exception();
            }
            if (First == Last)
            {
                First = Last = null;
                return;
            }
            else
            {
                var node = First.Next;
                First = null;
                Last.Next = node;
                node.Previous = Last;
                First = node;
            }
            Count--;
        }
        public void RemoveLast()
        {
            if (First == null)
            {
                throw new Exception();
            }
            if (First == Last)
            {
                First = Last = null;
                return;
            }
            else
            {
                var node = Last.Previous;
                Last = null;
                First.Previous = node;
                node.Next = First;
                Last = node;
            }
            Count--;
        }
        public int[] ToArray()
        {
            var array = new int[Count];
            var node = First;
            for (int i = 0; i < Count; i++)
            {
                array[i] = node.Value;
                node = node.Next;
            }
            return array;
        }
        public void Reverse()
        {
            var node = First;
            for (int i = 0; i < Count; i++)
            {
                var aux = node.Next;
                node.Next = node.Previous;
                node.Previous = aux;
                node = aux;
            }
            var auxa = First;
            First = Last;
            Last = auxa;
        }
        public void MoshReverse()
        {
            //reversing case no previous pointer
            if (First == null)
                return;

            Node pre = null;
            var current = First;
            var next = current.Next;
            for (int i = 1; i < Count; i++)
            {
                current.Next = pre;
                pre = current;
                current = next;
                next = current.Next;
            }
            Last.Next = pre;

            var aux = First;
            First = Last;
            Last = aux;
        }
        public int GetKthFromTheEnd(int k)
        {
            var node = Last;
            for (int i = 0; i < k; i++)
            {
                node = node.Previous;
            }
            return node.Value;
        }
        public int MoshGetKthFromTheEnd(int k)
        {
            //case no Previos pointer
            var x = First;
            var y = First;
            for (int i = 0; i < k; i++)
            {
                y = y.Next;
            }
            while (y != Last)
            {
                x = x.Next;
                y = y.Next;
            }
            return x.Value;
        }
        public int GetMiddle()
        {
            var slow = First;
            var fast = First.Next.Next;
            while (fast != Last)
            {
                slow = slow.Next;
                fast = fast.Next.Next;
            }
            return slow.Next.Value;
        }
    }
}
