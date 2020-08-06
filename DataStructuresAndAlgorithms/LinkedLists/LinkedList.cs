namespace DataStructuresAndAlgorithms.LinkedLists
{
    public class LinkedList<T>
    {
        private Node<T> first;
        private Node<T> last;
        class Node<T>
        {
            public T value;
            public Node<T> next;
            public Node(T value)
            {
                this.value = value;
            }
        }
        public void AddFirst(T value)
        {
            if(first==null)
            {
                first = new Node<T>(value);
                last = first;
                return;
            }
            var temp = first;
            first = new Node<T>(value);
            first.next = temp;
        }
        public void AddLast(T value)
        {
            if(last == null)
            {
                first = new Node<T>(value);
                last = first;
                return;
            }
            last.next = new Node<T>(value);
            last = last.next;
        }
        public void DeleteFirst()
        {
            if (first == null)
                return;

            first = first.next;
        }
        public void DeleteLast()
        {
            if (last == null)
                return;
            
            var current = first;
            while (current.next != last)
                current = current.next;

            last = current;
            last.next = null;

        }
        public bool Contains(T value)
        {
            if (first == null)
                return false;

            var current = first;
            while (current != null)
            {
                if (current.value.Equals(value))
                    return true;

                current = current.next;
            }
            return false;
        }
    }
}
