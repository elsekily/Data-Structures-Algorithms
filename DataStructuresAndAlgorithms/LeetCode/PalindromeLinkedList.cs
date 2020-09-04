using DataStructuresAndAlgorithms.LeetCode.InputTypes;
using System.Collections;
using System.Collections.Generic;

namespace DataStructuresAndAlgorithms.LeetCode
{
    class PalindromeLinkedList 
    {
        public bool IsPalindrome(ListNode head)
        {
            if (head == null || head.next == null)
                return true;

            var current = head;
            var list = new List<int>();
            while (current != null)
            {
                list.Add(current.val);
                current = current.next;
            }
            for (int i = 0; i < list.Count / 2; i++)
            {
                if (list[i] != list[list.Count - i - 1])
                    return false;
            }
            return true;
        }
        public bool TwoPointersSolutions(ListNode head)
        {
            var slow = head;
            var fast = head;
            while (fast != null && fast.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
            }
            slow = Reverse(slow);
            fast = head;
            while (slow != null) 
            {
                if (slow.val != fast.val)
                    return false;

                slow = slow.next;
                fast = fast.next;
            }
            return true;
        }
        private ListNode Reverse(ListNode head)
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
