using DataStructuresAndAlgorithms.LeetCode.InputTypes;

namespace DataStructuresAndAlgorithms.LeetCode
{
    public class ReverseLinkedList
    {
        //public class ListNode // inputs type
        //{
        //    public int val;
        //    public ListNode next;
        //    public ListNode(int val = 0, ListNode next = null)
        //    {
        //        this.val = val;
        //        this.next = next;
        //    }
        //}
        public ListNode ReverseList(ListNode head)
        {
            if (head == null)
                return null;

            var list = new ListNode(head.val);
            var current = head.next;

            while (current != null)
            {
                list = new ListNode(current.val, list);
                current = current.next;
            }
            return list;
        }
        public ListNode AnotherSolution(ListNode head)
        {
            ListNode prev = null;
            while (head != null) 
            {
                var next = head.next;
                head.next = prev;
                prev = head;
                head = next;
            }
            return prev;
        }
    }
 }
