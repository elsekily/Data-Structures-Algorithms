using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms.LeetCode
{
    /*
     You are given two non-empty linked lists representing two non-negative integers.
    The digits are stored in reverse order and each of their nodes contain a single digit.
    Add the two numbers and return it as a linked list.
    You may assume the two numbers do not contain any leading zero, except the number 0 itself.

    Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
    Output: 7 -> 0 -> 8
    Explanation: 342 + 465 = 807.
     */
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
    class AddTwoNumbers
    {
        public ListNode Solution(ListNode l1, ListNode l2)
        {
            var output = new ListNode();
            var n = output;
            var a = l1;
            var b = l2;
            var carry = 0;
            while (a != null || b != null)
            {
                var l1val = (a != null) ? a.val : 0;
                var l2val = (b != null) ? b.val : 0;
                var sum = l1val + l2val + carry;
                carry = sum / 10;
                n.next = new ListNode(sum % 10);
                if (a != null)
                    a = a.next;
                if (b != null)
                    b = b.next;
                n = n.next;
            }
            if (carry > 0)
                n.next = new ListNode(carry);
            return output.next;
        }
    }
}
