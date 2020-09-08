using DataStructuresAndAlgorithms.LeetCode.InputTypes;
using System.Runtime.InteropServices;

namespace DataStructuresAndAlgorithms.LeetCode
{
    public class OddEvenLinkedList
    {
        public ListNode OddEvenList(ListNode head)
        {
            var odd = head;
            var evenHead = head.next;
            var even = evenHead;
            while (even != null && even.next != null)
            {
                odd.next = even.next;
                odd = odd.next;
                even.next = odd.next;
                even = even.next;
            }
            odd.next = evenHead;
            return head;
        }
    }
}