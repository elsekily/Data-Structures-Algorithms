using DataStructuresAndAlgorithms.LeetCode.InputTypes;
using System.Collections.Generic;

namespace DataStructuresAndAlgorithms.LeetCode
{
    public class SwapNodesinPairs
    {
        public ListNode SwapPairs(ListNode head)
        {
            if (head == null)
                return head;

            var temp = new ListNode
            {
                next = head
            };

            var current = temp;

            while (current.next != null && current.next.next != null)
            {
                var first = current.next;
                var second = current.next.next;

                current.next = second;
                first.next = first.next.next;
                second.next = first;

                current = current.next.next;

            }
            return temp.next;
        }
    }
}