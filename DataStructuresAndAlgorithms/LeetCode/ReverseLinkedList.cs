using DataStructuresAndAlgorithms.LeetCode.InputTypes;
using System.Data;

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
        public ListNode ReverseBetween(ListNode head, int m, int n)
        {
            var start = head;
            var end = head;
            while (m > 2)
            {
                start = start.next;
                m--;
            }
            while (n > 1)
            {
                end = end.next;
                n--;
            }
            var tempEnd = end.next;
            end.next = null;
            
            if(m==1)
                head = AnotherSolution(start);
            
            else
                start.next = AnotherSolution(start.next);

            while (start.next != null)
            {
                start = start.next;
            }
            start.next = tempEnd;
            return head;
        }
    }
 }
