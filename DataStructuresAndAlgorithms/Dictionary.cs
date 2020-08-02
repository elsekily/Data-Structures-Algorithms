namespace DataStructuresAndAlgorithms
{
    public class Dictionary<T>
    {
        class Node<T>
        {
            public T Value { get; set; }
            public Node<T> Next { get; set; }
            public Node<T> Previous { get; set; }


            public Node(T value)
            {
                this.Value = value;
            }
        }
        public int Count { get; set; }
        private Node<T> First { get; set; }
        private Node<T> Last { get; set; }
        public void AddFirst(T value)
        {
            var node = new Node<T>(value);
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

        public T[] ToArray()
        {
            var array = new T[Count];
            var node = First;
            for (int i = 0; i < Count; i++)
            {
                array[i] = node.Value;
                node = node.Next;
            }
            return array;
        }
    }
}
