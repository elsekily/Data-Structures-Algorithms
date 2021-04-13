using System.Collections;
using System.Collections.Generic;
using DataStructuresAndAlgorithms.LeetCode.InputTypes;

namespace DataStructuresAndAlgorithms.LeetCode
{
    public class AddTwoNumbersII
    {
        public ListNode StacksSolution(ListNode l1, ListNode l2)
        {
            if (l1.val == 0) return l2;
            if (l2.val == 0) return l1;

            var stack1 = new Stack<int>();
            var stack2 = new Stack<int>();

            PopulateStack(stack1, l1);
            PopulateStack(stack2, l2);


            var output = new ListNode();
            var carry = 0;

            while (stack1.Count != 0 || stack2.Count != 0)
            {
                var sum = carry;
                if (stack1.Count != 0) sum += stack1.Pop();
                if (stack2.Count != 0) sum += stack2.Pop();

                if (sum > 9)
                {
                    output.val = sum % 10;
                    carry = sum / 10;
                }
                else
                {
                    output.val = sum;
                    carry = 0;
                }
                var temp = output;
                output = new ListNode(0, temp);
            }
            if (carry != 0)
            {
                output.val = carry;
                return output;
            }
            return output.next;
        }
        private void PopulateStack(Stack<int> Stack, ListNode head)
        {
            while (head != null)
            {
                Stack.Push(head.val);
                head = head.next;
            }
        }

        public ListNode ReverseLinkedListSolution(ListNode l1, ListNode l2)
        {
            if (l1.val == 0) return l2;
            if (l2.val == 0) return l1;

            l1 = ReverseLinkedList(l1);
            l2 = ReverseLinkedList(l2);

            var output = new ListNode();
            var current = output;
            var carry = 0;
            while (l1 != null || l2 != null)
            {
                var sum = carry;
                if (l1 != null) sum += l1.val;
                if (l2 != null) sum += l2.val;

                current.next = new ListNode();
                current = current.next;
                if (sum > 9)
                {
                    current.val = sum % 10;
                    carry = sum / 10;
                }
                else
                {
                    current.val = sum;
                    carry = 0;
                }
                l1 = l1 != null ? l1.next : l1;
                l2 = l2 != null ? l2.next : l2;
            }
            current.next = carry != 0 ? new ListNode(carry) : null;

            output = output.next;
            return ReverseLinkedList(output);
        }
        private ListNode ReverseLinkedList(ListNode head)
        {
            ListNode prev = null;
            while (head != null)
            {
                var temp = head.next;
                head.next = prev;
                prev = head;
                head = temp;
            }
            return prev;
        }
    }
}
