namespace DataStructuresAndAlgorithms.LinkedLists
{
    public class Utilities<T>
    {
        public T GetMiddle(System.Collections.Generic.LinkedList<T> list)
        {
            var slow = list.First;
            var fast = list.First;

            while (fast != list.Last && fast.Next != list.Last)
            {
                slow = slow.Next;
                fast = fast.Next.Next;
            }

            if (fast == list.Last)
                return slow.Value;

            return slow.Value;
        }

        public bool CheckLoop(System.Collections.Generic.LinkedList<T> list)
        {
            var slow = list.First;
            var fast = list.First;

            while (fast != list.Last && fast.Next != list.Last)
            {
                if (slow == fast)
                    return true;

                slow = slow.Next;
                fast = fast.Next.Next;
            }

            return false;
        }
    }
}
